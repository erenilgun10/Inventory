using Inventory.DAL.Repositories;

namespace Inventory.UI
{
    public partial class InventoryForm : Form
    {
        private readonly ReportRepository _reportRepo = new();
        private readonly ProductRepository _productRepo = new();
        private int? _selectedProductId = null;

        private enum ScreenMode
        {
            Reports,
            Products,
            Categories,
            Suppliers,
            StockMovements
        }

        public InventoryForm()
        {
            InitializeComponent();
            btnProductAdd.Click += btnProductAdd_Click;
            btnProductUpdate.Click += btnProductUpdate_Click;
            btnProductDelete.Click += btnProductDelete_Click;

            dgvProductList.SelectionChanged += dgvProductList_SelectionChanged;
        }

        private void InventoryForm_Load(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
        }

        private void SetScreen(ScreenMode mode)
        {
            grpReport.Visible = false;
            crudPanel.Visible = false;

            grpProductDetails.Visible = false;
            dgvProductList.Visible = false;

            btnLowStock.Visible = false;
            btnDailySales.Visible = false;
            btnProductSales.Visible = false;

            switch (mode)
            {
                case ScreenMode.Reports:
                    grpReport.Visible = true;
                    btnLowStock.Visible = true;
                    btnDailySales.Visible = true;
                    btnProductSales.Visible = true;
                    break;

                case ScreenMode.Products:
                    crudPanel.Visible = true;
                    grpProductDetails.Visible = true;
                    dgvProductList.Visible = true;
                    LoadProducts();
                    ClearProductForm();
                    break;

                case ScreenMode.Categories:
                    crudPanel.Visible = true;
                    break;

                case ScreenMode.Suppliers:
                    crudPanel.Visible = true;
                    break;

                case ScreenMode.StockMovements:
                    crudPanel.Visible = true;
                    break;
            }
        }

        private void LoadProducts()
        {
            dgvProductList.DataSource = _productRepo.GetAll();
            if (dgvProductList.Columns != null && dgvProductList.Columns.Contains("ProductId"))
                dgvProductList.Columns["ProductId"]!.Visible = false;
            if (dgvProductList.Columns != null && dgvProductList.Columns.Contains("MinStock"))
                dgvProductList.Columns["MinStock"]!.HeaderText = "Reorder Level";

            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.MultiSelect = false;
            dgvProductList.ReadOnly = true;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnReports_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
        }

        private void btnProducts_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Products);
            ClearProductForm();
        }

        private void btnCategories_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Categories);
        }

        private void btnSuppliers_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Suppliers);
        }

        private void btnStockMov_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.StockMovements);
        }

        private void btnLowStock_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportRepo.GetLowStock();
        }

        private void btnDailySales_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportRepo.GetDailySales();
        }

        private void btnProductSales_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportRepo.GetProductSales();
        }

        private void pnlLeft_Paint(object? sender, PaintEventArgs e) { }
        private void grpReport_Enter(object? sender, EventArgs e) { }

        private void dgvProductList_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            var row = dgvProductList.CurrentRow;

            var idObj = row.Cells["ProductId"].Value;
            if (idObj == null || idObj == DBNull.Value) return;

            _selectedProductId = Convert.ToInt32(idObj);

            txtProductBarcode.Text = Convert.ToString(row.Cells["Barcode"].Value) ?? "";
            txtProductName.Text = Convert.ToString(row.Cells["Name"].Value) ?? "";

            nudStock.Value = Convert.ToDecimal(row.Cells["Stock"].Value == DBNull.Value ? 0 : row.Cells["Stock"].Value);
            nudReorderLevel.Value = Convert.ToDecimal(row.Cells["MinStock"].Value == DBNull.Value ? 0 : row.Cells["MinStock"].Value);
            SetProductButtonsState();
        }




        private void gridReport_CellContentClick(object? sender, DataGridViewCellEventArgs e) { }
        // Update all event handler signatures to explicitly allow nullable sender
        private void btnProductAdd_Click(object? sender, EventArgs e)
        {
            var name = txtProductName.Text.Trim();
            var barcode = string.IsNullOrWhiteSpace(txtProductBarcode.Text) ? null : txtProductBarcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Ürün adı boş olamaz.");
                return;
            }

            _productRepo.Insert(barcode, name, (int)nudStock.Value, (int)nudReorderLevel.Value);

            ClearProductForm();
            LoadProducts();
        }

        private void btnProductUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Güncellemek için listeden ürün seç.");
                return;
            }

            var name = txtProductName.Text.Trim();
            var barcode = string.IsNullOrWhiteSpace(txtProductBarcode.Text) ? null : txtProductBarcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Ürün adı boş olamaz.");
                return;
            }

            _productRepo.Update(_selectedProductId.Value, barcode, name, (int)nudStock.Value, (int)nudReorderLevel.Value);

            ClearProductForm();
            LoadProducts();
        }


        private void btnProductDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Silmek için listeden ürün seç.");
                return;
            }

            if (MessageBox.Show("Seçili ürünü silmek istiyor musun?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            _productRepo.Delete(_selectedProductId.Value);

            ClearProductForm();
            LoadProducts();
        }

        private void ClearProductForm()
        {
            _selectedProductId = null;
            txtProductBarcode.Clear();
            txtProductName.Clear();
            nudStock.Value = 0;
            nudReorderLevel.Value = 0;
            dgvProductList.ClearSelection();
            SetProductButtonsState();

        }


        private void SetProductButtonsState()
        {
            var hasSelection = _selectedProductId.HasValue;

            btnProductUpdate.Enabled = hasSelection;
            btnProductDelete.Enabled = hasSelection;
        }


    }
}

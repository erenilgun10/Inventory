using Inventory.BLL.Services;
using System.Data;

namespace Inventory.UI
{
    public partial class InventoryForm : Form
    {
        private readonly ReportService _reportService = new();
        private readonly ProductService _productService = new();
        private readonly CategoryService _categoryService = new();
        private readonly SupplierService _supplierService = new();
        private readonly StockMovementService _stockMovementService = new();

        private int? _selectedProductId = null;
        private int? _selectedCategoryId = null;
        private int? _selectedSupplierId = null;
        private bool _productLookupsLoaded = false;
        private int? _selectedMovementId = null;
        private bool _movementProductsLoaded = false;



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
            this.Load += InventoryForm_Load;

            btnProductAdd.Click += btnProductAdd_Click;
            btnProductUpdate.Click += btnProductUpdate_Click;
            btnProductDelete.Click += btnProductDelete_Click;
            dgvProductList.SelectionChanged += dgvProductList_SelectionChanged;
            txtProductName.TextChanged += txtProductName_TextChanged;

            btnCategoryAdd.Click += btnCategoryAdd_Click;
            btnCategoryUpdate.Click += btnCategoryUpdate_Click;
            btnCategoryDelete.Click += btnCategoryDelete_Click;
            dgvCategoryList.SelectionChanged += dgvCategoryList_SelectionChanged;
            txtCategoryName.TextChanged += txtCategoryName_TextChanged;

            btnSupplierAdd.Click += btnSupplierAdd_Click;
            btnSupplierUpdate.Click += btnSupplierUpdate_Click;
            btnSupplierDelete.Click += btnSupplierDelete_Click;
            dgvSupplierList.SelectionChanged += dgvSupplierList_SelectionChanged;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;


            btnMovAdd.Click += btnMovAdd_Click;
            btnMovDelete.Click += btnMovDelete_Click;
            dgvStockMovementList.SelectionChanged += dgvStockMovementList_SelectionChanged;


        }

        private void InventoryForm_Load(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            UpdateSupplierAddButtonState();

        }

        private void SetScreen(ScreenMode mode)
        {
            grpReport.Visible = false;
            crudPanel.Visible = false;

            grpProductDetails.Visible = false;
            dgvProductList.Visible = false;

            grpCategoryDetails.Visible = false;
            dgvCategoryList.Visible = false;

            grpSupplierDetails.Visible = false;
            dgvSupplierList.Visible = false;

            btnProductSales.Visible = false;
            btnLowStock.Visible = false;
            btnDailySales.Visible = false;
            btnDailyPurchase.Visible = false;
            
            grpStockMovementDetails.Visible = false;
            dgvStockMovementList.Visible = false;

            switch (mode)
            {
                case ScreenMode.Reports:
                    grpReport.Visible = true;
                    btnLowStock.Visible = true;
                    btnDailySales.Visible = true;
                    btnProductSales.Visible = true;
                    btnDailyPurchase.Visible = true;
                    break;

                case ScreenMode.Products:
                    crudPanel.Visible = true;
                    grpProductDetails.Visible = true;
                    dgvProductList.Visible = true;

                    EnsureProductLookupsLoaded();
                    LoadProducts();
                    ClearProductForm();
                    break;

                case ScreenMode.Categories:
                    crudPanel.Visible = true;
                    grpCategoryDetails.Visible = true;
                    dgvCategoryList.Visible = true;
                    LoadCategories();
                    ClearCategoryForm();
                    break;

                case ScreenMode.Suppliers:
                    crudPanel.Visible = true;
                    grpSupplierDetails.Visible = true;
                    dgvSupplierList.Visible = true;
                    LoadSuppliers();
                    ClearSupplierForm();
                    break;

                case ScreenMode.StockMovements:
                    crudPanel.Visible = true;

                    grpStockMovementDetails.Visible = true;
                    dgvStockMovementList.Visible = true;

                    EnsureMovementProductsLoaded();
                    LoadStockMovements();
                    ClearStockMovementForm();
                    break;
            }
        }




        #region Reports

        private void btnReports_Click(object? sender, EventArgs e) => SetScreen(ScreenMode.Reports);

        private void btnProducts_Click(object? sender, EventArgs e) => SetScreen(ScreenMode.Products);

        private void btnCategories_Click(object? sender, EventArgs e) => SetScreen(ScreenMode.Categories);

        private void btnSuppliers_Click(object? sender, EventArgs e) => SetScreen(ScreenMode.Suppliers);

        private void btnStockMov_Click(object? sender, EventArgs e) => SetScreen(ScreenMode.StockMovements);

        private void btnLowStock_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportService.GetLowStock();
        }

        private void btnDailySales_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportService.GetDailySales();
        }

        private void btnProductSales_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportService.GetProductSales();
        }

        private void btnDailyPurchase_Click(object? sender, EventArgs e)
        {
            SetScreen(ScreenMode.Reports);
            gridReport.DataSource = _reportService.GetDailyPurchases();
        }

        private void pnlLeft_Paint(object? sender, PaintEventArgs e) { }
        private void grpReport_Enter(object? sender, EventArgs e) { }
        private void gridReport_CellContentClick(object? sender, DataGridViewCellEventArgs e) { }



        #endregion

        #region Product
        private void LoadProducts()
        {
            dgvProductList.DataSource = _productService.GetAll();

            if (dgvProductList.Columns != null && dgvProductList.Columns.Contains("ProductId"))
                dgvProductList.Columns["ProductId"]!.Visible = false;

            if (dgvProductList.Columns != null && dgvProductList.Columns.Contains("MinStock"))
                dgvProductList.Columns["MinStock"]!.HeaderText = "Reorder Level";

            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.MultiSelect = false;
            dgvProductList.ReadOnly = true;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

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

            var categoryValue = row.Cells["CategoryId"].Value;
            if (categoryValue == null || categoryValue == DBNull.Value)
                cmbCategory.SelectedIndex = -1;
            else
                cmbCategory.SelectedValue = Convert.ToInt32(categoryValue);

            var supplierValue = row.Cells["SupplierId"].Value;
            if (supplierValue == null || supplierValue == DBNull.Value)
                cmbSupplier.SelectedIndex = -1;
            else
                cmbSupplier.SelectedValue = Convert.ToInt32(supplierValue);


            nudPurchasePrice.Value = Convert.ToDecimal(row.Cells["PurchasePrice"].Value == DBNull.Value ? 0 : row.Cells["PurchasePrice"].Value);
            nudSalePrice.Value = Convert.ToDecimal(row.Cells["SalePrice"].Value == DBNull.Value ? 0 : row.Cells["SalePrice"].Value);

            SetProductButtonsState();
        }

        private void btnProductAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                int? categoryId = (cmbCategory.SelectedValue == null) ? null : Convert.ToInt32(cmbCategory.SelectedValue);
                int? supplierId = (cmbSupplier.SelectedValue == null) ? null : Convert.ToInt32(cmbSupplier.SelectedValue);

                _productService.Add(
                    txtProductBarcode.Text,
                    txtProductName.Text,
                    categoryId,
                    supplierId,
                    nudPurchasePrice.Value,
                    nudSalePrice.Value,
                    (int)nudStock.Value,
                    (int)nudReorderLevel.Value
                );

                ClearProductForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Please select a product to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int? categoryId = (cmbCategory.SelectedValue == null) ? null : Convert.ToInt32(cmbCategory.SelectedValue);
                int? supplierId = (cmbSupplier.SelectedValue == null) ? null : Convert.ToInt32(cmbSupplier.SelectedValue);

                _productService.Update(
                    _selectedProductId.Value,
                    txtProductBarcode.Text,
                    txtProductName.Text,
                    categoryId,
                    supplierId,
                    nudPurchasePrice.Value,
                    nudSalePrice.Value,
                    (int)nudStock.Value,
                    (int)nudReorderLevel.Value
                );

                ClearProductForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Please select a product to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete the selected product?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                _productService.Delete(_selectedProductId.Value);
                ClearProductForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearProductForm()
        {
            _selectedProductId = null;

            txtProductBarcode.Clear();
            txtProductName.Clear();

            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;

            nudPurchasePrice.Value = 0;
            nudSalePrice.Value = 0;

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

        private void EnsureProductLookupsLoaded()
        {
            if (_productLookupsLoaded) return;

            var catDt = _categoryService.GetAll();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = catDt;
            cmbCategory.SelectedIndex = -1;

            var supDt = _supplierService.GetAll();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.DataSource = supDt;
            cmbSupplier.SelectedIndex = -1;

            _productLookupsLoaded = true;
        }

        private void txtProductName_TextChanged(object? sender, EventArgs e)
        {
            UpdateProductAddButtonState();
        }

        private void UpdateProductAddButtonState()
        {
            btnProductAdd.Enabled = !string.IsNullOrWhiteSpace(txtProductName.Text);
        }
        #endregion

        #region Category

        private void LoadCategories()
        {
            dgvCategoryList.DataSource = _categoryService.GetAll();

            if (dgvCategoryList.Columns.Contains("CategoryId"))
                dgvCategoryList.Columns["CategoryId"]!.Visible = false;

            dgvCategoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryList.MultiSelect = false;
            dgvCategoryList.ReadOnly = true;
            dgvCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dgvCategoryList_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCategoryList.CurrentRow == null) return;

            var row = dgvCategoryList.CurrentRow;
            var idObj = row.Cells["CategoryId"].Value;
            if (idObj == null || idObj == DBNull.Value) return;

            _selectedCategoryId = Convert.ToInt32(idObj);
            txtCategoryName.Text = Convert.ToString(row.Cells["Name"].Value) ?? "";

            SetCategoryButtonsState();
        }

        private void btnCategoryAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(txtCategoryName.Text);
                _productLookupsLoaded = false;
                ClearCategoryForm();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoryUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedCategoryId == null)
            {
                MessageBox.Show("Please select a category to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _categoryService.Update(_selectedCategoryId.Value, txtCategoryName.Text);
                _productLookupsLoaded = false;
                ClearCategoryForm();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoryDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedCategoryId == null)
            {
                MessageBox.Show("Please select a category to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete the selected category?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _categoryService.Delete(_selectedCategoryId.Value);
                _productLookupsLoaded = false;
                ClearCategoryForm();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCategoryForm()
        {
            txtCategoryName.Clear();
            _selectedCategoryId = null;

            dgvCategoryList.ClearSelection();
            SetCategoryButtonsState();

            UpdateCategoryAddButtonState();
        }

        private void SetCategoryButtonsState()
        {
            var hasSelection = _selectedCategoryId.HasValue;
            btnCategoryUpdate.Enabled = hasSelection;
            btnCategoryDelete.Enabled = hasSelection;
        }

        private void txtCategoryName_TextChanged(object? sender, EventArgs e)
        {
            UpdateCategoryAddButtonState();
        }


        private void UpdateCategoryAddButtonState()
        {
            btnCategoryAdd.Enabled = !string.IsNullOrWhiteSpace(txtCategoryName.Text);
        }
        #endregion

        #region Supplier

        private void LoadSuppliers()
        {
            dgvSupplierList.DataSource = _supplierService.GetAll();

            if (dgvSupplierList.Columns.Contains("SupplierId"))
                dgvSupplierList.Columns["SupplierId"]!.Visible = false;

            dgvSupplierList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierList.MultiSelect = false;
            dgvSupplierList.ReadOnly = true;
            dgvSupplierList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvSupplierList_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSupplierList.CurrentRow == null) return;

            var row = dgvSupplierList.CurrentRow;
            var idObj = row.Cells["SupplierId"].Value;
            if (idObj == null || idObj == DBNull.Value) return;

            _selectedSupplierId = Convert.ToInt32(idObj);

            txtSupplierName.Text = Convert.ToString(row.Cells["Name"].Value) ?? "";
            txtSupplierPhone.Text = Convert.ToString(row.Cells["Phone"].Value) ?? "";
            txtSupplierEmail.Text = Convert.ToString(row.Cells["Email"].Value) ?? "";
            txtSupplierAddress.Text = Convert.ToString(row.Cells["Address"].Value) ?? "";

            SetSupplierButtonsState();
        }

        private void btnSupplierAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                _supplierService.Add(
                    txtSupplierName.Text,
                    txtSupplierPhone.Text,
                    txtSupplierEmail.Text,
                    txtSupplierAddress.Text
                );
                _productLookupsLoaded = false;
                ClearSupplierForm();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupplierUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedSupplierId == null)
            {
                MessageBox.Show("Please select a supplier to update.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _supplierService.Update(
                    _selectedSupplierId.Value,
                    txtSupplierName.Text,
                    txtSupplierPhone.Text,
                    txtSupplierEmail.Text,
                    txtSupplierAddress.Text
                );
                _productLookupsLoaded = false;
                ClearSupplierForm();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupplierDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedSupplierId == null)
            {
                MessageBox.Show("Please select a supplier to delete.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete the selected supplier?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _supplierService.Delete(_selectedSupplierId.Value);
                _productLookupsLoaded = false;
                ClearSupplierForm();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSupplierForm()
        {
            txtSupplierName.Clear();
            txtSupplierPhone.Clear();
            txtSupplierEmail.Clear();
            txtSupplierAddress.Clear();

            _selectedSupplierId = null;

            dgvSupplierList.ClearSelection();
            SetSupplierButtonsState();
            UpdateSupplierAddButtonState();
        }


        private void SetSupplierButtonsState()
        {
            var hasSelection = _selectedSupplierId.HasValue;
            btnSupplierUpdate.Enabled = hasSelection;
            btnSupplierDelete.Enabled = hasSelection;
        }

        private void txtSupplierName_TextChanged(object? sender, EventArgs e)
        {
            UpdateSupplierAddButtonState();
        }

        private void UpdateSupplierAddButtonState()
        {
            btnSupplierAdd.Enabled = !string.IsNullOrWhiteSpace(txtSupplierName.Text);
            UpdateProductAddButtonState();
            UpdateCategoryAddButtonState();
            UpdateSupplierAddButtonState();
        }


        #endregion

        #region Stock Movements

        private void EnsureMovementProductsLoaded()
        {
            if (_movementProductsLoaded) return;

            var dt = _productService.GetAll();
            cmbMovProduct.DisplayMember = "Name";
            cmbMovProduct.ValueMember = "ProductId";
            cmbMovProduct.DataSource = dt;
            cmbMovProduct.SelectedIndex = -1;

            cmbMovType.Items.Clear();
            cmbMovType.Items.AddRange(new object[] { "IN", "OUT" });
            cmbMovType.SelectedIndex = 0;

            _movementProductsLoaded = true;
        }

        private void LoadStockMovements()
        {
            dgvStockMovementList.DataSource = _stockMovementService.GetAll();

            dgvStockMovementList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockMovementList.MultiSelect = false;
            dgvStockMovementList.ReadOnly = true;
            dgvStockMovementList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvStockMovementList.Columns.Contains("MovementId"))
                dgvStockMovementList.Columns["MovementId"]!.Visible = false;
        }


        private void ClearStockMovementForm()
        {
            _selectedMovementId = null;
            cmbMovProduct.SelectedIndex = -1;
            cmbMovType.SelectedIndex = 0;
            nudMovQty.Value = 1;
            nudMovUnitPrice.Value = 0;
            txtMovNote.Clear();
            dtpMovDate.Value = DateTime.Today; 
            dgvStockMovementList.ClearSelection();

        }

        private void btnMovAdd_Click(object? sender, EventArgs e)
        {
            if (cmbMovProduct.SelectedValue is null) { MessageBox.Show("Select product."); return; }

            var productId = Convert.ToInt32(cmbMovProduct.SelectedValue);
            var type = cmbMovType.SelectedItem?.ToString() ?? "IN";
            var qty = (int)nudMovQty.Value;
            var price = nudMovUnitPrice.Value;
            var note = txtMovNote.Text;
            var date = dtpMovDate.Value.Date;

            _stockMovementService.Add(productId, type, qty, price, note, date);

            LoadStockMovements();
            ClearStockMovementForm();
        }

        private void btnMovDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedMovementId is null) { MessageBox.Show("Select a row."); return; }

            _stockMovementService.Delete(_selectedMovementId.Value);

            LoadStockMovements();
            ClearStockMovementForm();
        }

        private void dgvStockMovementList_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvStockMovementList.CurrentRow?.DataBoundItem is not DataRowView row) return;

            _selectedMovementId = Convert.ToInt32(row["MovementId"]);
        }


        #endregion


    }
}

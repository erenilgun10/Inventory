namespace Inventory.UI
{
    partial class InventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlLeft = new Panel();
            btnStockMov = new Button();
            btnSuppliers = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnReports = new Button();
            btnLowStock = new Button();
            btnDailySales = new Button();
            btnProductSales = new Button();
            pnlMain = new Panel();
            crudPanel = new Panel();
            splitCrud = new SplitContainer();
            grpStockMovementDetails = new GroupBox();
            btnMovDelete = new Button();
            btnMovAdd = new Button();
            txtMovNote = new TextBox();
            lblMovNote = new Label();
            cmbMovType = new ComboBox();
            dtpMovDate = new DateTimePicker();
            lblMovDate = new Label();
            nudMovUnitPrice = new NumericUpDown();
            lblMovUnitPrice = new Label();
            nudMovQty = new NumericUpDown();
            lblMovQty = new Label();
            lblMovType = new Label();
            cmbMovProduct = new ComboBox();
            lblMovProduct = new Label();
            grpSupplierDetails = new GroupBox();
            btnSupplierDelete = new Button();
            txtSupplierAddress = new TextBox();
            txtSupplierEmail = new TextBox();
            lblSupplierPhone = new Label();
            lblSupplierName = new Label();
            txtSupplierPhone = new TextBox();
            txtSupplierName = new TextBox();
            btnSupplierUpdate = new Button();
            btnSupplierAdd = new Button();
            grpProductDetails = new GroupBox();
            cmbSupplier = new ComboBox();
            cmbCategory = new ComboBox();
            lblSalePrice = new Label();
            nudSalePrice = new NumericUpDown();
            lblSupplierCb = new Label();
            lblNudPurchasePrice = new Label();
            nudPurchasePrice = new NumericUpDown();
            lblCategory = new Label();
            txtProductBarcode = new TextBox();
            lblBarcode = new Label();
            lblReorder = new Label();
            btnProductDelete = new Button();
            btnProductUpdate = new Button();
            btnProductAdd = new Button();
            nudStock = new NumericUpDown();
            nudReorderLevel = new NumericUpDown();
            lblStock = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            grpCategoryDetails = new GroupBox();
            btnCategoryDelete = new Button();
            btnCategoryUpdate = new Button();
            btnCategoryAdd = new Button();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            dgvProductList = new DataGridView();
            dgvCategoryList = new DataGridView();
            dgvSupplierList = new DataGridView();
            dgvStockMovementList = new DataGridView();
            grpReport = new GroupBox();
            statusStrip1 = new StatusStrip();
            statusStrip = new ToolStripStatusLabel();
            gridReport = new DataGridView();
            btnDailyPurchase = new Button();
            pnlLeft.SuspendLayout();
            pnlMain.SuspendLayout();
            crudPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitCrud).BeginInit();
            splitCrud.Panel1.SuspendLayout();
            splitCrud.Panel2.SuspendLayout();
            splitCrud.SuspendLayout();
            grpStockMovementDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMovUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMovQty).BeginInit();
            grpSupplierDetails.SuspendLayout();
            grpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPurchasePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).BeginInit();
            grpCategoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockMovementList).BeginInit();
            grpReport.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1123, 45);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(10, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory Management System";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnStockMov);
            pnlLeft.Controls.Add(btnSuppliers);
            pnlLeft.Controls.Add(btnCategories);
            pnlLeft.Controls.Add(btnProducts);
            pnlLeft.Controls.Add(btnReports);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 45);
            pnlLeft.Margin = new Padding(3, 2, 3, 2);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(9, 8, 9, 8);
            pnlLeft.Size = new Size(192, 737);
            pnlLeft.TabIndex = 2;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // btnStockMov
            // 
            btnStockMov.Dock = DockStyle.Top;
            btnStockMov.Location = new Point(9, 172);
            btnStockMov.Margin = new Padding(3, 2, 3, 2);
            btnStockMov.Name = "btnStockMov";
            btnStockMov.Padding = new Padding(9, 8, 9, 8);
            btnStockMov.Size = new Size(174, 41);
            btnStockMov.TabIndex = 4;
            btnStockMov.Text = "Stock Movements";
            btnStockMov.UseVisualStyleBackColor = true;
            btnStockMov.Click += btnStockMov_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.Location = new Point(9, 131);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(9, 8, 9, 8);
            btnSuppliers.Size = new Size(174, 41);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.Location = new Point(9, 90);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(9, 8, 9, 8);
            btnCategories.Size = new Size(174, 41);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.Location = new Point(9, 49);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(9, 8, 9, 8);
            btnProducts.Size = new Size(174, 41);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(9, 8);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(9, 8, 9, 8);
            btnReports.Size = new Size(174, 41);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.Dock = DockStyle.Top;
            btnLowStock.Location = new Point(192, 79);
            btnLowStock.Margin = new Padding(0, 0, 0, 8);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(931, 34);
            btnLowStock.TabIndex = 3;
            btnLowStock.Text = "Low Stock Products";
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnDailySales
            // 
            btnDailySales.Dock = DockStyle.Top;
            btnDailySales.Location = new Point(192, 113);
            btnDailySales.Margin = new Padding(0, 0, 0, 8);
            btnDailySales.Name = "btnDailySales";
            btnDailySales.Size = new Size(931, 34);
            btnDailySales.TabIndex = 4;
            btnDailySales.Text = "Daily Sales Summary";
            btnDailySales.UseVisualStyleBackColor = true;
            btnDailySales.Click += btnDailySales_Click;
            // 
            // btnProductSales
            // 
            btnProductSales.Dock = DockStyle.Top;
            btnProductSales.Location = new Point(192, 147);
            btnProductSales.Margin = new Padding(0, 0, 0, 8);
            btnProductSales.Name = "btnProductSales";
            btnProductSales.Size = new Size(931, 34);
            btnProductSales.TabIndex = 5;
            btnProductSales.Text = "Product Sales Summary";
            btnProductSales.UseVisualStyleBackColor = true;
            btnProductSales.Click += btnProductSales_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(crudPanel);
            pnlMain.Controls.Add(grpReport);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(192, 181);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(9, 8, 9, 8);
            pnlMain.Size = new Size(931, 601);
            pnlMain.TabIndex = 6;
            // 
            // crudPanel
            // 
            crudPanel.Controls.Add(splitCrud);
            crudPanel.Dock = DockStyle.Fill;
            crudPanel.Location = new Point(9, 8);
            crudPanel.Margin = new Padding(3, 2, 3, 2);
            crudPanel.Name = "crudPanel";
            crudPanel.Size = new Size(913, 585);
            crudPanel.TabIndex = 3;
            crudPanel.Visible = false;
            // 
            // splitCrud
            // 
            splitCrud.Dock = DockStyle.Fill;
            splitCrud.IsSplitterFixed = true;
            splitCrud.Location = new Point(0, 0);
            splitCrud.Margin = new Padding(3, 2, 3, 2);
            splitCrud.Name = "splitCrud";
            splitCrud.Orientation = Orientation.Horizontal;
            // 
            // splitCrud.Panel1
            // 
            splitCrud.Panel1.Controls.Add(grpStockMovementDetails);
            splitCrud.Panel1.Controls.Add(grpSupplierDetails);
            splitCrud.Panel1.Controls.Add(grpProductDetails);
            splitCrud.Panel1.Controls.Add(grpCategoryDetails);
            splitCrud.Panel1MinSize = 200;
            // 
            // splitCrud.Panel2
            // 
            splitCrud.Panel2.Controls.Add(dgvProductList);
            splitCrud.Panel2.Controls.Add(dgvCategoryList);
            splitCrud.Panel2.Controls.Add(dgvSupplierList);
            splitCrud.Panel2.Controls.Add(dgvStockMovementList);
            splitCrud.Panel2MinSize = 200;
            splitCrud.Size = new Size(913, 585);
            splitCrud.SplitterDistance = 207;
            splitCrud.SplitterWidth = 2;
            splitCrud.TabIndex = 13;
            // 
            // grpStockMovementDetails
            // 
            grpStockMovementDetails.Controls.Add(btnMovDelete);
            grpStockMovementDetails.Controls.Add(btnMovAdd);
            grpStockMovementDetails.Controls.Add(txtMovNote);
            grpStockMovementDetails.Controls.Add(lblMovNote);
            grpStockMovementDetails.Controls.Add(cmbMovType);
            grpStockMovementDetails.Controls.Add(dtpMovDate);
            grpStockMovementDetails.Controls.Add(lblMovDate);
            grpStockMovementDetails.Controls.Add(nudMovUnitPrice);
            grpStockMovementDetails.Controls.Add(lblMovUnitPrice);
            grpStockMovementDetails.Controls.Add(nudMovQty);
            grpStockMovementDetails.Controls.Add(lblMovQty);
            grpStockMovementDetails.Controls.Add(lblMovType);
            grpStockMovementDetails.Controls.Add(cmbMovProduct);
            grpStockMovementDetails.Controls.Add(lblMovProduct);
            grpStockMovementDetails.Dock = DockStyle.Fill;
            grpStockMovementDetails.Location = new Point(0, 0);
            grpStockMovementDetails.Margin = new Padding(3, 2, 3, 2);
            grpStockMovementDetails.Name = "grpStockMovementDetails";
            grpStockMovementDetails.Padding = new Padding(3, 2, 3, 2);
            grpStockMovementDetails.Size = new Size(913, 207);
            grpStockMovementDetails.TabIndex = 15;
            grpStockMovementDetails.TabStop = false;
            grpStockMovementDetails.Text = "Stock Movement";
            grpStockMovementDetails.Visible = false;
            // 
            // btnMovDelete
            // 
            btnMovDelete.Location = new Point(466, 146);
            btnMovDelete.Margin = new Padding(3, 2, 3, 2);
            btnMovDelete.Name = "btnMovDelete";
            btnMovDelete.Size = new Size(82, 22);
            btnMovDelete.TabIndex = 16;
            btnMovDelete.Text = "Delete";
            btnMovDelete.UseVisualStyleBackColor = true;
            // 
            // btnMovAdd
            // 
            btnMovAdd.Location = new Point(310, 146);
            btnMovAdd.Margin = new Padding(3, 2, 3, 2);
            btnMovAdd.Name = "btnMovAdd";
            btnMovAdd.Size = new Size(82, 22);
            btnMovAdd.TabIndex = 15;
            btnMovAdd.Text = "Add";
            btnMovAdd.UseVisualStyleBackColor = true;
            // 
            // txtMovNote
            // 
            txtMovNote.Location = new Point(644, 74);
            txtMovNote.Margin = new Padding(3, 2, 3, 2);
            txtMovNote.Multiline = true;
            txtMovNote.Name = "txtMovNote";
            txtMovNote.Size = new Size(110, 38);
            txtMovNote.TabIndex = 14;
            // 
            // lblMovNote
            // 
            lblMovNote.AutoSize = true;
            lblMovNote.Location = new Point(589, 80);
            lblMovNote.Name = "lblMovNote";
            lblMovNote.Size = new Size(33, 15);
            lblMovNote.TabIndex = 12;
            lblMovNote.Text = "Note";
            // 
            // cmbMovType
            // 
            cmbMovType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovType.FormattingEnabled = true;
            cmbMovType.Items.AddRange(new object[] { "IN, OUT" });
            cmbMovType.Location = new Point(111, 74);
            cmbMovType.Margin = new Padding(3, 2, 3, 2);
            cmbMovType.Name = "cmbMovType";
            cmbMovType.Size = new Size(133, 23);
            cmbMovType.TabIndex = 11;
            // 
            // dtpMovDate
            // 
            dtpMovDate.Format = DateTimePickerFormat.Short;
            dtpMovDate.Location = new Point(644, 38);
            dtpMovDate.Margin = new Padding(3, 2, 3, 2);
            dtpMovDate.Name = "dtpMovDate";
            dtpMovDate.Size = new Size(104, 23);
            dtpMovDate.TabIndex = 10;
            // 
            // lblMovDate
            // 
            lblMovDate.AutoSize = true;
            lblMovDate.Location = new Point(589, 42);
            lblMovDate.Name = "lblMovDate";
            lblMovDate.Size = new Size(31, 15);
            lblMovDate.TabIndex = 9;
            lblMovDate.Text = "Date";
            // 
            // nudMovUnitPrice
            // 
            nudMovUnitPrice.DecimalPlaces = 2;
            nudMovUnitPrice.Location = new Point(398, 75);
            nudMovUnitPrice.Margin = new Padding(3, 2, 3, 2);
            nudMovUnitPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudMovUnitPrice.Name = "nudMovUnitPrice";
            nudMovUnitPrice.Size = new Size(131, 23);
            nudMovUnitPrice.TabIndex = 8;
            // 
            // lblMovUnitPrice
            // 
            lblMovUnitPrice.AutoSize = true;
            lblMovUnitPrice.Location = new Point(317, 79);
            lblMovUnitPrice.Name = "lblMovUnitPrice";
            lblMovUnitPrice.Size = new Size(58, 15);
            lblMovUnitPrice.TabIndex = 7;
            lblMovUnitPrice.Text = "Unit Price";
            // 
            // nudMovQty
            // 
            nudMovQty.Location = new Point(398, 38);
            nudMovQty.Margin = new Padding(3, 2, 3, 2);
            nudMovQty.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMovQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMovQty.Name = "nudMovQty";
            nudMovQty.Size = new Size(131, 23);
            nudMovQty.TabIndex = 5;
            nudMovQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMovQty
            // 
            lblMovQty.AutoSize = true;
            lblMovQty.Location = new Point(317, 42);
            lblMovQty.Name = "lblMovQty";
            lblMovQty.Size = new Size(53, 15);
            lblMovQty.TabIndex = 4;
            lblMovQty.Text = "Quantity";
            // 
            // lblMovType
            // 
            lblMovType.AutoSize = true;
            lblMovType.Location = new Point(42, 80);
            lblMovType.Name = "lblMovType";
            lblMovType.Size = new Size(31, 15);
            lblMovType.TabIndex = 2;
            lblMovType.Text = "Type";
            // 
            // cmbMovProduct
            // 
            cmbMovProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovProduct.FormattingEnabled = true;
            cmbMovProduct.Location = new Point(111, 38);
            cmbMovProduct.Margin = new Padding(3, 2, 3, 2);
            cmbMovProduct.Name = "cmbMovProduct";
            cmbMovProduct.Size = new Size(133, 23);
            cmbMovProduct.TabIndex = 1;
            // 
            // lblMovProduct
            // 
            lblMovProduct.AutoSize = true;
            lblMovProduct.Location = new Point(42, 42);
            lblMovProduct.Name = "lblMovProduct";
            lblMovProduct.Size = new Size(49, 15);
            lblMovProduct.TabIndex = 0;
            lblMovProduct.Text = "Product";
            // 
            // grpSupplierDetails
            // 
            grpSupplierDetails.Controls.Add(btnSupplierDelete);
            grpSupplierDetails.Controls.Add(txtSupplierAddress);
            grpSupplierDetails.Controls.Add(txtSupplierEmail);
            grpSupplierDetails.Controls.Add(lblSupplierPhone);
            grpSupplierDetails.Controls.Add(lblSupplierName);
            grpSupplierDetails.Controls.Add(txtSupplierPhone);
            grpSupplierDetails.Controls.Add(txtSupplierName);
            grpSupplierDetails.Controls.Add(btnSupplierUpdate);
            grpSupplierDetails.Controls.Add(btnSupplierAdd);
            grpSupplierDetails.Dock = DockStyle.Fill;
            grpSupplierDetails.Location = new Point(0, 0);
            grpSupplierDetails.Margin = new Padding(3, 2, 3, 2);
            grpSupplierDetails.Name = "grpSupplierDetails";
            grpSupplierDetails.Padding = new Padding(3, 2, 3, 2);
            grpSupplierDetails.Size = new Size(913, 207);
            grpSupplierDetails.TabIndex = 14;
            grpSupplierDetails.TabStop = false;
            grpSupplierDetails.Text = "Supplier Details";
            grpSupplierDetails.Visible = false;
            // 
            // btnSupplierDelete
            // 
            btnSupplierDelete.Location = new Point(524, 130);
            btnSupplierDelete.Margin = new Padding(3, 2, 3, 2);
            btnSupplierDelete.Name = "btnSupplierDelete";
            btnSupplierDelete.Size = new Size(82, 22);
            btnSupplierDelete.TabIndex = 9;
            btnSupplierDelete.Text = "Delete";
            btnSupplierDelete.UseVisualStyleBackColor = true;
            btnSupplierDelete.Click += btnSupplierDelete_Click;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(542, 48);
            txtSupplierAddress.Margin = new Padding(3, 2, 3, 2);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(110, 23);
            txtSupplierAddress.TabIndex = 14;
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Location = new Point(542, 16);
            txtSupplierEmail.Margin = new Padding(3, 2, 3, 2);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(110, 23);
            txtSupplierEmail.TabIndex = 12;
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.AutoSize = true;
            lblSupplierPhone.Location = new Point(170, 53);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(87, 15);
            lblSupplierPhone.TabIndex = 8;
            lblSupplierPhone.Text = "Supplier Phone";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(170, 22);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(85, 15);
            lblSupplierName.TabIndex = 7;
            lblSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Location = new Point(280, 48);
            txtSupplierPhone.Margin = new Padding(3, 2, 3, 2);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(110, 23);
            txtSupplierPhone.TabIndex = 6;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(280, 20);
            txtSupplierName.Margin = new Padding(3, 2, 3, 2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(110, 23);
            txtSupplierName.TabIndex = 5;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;
            // 
            // btnSupplierUpdate
            // 
            btnSupplierUpdate.Location = new Point(395, 130);
            btnSupplierUpdate.Margin = new Padding(3, 2, 3, 2);
            btnSupplierUpdate.Name = "btnSupplierUpdate";
            btnSupplierUpdate.Size = new Size(82, 22);
            btnSupplierUpdate.TabIndex = 10;
            btnSupplierUpdate.Text = "Update";
            btnSupplierUpdate.UseVisualStyleBackColor = true;
            btnSupplierUpdate.Click += btnSupplierUpdate_Click;
            // 
            // btnSupplierAdd
            // 
            btnSupplierAdd.Location = new Point(270, 130);
            btnSupplierAdd.Margin = new Padding(3, 2, 3, 2);
            btnSupplierAdd.Name = "btnSupplierAdd";
            btnSupplierAdd.Size = new Size(82, 22);
            btnSupplierAdd.TabIndex = 11;
            btnSupplierAdd.Text = "Add";
            btnSupplierAdd.UseVisualStyleBackColor = true;
            btnSupplierAdd.Click += btnSupplierAdd_Click;
            // 
            // grpProductDetails
            // 
            grpProductDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpProductDetails.Controls.Add(cmbSupplier);
            grpProductDetails.Controls.Add(cmbCategory);
            grpProductDetails.Controls.Add(lblSalePrice);
            grpProductDetails.Controls.Add(nudSalePrice);
            grpProductDetails.Controls.Add(lblSupplierCb);
            grpProductDetails.Controls.Add(lblNudPurchasePrice);
            grpProductDetails.Controls.Add(nudPurchasePrice);
            grpProductDetails.Controls.Add(lblCategory);
            grpProductDetails.Controls.Add(txtProductBarcode);
            grpProductDetails.Controls.Add(lblBarcode);
            grpProductDetails.Controls.Add(lblReorder);
            grpProductDetails.Controls.Add(btnProductDelete);
            grpProductDetails.Controls.Add(btnProductUpdate);
            grpProductDetails.Controls.Add(btnProductAdd);
            grpProductDetails.Controls.Add(nudStock);
            grpProductDetails.Controls.Add(nudReorderLevel);
            grpProductDetails.Controls.Add(lblStock);
            grpProductDetails.Controls.Add(txtProductName);
            grpProductDetails.Controls.Add(lblProductName);
            grpProductDetails.Location = new Point(0, 36);
            grpProductDetails.Margin = new Padding(3, 2, 3, 2);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Padding = new Padding(3, 2, 3, 2);
            grpProductDetails.Size = new Size(913, 175);
            grpProductDetails.TabIndex = 12;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            grpProductDetails.Visible = false;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(420, 92);
            cmbSupplier.Margin = new Padding(3, 2, 3, 2);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(110, 23);
            cmbSupplier.TabIndex = 33;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(420, 62);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(110, 23);
            cmbCategory.TabIndex = 32;
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Location = new Point(569, 67);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(57, 15);
            lblSalePrice.TabIndex = 31;
            lblSalePrice.Text = "Sale Price";
            // 
            // nudSalePrice
            // 
            nudSalePrice.DecimalPlaces = 2;
            nudSalePrice.Location = new Point(691, 64);
            nudSalePrice.Margin = new Padding(3, 2, 3, 2);
            nudSalePrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(109, 23);
            nudSalePrice.TabIndex = 30;
            // 
            // lblSupplierCb
            // 
            lblSupplierCb.AutoSize = true;
            lblSupplierCb.Location = new Point(332, 97);
            lblSupplierCb.Name = "lblSupplierCb";
            lblSupplierCb.Size = new Size(50, 15);
            lblSupplierCb.TabIndex = 29;
            lblSupplierCb.Text = "Supplier";
            lblSupplierCb.UseMnemonic = false;
            // 
            // lblNudPurchasePrice
            // 
            lblNudPurchasePrice.AutoSize = true;
            lblNudPurchasePrice.Location = new Point(569, 32);
            lblNudPurchasePrice.Name = "lblNudPurchasePrice";
            lblNudPurchasePrice.Size = new Size(84, 15);
            lblNudPurchasePrice.TabIndex = 28;
            lblNudPurchasePrice.Text = "Purchase Price";
            // 
            // nudPurchasePrice
            // 
            nudPurchasePrice.DecimalPlaces = 2;
            nudPurchasePrice.Location = new Point(691, 27);
            nudPurchasePrice.Margin = new Padding(3, 2, 3, 2);
            nudPurchasePrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPurchasePrice.Name = "nudPurchasePrice";
            nudPurchasePrice.Size = new Size(109, 23);
            nudPurchasePrice.TabIndex = 27;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(332, 65);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 25;
            lblCategory.Text = "Category";
            // 
            // txtProductBarcode
            // 
            txtProductBarcode.Location = new Point(420, 29);
            txtProductBarcode.Margin = new Padding(3, 2, 3, 2);
            txtProductBarcode.Name = "txtProductBarcode";
            txtProductBarcode.Size = new Size(110, 23);
            txtProductBarcode.TabIndex = 22;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(332, 32);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(50, 15);
            lblBarcode.TabIndex = 21;
            lblBarcode.Text = "Barcode";
            // 
            // lblReorder
            // 
            lblReorder.AutoSize = true;
            lblReorder.Location = new Point(86, 97);
            lblReorder.Name = "lblReorder";
            lblReorder.Size = new Size(78, 15);
            lblReorder.TabIndex = 20;
            lblReorder.Text = "Reorder Level";
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(550, 136);
            btnProductDelete.Margin = new Padding(3, 2, 3, 2);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(82, 22);
            btnProductDelete.TabIndex = 19;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Location = new Point(421, 136);
            btnProductUpdate.Margin = new Padding(3, 2, 3, 2);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(82, 22);
            btnProductUpdate.TabIndex = 18;
            btnProductUpdate.Text = "Update";
            btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(284, 136);
            btnProductAdd.Margin = new Padding(3, 2, 3, 2);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(82, 22);
            btnProductAdd.TabIndex = 17;
            btnProductAdd.Text = "Add";
            btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(195, 62);
            nudStock.Margin = new Padding(3, 2, 3, 2);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(109, 23);
            nudStock.TabIndex = 16;
            // 
            // nudReorderLevel
            // 
            nudReorderLevel.Location = new Point(195, 92);
            nudReorderLevel.Margin = new Padding(3, 2, 3, 2);
            nudReorderLevel.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudReorderLevel.Name = "nudReorderLevel";
            nudReorderLevel.Size = new Size(109, 23);
            nudReorderLevel.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(89, 65);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(195, 32);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(110, 23);
            txtProductName.TabIndex = 13;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(86, 32);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(39, 15);
            lblProductName.TabIndex = 12;
            lblProductName.Text = "Name";
            // 
            // grpCategoryDetails
            // 
            grpCategoryDetails.Controls.Add(btnCategoryDelete);
            grpCategoryDetails.Controls.Add(btnCategoryUpdate);
            grpCategoryDetails.Controls.Add(btnCategoryAdd);
            grpCategoryDetails.Controls.Add(lblCategoryName);
            grpCategoryDetails.Controls.Add(txtCategoryName);
            grpCategoryDetails.Dock = DockStyle.Fill;
            grpCategoryDetails.Location = new Point(0, 0);
            grpCategoryDetails.Margin = new Padding(3, 2, 3, 2);
            grpCategoryDetails.Name = "grpCategoryDetails";
            grpCategoryDetails.Padding = new Padding(3, 2, 3, 2);
            grpCategoryDetails.Size = new Size(913, 207);
            grpCategoryDetails.TabIndex = 13;
            grpCategoryDetails.TabStop = false;
            grpCategoryDetails.Text = "Category Details";
            grpCategoryDetails.Visible = false;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.Location = new Point(480, 106);
            btnCategoryDelete.Margin = new Padding(3, 2, 3, 2);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(82, 22);
            btnCategoryDelete.TabIndex = 4;
            btnCategoryDelete.Text = "Delete";
            btnCategoryDelete.UseVisualStyleBackColor = true;
            btnCategoryDelete.Click += btnCategoryDelete_Click;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.Location = new Point(382, 107);
            btnCategoryUpdate.Margin = new Padding(3, 2, 3, 2);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(82, 22);
            btnCategoryUpdate.TabIndex = 3;
            btnCategoryUpdate.Text = "Update";
            btnCategoryUpdate.UseVisualStyleBackColor = true;
            btnCategoryUpdate.Click += btnCategoryUpdate_Click;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Location = new Point(278, 107);
            btnCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(82, 22);
            btnCategoryAdd.TabIndex = 2;
            btnCategoryAdd.Text = "Add";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(270, 46);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(90, 15);
            lblCategoryName.TabIndex = 1;
            lblCategoryName.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(391, 44);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(110, 23);
            txtCategoryName.TabIndex = 0;
            txtCategoryName.TextChanged += txtCategoryName_TextChanged;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(0, 0);
            dgvProductList.Margin = new Padding(3, 2, 3, 2);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(913, 376);
            dgvProductList.TabIndex = 0;
            dgvProductList.SelectionChanged += dgvProductList_SelectionChanged;
            // 
            // dgvCategoryList
            // 
            dgvCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryList.Dock = DockStyle.Fill;
            dgvCategoryList.Location = new Point(0, 0);
            dgvCategoryList.Margin = new Padding(3, 2, 3, 2);
            dgvCategoryList.MultiSelect = false;
            dgvCategoryList.Name = "dgvCategoryList";
            dgvCategoryList.ReadOnly = true;
            dgvCategoryList.RowHeadersWidth = 51;
            dgvCategoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryList.Size = new Size(913, 376);
            dgvCategoryList.TabIndex = 1;
            dgvCategoryList.Visible = false;
            dgvCategoryList.SelectionChanged += dgvCategoryList_SelectionChanged;
            // 
            // dgvSupplierList
            // 
            dgvSupplierList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierList.Dock = DockStyle.Fill;
            dgvSupplierList.Location = new Point(0, 0);
            dgvSupplierList.Margin = new Padding(3, 2, 3, 2);
            dgvSupplierList.Name = "dgvSupplierList";
            dgvSupplierList.RowHeadersWidth = 51;
            dgvSupplierList.Size = new Size(913, 376);
            dgvSupplierList.TabIndex = 2;
            dgvSupplierList.SelectionChanged += dgvSupplierList_SelectionChanged;
            // 
            // dgvStockMovementList
            // 
            dgvStockMovementList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockMovementList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockMovementList.Dock = DockStyle.Fill;
            dgvStockMovementList.Location = new Point(0, 0);
            dgvStockMovementList.Margin = new Padding(3, 2, 3, 2);
            dgvStockMovementList.MultiSelect = false;
            dgvStockMovementList.Name = "dgvStockMovementList";
            dgvStockMovementList.ReadOnly = true;
            dgvStockMovementList.RowHeadersWidth = 51;
            dgvStockMovementList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockMovementList.Size = new Size(913, 376);
            dgvStockMovementList.TabIndex = 3;
            // 
            // grpReport
            // 
            grpReport.Controls.Add(statusStrip1);
            grpReport.Controls.Add(gridReport);
            grpReport.Dock = DockStyle.Fill;
            grpReport.Location = new Point(9, 8);
            grpReport.Margin = new Padding(3, 2, 3, 2);
            grpReport.Name = "grpReport";
            grpReport.Padding = new Padding(3, 2, 3, 2);
            grpReport.Size = new Size(913, 585);
            grpReport.TabIndex = 2;
            grpReport.TabStop = false;
            grpReport.Text = "Report";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStrip });
            statusStrip1.Location = new Point(3, 561);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(907, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(39, 17);
            statusStrip.Text = "Ready";
            // 
            // gridReport
            // 
            gridReport.AllowUserToDeleteRows = false;
            gridReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReport.Dock = DockStyle.Fill;
            gridReport.Location = new Point(3, 18);
            gridReport.Margin = new Padding(3, 2, 3, 2);
            gridReport.Name = "gridReport";
            gridReport.ReadOnly = true;
            gridReport.RowHeadersWidth = 51;
            gridReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridReport.Size = new Size(907, 565);
            gridReport.TabIndex = 0;
            gridReport.CellContentClick += gridReport_CellContentClick;
            // 
            // btnDailyPurchase
            // 
            btnDailyPurchase.Dock = DockStyle.Top;
            btnDailyPurchase.Location = new Point(192, 45);
            btnDailyPurchase.Margin = new Padding(0, 0, 0, 8);
            btnDailyPurchase.Name = "btnDailyPurchase";
            btnDailyPurchase.Size = new Size(931, 34);
            btnDailyPurchase.TabIndex = 7;
            btnDailyPurchase.Text = "Daily Purchase Summary";
            btnDailyPurchase.UseVisualStyleBackColor = true;
            btnDailyPurchase.Click += btnDailyPurchase_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 782);
            Controls.Add(pnlMain);
            Controls.Add(btnProductSales);
            Controls.Add(btnDailySales);
            Controls.Add(btnLowStock);
            Controls.Add(btnDailyPurchase);
            Controls.Add(pnlLeft);
            Controls.Add(lblTitle);
            Controls.Add(pnlTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            WindowState = FormWindowState.Maximized;
            Load += InventoryForm_Load;
            pnlLeft.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            crudPanel.ResumeLayout(false);
            splitCrud.Panel1.ResumeLayout(false);
            splitCrud.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCrud).EndInit();
            splitCrud.ResumeLayout(false);
            grpStockMovementDetails.ResumeLayout(false);
            grpStockMovementDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMovUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMovQty).EndInit();
            grpSupplierDetails.ResumeLayout(false);
            grpSupplierDetails.PerformLayout();
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPurchasePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).EndInit();
            grpCategoryDetails.ResumeLayout(false);
            grpCategoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockMovementList).EndInit();
            grpReport.ResumeLayout(false);
            grpReport.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblTitle;
        private Panel pnlLeft;
        private Button btnLowStock;
        private Button btnDailySales;
        private Button btnProductSales;
        private Panel pnlMain;
        private GroupBox grpReport;
        private DataGridView gridReport;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStrip;
        private Button btnReports;
        private Button btnStockMov;
        private Button btnSuppliers;
        private Button btnCategories;
        private Button btnProducts;
        private Panel crudPanel;
        private DataGridView dgvProductList;
        private GroupBox grpProductDetails;
        private TextBox txtProductBarcode;
        private Label lblBarcode;
        private Label lblReorder;
        private Button btnProductDelete;
        private Button btnProductUpdate;
        private Button btnProductAdd;
        private NumericUpDown nudStock;
        private NumericUpDown nudReorderLevel;
        private Label lblStock;
        private TextBox txtProductName;
        private Label lblProductName;
        private SplitContainer splitCrud;
        private GroupBox grpCategoryDetails;
        private DataGridView dgvCategoryList;
        private Button btnCategoryDelete;
        private Button btnCategoryUpdate;
        private Button btnCategoryAdd;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private GroupBox grpSupplierDetails;
        private Label lblSupplierPhone;
        private Label lblSupplierName;
        private TextBox txtSupplierPhone;
        private TextBox txtSupplierName;
        private Button btnSupplierDelete;
        private Button btnSupplierUpdate;
        private Button btnSupplierAdd;
        private DataGridView dgvSupplierList;
        private TextBox txtSupplierEmail;
        private TextBox txtSupplierAddress;
        private Button btnDailyPurchase;
        private Label lblCategory;
        private Label lblSupplierCb;
        private Label lblNudPurchasePrice;
        private NumericUpDown nudPurchasePrice;
        private NumericUpDown nudSalePrice;
        private Label lblSalePrice;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private GroupBox grpStockMovementDetails;
        private ComboBox cmbMovProduct;
        private Label lblMovProduct;
        private Label lblMovType;
        private DateTimePicker dtpMovDate;
        private Label lblMovDate;
        private NumericUpDown nudMovUnitPrice;
        private Label lblMovUnitPrice;
        private NumericUpDown nudMovQty;
        private Label lblMovQty;
        private Label lblMovNote;
        private ComboBox cmbMovType;
        private TextBox txtMovNote;
        private Button btnMovDelete;
        private Button btnMovAdd;
        private DataGridView dgvStockMovementList;
    }
}

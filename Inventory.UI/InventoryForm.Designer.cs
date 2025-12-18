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
            splitProducts = new SplitContainer();
            grpProductDetails = new GroupBox();
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
            dgvProductList = new DataGridView();
            grpReport = new GroupBox();
            statusStrip1 = new StatusStrip();
            statusStrip = new ToolStripStatusLabel();
            gridReport = new DataGridView();
            pnlLeft.SuspendLayout();
            pnlMain.SuspendLayout();
            crudPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitProducts).BeginInit();
            splitProducts.Panel1.SuspendLayout();
            splitProducts.Panel2.SuspendLayout();
            splitProducts.SuspendLayout();
            grpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            grpReport.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 32);
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
            pnlLeft.Location = new Point(0, 60);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10);
            pnlLeft.Size = new Size(220, 390);
            pnlLeft.TabIndex = 2;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // btnStockMov
            // 
            btnStockMov.Dock = DockStyle.Top;
            btnStockMov.Location = new Point(10, 230);
            btnStockMov.Name = "btnStockMov";
            btnStockMov.Padding = new Padding(10);
            btnStockMov.Size = new Size(200, 55);
            btnStockMov.TabIndex = 4;
            btnStockMov.Text = "Stock Movements";
            btnStockMov.UseVisualStyleBackColor = true;
            btnStockMov.Click += btnStockMov_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.Location = new Point(10, 175);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(10);
            btnSuppliers.Size = new Size(200, 55);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.Location = new Point(10, 120);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(10);
            btnCategories.Size = new Size(200, 55);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.Location = new Point(10, 65);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(10);
            btnProducts.Size = new Size(200, 55);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(10, 10);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(10);
            btnReports.Size = new Size(200, 55);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.Dock = DockStyle.Top;
            btnLowStock.Location = new Point(220, 60);
            btnLowStock.Margin = new Padding(0, 0, 0, 10);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(580, 45);
            btnLowStock.TabIndex = 3;
            btnLowStock.Text = "Low Stock Products";
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnDailySales
            // 
            btnDailySales.Dock = DockStyle.Top;
            btnDailySales.Location = new Point(220, 105);
            btnDailySales.Margin = new Padding(0, 0, 0, 10);
            btnDailySales.Name = "btnDailySales";
            btnDailySales.Size = new Size(580, 45);
            btnDailySales.TabIndex = 4;
            btnDailySales.Text = "Daily Sales Summary";
            btnDailySales.UseVisualStyleBackColor = true;
            btnDailySales.Click += btnDailySales_Click;
            // 
            // btnProductSales
            // 
            btnProductSales.Dock = DockStyle.Top;
            btnProductSales.Location = new Point(220, 150);
            btnProductSales.Margin = new Padding(0, 0, 0, 10);
            btnProductSales.Name = "btnProductSales";
            btnProductSales.Size = new Size(580, 45);
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
            pnlMain.Location = new Point(220, 195);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(10);
            pnlMain.Size = new Size(580, 255);
            pnlMain.TabIndex = 6;
            // 
            // crudPanel
            // 
            crudPanel.Controls.Add(splitProducts);
            crudPanel.Dock = DockStyle.Fill;
            crudPanel.Location = new Point(10, 10);
            crudPanel.Name = "crudPanel";
            crudPanel.Size = new Size(560, 235);
            crudPanel.TabIndex = 3;
            crudPanel.Visible = false;
            // 
            // splitProducts
            // 
            splitProducts.Dock = DockStyle.Fill;
            splitProducts.IsSplitterFixed = true;
            splitProducts.Location = new Point(0, 0);
            splitProducts.Name = "splitProducts";
            splitProducts.Orientation = Orientation.Horizontal;
            // 
            // splitProducts.Panel1
            // 
            splitProducts.Panel1.Controls.Add(grpProductDetails);
            splitProducts.Panel1MinSize = 106;
            // 
            // splitProducts.Panel2
            // 
            splitProducts.Panel2.Controls.Add(dgvProductList);
            splitProducts.Panel2MinSize = 101;
            splitProducts.Size = new Size(560, 235);
            splitProducts.SplitterDistance = 131;
            splitProducts.SplitterWidth = 3;
            splitProducts.TabIndex = 13;
            // 
            // grpProductDetails
            // 
            grpProductDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            grpProductDetails.Location = new Point(0, 0);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Size = new Size(560, 131);
            grpProductDetails.TabIndex = 12;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            // 
            // txtProductBarcode
            // 
            txtProductBarcode.Location = new Point(282, 127);
            txtProductBarcode.Name = "txtProductBarcode";
            txtProductBarcode.Size = new Size(125, 27);
            txtProductBarcode.TabIndex = 22;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(157, 127);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(64, 20);
            lblBarcode.TabIndex = 21;
            lblBarcode.Text = "Barcode";
            // 
            // lblReorder
            // 
            lblReorder.AutoSize = true;
            lblReorder.Location = new Point(157, 91);
            lblReorder.Name = "lblReorder";
            lblReorder.Size = new Size(100, 20);
            lblReorder.TabIndex = 20;
            lblReorder.Text = "Reorder Level";
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(364, 176);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(94, 29);
            btnProductDelete.TabIndex = 19;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Location = new Point(216, 176);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(94, 29);
            btnProductUpdate.TabIndex = 18;
            btnProductUpdate.Text = "Update";
            btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(59, 176);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(94, 29);
            btnProductAdd.TabIndex = 17;
            btnProductAdd.Text = "Add";
            btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(282, 47);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(125, 27);
            nudStock.TabIndex = 16;
            // 
            // nudReorderLevel
            // 
            nudReorderLevel.Location = new Point(282, 89);
            nudReorderLevel.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudReorderLevel.Name = "nudReorderLevel";
            nudReorderLevel.Size = new Size(125, 27);
            nudReorderLevel.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(157, 47);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(282, 7);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 13;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(157, 7);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(49, 20);
            lblProductName.TabIndex = 12;
            lblProductName.Text = "Name";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(0, 0);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(560, 101);
            dgvProductList.TabIndex = 0;
            dgvProductList.SelectionChanged += dgvProductList_SelectionChanged;
            // 
            // grpReport
            // 
            grpReport.Controls.Add(statusStrip1);
            grpReport.Controls.Add(gridReport);
            grpReport.Dock = DockStyle.Fill;
            grpReport.Location = new Point(10, 10);
            grpReport.Name = "grpReport";
            grpReport.Size = new Size(560, 235);
            grpReport.TabIndex = 2;
            grpReport.TabStop = false;
            grpReport.Text = "Report";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStrip });
            statusStrip1.Location = new Point(3, 206);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(554, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(50, 20);
            statusStrip.Text = "Ready";
            // 
            // gridReport
            // 
            gridReport.AllowUserToDeleteRows = false;
            gridReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReport.Dock = DockStyle.Fill;
            gridReport.Location = new Point(3, 23);
            gridReport.Name = "gridReport";
            gridReport.ReadOnly = true;
            gridReport.RowHeadersWidth = 51;
            gridReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridReport.Size = new Size(554, 209);
            gridReport.TabIndex = 0;
            gridReport.CellContentClick += gridReport_CellContentClick;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(btnProductSales);
            Controls.Add(btnDailySales);
            Controls.Add(btnLowStock);
            Controls.Add(pnlLeft);
            Controls.Add(lblTitle);
            Controls.Add(pnlTop);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            WindowState = FormWindowState.Maximized;
            Load += InventoryForm_Load;
            pnlLeft.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            crudPanel.ResumeLayout(false);
            splitProducts.Panel1.ResumeLayout(false);
            splitProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitProducts).EndInit();
            splitProducts.ResumeLayout(false);
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
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
        private SplitContainer splitProducts;
    }
}

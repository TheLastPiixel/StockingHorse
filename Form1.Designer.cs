namespace StockControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.InwardsTabPage = new System.Windows.Forms.TabPage();
            this.InwardsSaveButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.InwardsUnitTextBox = new System.Windows.Forms.TextBox();
            this.InwardsAmountTextBox = new System.Windows.Forms.TextBox();
            this.InwardsAmountLabel = new System.Windows.Forms.Label();
            this.InwardsBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.InwardsBarcodeLabel = new System.Windows.Forms.Label();
            this.OutwardsTabPage = new System.Windows.Forms.TabPage();
            this.OutwardsSaveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OutwardsUnitTextBox = new System.Windows.Forms.TextBox();
            this.OutwardsAmountTextBox = new System.Windows.Forms.TextBox();
            this.OutwardsAmountLabel = new System.Windows.Forms.Label();
            this.OutwardsBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.OutwardsBarcodeLabel = new System.Windows.Forms.Label();
            this.SKUTabPage = new System.Windows.Forms.TabPage();
            this.SKUNoticeLabel = new System.Windows.Forms.Label();
            this.SKUSaveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SKUUnitTextBox = new System.Windows.Forms.ComboBox();
            this.SKUUnitLabel = new System.Windows.Forms.Label();
            this.SKUSupplierTextBox = new System.Windows.Forms.ComboBox();
            this.SKUSupplierLabel = new System.Windows.Forms.Label();
            this.SKULocationTextBox = new System.Windows.Forms.ComboBox();
            this.SKUMinimumStockAmountTextBox = new System.Windows.Forms.TextBox();
            this.SKUMinimumStockAmountLabel = new System.Windows.Forms.Label();
            this.SKULocationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SKUItemBrandTextBox = new System.Windows.Forms.TextBox();
            this.SKUItemBrandLabel = new System.Windows.Forms.Label();
            this.SKUDescriptionLabel = new System.Windows.Forms.Label();
            this.SKUDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SKUItemNameLabel = new System.Windows.Forms.Label();
            this.SKUBarcodeLabel = new System.Windows.Forms.Label();
            this.SKUItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SKUBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTabPage = new System.Windows.Forms.TabPage();
            this.StockListTabControl = new System.Windows.Forms.TabControl();
            this.StockListTabPage = new System.Windows.Forms.TabPage();
            this.StockList_Database = new System.Windows.Forms.DataGridView();
            this.Barcode_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimum_Stock_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockListMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LowStockDatabaseTabPage = new System.Windows.Forms.TabPage();
            this.LowStock_Database = new System.Windows.Forms.DataGridView();
            this.LowStock_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowStock_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowStock_ItemBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowStock_StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowStock_MinimumStockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowStock_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliersDatabaseTabPage = new System.Windows.Forms.TabPage();
            this.Suppliers_Database = new System.Windows.Forms.DataGridView();
            this.Suppliers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminTabPage = new System.Windows.Forms.TabPage();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.ReportsTabPage = new System.Windows.Forms.TabPage();
            this.LowStockReport = new System.Windows.Forms.GroupBox();
            this.AdminLowStockReportButton = new System.Windows.Forms.Button();
            this.CurrentStockGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminCurrentStockButton = new System.Windows.Forms.Button();
            this.AdminReportsGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminReportsPanel = new System.Windows.Forms.Panel();
            this.AdminToLabel = new System.Windows.Forms.Label();
            this.AdminInwardsButton = new System.Windows.Forms.Button();
            this.AdminEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AdminReportsInstructionLabel = new System.Windows.Forms.Label();
            this.AdminStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AdminOutwardsButton = new System.Windows.Forms.Button();
            this.AdminFromLabel = new System.Windows.Forms.Label();
            this.SuppliersTabPage = new System.Windows.Forms.TabPage();
            this.DeleteSupplierGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminDeleteSupplierTextBox = new System.Windows.Forms.ComboBox();
            this.AdminDeleteSupplierButton = new System.Windows.Forms.Button();
            this.SuppliersGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminAddressTextBox = new System.Windows.Forms.TextBox();
            this.AdminAddressLabel = new System.Windows.Forms.Label();
            this.AdminAddSupplierButton = new System.Windows.Forms.Button();
            this.AdminEmailTextBox = new System.Windows.Forms.TextBox();
            this.AdminEmailLabel = new System.Windows.Forms.Label();
            this.AdminPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AdminPhoneNumberLabel = new System.Windows.Forms.Label();
            this.AdminNoteLabel = new System.Windows.Forms.Label();
            this.AdminNoteTextBox = new System.Windows.Forms.TextBox();
            this.AdminContactNameLabel = new System.Windows.Forms.Label();
            this.AdminSupplierLabel = new System.Windows.Forms.Label();
            this.AdminContactNameTextBox = new System.Windows.Forms.TextBox();
            this.AdminSupplierTextBox = new System.Windows.Forms.TextBox();
            this.LocationsTabPage = new System.Windows.Forms.TabPage();
            this.AdminLocationsGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminDeleteLocationTextBox = new System.Windows.Forms.ComboBox();
            this.AdminAddLocationTextBox = new System.Windows.Forms.TextBox();
            this.AdminDeleteLocationButton = new System.Windows.Forms.Button();
            this.AdminAddLocationButton = new System.Windows.Forms.Button();
            this.ReconcileTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ReconcileUnitTextBox = new System.Windows.Forms.TextBox();
            this.AdminReconcileButton = new System.Windows.Forms.Button();
            this.ReconcileDescriptionLabel = new System.Windows.Forms.Label();
            this.ReconcileReasonTextBox = new System.Windows.Forms.ComboBox();
            this.ReconcileReasonLabel = new System.Windows.Forms.Label();
            this.ReconcileAmountTextBox = new System.Windows.Forms.TextBox();
            this.ReconcileAmountLabel = new System.Windows.Forms.Label();
            this.ReconcileBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.ReconcileBarcodeLabel = new System.Windows.Forms.Label();
            this.SKUToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl.SuspendLayout();
            this.InwardsTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.OutwardsTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SKUTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DatabaseTabPage.SuspendLayout();
            this.StockListTabControl.SuspendLayout();
            this.StockListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockList_Database)).BeginInit();
            this.StockListMenuStrip.SuspendLayout();
            this.LowStockDatabaseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowStock_Database)).BeginInit();
            this.SuppliersDatabaseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers_Database)).BeginInit();
            this.AdminTabPage.SuspendLayout();
            this.AdminTabControl.SuspendLayout();
            this.ReportsTabPage.SuspendLayout();
            this.LowStockReport.SuspendLayout();
            this.CurrentStockGroupBox.SuspendLayout();
            this.AdminReportsGroupBox.SuspendLayout();
            this.AdminReportsPanel.SuspendLayout();
            this.SuppliersTabPage.SuspendLayout();
            this.DeleteSupplierGroupBox.SuspendLayout();
            this.SuppliersGroupBox.SuspendLayout();
            this.LocationsTabPage.SuspendLayout();
            this.AdminLocationsGroupBox.SuspendLayout();
            this.ReconcileTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.InwardsTabPage);
            this.TabControl.Controls.Add(this.OutwardsTabPage);
            this.TabControl.Controls.Add(this.SKUTabPage);
            this.TabControl.Controls.Add(this.DatabaseTabPage);
            this.TabControl.Controls.Add(this.AdminTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(849, 589);
            this.TabControl.TabIndex = 0;
            // 
            // InwardsTabPage
            // 
            this.InwardsTabPage.Controls.Add(this.InwardsSaveButton);
            this.InwardsTabPage.Controls.Add(this.groupBox4);
            this.InwardsTabPage.Location = new System.Drawing.Point(4, 29);
            this.InwardsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InwardsTabPage.Name = "InwardsTabPage";
            this.InwardsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InwardsTabPage.Size = new System.Drawing.Size(841, 556);
            this.InwardsTabPage.TabIndex = 0;
            this.InwardsTabPage.Text = "Inwards";
            this.InwardsTabPage.UseVisualStyleBackColor = true;
            // 
            // InwardsSaveButton
            // 
            this.InwardsSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InwardsSaveButton.Location = new System.Drawing.Point(334, 369);
            this.InwardsSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InwardsSaveButton.Name = "InwardsSaveButton";
            this.InwardsSaveButton.Size = new System.Drawing.Size(188, 54);
            this.InwardsSaveButton.TabIndex = 1;
            this.InwardsSaveButton.Text = "Stock In";
            this.InwardsSaveButton.UseVisualStyleBackColor = true;
            this.InwardsSaveButton.Click += new System.EventHandler(this.InwardsSaveButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.InwardsUnitTextBox);
            this.groupBox4.Controls.Add(this.InwardsAmountTextBox);
            this.groupBox4.Controls.Add(this.InwardsAmountLabel);
            this.groupBox4.Controls.Add(this.InwardsBarcodeTextBox);
            this.groupBox4.Controls.Add(this.InwardsBarcodeLabel);
            this.groupBox4.Location = new System.Drawing.Point(18, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(813, 123);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // InwardsUnitTextBox
            // 
            this.InwardsUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InwardsUnitTextBox.Location = new System.Drawing.Point(574, 71);
            this.InwardsUnitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InwardsUnitTextBox.Name = "InwardsUnitTextBox";
            this.InwardsUnitTextBox.ReadOnly = true;
            this.InwardsUnitTextBox.Size = new System.Drawing.Size(96, 26);
            this.InwardsUnitTextBox.TabIndex = 4;
            // 
            // InwardsAmountTextBox
            // 
            this.InwardsAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InwardsAmountTextBox.Location = new System.Drawing.Point(260, 71);
            this.InwardsAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InwardsAmountTextBox.Name = "InwardsAmountTextBox";
            this.InwardsAmountTextBox.Size = new System.Drawing.Size(318, 26);
            this.InwardsAmountTextBox.TabIndex = 3;
            this.InwardsAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InwardsAmountTextBox_KeyDown);
            // 
            // InwardsAmountLabel
            // 
            this.InwardsAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InwardsAmountLabel.AutoSize = true;
            this.InwardsAmountLabel.Location = new System.Drawing.Point(134, 75);
            this.InwardsAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InwardsAmountLabel.Name = "InwardsAmountLabel";
            this.InwardsAmountLabel.Size = new System.Drawing.Size(69, 20);
            this.InwardsAmountLabel.TabIndex = 2;
            this.InwardsAmountLabel.Text = "Amount:";
            // 
            // InwardsBarcodeTextBox
            // 
            this.InwardsBarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InwardsBarcodeTextBox.Location = new System.Drawing.Point(260, 31);
            this.InwardsBarcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InwardsBarcodeTextBox.Name = "InwardsBarcodeTextBox";
            this.InwardsBarcodeTextBox.Size = new System.Drawing.Size(410, 26);
            this.InwardsBarcodeTextBox.TabIndex = 1;
            this.InwardsBarcodeTextBox.TextChanged += new System.EventHandler(this.InwardsBarcodeTextBox_TextChanged);
            // 
            // InwardsBarcodeLabel
            // 
            this.InwardsBarcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InwardsBarcodeLabel.AutoSize = true;
            this.InwardsBarcodeLabel.Location = new System.Drawing.Point(134, 31);
            this.InwardsBarcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InwardsBarcodeLabel.Name = "InwardsBarcodeLabel";
            this.InwardsBarcodeLabel.Size = new System.Drawing.Size(73, 20);
            this.InwardsBarcodeLabel.TabIndex = 0;
            this.InwardsBarcodeLabel.Text = "Barcode:";
            // 
            // OutwardsTabPage
            // 
            this.OutwardsTabPage.Controls.Add(this.OutwardsSaveButton);
            this.OutwardsTabPage.Controls.Add(this.groupBox3);
            this.OutwardsTabPage.Location = new System.Drawing.Point(4, 29);
            this.OutwardsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutwardsTabPage.Name = "OutwardsTabPage";
            this.OutwardsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutwardsTabPage.Size = new System.Drawing.Size(841, 556);
            this.OutwardsTabPage.TabIndex = 1;
            this.OutwardsTabPage.Text = "Outwards";
            this.OutwardsTabPage.UseVisualStyleBackColor = true;
            // 
            // OutwardsSaveButton
            // 
            this.OutwardsSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutwardsSaveButton.Location = new System.Drawing.Point(334, 369);
            this.OutwardsSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutwardsSaveButton.Name = "OutwardsSaveButton";
            this.OutwardsSaveButton.Size = new System.Drawing.Size(188, 54);
            this.OutwardsSaveButton.TabIndex = 1;
            this.OutwardsSaveButton.Text = "Take Out";
            this.OutwardsSaveButton.UseVisualStyleBackColor = true;
            this.OutwardsSaveButton.Click += new System.EventHandler(this.OutwardsSaveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.OutwardsUnitTextBox);
            this.groupBox3.Controls.Add(this.OutwardsAmountTextBox);
            this.groupBox3.Controls.Add(this.OutwardsAmountLabel);
            this.groupBox3.Controls.Add(this.OutwardsBarcodeTextBox);
            this.groupBox3.Controls.Add(this.OutwardsBarcodeLabel);
            this.groupBox3.Location = new System.Drawing.Point(18, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(813, 123);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // OutwardsUnitTextBox
            // 
            this.OutwardsUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutwardsUnitTextBox.Location = new System.Drawing.Point(574, 71);
            this.OutwardsUnitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutwardsUnitTextBox.Name = "OutwardsUnitTextBox";
            this.OutwardsUnitTextBox.ReadOnly = true;
            this.OutwardsUnitTextBox.Size = new System.Drawing.Size(96, 26);
            this.OutwardsUnitTextBox.TabIndex = 5;
            // 
            // OutwardsAmountTextBox
            // 
            this.OutwardsAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutwardsAmountTextBox.Location = new System.Drawing.Point(260, 71);
            this.OutwardsAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutwardsAmountTextBox.Name = "OutwardsAmountTextBox";
            this.OutwardsAmountTextBox.Size = new System.Drawing.Size(314, 26);
            this.OutwardsAmountTextBox.TabIndex = 3;
            this.OutwardsAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutwardsAmountTextBox_KeyDown);
            // 
            // OutwardsAmountLabel
            // 
            this.OutwardsAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutwardsAmountLabel.AutoSize = true;
            this.OutwardsAmountLabel.Location = new System.Drawing.Point(134, 75);
            this.OutwardsAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutwardsAmountLabel.Name = "OutwardsAmountLabel";
            this.OutwardsAmountLabel.Size = new System.Drawing.Size(69, 20);
            this.OutwardsAmountLabel.TabIndex = 2;
            this.OutwardsAmountLabel.Text = "Amount:";
            // 
            // OutwardsBarcodeTextBox
            // 
            this.OutwardsBarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutwardsBarcodeTextBox.Location = new System.Drawing.Point(260, 31);
            this.OutwardsBarcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutwardsBarcodeTextBox.Name = "OutwardsBarcodeTextBox";
            this.OutwardsBarcodeTextBox.Size = new System.Drawing.Size(410, 26);
            this.OutwardsBarcodeTextBox.TabIndex = 1;
            this.OutwardsBarcodeTextBox.TextChanged += new System.EventHandler(this.OutwardsBarcodeTextBox_TextChanged);
            // 
            // OutwardsBarcodeLabel
            // 
            this.OutwardsBarcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutwardsBarcodeLabel.AutoSize = true;
            this.OutwardsBarcodeLabel.Location = new System.Drawing.Point(134, 31);
            this.OutwardsBarcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutwardsBarcodeLabel.Name = "OutwardsBarcodeLabel";
            this.OutwardsBarcodeLabel.Size = new System.Drawing.Size(73, 20);
            this.OutwardsBarcodeLabel.TabIndex = 0;
            this.OutwardsBarcodeLabel.Text = "Barcode:";
            // 
            // SKUTabPage
            // 
            this.SKUTabPage.Controls.Add(this.SKUNoticeLabel);
            this.SKUTabPage.Controls.Add(this.SKUSaveButton);
            this.SKUTabPage.Controls.Add(this.groupBox2);
            this.SKUTabPage.Controls.Add(this.groupBox1);
            this.SKUTabPage.Location = new System.Drawing.Point(4, 29);
            this.SKUTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUTabPage.Name = "SKUTabPage";
            this.SKUTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUTabPage.Size = new System.Drawing.Size(841, 556);
            this.SKUTabPage.TabIndex = 2;
            this.SKUTabPage.Text = "SKU";
            this.SKUTabPage.UseVisualStyleBackColor = true;
            // 
            // SKUNoticeLabel
            // 
            this.SKUNoticeLabel.AutoSize = true;
            this.SKUNoticeLabel.Location = new System.Drawing.Point(28, 403);
            this.SKUNoticeLabel.Name = "SKUNoticeLabel";
            this.SKUNoticeLabel.Size = new System.Drawing.Size(0, 20);
            this.SKUNoticeLabel.TabIndex = 3;
            // 
            // SKUSaveButton
            // 
            this.SKUSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SKUSaveButton.Location = new System.Drawing.Point(334, 428);
            this.SKUSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUSaveButton.Name = "SKUSaveButton";
            this.SKUSaveButton.Size = new System.Drawing.Size(188, 54);
            this.SKUSaveButton.TabIndex = 2;
            this.SKUSaveButton.Text = "Save";
            this.SKUSaveButton.UseVisualStyleBackColor = true;
            this.SKUSaveButton.Click += new System.EventHandler(this.SKUSaveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SKUUnitTextBox);
            this.groupBox2.Controls.Add(this.SKUUnitLabel);
            this.groupBox2.Controls.Add(this.SKUSupplierTextBox);
            this.groupBox2.Controls.Add(this.SKUSupplierLabel);
            this.groupBox2.Controls.Add(this.SKULocationTextBox);
            this.groupBox2.Controls.Add(this.SKUMinimumStockAmountTextBox);
            this.groupBox2.Controls.Add(this.SKUMinimumStockAmountLabel);
            this.groupBox2.Controls.Add(this.SKULocationLabel);
            this.groupBox2.Location = new System.Drawing.Point(18, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(813, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // SKUUnitTextBox
            // 
            this.SKUUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUUnitTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SKUUnitTextBox.FormattingEnabled = true;
            this.SKUUnitTextBox.Location = new System.Drawing.Point(492, 108);
            this.SKUUnitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUUnitTextBox.Name = "SKUUnitTextBox";
            this.SKUUnitTextBox.Size = new System.Drawing.Size(178, 28);
            this.SKUUnitTextBox.TabIndex = 7;
            this.SKUToolTip.SetToolTip(this.SKUUnitTextBox, "Leave Blank If There\'s No Unit (ie. Quantity)");
            this.SKUUnitTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SKUUnitTextBox_KeyDown);
            // 
            // SKUUnitLabel
            // 
            this.SKUUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUUnitLabel.AutoSize = true;
            this.SKUUnitLabel.Location = new System.Drawing.Point(446, 112);
            this.SKUUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUUnitLabel.Name = "SKUUnitLabel";
            this.SKUUnitLabel.Size = new System.Drawing.Size(42, 20);
            this.SKUUnitLabel.TabIndex = 8;
            this.SKUUnitLabel.Text = "Unit:";
            // 
            // SKUSupplierTextBox
            // 
            this.SKUSupplierTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUSupplierTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SKUSupplierTextBox.FormattingEnabled = true;
            this.SKUSupplierTextBox.Location = new System.Drawing.Point(260, 66);
            this.SKUSupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUSupplierTextBox.Name = "SKUSupplierTextBox";
            this.SKUSupplierTextBox.Size = new System.Drawing.Size(410, 28);
            this.SKUSupplierTextBox.TabIndex = 5;
            // 
            // SKUSupplierLabel
            // 
            this.SKUSupplierLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUSupplierLabel.AutoSize = true;
            this.SKUSupplierLabel.Location = new System.Drawing.Point(134, 71);
            this.SKUSupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUSupplierLabel.Name = "SKUSupplierLabel";
            this.SKUSupplierLabel.Size = new System.Drawing.Size(71, 20);
            this.SKUSupplierLabel.TabIndex = 6;
            this.SKUSupplierLabel.Text = "Supplier:";
            // 
            // SKULocationTextBox
            // 
            this.SKULocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKULocationTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SKULocationTextBox.FormattingEnabled = true;
            this.SKULocationTextBox.Location = new System.Drawing.Point(260, 25);
            this.SKULocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKULocationTextBox.Name = "SKULocationTextBox";
            this.SKULocationTextBox.Size = new System.Drawing.Size(410, 28);
            this.SKULocationTextBox.TabIndex = 4;
            // 
            // SKUMinimumStockAmountTextBox
            // 
            this.SKUMinimumStockAmountTextBox.AcceptsReturn = true;
            this.SKUMinimumStockAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUMinimumStockAmountTextBox.Location = new System.Drawing.Point(260, 108);
            this.SKUMinimumStockAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUMinimumStockAmountTextBox.Name = "SKUMinimumStockAmountTextBox";
            this.SKUMinimumStockAmountTextBox.Size = new System.Drawing.Size(176, 26);
            this.SKUMinimumStockAmountTextBox.TabIndex = 6;
            this.SKUToolTip.SetToolTip(this.SKUMinimumStockAmountTextBox, "Minimum Stock Amount Before Warning");
            this.SKUMinimumStockAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SKUStockAmountTextBox_KeyDown);
            // 
            // SKUMinimumStockAmountLabel
            // 
            this.SKUMinimumStockAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUMinimumStockAmountLabel.AutoSize = true;
            this.SKUMinimumStockAmountLabel.Location = new System.Drawing.Point(134, 111);
            this.SKUMinimumStockAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUMinimumStockAmountLabel.Name = "SKUMinimumStockAmountLabel";
            this.SKUMinimumStockAmountLabel.Size = new System.Drawing.Size(121, 20);
            this.SKUMinimumStockAmountLabel.TabIndex = 5;
            this.SKUMinimumStockAmountLabel.Text = "Minimum Stock:";
            // 
            // SKULocationLabel
            // 
            this.SKULocationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKULocationLabel.AutoSize = true;
            this.SKULocationLabel.Location = new System.Drawing.Point(134, 29);
            this.SKULocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKULocationLabel.Name = "SKULocationLabel";
            this.SKULocationLabel.Size = new System.Drawing.Size(74, 20);
            this.SKULocationLabel.TabIndex = 3;
            this.SKULocationLabel.Text = "Location:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SKUItemBrandTextBox);
            this.groupBox1.Controls.Add(this.SKUItemBrandLabel);
            this.groupBox1.Controls.Add(this.SKUDescriptionLabel);
            this.groupBox1.Controls.Add(this.SKUDescriptionTextBox);
            this.groupBox1.Controls.Add(this.SKUItemNameLabel);
            this.groupBox1.Controls.Add(this.SKUBarcodeLabel);
            this.groupBox1.Controls.Add(this.SKUItemNameTextBox);
            this.groupBox1.Controls.Add(this.SKUBarcodeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(813, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SKUItemBrandTextBox
            // 
            this.SKUItemBrandTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemBrandTextBox.Location = new System.Drawing.Point(260, 115);
            this.SKUItemBrandTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUItemBrandTextBox.Name = "SKUItemBrandTextBox";
            this.SKUItemBrandTextBox.Size = new System.Drawing.Size(410, 26);
            this.SKUItemBrandTextBox.TabIndex = 2;
            // 
            // SKUItemBrandLabel
            // 
            this.SKUItemBrandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemBrandLabel.AutoSize = true;
            this.SKUItemBrandLabel.Location = new System.Drawing.Point(132, 115);
            this.SKUItemBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUItemBrandLabel.Name = "SKUItemBrandLabel";
            this.SKUItemBrandLabel.Size = new System.Drawing.Size(92, 20);
            this.SKUItemBrandLabel.TabIndex = 6;
            this.SKUItemBrandLabel.Text = "Item Brand:";
            // 
            // SKUDescriptionLabel
            // 
            this.SKUDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUDescriptionLabel.AutoSize = true;
            this.SKUDescriptionLabel.Location = new System.Drawing.Point(134, 155);
            this.SKUDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUDescriptionLabel.Name = "SKUDescriptionLabel";
            this.SKUDescriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.SKUDescriptionLabel.TabIndex = 5;
            this.SKUDescriptionLabel.Text = "Description:";
            // 
            // SKUDescriptionTextBox
            // 
            this.SKUDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUDescriptionTextBox.Location = new System.Drawing.Point(260, 155);
            this.SKUDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUDescriptionTextBox.Multiline = true;
            this.SKUDescriptionTextBox.Name = "SKUDescriptionTextBox";
            this.SKUDescriptionTextBox.Size = new System.Drawing.Size(410, 56);
            this.SKUDescriptionTextBox.TabIndex = 3;
            // 
            // SKUItemNameLabel
            // 
            this.SKUItemNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemNameLabel.AutoSize = true;
            this.SKUItemNameLabel.Location = new System.Drawing.Point(134, 75);
            this.SKUItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUItemNameLabel.Name = "SKUItemNameLabel";
            this.SKUItemNameLabel.Size = new System.Drawing.Size(91, 20);
            this.SKUItemNameLabel.TabIndex = 3;
            this.SKUItemNameLabel.Text = "Item Name:";
            // 
            // SKUBarcodeLabel
            // 
            this.SKUBarcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUBarcodeLabel.AutoSize = true;
            this.SKUBarcodeLabel.Location = new System.Drawing.Point(134, 31);
            this.SKUBarcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUBarcodeLabel.Name = "SKUBarcodeLabel";
            this.SKUBarcodeLabel.Size = new System.Drawing.Size(73, 20);
            this.SKUBarcodeLabel.TabIndex = 2;
            this.SKUBarcodeLabel.Text = "Barcode:";
            // 
            // SKUItemNameTextBox
            // 
            this.SKUItemNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemNameTextBox.Location = new System.Drawing.Point(260, 71);
            this.SKUItemNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUItemNameTextBox.Name = "SKUItemNameTextBox";
            this.SKUItemNameTextBox.Size = new System.Drawing.Size(410, 26);
            this.SKUItemNameTextBox.TabIndex = 1;
            // 
            // SKUBarcodeTextBox
            // 
            this.SKUBarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUBarcodeTextBox.Location = new System.Drawing.Point(260, 31);
            this.SKUBarcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUBarcodeTextBox.Name = "SKUBarcodeTextBox";
            this.SKUBarcodeTextBox.Size = new System.Drawing.Size(410, 26);
            this.SKUBarcodeTextBox.TabIndex = 0;
            // 
            // DatabaseTabPage
            // 
            this.DatabaseTabPage.Controls.Add(this.StockListTabControl);
            this.DatabaseTabPage.Location = new System.Drawing.Point(4, 29);
            this.DatabaseTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatabaseTabPage.Name = "DatabaseTabPage";
            this.DatabaseTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatabaseTabPage.Size = new System.Drawing.Size(841, 556);
            this.DatabaseTabPage.TabIndex = 3;
            this.DatabaseTabPage.Text = "Database";
            this.DatabaseTabPage.UseVisualStyleBackColor = true;
            // 
            // StockListTabControl
            // 
            this.StockListTabControl.Controls.Add(this.StockListTabPage);
            this.StockListTabControl.Controls.Add(this.LowStockDatabaseTabPage);
            this.StockListTabControl.Controls.Add(this.SuppliersDatabaseTabPage);
            this.StockListTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockListTabControl.Location = new System.Drawing.Point(4, 5);
            this.StockListTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StockListTabControl.Name = "StockListTabControl";
            this.StockListTabControl.SelectedIndex = 0;
            this.StockListTabControl.Size = new System.Drawing.Size(833, 546);
            this.StockListTabControl.TabIndex = 1;
            // 
            // StockListTabPage
            // 
            this.StockListTabPage.Controls.Add(this.StockList_Database);
            this.StockListTabPage.Location = new System.Drawing.Point(4, 29);
            this.StockListTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StockListTabPage.Name = "StockListTabPage";
            this.StockListTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StockListTabPage.Size = new System.Drawing.Size(825, 513);
            this.StockListTabPage.TabIndex = 0;
            this.StockListTabPage.Text = "Stock List";
            this.StockListTabPage.UseVisualStyleBackColor = true;
            // 
            // StockList_Database
            // 
            this.StockList_Database.ColumnHeadersHeight = 34;
            this.StockList_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StockList_Database.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode_Column,
            this.Item_Name,
            this.Item_Brand,
            this.Description_Column,
            this.Location_Column,
            this.UnitColumn,
            this.Stock_Amount,
            this.Minimum_Stock_Amount,
            this.Supplier_Column});
            this.StockList_Database.ContextMenuStrip = this.StockListMenuStrip;
            this.StockList_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockList_Database.Location = new System.Drawing.Point(4, 5);
            this.StockList_Database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StockList_Database.Name = "StockList_Database";
            this.StockList_Database.ReadOnly = true;
            this.StockList_Database.RowHeadersWidth = 62;
            this.StockList_Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockList_Database.Size = new System.Drawing.Size(817, 503);
            this.StockList_Database.TabIndex = 0;
            this.StockList_Database.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockList_Database_CellDoubleClick);
            this.StockList_Database.SelectionChanged += new System.EventHandler(this.StockList_Database_SelectionChanged);
            // 
            // Barcode_Column
            // 
            this.Barcode_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode_Column.HeaderText = "Barcode";
            this.Barcode_Column.MinimumWidth = 100;
            this.Barcode_Column.Name = "Barcode_Column";
            this.Barcode_Column.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 50;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Item_Brand
            // 
            this.Item_Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Brand.HeaderText = "Item Brand";
            this.Item_Brand.MinimumWidth = 50;
            this.Item_Brand.Name = "Item_Brand";
            this.Item_Brand.ReadOnly = true;
            // 
            // Description_Column
            // 
            this.Description_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_Column.HeaderText = "Description";
            this.Description_Column.MinimumWidth = 100;
            this.Description_Column.Name = "Description_Column";
            this.Description_Column.ReadOnly = true;
            // 
            // Location_Column
            // 
            this.Location_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location_Column.HeaderText = "Location";
            this.Location_Column.MinimumWidth = 50;
            this.Location_Column.Name = "Location_Column";
            this.Location_Column.ReadOnly = true;
            // 
            // UnitColumn
            // 
            this.UnitColumn.HeaderText = "Unit";
            this.UnitColumn.MinimumWidth = 8;
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            this.UnitColumn.Width = 60;
            // 
            // Stock_Amount
            // 
            this.Stock_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock_Amount.HeaderText = "Stock Amount";
            this.Stock_Amount.MinimumWidth = 40;
            this.Stock_Amount.Name = "Stock_Amount";
            this.Stock_Amount.ReadOnly = true;
            // 
            // Minimum_Stock_Amount
            // 
            this.Minimum_Stock_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Minimum_Stock_Amount.HeaderText = "Minimum Stock Amount";
            this.Minimum_Stock_Amount.MinimumWidth = 40;
            this.Minimum_Stock_Amount.Name = "Minimum_Stock_Amount";
            this.Minimum_Stock_Amount.ReadOnly = true;
            // 
            // Supplier_Column
            // 
            this.Supplier_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier_Column.HeaderText = "Supplier";
            this.Supplier_Column.MinimumWidth = 100;
            this.Supplier_Column.Name = "Supplier_Column";
            this.Supplier_Column.ReadOnly = true;
            // 
            // StockListMenuStrip
            // 
            this.StockListMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StockListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.StockListMenuStrip.Name = "StockListMenuStrip";
            this.StockListMenuStrip.Size = new System.Drawing.Size(152, 36);
            this.StockListMenuStrip.Text = "Leave ";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(151, 32);
            this.editToolStripMenuItem1.Text = "Edit SKU";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // LowStockDatabaseTabPage
            // 
            this.LowStockDatabaseTabPage.Controls.Add(this.LowStock_Database);
            this.LowStockDatabaseTabPage.Location = new System.Drawing.Point(4, 29);
            this.LowStockDatabaseTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LowStockDatabaseTabPage.Name = "LowStockDatabaseTabPage";
            this.LowStockDatabaseTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LowStockDatabaseTabPage.Size = new System.Drawing.Size(825, 513);
            this.LowStockDatabaseTabPage.TabIndex = 1;
            this.LowStockDatabaseTabPage.Text = "Low Stock";
            this.LowStockDatabaseTabPage.UseVisualStyleBackColor = true;
            // 
            // LowStock_Database
            // 
            this.LowStock_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LowStock_Database.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LowStock_Barcode,
            this.LowStock_ItemName,
            this.LowStock_ItemBrand,
            this.Unit_Column,
            this.LowStock_StockAmount,
            this.LowStock_MinimumStockAmount,
            this.LowStock_Supplier});
            this.LowStock_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowStock_Database.Location = new System.Drawing.Point(4, 5);
            this.LowStock_Database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LowStock_Database.Name = "LowStock_Database";
            this.LowStock_Database.ReadOnly = true;
            this.LowStock_Database.RowHeadersWidth = 62;
            this.LowStock_Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LowStock_Database.Size = new System.Drawing.Size(817, 503);
            this.LowStock_Database.TabIndex = 0;
            // 
            // LowStock_Barcode
            // 
            this.LowStock_Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LowStock_Barcode.HeaderText = "Barcode";
            this.LowStock_Barcode.MinimumWidth = 8;
            this.LowStock_Barcode.Name = "LowStock_Barcode";
            this.LowStock_Barcode.ReadOnly = true;
            // 
            // LowStock_ItemName
            // 
            this.LowStock_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LowStock_ItemName.HeaderText = "Item Name";
            this.LowStock_ItemName.MinimumWidth = 8;
            this.LowStock_ItemName.Name = "LowStock_ItemName";
            this.LowStock_ItemName.ReadOnly = true;
            // 
            // LowStock_ItemBrand
            // 
            this.LowStock_ItemBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LowStock_ItemBrand.HeaderText = "Item Brand";
            this.LowStock_ItemBrand.MinimumWidth = 8;
            this.LowStock_ItemBrand.Name = "LowStock_ItemBrand";
            this.LowStock_ItemBrand.ReadOnly = true;
            // 
            // Unit_Column
            // 
            this.Unit_Column.HeaderText = "Unit";
            this.Unit_Column.MinimumWidth = 8;
            this.Unit_Column.Name = "Unit_Column";
            this.Unit_Column.ReadOnly = true;
            this.Unit_Column.Width = 70;
            // 
            // LowStock_StockAmount
            // 
            this.LowStock_StockAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LowStock_StockAmount.HeaderText = "Stock Amount";
            this.LowStock_StockAmount.MinimumWidth = 8;
            this.LowStock_StockAmount.Name = "LowStock_StockAmount";
            this.LowStock_StockAmount.ReadOnly = true;
            // 
            // LowStock_MinimumStockAmount
            // 
            this.LowStock_MinimumStockAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LowStock_MinimumStockAmount.HeaderText = "Minimum Stock Amount";
            this.LowStock_MinimumStockAmount.MinimumWidth = 8;
            this.LowStock_MinimumStockAmount.Name = "LowStock_MinimumStockAmount";
            this.LowStock_MinimumStockAmount.ReadOnly = true;
            // 
            // LowStock_Supplier
            // 
            this.LowStock_Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LowStock_Supplier.HeaderText = "Supplier";
            this.LowStock_Supplier.MinimumWidth = 8;
            this.LowStock_Supplier.Name = "LowStock_Supplier";
            this.LowStock_Supplier.ReadOnly = true;
            // 
            // SuppliersDatabaseTabPage
            // 
            this.SuppliersDatabaseTabPage.Controls.Add(this.Suppliers_Database);
            this.SuppliersDatabaseTabPage.Location = new System.Drawing.Point(4, 29);
            this.SuppliersDatabaseTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersDatabaseTabPage.Name = "SuppliersDatabaseTabPage";
            this.SuppliersDatabaseTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersDatabaseTabPage.Size = new System.Drawing.Size(825, 513);
            this.SuppliersDatabaseTabPage.TabIndex = 2;
            this.SuppliersDatabaseTabPage.Text = "Suppliers";
            this.SuppliersDatabaseTabPage.UseVisualStyleBackColor = true;
            // 
            // Suppliers_Database
            // 
            this.Suppliers_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Suppliers_Database.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Suppliers,
            this.Contact_Name,
            this.Phone_Number,
            this.Email,
            this.Address,
            this.Notes});
            this.Suppliers_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Suppliers_Database.Location = new System.Drawing.Point(4, 5);
            this.Suppliers_Database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Suppliers_Database.Name = "Suppliers_Database";
            this.Suppliers_Database.ReadOnly = true;
            this.Suppliers_Database.RowHeadersWidth = 62;
            this.Suppliers_Database.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Suppliers_Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Suppliers_Database.Size = new System.Drawing.Size(817, 503);
            this.Suppliers_Database.TabIndex = 0;
            // 
            // Suppliers
            // 
            this.Suppliers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Suppliers.HeaderText = "Suppliers";
            this.Suppliers.MinimumWidth = 8;
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.ReadOnly = true;
            // 
            // Contact_Name
            // 
            this.Contact_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contact_Name.HeaderText = "Contact Name";
            this.Contact_Name.MinimumWidth = 8;
            this.Contact_Name.Name = "Contact_Name";
            this.Contact_Name.ReadOnly = true;
            // 
            // Phone_Number
            // 
            this.Phone_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone_Number.HeaderText = "Phone Number";
            this.Phone_Number.MinimumWidth = 8;
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 8;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // AdminTabPage
            // 
            this.AdminTabPage.Controls.Add(this.AdminTabControl);
            this.AdminTabPage.Location = new System.Drawing.Point(4, 29);
            this.AdminTabPage.Name = "AdminTabPage";
            this.AdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTabPage.Size = new System.Drawing.Size(841, 556);
            this.AdminTabPage.TabIndex = 4;
            this.AdminTabPage.Text = "Admin";
            this.AdminTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.ReportsTabPage);
            this.AdminTabControl.Controls.Add(this.SuppliersTabPage);
            this.AdminTabControl.Controls.Add(this.LocationsTabPage);
            this.AdminTabControl.Controls.Add(this.ReconcileTabPage);
            this.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTabControl.Location = new System.Drawing.Point(3, 3);
            this.AdminTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(835, 550);
            this.AdminTabControl.TabIndex = 2;
            // 
            // ReportsTabPage
            // 
            this.ReportsTabPage.Controls.Add(this.LowStockReport);
            this.ReportsTabPage.Controls.Add(this.CurrentStockGroupBox);
            this.ReportsTabPage.Controls.Add(this.AdminReportsGroupBox);
            this.ReportsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ReportsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportsTabPage.Name = "ReportsTabPage";
            this.ReportsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportsTabPage.Size = new System.Drawing.Size(827, 517);
            this.ReportsTabPage.TabIndex = 0;
            this.ReportsTabPage.Text = "Reports";
            this.ReportsTabPage.UseVisualStyleBackColor = true;
            // 
            // LowStockReport
            // 
            this.LowStockReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowStockReport.Controls.Add(this.AdminLowStockReportButton);
            this.LowStockReport.Location = new System.Drawing.Point(6, 285);
            this.LowStockReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LowStockReport.Name = "LowStockReport";
            this.LowStockReport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LowStockReport.Size = new System.Drawing.Size(811, 123);
            this.LowStockReport.TabIndex = 2;
            this.LowStockReport.TabStop = false;
            this.LowStockReport.Text = "Low Stock Report";
            // 
            // AdminLowStockReportButton
            // 
            this.AdminLowStockReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLowStockReportButton.Location = new System.Drawing.Point(329, 45);
            this.AdminLowStockReportButton.Name = "AdminLowStockReportButton";
            this.AdminLowStockReportButton.Size = new System.Drawing.Size(141, 42);
            this.AdminLowStockReportButton.TabIndex = 7;
            this.AdminLowStockReportButton.Text = "Low Stock";
            this.AdminLowStockReportButton.UseVisualStyleBackColor = true;
            this.AdminLowStockReportButton.Click += new System.EventHandler(this.AdminLowStockReportButton_Click);
            // 
            // CurrentStockGroupBox
            // 
            this.CurrentStockGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStockGroupBox.Controls.Add(this.AdminCurrentStockButton);
            this.CurrentStockGroupBox.Location = new System.Drawing.Point(4, 157);
            this.CurrentStockGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentStockGroupBox.Name = "CurrentStockGroupBox";
            this.CurrentStockGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentStockGroupBox.Size = new System.Drawing.Size(811, 123);
            this.CurrentStockGroupBox.TabIndex = 1;
            this.CurrentStockGroupBox.TabStop = false;
            this.CurrentStockGroupBox.Text = "Current Stock Report";
            // 
            // AdminCurrentStockButton
            // 
            this.AdminCurrentStockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCurrentStockButton.Location = new System.Drawing.Point(329, 49);
            this.AdminCurrentStockButton.Name = "AdminCurrentStockButton";
            this.AdminCurrentStockButton.Size = new System.Drawing.Size(141, 42);
            this.AdminCurrentStockButton.TabIndex = 0;
            this.AdminCurrentStockButton.Text = "Current Stock";
            this.AdminCurrentStockButton.UseVisualStyleBackColor = true;
            this.AdminCurrentStockButton.Click += new System.EventHandler(this.AdminCurrentStockButton_Click);
            // 
            // AdminReportsGroupBox
            // 
            this.AdminReportsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminReportsGroupBox.Controls.Add(this.AdminReportsPanel);
            this.AdminReportsGroupBox.Location = new System.Drawing.Point(4, 5);
            this.AdminReportsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminReportsGroupBox.Name = "AdminReportsGroupBox";
            this.AdminReportsGroupBox.Size = new System.Drawing.Size(811, 148);
            this.AdminReportsGroupBox.TabIndex = 0;
            this.AdminReportsGroupBox.TabStop = false;
            this.AdminReportsGroupBox.Text = "Inwards & Outwards Report";
            // 
            // AdminReportsPanel
            // 
            this.AdminReportsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminReportsPanel.Controls.Add(this.AdminToLabel);
            this.AdminReportsPanel.Controls.Add(this.AdminInwardsButton);
            this.AdminReportsPanel.Controls.Add(this.AdminEndDatePicker);
            this.AdminReportsPanel.Controls.Add(this.AdminReportsInstructionLabel);
            this.AdminReportsPanel.Controls.Add(this.AdminStartDatePicker);
            this.AdminReportsPanel.Controls.Add(this.AdminOutwardsButton);
            this.AdminReportsPanel.Controls.Add(this.AdminFromLabel);
            this.AdminReportsPanel.Location = new System.Drawing.Point(4, 20);
            this.AdminReportsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminReportsPanel.Name = "AdminReportsPanel";
            this.AdminReportsPanel.Size = new System.Drawing.Size(799, 126);
            this.AdminReportsPanel.TabIndex = 1;
            // 
            // AdminToLabel
            // 
            this.AdminToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminToLabel.AutoSize = true;
            this.AdminToLabel.Location = new System.Drawing.Point(126, 86);
            this.AdminToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminToLabel.Name = "AdminToLabel";
            this.AdminToLabel.Size = new System.Drawing.Size(31, 20);
            this.AdminToLabel.TabIndex = 6;
            this.AdminToLabel.Text = "To:";
            // 
            // AdminInwardsButton
            // 
            this.AdminInwardsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminInwardsButton.Location = new System.Drawing.Point(368, 57);
            this.AdminInwardsButton.Name = "AdminInwardsButton";
            this.AdminInwardsButton.Size = new System.Drawing.Size(141, 42);
            this.AdminInwardsButton.TabIndex = 2;
            this.AdminInwardsButton.Text = "Inwards";
            this.AdminInwardsButton.UseVisualStyleBackColor = true;
            this.AdminInwardsButton.Click += new System.EventHandler(this.AdminInwardsButton_Click);
            // 
            // AdminEndDatePicker
            // 
            this.AdminEndDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AdminEndDatePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AdminEndDatePicker.Location = new System.Drawing.Point(185, 83);
            this.AdminEndDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminEndDatePicker.Name = "AdminEndDatePicker";
            this.AdminEndDatePicker.Size = new System.Drawing.Size(152, 26);
            this.AdminEndDatePicker.TabIndex = 4;
            // 
            // AdminReportsInstructionLabel
            // 
            this.AdminReportsInstructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminReportsInstructionLabel.AutoSize = true;
            this.AdminReportsInstructionLabel.Location = new System.Drawing.Point(197, 17);
            this.AdminReportsInstructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminReportsInstructionLabel.Name = "AdminReportsInstructionLabel";
            this.AdminReportsInstructionLabel.Size = new System.Drawing.Size(430, 20);
            this.AdminReportsInstructionLabel.TabIndex = 0;
            this.AdminReportsInstructionLabel.Text = "Select date range to generate Inwards and Outwards report";
            // 
            // AdminStartDatePicker
            // 
            this.AdminStartDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AdminStartDatePicker.Location = new System.Drawing.Point(185, 43);
            this.AdminStartDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminStartDatePicker.Name = "AdminStartDatePicker";
            this.AdminStartDatePicker.Size = new System.Drawing.Size(152, 26);
            this.AdminStartDatePicker.TabIndex = 3;
            // 
            // AdminOutwardsButton
            // 
            this.AdminOutwardsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminOutwardsButton.Location = new System.Drawing.Point(533, 57);
            this.AdminOutwardsButton.Name = "AdminOutwardsButton";
            this.AdminOutwardsButton.Size = new System.Drawing.Size(141, 42);
            this.AdminOutwardsButton.TabIndex = 1;
            this.AdminOutwardsButton.Text = "Outwards";
            this.AdminOutwardsButton.UseVisualStyleBackColor = true;
            this.AdminOutwardsButton.Click += new System.EventHandler(this.AdminOutwardsButton_Click);
            // 
            // AdminFromLabel
            // 
            this.AdminFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminFromLabel.AutoSize = true;
            this.AdminFromLabel.Location = new System.Drawing.Point(126, 49);
            this.AdminFromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminFromLabel.Name = "AdminFromLabel";
            this.AdminFromLabel.Size = new System.Drawing.Size(50, 20);
            this.AdminFromLabel.TabIndex = 5;
            this.AdminFromLabel.Text = "From:";
            // 
            // SuppliersTabPage
            // 
            this.SuppliersTabPage.Controls.Add(this.DeleteSupplierGroupBox);
            this.SuppliersTabPage.Controls.Add(this.SuppliersGroupBox);
            this.SuppliersTabPage.Location = new System.Drawing.Point(4, 29);
            this.SuppliersTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTabPage.Name = "SuppliersTabPage";
            this.SuppliersTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTabPage.Size = new System.Drawing.Size(827, 517);
            this.SuppliersTabPage.TabIndex = 1;
            this.SuppliersTabPage.Text = "Suppliers";
            this.SuppliersTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteSupplierGroupBox
            // 
            this.DeleteSupplierGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSupplierGroupBox.Controls.Add(this.AdminDeleteSupplierTextBox);
            this.DeleteSupplierGroupBox.Controls.Add(this.AdminDeleteSupplierButton);
            this.DeleteSupplierGroupBox.Location = new System.Drawing.Point(6, 382);
            this.DeleteSupplierGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteSupplierGroupBox.Name = "DeleteSupplierGroupBox";
            this.DeleteSupplierGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteSupplierGroupBox.Size = new System.Drawing.Size(811, 112);
            this.DeleteSupplierGroupBox.TabIndex = 3;
            this.DeleteSupplierGroupBox.TabStop = false;
            this.DeleteSupplierGroupBox.Text = "Delete Supplier";
            // 
            // AdminDeleteSupplierTextBox
            // 
            this.AdminDeleteSupplierTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminDeleteSupplierTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminDeleteSupplierTextBox.FormattingEnabled = true;
            this.AdminDeleteSupplierTextBox.Location = new System.Drawing.Point(156, 43);
            this.AdminDeleteSupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminDeleteSupplierTextBox.Name = "AdminDeleteSupplierTextBox";
            this.AdminDeleteSupplierTextBox.Size = new System.Drawing.Size(312, 28);
            this.AdminDeleteSupplierTextBox.TabIndex = 10;
            // 
            // AdminDeleteSupplierButton
            // 
            this.AdminDeleteSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminDeleteSupplierButton.Location = new System.Drawing.Point(500, 37);
            this.AdminDeleteSupplierButton.Name = "AdminDeleteSupplierButton";
            this.AdminDeleteSupplierButton.Size = new System.Drawing.Size(141, 42);
            this.AdminDeleteSupplierButton.TabIndex = 8;
            this.AdminDeleteSupplierButton.Text = "Delete Supplier";
            this.AdminDeleteSupplierButton.UseVisualStyleBackColor = true;
            this.AdminDeleteSupplierButton.Click += new System.EventHandler(this.AdminDeleteSupplierButton_Click);
            // 
            // SuppliersGroupBox
            // 
            this.SuppliersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuppliersGroupBox.Controls.Add(this.AdminAddressTextBox);
            this.SuppliersGroupBox.Controls.Add(this.AdminAddressLabel);
            this.SuppliersGroupBox.Controls.Add(this.AdminAddSupplierButton);
            this.SuppliersGroupBox.Controls.Add(this.AdminEmailTextBox);
            this.SuppliersGroupBox.Controls.Add(this.AdminEmailLabel);
            this.SuppliersGroupBox.Controls.Add(this.AdminPhoneNumberTextBox);
            this.SuppliersGroupBox.Controls.Add(this.AdminPhoneNumberLabel);
            this.SuppliersGroupBox.Controls.Add(this.AdminNoteLabel);
            this.SuppliersGroupBox.Controls.Add(this.AdminNoteTextBox);
            this.SuppliersGroupBox.Controls.Add(this.AdminContactNameLabel);
            this.SuppliersGroupBox.Controls.Add(this.AdminSupplierLabel);
            this.SuppliersGroupBox.Controls.Add(this.AdminContactNameTextBox);
            this.SuppliersGroupBox.Controls.Add(this.AdminSupplierTextBox);
            this.SuppliersGroupBox.Location = new System.Drawing.Point(6, 3);
            this.SuppliersGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersGroupBox.Name = "SuppliersGroupBox";
            this.SuppliersGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersGroupBox.Size = new System.Drawing.Size(811, 369);
            this.SuppliersGroupBox.TabIndex = 2;
            this.SuppliersGroupBox.TabStop = false;
            this.SuppliersGroupBox.Text = "Add Supplier";
            // 
            // AdminAddressTextBox
            // 
            this.AdminAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAddressTextBox.Location = new System.Drawing.Point(263, 189);
            this.AdminAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminAddressTextBox.Name = "AdminAddressTextBox";
            this.AdminAddressTextBox.Size = new System.Drawing.Size(410, 26);
            this.AdminAddressTextBox.TabIndex = 5;
            // 
            // AdminAddressLabel
            // 
            this.AdminAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAddressLabel.AutoSize = true;
            this.AdminAddressLabel.Location = new System.Drawing.Point(137, 195);
            this.AdminAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminAddressLabel.Name = "AdminAddressLabel";
            this.AdminAddressLabel.Size = new System.Drawing.Size(72, 20);
            this.AdminAddressLabel.TabIndex = 18;
            this.AdminAddressLabel.Text = "Address:";
            // 
            // AdminAddSupplierButton
            // 
            this.AdminAddSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAddSupplierButton.Location = new System.Drawing.Point(335, 306);
            this.AdminAddSupplierButton.Name = "AdminAddSupplierButton";
            this.AdminAddSupplierButton.Size = new System.Drawing.Size(141, 42);
            this.AdminAddSupplierButton.TabIndex = 7;
            this.AdminAddSupplierButton.Text = "Add Supplier";
            this.AdminAddSupplierButton.UseVisualStyleBackColor = true;
            this.AdminAddSupplierButton.Click += new System.EventHandler(this.AdminAddSupplierButton_Click);
            // 
            // AdminEmailTextBox
            // 
            this.AdminEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminEmailTextBox.Location = new System.Drawing.Point(263, 149);
            this.AdminEmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminEmailTextBox.Name = "AdminEmailTextBox";
            this.AdminEmailTextBox.Size = new System.Drawing.Size(410, 26);
            this.AdminEmailTextBox.TabIndex = 4;
            // 
            // AdminEmailLabel
            // 
            this.AdminEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminEmailLabel.AutoSize = true;
            this.AdminEmailLabel.Location = new System.Drawing.Point(137, 155);
            this.AdminEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminEmailLabel.Name = "AdminEmailLabel";
            this.AdminEmailLabel.Size = new System.Drawing.Size(52, 20);
            this.AdminEmailLabel.TabIndex = 16;
            this.AdminEmailLabel.Text = "Email:";
            // 
            // AdminPhoneNumberTextBox
            // 
            this.AdminPhoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminPhoneNumberTextBox.Location = new System.Drawing.Point(263, 109);
            this.AdminPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminPhoneNumberTextBox.Name = "AdminPhoneNumberTextBox";
            this.AdminPhoneNumberTextBox.Size = new System.Drawing.Size(410, 26);
            this.AdminPhoneNumberTextBox.TabIndex = 3;
            // 
            // AdminPhoneNumberLabel
            // 
            this.AdminPhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminPhoneNumberLabel.AutoSize = true;
            this.AdminPhoneNumberLabel.Location = new System.Drawing.Point(137, 115);
            this.AdminPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminPhoneNumberLabel.Name = "AdminPhoneNumberLabel";
            this.AdminPhoneNumberLabel.Size = new System.Drawing.Size(119, 20);
            this.AdminPhoneNumberLabel.TabIndex = 14;
            this.AdminPhoneNumberLabel.Text = "Phone Number:";
            // 
            // AdminNoteLabel
            // 
            this.AdminNoteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminNoteLabel.AutoSize = true;
            this.AdminNoteLabel.Location = new System.Drawing.Point(137, 234);
            this.AdminNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminNoteLabel.Name = "AdminNoteLabel";
            this.AdminNoteLabel.Size = new System.Drawing.Size(55, 20);
            this.AdminNoteLabel.TabIndex = 13;
            this.AdminNoteLabel.Text = "Notes:";
            // 
            // AdminNoteTextBox
            // 
            this.AdminNoteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminNoteTextBox.Location = new System.Drawing.Point(263, 229);
            this.AdminNoteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminNoteTextBox.Multiline = true;
            this.AdminNoteTextBox.Name = "AdminNoteTextBox";
            this.AdminNoteTextBox.Size = new System.Drawing.Size(410, 56);
            this.AdminNoteTextBox.TabIndex = 6;
            // 
            // AdminContactNameLabel
            // 
            this.AdminContactNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminContactNameLabel.AutoSize = true;
            this.AdminContactNameLabel.Location = new System.Drawing.Point(137, 69);
            this.AdminContactNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminContactNameLabel.Name = "AdminContactNameLabel";
            this.AdminContactNameLabel.Size = new System.Drawing.Size(115, 20);
            this.AdminContactNameLabel.TabIndex = 12;
            this.AdminContactNameLabel.Text = "Contact Name:";
            // 
            // AdminSupplierLabel
            // 
            this.AdminSupplierLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminSupplierLabel.AutoSize = true;
            this.AdminSupplierLabel.Location = new System.Drawing.Point(137, 31);
            this.AdminSupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminSupplierLabel.Name = "AdminSupplierLabel";
            this.AdminSupplierLabel.Size = new System.Drawing.Size(71, 20);
            this.AdminSupplierLabel.TabIndex = 10;
            this.AdminSupplierLabel.Text = "Supplier:";
            // 
            // AdminContactNameTextBox
            // 
            this.AdminContactNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminContactNameTextBox.Location = new System.Drawing.Point(263, 65);
            this.AdminContactNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminContactNameTextBox.Name = "AdminContactNameTextBox";
            this.AdminContactNameTextBox.Size = new System.Drawing.Size(410, 26);
            this.AdminContactNameTextBox.TabIndex = 2;
            // 
            // AdminSupplierTextBox
            // 
            this.AdminSupplierTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminSupplierTextBox.Location = new System.Drawing.Point(263, 25);
            this.AdminSupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSupplierTextBox.Name = "AdminSupplierTextBox";
            this.AdminSupplierTextBox.Size = new System.Drawing.Size(410, 26);
            this.AdminSupplierTextBox.TabIndex = 1;
            // 
            // LocationsTabPage
            // 
            this.LocationsTabPage.Controls.Add(this.AdminLocationsGroupBox);
            this.LocationsTabPage.Location = new System.Drawing.Point(4, 29);
            this.LocationsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocationsTabPage.Name = "LocationsTabPage";
            this.LocationsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocationsTabPage.Size = new System.Drawing.Size(827, 517);
            this.LocationsTabPage.TabIndex = 2;
            this.LocationsTabPage.Text = "Locations";
            this.LocationsTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminLocationsGroupBox
            // 
            this.AdminLocationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminLocationsGroupBox.Controls.Add(this.AdminDeleteLocationTextBox);
            this.AdminLocationsGroupBox.Controls.Add(this.AdminAddLocationTextBox);
            this.AdminLocationsGroupBox.Controls.Add(this.AdminDeleteLocationButton);
            this.AdminLocationsGroupBox.Controls.Add(this.AdminAddLocationButton);
            this.AdminLocationsGroupBox.Location = new System.Drawing.Point(6, 9);
            this.AdminLocationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminLocationsGroupBox.Name = "AdminLocationsGroupBox";
            this.AdminLocationsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminLocationsGroupBox.Size = new System.Drawing.Size(811, 154);
            this.AdminLocationsGroupBox.TabIndex = 1;
            this.AdminLocationsGroupBox.TabStop = false;
            this.AdminLocationsGroupBox.Text = "Locations";
            // 
            // AdminDeleteLocationTextBox
            // 
            this.AdminDeleteLocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminDeleteLocationTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminDeleteLocationTextBox.FormattingEnabled = true;
            this.AdminDeleteLocationTextBox.Location = new System.Drawing.Point(156, 95);
            this.AdminDeleteLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminDeleteLocationTextBox.Name = "AdminDeleteLocationTextBox";
            this.AdminDeleteLocationTextBox.Size = new System.Drawing.Size(312, 28);
            this.AdminDeleteLocationTextBox.TabIndex = 10;
            this.AdminDeleteLocationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminDeleteLocationTextBox_KeyDown);
            // 
            // AdminAddLocationTextBox
            // 
            this.AdminAddLocationTextBox.AcceptsReturn = true;
            this.AdminAddLocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAddLocationTextBox.Location = new System.Drawing.Point(156, 34);
            this.AdminAddLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminAddLocationTextBox.Name = "AdminAddLocationTextBox";
            this.AdminAddLocationTextBox.Size = new System.Drawing.Size(312, 26);
            this.AdminAddLocationTextBox.TabIndex = 9;
            this.AdminAddLocationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminAddLocationTextBox_KeyDown);
            // 
            // AdminDeleteLocationButton
            // 
            this.AdminDeleteLocationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminDeleteLocationButton.Location = new System.Drawing.Point(500, 89);
            this.AdminDeleteLocationButton.Name = "AdminDeleteLocationButton";
            this.AdminDeleteLocationButton.Size = new System.Drawing.Size(141, 42);
            this.AdminDeleteLocationButton.TabIndex = 8;
            this.AdminDeleteLocationButton.Text = "Delete Location";
            this.AdminDeleteLocationButton.UseVisualStyleBackColor = true;
            this.AdminDeleteLocationButton.Click += new System.EventHandler(this.AdminDeleteLocationButton_Click);
            // 
            // AdminAddLocationButton
            // 
            this.AdminAddLocationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAddLocationButton.Location = new System.Drawing.Point(500, 28);
            this.AdminAddLocationButton.Name = "AdminAddLocationButton";
            this.AdminAddLocationButton.Size = new System.Drawing.Size(141, 42);
            this.AdminAddLocationButton.TabIndex = 7;
            this.AdminAddLocationButton.Text = "Add Location";
            this.AdminAddLocationButton.UseVisualStyleBackColor = true;
            this.AdminAddLocationButton.Click += new System.EventHandler(this.AdminAddLocationButton_Click);
            // 
            // ReconcileTabPage
            // 
            this.ReconcileTabPage.Controls.Add(this.groupBox5);
            this.ReconcileTabPage.Location = new System.Drawing.Point(4, 29);
            this.ReconcileTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReconcileTabPage.Name = "ReconcileTabPage";
            this.ReconcileTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReconcileTabPage.Size = new System.Drawing.Size(827, 517);
            this.ReconcileTabPage.TabIndex = 3;
            this.ReconcileTabPage.Text = "Reconcile";
            this.ReconcileTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ReconcileUnitTextBox);
            this.groupBox5.Controls.Add(this.AdminReconcileButton);
            this.groupBox5.Controls.Add(this.ReconcileDescriptionLabel);
            this.groupBox5.Controls.Add(this.ReconcileReasonTextBox);
            this.groupBox5.Controls.Add(this.ReconcileReasonLabel);
            this.groupBox5.Controls.Add(this.ReconcileAmountTextBox);
            this.groupBox5.Controls.Add(this.ReconcileAmountLabel);
            this.groupBox5.Controls.Add(this.ReconcileBarcodeTextBox);
            this.groupBox5.Controls.Add(this.ReconcileBarcodeLabel);
            this.groupBox5.Location = new System.Drawing.Point(8, -3);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(811, 283);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // ReconcileUnitTextBox
            // 
            this.ReconcileUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileUnitTextBox.Location = new System.Drawing.Point(575, 94);
            this.ReconcileUnitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReconcileUnitTextBox.Name = "ReconcileUnitTextBox";
            this.ReconcileUnitTextBox.ReadOnly = true;
            this.ReconcileUnitTextBox.Size = new System.Drawing.Size(96, 26);
            this.ReconcileUnitTextBox.TabIndex = 9;
            // 
            // AdminReconcileButton
            // 
            this.AdminReconcileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminReconcileButton.Location = new System.Drawing.Point(335, 205);
            this.AdminReconcileButton.Name = "AdminReconcileButton";
            this.AdminReconcileButton.Size = new System.Drawing.Size(141, 42);
            this.AdminReconcileButton.TabIndex = 8;
            this.AdminReconcileButton.Text = "Reconcile Item";
            this.AdminReconcileButton.UseVisualStyleBackColor = true;
            this.AdminReconcileButton.Click += new System.EventHandler(this.AdminReconcileButton_Click);
            // 
            // ReconcileDescriptionLabel
            // 
            this.ReconcileDescriptionLabel.AutoSize = true;
            this.ReconcileDescriptionLabel.Location = new System.Drawing.Point(201, 23);
            this.ReconcileDescriptionLabel.Name = "ReconcileDescriptionLabel";
            this.ReconcileDescriptionLabel.Size = new System.Drawing.Size(464, 20);
            this.ReconcileDescriptionLabel.TabIndex = 7;
            this.ReconcileDescriptionLabel.Text = "Reconcile allows you to remove stock that is damaged or missing";
            // 
            // ReconcileReasonTextBox
            // 
            this.ReconcileReasonTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileReasonTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReconcileReasonTextBox.FormattingEnabled = true;
            this.ReconcileReasonTextBox.Location = new System.Drawing.Point(258, 135);
            this.ReconcileReasonTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReconcileReasonTextBox.Name = "ReconcileReasonTextBox";
            this.ReconcileReasonTextBox.Size = new System.Drawing.Size(410, 28);
            this.ReconcileReasonTextBox.TabIndex = 6;
            this.ReconcileReasonTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReconcileReasonTextBox_KeyDown);
            // 
            // ReconcileReasonLabel
            // 
            this.ReconcileReasonLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileReasonLabel.AutoSize = true;
            this.ReconcileReasonLabel.Location = new System.Drawing.Point(132, 140);
            this.ReconcileReasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReconcileReasonLabel.Name = "ReconcileReasonLabel";
            this.ReconcileReasonLabel.Size = new System.Drawing.Size(69, 20);
            this.ReconcileReasonLabel.TabIndex = 5;
            this.ReconcileReasonLabel.Text = "Reason:";
            // 
            // ReconcileAmountTextBox
            // 
            this.ReconcileAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileAmountTextBox.Location = new System.Drawing.Point(258, 94);
            this.ReconcileAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReconcileAmountTextBox.Name = "ReconcileAmountTextBox";
            this.ReconcileAmountTextBox.Size = new System.Drawing.Size(316, 26);
            this.ReconcileAmountTextBox.TabIndex = 3;
            // 
            // ReconcileAmountLabel
            // 
            this.ReconcileAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileAmountLabel.AutoSize = true;
            this.ReconcileAmountLabel.Location = new System.Drawing.Point(132, 98);
            this.ReconcileAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReconcileAmountLabel.Name = "ReconcileAmountLabel";
            this.ReconcileAmountLabel.Size = new System.Drawing.Size(69, 20);
            this.ReconcileAmountLabel.TabIndex = 2;
            this.ReconcileAmountLabel.Text = "Amount:";
            // 
            // ReconcileBarcodeTextBox
            // 
            this.ReconcileBarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileBarcodeTextBox.Location = new System.Drawing.Point(258, 54);
            this.ReconcileBarcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReconcileBarcodeTextBox.Name = "ReconcileBarcodeTextBox";
            this.ReconcileBarcodeTextBox.Size = new System.Drawing.Size(410, 26);
            this.ReconcileBarcodeTextBox.TabIndex = 1;
            this.ReconcileBarcodeTextBox.TextChanged += new System.EventHandler(this.ReconcileBarcodeTextBox_TextChanged);
            // 
            // ReconcileBarcodeLabel
            // 
            this.ReconcileBarcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReconcileBarcodeLabel.AutoSize = true;
            this.ReconcileBarcodeLabel.Location = new System.Drawing.Point(132, 57);
            this.ReconcileBarcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReconcileBarcodeLabel.Name = "ReconcileBarcodeLabel";
            this.ReconcileBarcodeLabel.Size = new System.Drawing.Size(73, 20);
            this.ReconcileBarcodeLabel.TabIndex = 0;
            this.ReconcileBarcodeLabel.Text = "Barcode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 589);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Stocking Horse";
            this.TabControl.ResumeLayout(false);
            this.InwardsTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.OutwardsTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.SKUTabPage.ResumeLayout(false);
            this.SKUTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DatabaseTabPage.ResumeLayout(false);
            this.StockListTabControl.ResumeLayout(false);
            this.StockListTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockList_Database)).EndInit();
            this.StockListMenuStrip.ResumeLayout(false);
            this.LowStockDatabaseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LowStock_Database)).EndInit();
            this.SuppliersDatabaseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers_Database)).EndInit();
            this.AdminTabPage.ResumeLayout(false);
            this.AdminTabControl.ResumeLayout(false);
            this.ReportsTabPage.ResumeLayout(false);
            this.LowStockReport.ResumeLayout(false);
            this.CurrentStockGroupBox.ResumeLayout(false);
            this.AdminReportsGroupBox.ResumeLayout(false);
            this.AdminReportsPanel.ResumeLayout(false);
            this.AdminReportsPanel.PerformLayout();
            this.SuppliersTabPage.ResumeLayout(false);
            this.DeleteSupplierGroupBox.ResumeLayout(false);
            this.SuppliersGroupBox.ResumeLayout(false);
            this.SuppliersGroupBox.PerformLayout();
            this.LocationsTabPage.ResumeLayout(false);
            this.AdminLocationsGroupBox.ResumeLayout(false);
            this.AdminLocationsGroupBox.PerformLayout();
            this.ReconcileTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage InwardsTabPage;
        private System.Windows.Forms.TabPage OutwardsTabPage;
        private System.Windows.Forms.TabPage SKUTabPage;
        private System.Windows.Forms.TabPage DatabaseTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SKUBarcodeTextBox;
        private System.Windows.Forms.Label SKUBarcodeLabel;
        private System.Windows.Forms.TextBox SKUItemNameTextBox;
        private System.Windows.Forms.Label SKUItemNameLabel;
        private System.Windows.Forms.Label SKUDescriptionLabel;
        private System.Windows.Forms.TextBox SKUDescriptionTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SKULocationLabel;
        private System.Windows.Forms.Button SKUSaveButton;
        private System.Windows.Forms.Label SKUMinimumStockAmountLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label OutwardsBarcodeLabel;
        private System.Windows.Forms.Button OutwardsSaveButton;
        private System.Windows.Forms.TextBox OutwardsAmountTextBox;
        private System.Windows.Forms.Label OutwardsAmountLabel;
        private System.Windows.Forms.TextBox OutwardsBarcodeTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label InwardsBarcodeLabel;
        private System.Windows.Forms.TextBox InwardsAmountTextBox;
        private System.Windows.Forms.Label InwardsAmountLabel;
        private System.Windows.Forms.TextBox InwardsBarcodeTextBox;
        private System.Windows.Forms.Button InwardsSaveButton;
        private System.Windows.Forms.Label SKUItemBrandLabel;
        private System.Windows.Forms.TextBox SKUItemBrandTextBox;
        private System.Windows.Forms.Label SKUNoticeLabel;
        private System.Windows.Forms.TextBox SKUMinimumStockAmountTextBox;
        private System.Windows.Forms.DataGridView StockList_Database;
        private System.Windows.Forms.ComboBox SKULocationTextBox;
        private System.Windows.Forms.TabPage AdminTabPage;
        private System.Windows.Forms.GroupBox AdminReportsGroupBox;
        private System.Windows.Forms.Button AdminCurrentStockButton;
        private System.Windows.Forms.DateTimePicker AdminStartDatePicker;
        private System.Windows.Forms.Button AdminOutwardsButton;
        private System.Windows.Forms.Button AdminInwardsButton;
        private System.Windows.Forms.DateTimePicker AdminEndDatePicker;
        private System.Windows.Forms.Label AdminToLabel;
        private System.Windows.Forms.Label AdminReportsInstructionLabel;
        private System.Windows.Forms.Label AdminFromLabel;
        private System.Windows.Forms.Panel AdminReportsPanel;
        private System.Windows.Forms.GroupBox AdminLocationsGroupBox;
        private System.Windows.Forms.Button AdminDeleteLocationButton;
        private System.Windows.Forms.Button AdminAddLocationButton;
        private System.Windows.Forms.TextBox AdminAddLocationTextBox;
        private System.Windows.Forms.ComboBox AdminDeleteLocationTextBox;
        private System.Windows.Forms.TabControl StockListTabControl;
        private System.Windows.Forms.TabPage StockListTabPage;
        private System.Windows.Forms.TabPage LowStockDatabaseTabPage;
        private System.Windows.Forms.DataGridView LowStock_Database;
        private System.Windows.Forms.Button AdminLowStockReportButton;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage ReportsTabPage;
        private System.Windows.Forms.TabPage SuppliersTabPage;
        private System.Windows.Forms.TabPage LocationsTabPage;
        private System.Windows.Forms.Button AdminAddSupplierButton;
        private System.Windows.Forms.GroupBox SuppliersGroupBox;
        private System.Windows.Forms.TextBox AdminPhoneNumberTextBox;
        private System.Windows.Forms.Label AdminPhoneNumberLabel;
        private System.Windows.Forms.Label AdminNoteLabel;
        private System.Windows.Forms.TextBox AdminNoteTextBox;
        private System.Windows.Forms.Label AdminContactNameLabel;
        private System.Windows.Forms.Label AdminSupplierLabel;
        private System.Windows.Forms.TextBox AdminContactNameTextBox;
        private System.Windows.Forms.TextBox AdminSupplierTextBox;
        private System.Windows.Forms.TextBox AdminAddressTextBox;
        private System.Windows.Forms.Label AdminAddressLabel;
        private System.Windows.Forms.TextBox AdminEmailTextBox;
        private System.Windows.Forms.Label AdminEmailLabel;
        private System.Windows.Forms.GroupBox DeleteSupplierGroupBox;
        private System.Windows.Forms.ComboBox AdminDeleteSupplierTextBox;
        private System.Windows.Forms.Button AdminDeleteSupplierButton;
        private System.Windows.Forms.GroupBox LowStockReport;
        private System.Windows.Forms.GroupBox CurrentStockGroupBox;
        private System.Windows.Forms.ComboBox SKUSupplierTextBox;
        private System.Windows.Forms.Label SKUSupplierLabel;
        private System.Windows.Forms.TabPage SuppliersDatabaseTabPage;
        private System.Windows.Forms.DataGridView Suppliers_Database;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.ContextMenuStrip StockListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.TabPage ReconcileTabPage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox ReconcileAmountTextBox;
        private System.Windows.Forms.Label ReconcileAmountLabel;
        private System.Windows.Forms.TextBox ReconcileBarcodeTextBox;
        private System.Windows.Forms.Label ReconcileBarcodeLabel;
        private System.Windows.Forms.ComboBox ReconcileReasonTextBox;
        private System.Windows.Forms.Label ReconcileReasonLabel;
        private System.Windows.Forms.Label ReconcileDescriptionLabel;
        private System.Windows.Forms.Button AdminReconcileButton;
        private System.Windows.Forms.ComboBox SKUUnitTextBox;
        private System.Windows.Forms.Label SKUUnitLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimum_Stock_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStock_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStock_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStock_ItemBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStock_StockAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStock_MinimumStockAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowStock_Supplier;
        private System.Windows.Forms.TextBox InwardsUnitTextBox;
        private System.Windows.Forms.TextBox OutwardsUnitTextBox;
        private System.Windows.Forms.TextBox ReconcileUnitTextBox;
        private System.Windows.Forms.ToolTip SKUToolTip;
    }
}


namespace StockControl
{
    partial class EditSKUForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSKUForm));
            this.SKUNoticeLabel = new System.Windows.Forms.Label();
            this.SKUSaveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SKUUnitTextBox = new System.Windows.Forms.TextBox();
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
            this.BarcodeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SKUNoticeLabel
            // 
            this.SKUNoticeLabel.AutoSize = true;
            this.SKUNoticeLabel.Location = new System.Drawing.Point(28, 403);
            this.SKUNoticeLabel.Name = "SKUNoticeLabel";
            this.SKUNoticeLabel.Size = new System.Drawing.Size(0, 20);
            this.SKUNoticeLabel.TabIndex = 7;
            // 
            // SKUSaveButton
            // 
            this.SKUSaveButton.Location = new System.Drawing.Point(249, 428);
            this.SKUSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUSaveButton.Name = "SKUSaveButton";
            this.SKUSaveButton.Size = new System.Drawing.Size(136, 54);
            this.SKUSaveButton.TabIndex = 10;
            this.SKUSaveButton.Text = "Save";
            this.SKUSaveButton.UseVisualStyleBackColor = true;
            this.SKUSaveButton.Click += new System.EventHandler(this.SKUSaveButton_Click);
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(591, 171);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // SKUUnitTextBox
            // 
            this.SKUUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUUnitTextBox.BackColor = System.Drawing.Color.Silver;
            this.SKUUnitTextBox.Location = new System.Drawing.Point(387, 108);
            this.SKUUnitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUUnitTextBox.Name = "SKUUnitTextBox";
            this.SKUUnitTextBox.ReadOnly = true;
            this.SKUUnitTextBox.Size = new System.Drawing.Size(172, 26);
            this.SKUUnitTextBox.TabIndex = 11;
            // 
            // SKUUnitLabel
            // 
            this.SKUUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUUnitLabel.AutoSize = true;
            this.SKUUnitLabel.Location = new System.Drawing.Point(334, 111);
            this.SKUUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUUnitLabel.Name = "SKUUnitLabel";
            this.SKUUnitLabel.Size = new System.Drawing.Size(42, 20);
            this.SKUUnitLabel.TabIndex = 10;
            this.SKUUnitLabel.Text = "Unit:";
            // 
            // SKUSupplierTextBox
            // 
            this.SKUSupplierTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUSupplierTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SKUSupplierTextBox.FormattingEnabled = true;
            this.SKUSupplierTextBox.Location = new System.Drawing.Point(148, 66);
            this.SKUSupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUSupplierTextBox.Name = "SKUSupplierTextBox";
            this.SKUSupplierTextBox.Size = new System.Drawing.Size(410, 28);
            this.SKUSupplierTextBox.TabIndex = 5;
            // 
            // SKUSupplierLabel
            // 
            this.SKUSupplierLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUSupplierLabel.AutoSize = true;
            this.SKUSupplierLabel.Location = new System.Drawing.Point(22, 71);
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
            this.SKULocationTextBox.Location = new System.Drawing.Point(148, 25);
            this.SKULocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKULocationTextBox.Name = "SKULocationTextBox";
            this.SKULocationTextBox.Size = new System.Drawing.Size(410, 28);
            this.SKULocationTextBox.TabIndex = 4;
            // 
            // SKUMinimumStockAmountTextBox
            // 
            this.SKUMinimumStockAmountTextBox.AcceptsReturn = true;
            this.SKUMinimumStockAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUMinimumStockAmountTextBox.Location = new System.Drawing.Point(148, 108);
            this.SKUMinimumStockAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUMinimumStockAmountTextBox.Name = "SKUMinimumStockAmountTextBox";
            this.SKUMinimumStockAmountTextBox.Size = new System.Drawing.Size(175, 26);
            this.SKUMinimumStockAmountTextBox.TabIndex = 6;
            // 
            // SKUMinimumStockAmountLabel
            // 
            this.SKUMinimumStockAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUMinimumStockAmountLabel.AutoSize = true;
            this.SKUMinimumStockAmountLabel.Location = new System.Drawing.Point(22, 114);
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
            this.SKULocationLabel.Location = new System.Drawing.Point(22, 29);
            this.SKULocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKULocationLabel.Name = "SKULocationLabel";
            this.SKULocationLabel.Size = new System.Drawing.Size(74, 20);
            this.SKULocationLabel.TabIndex = 3;
            this.SKULocationLabel.Text = "Location:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(591, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // SKUItemBrandTextBox
            // 
            this.SKUItemBrandTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemBrandTextBox.Location = new System.Drawing.Point(148, 115);
            this.SKUItemBrandTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUItemBrandTextBox.Name = "SKUItemBrandTextBox";
            this.SKUItemBrandTextBox.Size = new System.Drawing.Size(410, 26);
            this.SKUItemBrandTextBox.TabIndex = 2;
            // 
            // SKUItemBrandLabel
            // 
            this.SKUItemBrandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemBrandLabel.AutoSize = true;
            this.SKUItemBrandLabel.Location = new System.Drawing.Point(21, 115);
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
            this.SKUDescriptionLabel.Location = new System.Drawing.Point(22, 155);
            this.SKUDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUDescriptionLabel.Name = "SKUDescriptionLabel";
            this.SKUDescriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.SKUDescriptionLabel.TabIndex = 5;
            this.SKUDescriptionLabel.Text = "Description:";
            // 
            // SKUDescriptionTextBox
            // 
            this.SKUDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUDescriptionTextBox.Location = new System.Drawing.Point(148, 155);
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
            this.SKUItemNameLabel.Location = new System.Drawing.Point(22, 75);
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
            this.SKUBarcodeLabel.Location = new System.Drawing.Point(22, 31);
            this.SKUBarcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SKUBarcodeLabel.Name = "SKUBarcodeLabel";
            this.SKUBarcodeLabel.Size = new System.Drawing.Size(73, 20);
            this.SKUBarcodeLabel.TabIndex = 2;
            this.SKUBarcodeLabel.Text = "Barcode:";
            // 
            // SKUItemNameTextBox
            // 
            this.SKUItemNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUItemNameTextBox.Location = new System.Drawing.Point(148, 71);
            this.SKUItemNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUItemNameTextBox.Name = "SKUItemNameTextBox";
            this.SKUItemNameTextBox.Size = new System.Drawing.Size(410, 26);
            this.SKUItemNameTextBox.TabIndex = 1;
            // 
            // SKUBarcodeTextBox
            // 
            this.SKUBarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SKUBarcodeTextBox.BackColor = System.Drawing.Color.Silver;
            this.SKUBarcodeTextBox.Location = new System.Drawing.Point(148, 31);
            this.SKUBarcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SKUBarcodeTextBox.Name = "SKUBarcodeTextBox";
            this.SKUBarcodeTextBox.ReadOnly = true;
            this.SKUBarcodeTextBox.Size = new System.Drawing.Size(410, 26);
            this.SKUBarcodeTextBox.TabIndex = 10;
            this.SKUBarcodeTextBox.MouseHover += new System.EventHandler(this.SKUBarcodeTextBox_MouseHover);
            // 
            // EditSKUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 505);
            this.Controls.Add(this.SKUSaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SKUNoticeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSKUForm";
            this.Text = "Edit SKU";
            this.Load += new System.EventHandler(this.EditSKUForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SKUNoticeLabel;
        private System.Windows.Forms.Button SKUSaveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox SKUSupplierTextBox;
        private System.Windows.Forms.Label SKUSupplierLabel;
        private System.Windows.Forms.ComboBox SKULocationTextBox;
        private System.Windows.Forms.TextBox SKUMinimumStockAmountTextBox;
        private System.Windows.Forms.Label SKUMinimumStockAmountLabel;
        private System.Windows.Forms.Label SKULocationLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SKUItemBrandTextBox;
        private System.Windows.Forms.Label SKUItemBrandLabel;
        private System.Windows.Forms.Label SKUDescriptionLabel;
        private System.Windows.Forms.TextBox SKUDescriptionTextBox;
        private System.Windows.Forms.Label SKUItemNameLabel;
        private System.Windows.Forms.Label SKUBarcodeLabel;
        private System.Windows.Forms.TextBox SKUItemNameTextBox;
        private System.Windows.Forms.TextBox SKUBarcodeTextBox;
        private System.Windows.Forms.ToolTip BarcodeToolTip;
        private System.Windows.Forms.Label SKUUnitLabel;
        private System.Windows.Forms.TextBox SKUUnitTextBox;
    }
}
namespace StockControl
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.StockingHorseTitleLabel = new System.Windows.Forms.Label();
            this.StockingHorseLogo = new System.Windows.Forms.PictureBox();
            this.LoginSubTitle = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.StockingHorseWebsiteLabel = new System.Windows.Forms.LinkLabel();
            this.InitialPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StockingHorseLogo)).BeginInit();
            this.InitialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockingHorseTitleLabel
            // 
            this.StockingHorseTitleLabel.AutoSize = true;
            this.StockingHorseTitleLabel.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockingHorseTitleLabel.Location = new System.Drawing.Point(88, 56);
            this.StockingHorseTitleLabel.Name = "StockingHorseTitleLabel";
            this.StockingHorseTitleLabel.Size = new System.Drawing.Size(251, 39);
            this.StockingHorseTitleLabel.TabIndex = 0;
            this.StockingHorseTitleLabel.Text = "Stocking Horse";
            this.StockingHorseTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StockingHorseLogo
            // 
            this.StockingHorseLogo.Image = ((System.Drawing.Image)(resources.GetObject("StockingHorseLogo.Image")));
            this.StockingHorseLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("StockingHorseLogo.InitialImage")));
            this.StockingHorseLogo.Location = new System.Drawing.Point(12, 42);
            this.StockingHorseLogo.Name = "StockingHorseLogo";
            this.StockingHorseLogo.Size = new System.Drawing.Size(63, 69);
            this.StockingHorseLogo.TabIndex = 1;
            this.StockingHorseLogo.TabStop = false;
            this.StockingHorseLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginSubTitle
            // 
            this.LoginSubTitle.AutoSize = true;
            this.LoginSubTitle.Font = new System.Drawing.Font("Rockwell", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSubTitle.Location = new System.Drawing.Point(93, 95);
            this.LoginSubTitle.Name = "LoginSubTitle";
            this.LoginSubTitle.Size = new System.Drawing.Size(98, 9);
            this.LoginSubTitle.TabIndex = 2;
            this.LoginSubTitle.Text = "Created By Joseph Chua";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(114, 155);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(114, 59);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(114, 236);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(114, 59);
            this.SignUpButton.TabIndex = 4;
            this.SignUpButton.Text = "Sign-Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // StockingHorseWebsiteLabel
            // 
            this.StockingHorseWebsiteLabel.AutoSize = true;
            this.StockingHorseWebsiteLabel.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockingHorseWebsiteLabel.Location = new System.Drawing.Point(9, 364);
            this.StockingHorseWebsiteLabel.Name = "StockingHorseWebsiteLabel";
            this.StockingHorseWebsiteLabel.Size = new System.Drawing.Size(129, 13);
            this.StockingHorseWebsiteLabel.TabIndex = 5;
            this.StockingHorseWebsiteLabel.TabStop = true;
            this.StockingHorseWebsiteLabel.Text = "www.stockinghorse.com";
            // 
            // InitialPanel
            // 
            this.InitialPanel.Controls.Add(this.StockingHorseWebsiteLabel);
            this.InitialPanel.Controls.Add(this.SignUpButton);
            this.InitialPanel.Controls.Add(this.LoginButton);
            this.InitialPanel.Controls.Add(this.LoginSubTitle);
            this.InitialPanel.Controls.Add(this.StockingHorseLogo);
            this.InitialPanel.Controls.Add(this.StockingHorseTitleLabel);
            this.InitialPanel.Location = new System.Drawing.Point(0, 0);
            this.InitialPanel.Name = "InitialPanel";
            this.InitialPanel.Size = new System.Drawing.Size(351, 386);
            this.InitialPanel.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 386);
            this.Controls.Add(this.InitialPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Stocking Horse - Login";
            ((System.ComponentModel.ISupportInitialize)(this.StockingHorseLogo)).EndInit();
            this.InitialPanel.ResumeLayout(false);
            this.InitialPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StockingHorseTitleLabel;
        private System.Windows.Forms.PictureBox StockingHorseLogo;
        private System.Windows.Forms.Label LoginSubTitle;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.LinkLabel StockingHorseWebsiteLabel;
        private System.Windows.Forms.Panel InitialPanel;
    }
}
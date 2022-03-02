namespace StockControl
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            this.PopUpButton = new System.Windows.Forms.Button();
            this.PopUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PopUpButton
            // 
            this.PopUpButton.Location = new System.Drawing.Point(98, 112);
            this.PopUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PopUpButton.Name = "PopUpButton";
            this.PopUpButton.Size = new System.Drawing.Size(124, 38);
            this.PopUpButton.TabIndex = 1;
            this.PopUpButton.Text = "ok";
            this.PopUpButton.UseVisualStyleBackColor = true;
            this.PopUpButton.Click += new System.EventHandler(this.PopUpButton_Click);
            // 
            // PopUpLabel
            // 
            this.PopUpLabel.Location = new System.Drawing.Point(-2, 28);
            this.PopUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PopUpLabel.Name = "PopUpLabel";
            this.PopUpLabel.Size = new System.Drawing.Size(309, 54);
            this.PopUpLabel.TabIndex = 2;
            this.PopUpLabel.Text = "PopUpLabel";
            this.PopUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 169);
            this.Controls.Add(this.PopUpLabel);
            this.Controls.Add(this.PopUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Text = "Notice";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PopUp_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PopUpButton;
        private System.Windows.Forms.Label PopUpLabel;
    }
}
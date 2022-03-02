using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class PopUp : Form
    {
        public PopUp(string Prompt)
        {
            InitializeComponent();
            PopUpLabel.Text = Prompt;
        }

        private void PopUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopUpButton_Click(sender, e);
            }
        }
    }
}

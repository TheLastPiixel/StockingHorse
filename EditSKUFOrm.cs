using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StockControl
{
    public partial class EditSKUForm : Form
    {
        private SQLiteConnection SQLite;
        private string Barcode;
        private string ItemName;
        private string ItemBrand;
        private string Description;
        private string Location;
        private string Supplier;
        private int MinimumStock;
        private string Unit;
        private string[] LocationsArray;
        private string[] SuppliersArray;
        private string[] UnitsArray;
        public EditSKUForm(string Barcode, string ItemName, string ItemBrand, string Description, string Location, string Supplier, int MinimumStock, string Unit, string[] LocationsArray, string[] SuppliersArray)
        {
            InitializeComponent();

            Barcode = Barcode;
            ItemName = ItemName;
            ItemBrand = ItemBrand;
            Description = Description;
            Location = Location;
            Supplier = Supplier;
            MinimumStock = MinimumStock;
            LocationsArray = LocationsArray;
            SuppliersArray = SuppliersArray;
            UnitsArray = UnitsArray;

            SKULocationTextBox.Items.AddRange(LocationsArray);
            SKUSupplierTextBox.Items.AddRange(SuppliersArray);

            SKUBarcodeTextBox.Text = Barcode;
            SKUItemNameTextBox.Text = ItemName;
            SKUItemBrandTextBox.Text = ItemBrand;
            SKUDescriptionTextBox.Text = Description;
            SKULocationTextBox.Text = Location;
            SKUSupplierTextBox.Text = Supplier;
            SKUUnitTextBox.Text = Unit;
            SKUMinimumStockAmountTextBox.Text = Convert.ToString(ConvertToKiloManager(MinimumStock, Unit));
        }

        #region Database Helpers definition
        private void OpenDataBase()
        {
            try
            {
                var docPath = $@"URI=file:" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + $@"\StockList.db";
                SQLite = new SQLiteConnection(docPath);
                SQLite.Open();
            }
            catch
            {
                OpenPopUp("Failed to Open Database!");
                return;
            }
        }
        private void CloseDataBase()
        {
            SQLite.Close();
        }
        #endregion

        private void OpenPopUp(string Prompt)
        {
            PopUp PopUpForm = new PopUp(Prompt);
            PopUpForm.Show();
        }

        private void SKUSaveButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { SKUBarcodeTextBox.Text, SKUItemNameTextBox.Text, SKUItemBrandTextBox.Text, SKUMinimumStockAmountTextBox.Text};
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }
            if (SKUUnitTextBox.Text == "Kilogram" || SKUUnitTextBox.Text == "Litre")
            {
                if (ConvertAndValidateUnitStockAmounts(SKUMinimumStockAmountTextBox.Text) == false)
                {
                    return;
                }
            }
            else
            {
                if (ConvertAndValidateStockAmounts(SKUMinimumStockAmountTextBox.Text) == false)
                {
                    return;
                }
            }

            try
            {
                Barcode = SKUBarcodeTextBox.Text;
                ItemName = SKUItemNameTextBox.Text;
                ItemBrand = SKUItemBrandTextBox.Text;
                Description = SKUDescriptionTextBox.Text;
                Location = SKULocationTextBox.Text;
                Supplier = SKUSupplierTextBox.Text;
                Unit = SKUUnitTextBox.Text;
                MinimumStock = ConvertToBaseUnitManager(Convert.ToDouble(SKUMinimumStockAmountTextBox.Text), Unit);

                //Checks user confirmation
                if (true)
                {
                    OpenDataBase();

                    //Creates new SQLite command to edit record
                    var cmd = new SQLiteCommand(SQLite);
                    cmd.CommandText = @"UPDATE StockList SET Item_Name = '" + ItemName + "', Item_Brand = '" + ItemBrand + "', Description = '" + Description + "', Location = '" + Location + "', Supplier = '" + Supplier + "', Min_Stock_Amount = '" + MinimumStock + "'  WHERE Barcode = '" + Barcode + "'";
                    cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    //Closes Database
                    CloseDataBase();

                    //Prompt user of successful stock in
                    OpenPopUp("Succesfully Edited SKU");
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                OpenPopUp("Failed to Edit SKU!");
            }
        }

        private void SKUBarcodeTextBox_MouseHover(object sender, EventArgs e)
        {
            BarcodeToolTip.Show("Unable to change barcode", SKUBarcodeTextBox);
        }

        #region Unit Conversion definition

        //Converts values from base to unit to Kilograms/ Litres, returns a double
        private double ConvertToKiloManager(int Value, string Unit)
        {
            if (Unit == "Kilogram" || Unit == "Litre")
            {
                return ConvertToKilo(Value);
            }
            else
            {
                return Value;
            }
        }
        private int ConvertToBaseUnitManager(double Value, string Unit)
        {
            Console.WriteLine(Unit);
            if (Unit == "Kilogram" || Unit == "Litre")
            {
                return ConvertToBaseUnit(Value);
            }
            else
            {
                return Convert.ToInt32(Value);
            }
        }
        private double ConvertToKilo(int BaseValue)
        {
            double KiloValue = (double)BaseValue / (double)1000;
            return KiloValue;
        }

        private int ConvertToBaseUnit(double KiloValue)
        {
            int BaseValue = Convert.ToInt32(KiloValue * 1000);
            return BaseValue;
        }
        #endregion

        #region Validation definition
        private bool CheckForEmptyFields(string[] Fields)
        {
            int i_max = Fields.Length;
            for (int i = 0; i < i_max; i++)
            {
                if (Fields[i] == String.Empty)
                {
                    OpenPopUp("One or More Required Fields are Empty!");
                    return true;
                }
            }
            return false;
        }

        private bool ConvertAndValidateStockAmounts(string Input)
        {
            try
            {
                int StockAmount = Convert.ToInt32(Input);
                if (StockAmount <= 0)
                {
                    OpenPopUp("Invalid Stock Amount!");
                    return false;
                }
                return true;
            }
            catch
            {
                OpenPopUp("Invalid Stock Amount!");
                return false;
            }
        }

        private bool ConvertAndValidateUnitStockAmounts(string Input)
        {
            try
            {
                double StockAmount = Convert.ToDouble(Input);
                if (StockAmount < 0.001)
                {
                    OpenPopUp("Invalid Stock Amount!");
                    return false;
                }
                return true;
            }
            catch
            {
                OpenPopUp("Invalid Stock Amount!");
                return false;
            }
        }
        #endregion

        private void EditSKUForm_Load(object sender, EventArgs e)
        {

        }
    }
}

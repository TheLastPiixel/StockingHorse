#region Libraries definition
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CsvHelper;
using Tulpep.NotificationWindow;

#endregion

namespace StockControl
{
    public partial class Form1 : Form
    {
        #region Variable Declaration definition
        //Variable declaration
        private SQLiteConnection SQLite;
        //private SQLiteCommand cmd;

        string Barcode;
        string ItemName;
        string ItemBrand;
        string Description;
        string Location;
        string Unit;
        string Supplier;
        string ReconcileReason;
        string[] LocationsArray;
        string[] SuppliersArray;
        string[] ReconcileReasonsArray;
        string[] UnitsArray;
        int StockAmount;
        int MinimumStockAmount;
        string Prompt;
        string User = "Joseph";
        DateTime StartDate;
        DateTime EndDate;
        string EditDate;

        //Edit SKU Variables
        string EditSKUBarcode;
        string EditSKUItemName;
        string EditSKUItemBrand;
        string EditSKUDescription;
        string EditSKULocation;
        string EditSKUSupplier;
        string EditSKUUnit;
        int EditSKUMinimumStockAmount;

        int CurrentStock;
        int NewStock;

        Color NotificationBackground = Color.FromArgb(37, 37, 38);
        Color NotificationText = Color.FromArgb(168, 168, 169);

        enum ActionType
        {
            SKU,
            StockIn,
            StockOut,
            Reconcile
        }

        enum Tables
        {
            StockList,
            StockListActions,
            LowStockList
        }

        //Class for CurrentStock Report .csv records
        internal class StockRecord
        {
            public string Barcode { get; set; }
            public string ItemName { get; set; }
            public string ItemBrand { get; set; }
            public string Location { get; set; }
            public double StockAmount { get; set; }
            public string Unit { get; set; }
        }

        //Class for LowStock Report .csv records
        internal class LowStockRecord
        {
            public string Barcode { get; set; }
            public string ItemName { get; set; }
            public string ItemBrand { get; set; }
            public double StockAmount { get; set; }
            public double MinimumStockAmount { get; set; }
            public string Unit { get; set; }
            public string Supplier { get; set; }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();

            AdminStartDatePicker.Format = DateTimePickerFormat.Custom;
            AdminEndDatePicker.Format = DateTimePickerFormat.Custom;
            AdminStartDatePicker.CustomFormat = "dd MMM yyyy";
            AdminEndDatePicker.CustomFormat = "dd MMM yyyy";
            AdminStartDatePicker.Value = DateTime.Now.AddMonths(-1);

            //Deletes empty first row in grid view
            StockList_Database.RowHeadersVisible = false;
            LowStock_Database.RowHeadersVisible = false;
            Suppliers_Database.RowHeadersVisible = false;

            RefreshData();
        }

        public void RefreshData()
        {
            //Load Tables
            LowStock_Database.Rows.Clear();
            LoadLowStockDataBase();

            Suppliers_Database.Rows.Clear();
            LoadSuppliersDataBase();

            StockList_Database.Rows.Clear();
            LoadStockListDataBase();

            //Load Dropdowns
            LoadLocations();
            LoadSuppliers();
            LoadReconcileReasons();
            LoadUnitsList();

            //Other Refresh Data
            WarningSymbolManager();
        }

        #region DatabaseHelper definition
        private bool CheckBarcodeExist(string Barcode, Tables Table)
        {
            OpenDataBase();

            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT count(*) FROM '" + Table + "' WHERE Barcode = '" + Barcode + "'";
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            CloseDataBase();
        }
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

        #region LoadTables definition 
        private void LoadStockListDataBase()
        {
            OpenDataBase();

            //Creates new command to select all records from table
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * From StockList";
            SQLiteDataReader reader = cmd.ExecuteReader();

            //Reads all records from StockList.db and adds rows in StockList_DataBase
            while (reader.Read())
            {
                string UnitType = $"{reader.GetValue(9)}";
                object StockAmountVar;
                object MinStockAmountVar;
                if (UnitType == "Kilogram" || UnitType == "Litre")
                {
                    StockAmountVar = ConvertToKilo(Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Stock_Amount"))));
                    MinStockAmountVar = ConvertToKilo(Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Min_Stock_Amount"))));
                }
                else
                {
                    StockAmountVar = reader.GetValue(reader.GetOrdinal("Stock_Amount"));
                    MinStockAmountVar = reader.GetValue(reader.GetOrdinal("Min_Stock_Amount"));
                }

                StockList_Database.Rows.Add(new object[] {
                reader.GetValue(reader.GetOrdinal("Barcode")),
                reader.GetValue(reader.GetOrdinal("Item_Name")),
                reader.GetValue(reader.GetOrdinal("Item_Brand")),
                reader.GetValue(reader.GetOrdinal("Description")),
                reader.GetValue(reader.GetOrdinal("Location")),
                reader.GetValue(reader.GetOrdinal("Unit")),
                StockAmountVar,
                MinStockAmountVar,
                reader.GetValue(reader.GetOrdinal("Supplier"))
                });
            }

            CloseDataBase();
        }

        private void LoadLowStockDataBase()
        {
            OpenDataBase();

            //Creates new command to select all records from table
            int count = 0;
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * From LowStockList";
            SQLiteDataReader reader = cmd.ExecuteReader();

            //Reads all records from StockList.db and adds rows in StockList_DataBase
            while (reader.Read())
            {
                string UnitType = $"{reader.GetValue(6)}";
                object StockAmountVar;
                object MinStockAmountVar;
                if (UnitType == "Kilogram" || UnitType == "Litre")
                {
                    StockAmountVar = ConvertToKilo(Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Stock_Amount"))));
                    MinStockAmountVar = ConvertToKilo(Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Min_Stock_Amount"))));
                }
                else
                {
                    StockAmountVar = reader.GetValue(reader.GetOrdinal("Stock_Amount"));
                    MinStockAmountVar = reader.GetValue(reader.GetOrdinal("Min_Stock_Amount"));
                }

                LowStock_Database.Rows.Add(new object[] {
                reader.GetValue(reader.GetOrdinal("Barcode")),
                reader.GetValue(reader.GetOrdinal("Item_Name")),
                reader.GetValue(reader.GetOrdinal("Item_Brand")),
                reader.GetValue(reader.GetOrdinal("Unit")),
                StockAmountVar,
                MinStockAmountVar,
                reader.GetValue(reader.GetOrdinal("Supplier"))
                });
                count++;
            }

            CloseDataBase();
        }
        private void LoadSuppliersDataBase()
        {
            OpenDataBase();

            //Creates new command to select all records from table
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * From Suppliers";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Suppliers_Database.Rows.Add(new object[] {
                reader.GetValue(reader.GetOrdinal("Supplier")),
                reader.GetValue(reader.GetOrdinal("Contact_Name")),
                reader.GetValue(reader.GetOrdinal("Phone_Number")),
                reader.GetValue(reader.GetOrdinal("Email")),
                reader.GetValue(reader.GetOrdinal("Address")),
                reader.GetValue(reader.GetOrdinal("Notes"))
                });
            }

            CloseDataBase();
        }
        #endregion

        #region LoadDropDowns definition
        private void LoadLocations()
        {
            List<string> LocationsList = new List<string>();

            OpenDataBase();

            //Creates new command to select all records from table
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * From Locations";
            SQLiteDataReader reader = cmd.ExecuteReader();

            //Reads all records from StockList.db and adds rows in StockList_DataBase
            while (reader.Read())
            {
                LocationsList.Add($"{reader.GetValue(0)}");
            }

            CloseDataBase();

            //Load all Locations into Drop Down
            LocationsArray = LocationsList.ToArray();

            //Clears the list
            SKULocationTextBox.Items.Clear();
            AdminDeleteLocationTextBox.Items.Clear();

            //Sets new list
            SKULocationTextBox.Items.AddRange(LocationsArray);
            AdminDeleteLocationTextBox.Items.AddRange(LocationsArray);
        }

        private void LoadSuppliers()
        {
            List<string> SuppliersList = new List<string>();

            OpenDataBase();

            //Creates new command to select all records from table
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * From Suppliers";
            SQLiteDataReader reader = cmd.ExecuteReader();

            //Reads all records from StockList.db and adds rows in StockList_DataBase
            while (reader.Read())
            {
                SuppliersList.Add($"{reader.GetValue(0)}");
            }

            CloseDataBase();

            //Load all Locations into Drop Down
            SuppliersArray = SuppliersList.ToArray();

            //Clears the list
            AdminDeleteSupplierTextBox.Items.Clear();
            SKUSupplierTextBox.Items.Clear();

            //Sets new list
            AdminDeleteSupplierTextBox.Items.AddRange(SuppliersArray);
            SKUSupplierTextBox.Items.AddRange(SuppliersArray);
        }

        private void LoadReconcileReasons()
        {
            List<string> ReconcileReasonsList = new List<string>();

            OpenDataBase();

            //Creates new command to select all records from table
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * From ReconcileReasons";
            SQLiteDataReader reader = cmd.ExecuteReader();

            //Reads all records from StockList.db and adds rows in StockList_DataBase
            while (reader.Read())
            {
                ReconcileReasonsList.Add($"{reader.GetValue(0)}");
            }

            CloseDataBase();

            //Load all Locations into Drop Down
            ReconcileReasonsArray = ReconcileReasonsList.ToArray();

            //Clears the list
            ReconcileReasonTextBox.Items.Clear();

            //Sets new list
            ReconcileReasonTextBox.Items.AddRange(ReconcileReasonsArray);
        }

        //Units are currently hardcoded
        private void LoadUnitsList()
        {
            List<string> UnitsList = new List<string>();
            UnitsList.Add("");
            UnitsList.Add("Kilogram");
            UnitsList.Add("Litre");

            UnitsArray = UnitsList.ToArray();

            SKUUnitTextBox.Items.Clear();
            SKUUnitTextBox.Items.AddRange(UnitsArray);
        }
        #endregion

        private void AddStockListAction(string Barcode, int Amount, string Unit, ActionType Action, string Reason)
        {
            try
            {
                string Edit_Time = DateTime.Now.ToString("dd-MM-yyyy HH:mm tt");
                OpenDataBase();

                //Input data into database
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "INSERT INTO StockListActions(Barcode, Amount, Action, Edited_By, Edit_Time, Unit, Reason) VALUES('" + Barcode + "', '" + Amount + "', '" + Action + "', '" + User + "', '" + Edit_Time + "', '" + Unit + "', '" + Reason + "')";

                //Execute SQLite Changes
                cmd.ExecuteNonQuery();

                //Closes the database
                CloseDataBase();
            }
            catch
            {
                OpenPopUp("Failed to update database: StockListActions");
            }
        }
        private void CreateReport(string ReportName)
        {
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + $@"\Reports");
        }
        private void OpenPopUp(string Prompt)
        {
            PopUp PopUpForm = new PopUp(Prompt);
            PopUpForm.Show();
        }
        //Requires database to be opened

        #region SKU, Inwards, Outwards definition
        private void SKUSaveButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { SKUBarcodeTextBox.Text, SKUItemNameTextBox.Text, SKUItemBrandTextBox.Text, SKUMinimumStockAmountTextBox.Text};
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }

            //Collect data from text boxes
            Barcode = SKUBarcodeTextBox.Text;
            ItemName = SKUItemNameTextBox.Text;
            ItemBrand = SKUItemBrandTextBox.Text;
            Description = SKUDescriptionTextBox.Text;
            Location = SKULocationTextBox.Text;
            StockAmount = 0;
            Unit = SKUUnitTextBox.Text;
            Supplier = SKUSupplierTextBox.Text;
            if (Unit == "Kilogram" || Unit == "Litre")
            {
                MinimumStockAmount = ConvertToBaseUnit(float.Parse(SKUMinimumStockAmountTextBox.Text));
            }
            else
            {
                try
                {
                    MinimumStockAmount = Convert.ToInt32(SKUMinimumStockAmountTextBox.Text);
                }
                catch
                {
                    OpenPopUp("Minimum Stock Amount: \n\rIncorrect Format!");
                    return;
                }
            }

            AddStockListAction(Barcode, StockAmount, Unit, ActionType.SKU, null);

            try
            {
                //Opens the database
                OpenDataBase();

                //Input data into database
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "INSERT INTO StockList(Barcode, Item_Name, Item_Brand, Description, Location, Stock_Amount, Edited_By, Min_Stock_Amount, Supplier, Unit) VALUES('" + Barcode + "', '" + ItemName + "', '" + ItemBrand + "', '" + Description + "', '" + Location + "', '" + StockAmount + "', '" + User + "', '" + MinimumStockAmount + "', '" + Supplier + "', '" + Unit + "')";

                //Execute SQLite Changes
                cmd.ExecuteNonQuery();

                //Closes the database
                CloseDataBase();

                //Prompts user when SKU added
                OpenPopUp("SKU Added");
                
                RefreshData();

                //Delete data from text boxes
                SKUBarcodeTextBox.Text = String.Empty;
                SKUItemNameTextBox.Text = String.Empty;
                SKUItemBrandTextBox.Text = String.Empty;
                SKUDescriptionTextBox.Text = String.Empty;
                SKULocationTextBox.Text = String.Empty;
                SKUMinimumStockAmountTextBox.Text = String.Empty;
                SKUSupplierTextBox.Text = String.Empty;
                SKUUnitTextBox.Text = String.Empty;

                SKUBarcodeTextBox.Select();
            }
            catch
            {
                OpenPopUp("Unknown Database Error!");
            }
        }
        private void InwardsSaveButton_Click(object sender, EventArgs e)
        {
            //Validate Input
            string[] ArrayOfInputs = {InwardsBarcodeTextBox.Text, InwardsAmountTextBox.Text};
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }
            if (ValidateBarcode(InwardsBarcodeTextBox.Text) == false)
            {
                return;
            }
            if (ConvertAndValidateStockAmounts(InwardsAmountTextBox.Text) == false)
            {
                return;
            }

            string StockAmountStr;

            //Collect data in form
            Barcode = InwardsBarcodeTextBox.Text;

            //Opens DataBase
            OpenDataBase();

            //Set up SQLite command
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @Barcode + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Capture the current stock amount to be edited
                CurrentStock = Convert.ToInt32(reader.GetValue(5));
                Barcode = $"{reader.GetValue(0)}";
                ItemName = $"{reader.GetValue(1)}";
                ItemBrand = $"{reader.GetValue(2)}";
                Unit = $"{reader.GetValue(9)}";
            }

            if (Unit == "Kilogram" || Unit == "Litre")
            {
                StockAmount = ConvertToBaseUnit(Convert.ToDouble(InwardsAmountTextBox.Text));
                NewStock = CurrentStock + StockAmount;
                StockAmountStr = Convert.ToString(ConvertToKilo(NewStock)) + " " + Unit;
            }
            else
            {
                StockAmount = Convert.ToInt32(InwardsAmountTextBox.Text);
                NewStock = CurrentStock + StockAmount;
                StockAmountStr = Convert.ToString(NewStock);
            }
            AddStockListAction(Barcode, StockAmount, Unit, ActionType.StockIn, null);

            //Clears text box in form
            InwardsBarcodeTextBox.Text = String.Empty;
            InwardsAmountTextBox.Text = String.Empty;
            InwardsUnitTextBox.Text = String.Empty;

            //Creates new SQLite command to edit record
            cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = @"UPDATE StockList SET Stock_Amount = '" + NewStock + "' WHERE Barcode = '" + Barcode + "'";
            cmd.ExecuteNonQuery();

            //Closes Database
            CloseDataBase();
            LowStockManager(Barcode);

            //Prompt user of successful stock in
            OpenPopUp("Succesfully Stocked In:\n\r" + " " + Barcode + " " + ItemBrand + " " + ItemName + " " + StockAmountStr);
            
            RefreshData();
            InwardsBarcodeTextBox.Select();
        }
        private void OutwardsSaveButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { OutwardsBarcodeTextBox.Text, OutwardsAmountTextBox.Text };
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }
            if (ValidateBarcode(OutwardsBarcodeTextBox.Text) == false)
            {
                return;
            }
            if (ConvertAndValidateStockAmounts(OutwardsAmountTextBox.Text) == false)
            {
                return;
            }

            string StockAmountStr;

            //Collect data in form
            Barcode = OutwardsBarcodeTextBox.Text;

            //Opens DataBase
            OpenDataBase();

            //Set up SQLite command
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @Barcode + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Capture the current stock amount to be edited
                CurrentStock = Convert.ToInt32(reader.GetValue(5));
                //Checks Outwards Stock Amount is Less than current stock
                if (StockAmount > CurrentStock)
                {
                    OpenPopUp("Cannot Take Out More Than Current Stock");
                    return;
                }
                Barcode = $"{reader.GetValue(0)}";
                ItemName = $"{reader.GetValue(1)}";
                ItemBrand = $"{reader.GetValue(2)}";
                Unit = $"{reader.GetValue(9)}";
            }

            if (Unit == "Kilogram" || Unit == "Litre")
            {
                StockAmount = ConvertToBaseUnit(Convert.ToDouble(OutwardsAmountTextBox.Text));
                NewStock = CurrentStock - StockAmount;
                StockAmountStr = Convert.ToString(ConvertToKilo(NewStock)) + " " + Unit;
            }
            else
            {
                StockAmount = Convert.ToInt32(OutwardsAmountTextBox.Text);
                NewStock = CurrentStock - StockAmount;
                StockAmountStr = Convert.ToString(NewStock);
            }

            //Add to user actions
            AddStockListAction(Barcode, StockAmount, Unit, ActionType.StockOut, null);

            //Clears text box in form
            OutwardsBarcodeTextBox.Text = String.Empty;
            OutwardsAmountTextBox.Text = String.Empty;
            OutwardsUnitTextBox.Text = String.Empty;

            //Creates new SQLite command to edit record
            cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = @"UPDATE StockList SET Stock_Amount = '" + NewStock + "' WHERE Barcode = '" + Barcode + "'";
            cmd.ExecuteNonQuery();

            //Closes Database
            CloseDataBase();
            OutwardsBarcodeTextBox.Select();
            LowStockManager(Barcode);

            //Prompts user of successful stock out
            OpenPopUp("Succesfully Stocked Out:\n\r" + " " + Barcode + " " + ItemBrand + " " + ItemName + " " + StockAmountStr);

            RefreshData();
        }
        #endregion

        #region KeyPresses definition
        //ENTER = PRESS BUTTON 
        private void OutwardsAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutwardsSaveButton_Click(sender, e);
            }
        }

        private void InwardsAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InwardsSaveButton_Click(sender, e);
            }
        }
        private void SKUStockAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SKUSaveButton_Click(sender, e);
            }
        }

        private void SKUUnitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SKUSaveButton_Click(sender, e);
            }
        }

        private void AdminAddLocationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdminAddLocationButton_Click(sender, e);
            }
        }

        private void AdminDeleteLocationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdminDeleteLocationButton_Click(sender, e);
            }
        }

        private void ReconcileReasonTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdminReconcileButton_Click(sender, e);
            }
        }
        #endregion

        #region Admin Report Buttons definition
        private void AdminCurrentStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                var filename = Directory.GetCurrentDirectory() + @"\Reports\CurrentStock " + DateTime.Now.ToString("yyyy-MM-dd") + @".csv";
                List<StockRecord> list = new List<StockRecord>() { };
                TextWriter textWriter = File.CreateText(filename);
                var csvWriter = new CsvWriter(textWriter, System.Globalization.CultureInfo.CurrentCulture);

                OpenDataBase();

                //Creates new command to select all records from table
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * From StockList";
                SQLiteDataReader reader = cmd.ExecuteReader();

                //Reads all records from StockList.db and adds rows in StockList_DataBase
                while (reader.Read())
                {
                    Barcode = $"{reader.GetValue(0)}";
                    ItemName = $"{reader.GetValue(1)}";
                    ItemBrand = $"{reader.GetValue(2)}";
                    Location = $"{reader.GetValue(4)}";
                    StockAmount = Convert.ToInt32($"{reader.GetValue(5)}");
                    Unit = $"{reader.GetValue(9)}";
                    var ActualStockAmount = ConvertToKiloManager(StockAmount, Unit);

                    //Writes all fields into a record and stores it in the csv
                    list = new List<StockRecord>() {
                        new  StockRecord(){Barcode=Barcode, ItemName=ItemName, ItemBrand=ItemBrand, Location=Location, StockAmount=ActualStockAmount, Unit=Unit},
                    };
                    csvWriter.WriteRecords(list);
                }

                CloseDataBase();
                textWriter.Close();

                OpenPopUp("Successfully Created Current Stock Report");
            }
            catch
            {
                OpenPopUp("Failed to Create Current Stock Report!");
            }
        }

        private void AdminLowStockReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                var filename = Directory.GetCurrentDirectory() + @"\Reports\LowStock " + DateTime.Now.ToString("yyyy-MM-dd") + @".csv";
                List<LowStockRecord> list = new List<LowStockRecord>() { };
                TextWriter textWriter = File.CreateText(filename);
                var csvWriter = new CsvWriter(textWriter, System.Globalization.CultureInfo.CurrentCulture);

                OpenDataBase();

                //Creates new command to select all records from table
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * From LowStockList";
                SQLiteDataReader reader = cmd.ExecuteReader();

                //Reads all records from StockList.db and adds rows in StockList_DataBase
                while (reader.Read())
                {
                    Barcode = $"{reader.GetValue(0)}";
                    ItemName = $"{reader.GetValue(1)}";
                    ItemBrand = $"{reader.GetValue(2)}";
                    StockAmount = Convert.ToInt32($"{reader.GetValue(3)}");
                    MinimumStockAmount = Convert.ToInt32($"{reader.GetValue(4)}");
                    Supplier = $"{reader.GetValue(5)}";
                    Unit = $"{reader.GetValue(6)}";
                    var ActualStockAmount = ConvertToKiloManager(StockAmount, Unit);
                    var ActualMinimumStockAmount = ConvertToKiloManager(MinimumStockAmount, Unit);

                    //Writes all fields into a record and stores it in the csv
                    list = new List<LowStockRecord>() {
                        new  LowStockRecord(){Barcode=Barcode, ItemName=ItemName, ItemBrand=ItemBrand, StockAmount=ActualStockAmount, MinimumStockAmount=ActualMinimumStockAmount, Unit=Unit, Supplier=Supplier},
                    };
                    csvWriter.WriteRecords(list);
                }

                CloseDataBase();
                textWriter.Close();

                OpenPopUp("Successfully Created Low Stock Report");
            }
            catch
            {
                OpenPopUp("Failed to Create Low Stock Report!");
            }
        }

        private void AdminInwardsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //List variables
                List<string> CheckedBarcodes = new List<string>();
                List<int> CheckedBarcodesStockAmount = new List<int>();
                List<string> ItemNamesList = new List<string>();
                List<string> ItemBrandsList = new List<string>();
                List<string> LocationsList = new List<string>();
                List<string> UnitsList = new List<string>();

                //csv variables
                string StartDateStr = AdminStartDatePicker.Value.ToString("dd-MM-yyyy");
                string EndDateStr = AdminEndDatePicker.Value.ToString("dd-MM-yyyy");
                var filename = Directory.GetCurrentDirectory() + @"\Reports\Inwards " + StartDateStr + " To " + EndDateStr + @".csv";
                List<StockRecord> list = new List<StockRecord>() { };
                TextWriter textWriter = File.CreateText(filename);
                Console.WriteLine("I'm Here!");
                var csvWriter = new CsvWriter(textWriter, System.Globalization.CultureInfo.CurrentCulture);

                //Other variables
                int ArrayIndex;
                int ArraySize = 0;
                string Action;

                OpenDataBase();
                AdminUpdateDates();

                //Creates new command to select all records from table
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * From StockListActions";
                SQLiteDataReader reader = cmd.ExecuteReader();

                //Reads all records from StockList.db and adds rows in StockList_DataBase
                while (reader.Read())
                {
                    Barcode = $"{reader.GetValue(1)}";
                    StockAmount = Convert.ToInt32($"{reader.GetValue(2)}");
                    Action = $"{reader.GetValue(3)}";
                    EditDate = $"{reader.GetValue(5)}";

                    //Checks action is within date range
                    if (DateTime.Compare(StartDate, AdminUpdateEditDate(EditDate)) <= 0)
                    {
                        if (DateTime.Compare(EndDate, AdminUpdateEditDate(EditDate)) >= 0)
                        {
                            //Checks action is Inwards
                            if (Action == "StockIn")
                            {
                                //Check if barcode already exists in array
                                if (CheckedBarcodes.Contains(Barcode))
                                {
                                    ArrayIndex = CheckedBarcodes.IndexOf(Barcode);
                                    CheckedBarcodesStockAmount[ArrayIndex] = CheckedBarcodesStockAmount[ArrayIndex] + StockAmount;
                                }
                                //If barcode not in array add it
                                else
                                {
                                    ArraySize = CheckedBarcodes.Count;
                                    CheckedBarcodes.Add(Barcode);
                                    CheckedBarcodesStockAmount.Add(StockAmount);
                                    ArraySize++;
                                }
                            }

                        }
                    }
                }
                reader.Close();

                //Queries barcodes for item information
                var QueryBarcodeTuple = QueryBarcodes(ArraySize, CheckedBarcodes);
                ItemNamesList = QueryBarcodeTuple.Item1;
                ItemBrandsList = QueryBarcodeTuple.Item2;
                LocationsList = QueryBarcodeTuple.Item3;
                UnitsList = QueryBarcodeTuple.Item4;

                Console.WriteLine(UnitsList);

                CloseDataBase();

                //Write .csv file
                for (int i = 0; i < ArraySize; i++)
                {
                    //Writes all fields into a record and stores it in the csv
                    list = new List<StockRecord>() {
                    new  StockRecord(){Barcode=CheckedBarcodes[i], ItemName=ItemNamesList[i], ItemBrand=ItemBrandsList[i], Location=LocationsList[i], StockAmount=ConvertToKiloManager(CheckedBarcodesStockAmount[i], UnitsList[i]), Unit=UnitsList[i]},
                };
                    csvWriter.WriteRecords(list);
                }

                textWriter.Close();
                OpenPopUp("Successfully Created Inwards Report");
            }
            catch
            {
                OpenPopUp("Failed to Create Inwards Report!");
            }
        }

        private void AdminOutwardsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //List variables
                List<string> CheckedBarcodes = new List<string>();
                List<int> CheckedBarcodesStockAmount = new List<int>();
                List<string> ItemNamesList = new List<string>();
                List<string> ItemBrandsList = new List<string>();
                List<string> LocationsList = new List<string>();
                List<string> UnitsList = new List<string>();

                //csv variables
                string StartDateStr = AdminStartDatePicker.Value.ToString("dd-MM-yyyy");
                string EndDateStr = AdminEndDatePicker.Value.ToString("dd-MM-yyyy");
                var filename = Directory.GetCurrentDirectory() + @"\Reports\Outwards " + StartDateStr + " To " + EndDateStr + @".csv";
                List<StockRecord> list = new List<StockRecord>() { };
                TextWriter textWriter = File.CreateText(filename);
                var csvWriter = new CsvWriter(textWriter, System.Globalization.CultureInfo.CurrentCulture);

                //Other variables
                int ArrayIndex;
                int ArraySize = 0;
                string Action;

                OpenDataBase();
                AdminUpdateDates();

                //Creates new command to select all records from table
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * From StockListActions";
                SQLiteDataReader reader = cmd.ExecuteReader();

                //Reads all records from StockList.db and adds rows in StockList_DataBase
                while (reader.Read())
                {
                    Barcode = $"{reader.GetValue(1)}";
                    StockAmount = Convert.ToInt32($"{reader.GetValue(2)}");
                    Action = $"{reader.GetValue(3)}";
                    EditDate = $"{reader.GetValue(5)}";

                    //Checks action is within date range
                    if (DateTime.Compare(StartDate, AdminUpdateEditDate(EditDate)) <= 0)
                    {
                        if (DateTime.Compare(EndDate, AdminUpdateEditDate(EditDate)) >= 0)
                        {
                            //Checks action is Inwards
                            if (Action == "StockOut")
                            {
                                //Check if barcode already exists in array
                                if (CheckedBarcodes.Contains(Barcode))
                                {
                                    ArrayIndex = CheckedBarcodes.IndexOf(Barcode);
                                    CheckedBarcodesStockAmount[ArrayIndex] = CheckedBarcodesStockAmount[ArrayIndex] + StockAmount;
                                }
                                //If barcode not in array add it
                                else
                                {
                                    ArraySize = CheckedBarcodes.Count;
                                    CheckedBarcodes.Add(Barcode);
                                    CheckedBarcodesStockAmount.Add(StockAmount);
                                    ArraySize++;
                                }
                            }

                        }
                    }
                }
                reader.Close();

                //Queries barcodes for item information
                var QueryBarcodeTuple = QueryBarcodes(ArraySize, CheckedBarcodes);
                ItemNamesList = QueryBarcodeTuple.Item1;
                ItemBrandsList = QueryBarcodeTuple.Item2;
                LocationsList = QueryBarcodeTuple.Item3;
                UnitsList = QueryBarcodeTuple.Item4;

                CloseDataBase();

                //Write .csv file
                for (int i = 0; i < ArraySize; i++)
                {
                    //Writes all fields into a record and stores it in the csv
                    list = new List<StockRecord>() {
                    new  StockRecord(){Barcode=CheckedBarcodes[i], ItemName=ItemNamesList[i], ItemBrand=ItemBrandsList[i], Location=LocationsList[i], StockAmount=ConvertToKiloManager(CheckedBarcodesStockAmount[i], UnitsList[i]), Unit=UnitsList[i]},
                };
                    csvWriter.WriteRecords(list);
                }

                textWriter.Close();
                OpenPopUp("Successfully Created Outwards Report");
            }
            catch
            {
                OpenPopUp("Failed to Created Outwards Report!");
            }

        }
        #endregion

        #region AdminLocationButtons definition
        private void AdminAddLocationButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { AdminAddLocationTextBox.Text };
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }

            try
            {
                OpenDataBase();
                Location = AdminAddLocationTextBox.Text;

                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "INSERT INTO Locations VALUES('" + Location + "')";
                cmd.ExecuteNonQuery();

                CloseDataBase();
                AdminAddLocationTextBox.Text = String.Empty;
                RefreshData();

                OpenPopUp("Location: " + Location + "\nHas Successfully Been Added");
            }
            catch
            {
                OpenPopUp("Location: " + Location + "\nCould Not Be Added!");
            }

        }

        private void AdminDeleteLocationButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { AdminDeleteLocationTextBox.Text };
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }

            try
            {
                OpenDataBase();

                Location = AdminDeleteLocationTextBox.Text;
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "DELETE FROM Locations WHERE Location = '" + Location + "'";
                cmd.ExecuteNonQuery();

                CloseDataBase();
                AdminDeleteLocationTextBox.ResetText();
                RefreshData();

                OpenPopUp("Location: " + Location + "\nHas Successfully Been Deleted!");
            }
            catch
            {
                OpenPopUp("Failed to Delete Location!");
            }
        }
        #endregion

        #region AdminSupplierButtons definition
        private void AdminAddSupplierButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = {AdminSupplierTextBox.Text};
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }

            //Collect data from text boxes
            Supplier = AdminSupplierTextBox.Text;
            string Contact_Name = AdminContactNameTextBox.Text;
            string Phone_Number = AdminPhoneNumberTextBox.Text;
            string Email = AdminEmailTextBox.Text;
            string Address = AdminAddressTextBox.Text;
            string Notes = AdminNoteTextBox.Text;

            //Delete data from text boxes
            AdminSupplierTextBox.Text = String.Empty;
            AdminContactNameTextBox.Text = String.Empty;
            AdminPhoneNumberTextBox.Text = String.Empty;
            AdminEmailTextBox.Text = String.Empty;
            AdminAddressTextBox.Text = String.Empty;
            AdminNoteTextBox.Text = String.Empty;

            try
            {
                //Opens the database
                OpenDataBase();

                //Input data into database
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "INSERT INTO Suppliers(Supplier, Contact_Name, Phone_Number, Email, Address, Notes) VALUES('" + Supplier + "', '" + Contact_Name + "', '" + Phone_Number + "', '" + Email + "', '" + Address + "', '" + Notes + "')";

                //Execute SQLite Changes
                cmd.ExecuteNonQuery();

                //Closes the database
                CloseDataBase();

                //Prompts user when SKU added
                OpenPopUp("Supplier Added");

                RefreshData();
            }
            catch
            {
                OpenPopUp("Failed to Add Supplier!");
            }
        }

        private void AdminDeleteSupplierButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { AdminDeleteSupplierTextBox.Text };
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }
            try
            {
                OpenDataBase();

                Supplier = AdminDeleteSupplierTextBox.Text;
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "DELETE FROM Suppliers WHERE Supplier = '" + Supplier + "'";
                cmd.ExecuteNonQuery();

                CloseDataBase();
                AdminDeleteSupplierTextBox.ResetText();
                RefreshData();

                OpenPopUp("Supplier: " + Supplier + "\nHas Successfully Been Deleted!");
            }
            catch
            {
                OpenPopUp("Failed to Delete Supplier!");
            }
        }
        #endregion

        #region AdminPageHelperFunctions definition
        private void AdminUpdateDates()
        {
            TimeSpan StartTime = new TimeSpan(0, 00, 0);
            TimeSpan EndTime = new TimeSpan(23, 59, 0);
            CultureInfo provider = CultureInfo.InvariantCulture;
            string StartDateStr;
            string EndDateStr;

            StartDateStr = AdminStartDatePicker.Value.ToString("dd-MM-yyyy HH:mm tt");
            EndDateStr = AdminEndDatePicker.Value.ToString("dd-MM-yyyy HH:mm tt");

            StartDate = DateTime.ParseExact(StartDateStr, "dd-MM-yyyy HH:mm tt", provider);
            EndDate = DateTime.ParseExact(EndDateStr, "dd-MM-yyyy HH:mm tt", provider);

            StartDate = StartDate.Date + StartTime;
            EndDate = EndDate.Date + EndTime;

            //Console.WriteLine(StartDate);
            //Console.WriteLine(EndDate);
        }

        private DateTime AdminUpdateEditDate(string EditDate)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            return DateTime.ParseExact(EditDate, "dd-MM-yyyy HH:mm tt", provider);
        }

        private Tuple<List<string>, List<string>, List<string>, List<string>> QueryBarcodes(int ArraySize, List<string> CheckedBarcodes)
        {
            List<string> ItemNamesList = new List<string>();
            List<string> ItemBrandsList = new List<string>();
            List<string> LocationsList = new List<string>();
            List<string> UnitsList = new List<string>();
            var cmd = new SQLiteCommand(SQLite);
            SQLiteDataReader reader;

            OpenDataBase();

            //Read ItemName, ItemBrand, Location from StockList Database
            for (int i = 0; i < ArraySize; i++)
            {
                cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @CheckedBarcodes[i] + "'";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ItemNamesList.Add($"{reader.GetValue(1)}");
                    ItemBrandsList.Add($"{reader.GetValue(2)}");
                    LocationsList.Add($"{reader.GetValue(4)}");
                    UnitsList.Add($"{reader.GetValue(9)}");
                }
                reader.Close();
            }

            CloseDataBase();

            return Tuple.Create(ItemNamesList, ItemBrandsList, LocationsList, UnitsList);
        }
        #endregion

        #region Edit SKU definition
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditSKU();
        }
        private void StockList_Database_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSKU();
        }

        private void StockList_Database_SelectionChanged(object sender, EventArgs e)
        {
            if (StockList_Database.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = StockList_Database.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = StockList_Database.Rows[SelectedRowIndex];
                EditSKUBarcode = SelectedRow.Cells[0].Value.ToString();
                EditSKUItemName = SelectedRow.Cells[1].Value.ToString();
                EditSKUItemBrand = SelectedRow.Cells[2].Value.ToString();
                EditSKUDescription = SelectedRow.Cells[3].Value.ToString();
                EditSKULocation = SelectedRow.Cells[4].Value.ToString();
                EditSKUUnit = SelectedRow.Cells[5].Value.ToString();
                EditSKUSupplier = SelectedRow.Cells[8].Value.ToString();
                EditSKUMinimumStockAmount = ConvertToBaseUnitManager(Convert.ToDouble(SelectedRow.Cells[7].Value.ToString()), EditSKUUnit);
            }
        }

        private void EditSKU()
        {
            try
            {
                EditSKUForm EditSKUForm = new EditSKUForm(EditSKUBarcode, EditSKUItemName, EditSKUItemBrand, EditSKUDescription, EditSKULocation, EditSKUSupplier, EditSKUMinimumStockAmount, EditSKUUnit, LocationsArray, SuppliersArray);
                EditSKUForm.ShowDialog();
                RefreshData();
            }
            catch
            {
                OpenPopUp("Failed to Edit SKU!");
            }
        }
        #endregion

        #region LowStockLevel definition
        private void LowStockManager(string Barcode)
        {
            OpenDataBase();

            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @Barcode + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ItemName = $"{reader.GetValue(1)}";
                ItemBrand = $"{reader.GetValue(2)}";
                StockAmount = Convert.ToInt32(reader.GetValue(5));
                MinimumStockAmount = Convert.ToInt32(reader.GetValue(7));
                Supplier = $"{reader.GetValue(8)}";
                Unit = $"{reader.GetValue(9)}";
            }

            CloseDataBase();

            if (StockAmount <= MinimumStockAmount)
            {
                AddItemToLowStockList(Barcode, ItemName, ItemBrand, StockAmount, MinimumStockAmount, Supplier, Unit);
            }
            else
            {
                RemoveItemFromLowStockList(Barcode);
            }
        }

        private void AddItemToLowStockList(string Barcode, string Name, string Brand, int StockLevel, int MinimumStockAmount, string Supplier, string Unit)
        {
            OpenDataBase();

            var cmd = new SQLiteCommand(SQLite);
            if (CheckBarcodeExist(Barcode, Tables.LowStockList) == false)
            {
                cmd.CommandText = "INSERT INTO LowStockList(Barcode, Item_Name, Item_Brand, Stock_Amount, Min_Stock_Amount, Supplier, Unit) VALUES('" + Barcode + "', '" + Name + "', '" + Brand + "', '" + StockLevel + "', '" + MinimumStockAmount + "', '" + Supplier + "', '" + Unit + "')";
            }
            else
            {
                cmd.CommandText = @"UPDATE LowStockList SET Stock_Amount = '" + StockLevel + "' WHERE Barcode = '" + Barcode + "'";
            }
            cmd.ExecuteNonQuery();
            CloseDataBase();

            ShowLowStockNotification(Barcode, Name, Brand, StockLevel, Supplier);
        }

        private void RemoveItemFromLowStockList(string Barcode)
        {
            try
            {
                OpenDataBase();

                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "DELETE FROM LowStockList WHERE Barcode = '" + Barcode + "'";
                cmd.ExecuteNonQuery();

                CloseDataBase();
                RefreshData();
            }
            catch
            {
                OpenPopUp("Database Error: Faild to delete from LowStockList!");
            }
        }

        private void ShowLowStockNotification(string Barcode, string Name, string Brand, int StockLevel, string Supplier)
        {
            string StockLevelStr = Convert.ToString(StockLevel);
            if (Unit == "Kilogram" || Unit == "Litre")
            {
                StockLevelStr = Convert.ToString(ConvertToKilo(StockLevel)) + " " + Unit;
            }

            PopupNotifier NotificationCard = new PopupNotifier();
            NotificationStyling(NotificationCard);
            NotificationCard.TitleText = "Low Stock Level";
            NotificationCard.ContentText = "Barcode: " + Barcode + "\nBrand: " + Brand + "\n\rName: " + Name + "\n\rStock Amount: " + StockLevelStr + "\n\rSupplier: " + Supplier;
            NotificationCard.Popup();
        }

        private void NotificationStyling(PopupNotifier NotificationCard)
        {
            NotificationCard.Image = Properties.Resources.exclamation;
            NotificationCard.ImageSize = new Size(40, 40);
            NotificationCard.Delay = 5000;
            NotificationCard.AnimationDuration = 500;
            NotificationCard.BodyColor = NotificationBackground;
            NotificationCard.BorderColor = NotificationBackground;
            NotificationCard.HeaderColor = NotificationBackground;
            NotificationCard.TitleColor = Color.White;
            NotificationCard.ContentColor = NotificationText;
            NotificationCard.ButtonHoverColor = Color.DarkRed;
            NotificationCard.ContentHoverColor = Color.White;
            NotificationCard.GradientPower = 0;
            NotificationCard.HeaderHeight = 1;
            NotificationCard.ShowGrip = false;
            NotificationCard.TitlePadding = new Padding(0, 5, 0, 5);
            NotificationCard.ImagePadding = new Padding(10, 10, 10, 0);
        }

        private void WarningSymbolManager()
        {
            ImageList IconList = new ImageList();
            if (LowStock_Database.Rows.Count > 1)
            {
                IconList.Images.Add("warning", Properties.Resources.exclamation);
                TabControl.ImageList = IconList;
                StockListTabControl.ImageList = IconList;
                LowStockDatabaseTabPage.ImageKey = "warning";
                DatabaseTabPage.ImageKey = "warning";
            }
            else
            {
                LowStockDatabaseTabPage.ImageKey = " ";
                DatabaseTabPage.ImageKey = " ";
            }
        }
        #endregion

        #region Reconcile definition
        private void AdminReconcileButton_Click(object sender, EventArgs e)
        {
            string[] ArrayOfInputs = { ReconcileBarcodeTextBox.Text, ReconcileAmountTextBox.Text, ReconcileReasonTextBox.Text };
            if (CheckForEmptyFields(ArrayOfInputs) == true)
            {
                return;
            }
            if (ValidateBarcode(ReconcileBarcodeTextBox.Text) == false)
            {
                return;
            }
            if (ConvertAndValidateStockAmounts(ReconcileAmountTextBox.Text) == false)
            {
                return;
            }

            Barcode = ReconcileBarcodeTextBox.Text;
            Unit = ReconcileUnitTextBox.Text;
            StockAmount = ConvertToBaseUnitManager(Convert.ToDouble(ReconcileAmountTextBox.Text), Unit);
            ReconcileReason = ReconcileReasonTextBox.Text;

            //Opens DataBase
            OpenDataBase();

            //Set up SQLite command
            var cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @Barcode + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Capture the current stock amount to be edited
                CurrentStock = Convert.ToInt32(reader.GetValue(5));
            }

            //Checks Outwards Stock Amount is Less than current stock
            if (StockAmount > CurrentStock)
            {
                OpenPopUp("Cannot Reconcile More Than Current Stock!");
                return;
            }
            else
            {
                NewStock = CurrentStock - StockAmount;
            }
            
            //Add to user actions
            AddStockListAction(Barcode, StockAmount, Unit, ActionType.Reconcile, ReconcileReason);

            //Clears text box in form
            ReconcileBarcodeTextBox.Text = String.Empty;
            ReconcileAmountTextBox.Text = String.Empty;
            ReconcileReasonTextBox.Text = String.Empty;

            //Creates new SQLite command to edit record
            cmd = new SQLiteCommand(SQLite);
            cmd.CommandText = @"UPDATE StockList SET Stock_Amount = '" + NewStock + "' WHERE Barcode = '" + Barcode + "'";
            cmd.ExecuteNonQuery();

            //Closes Database
            CloseDataBase();

            Console.WriteLine(StockAmount);
            //Prompts user of successful stock out
            OpenPopUp("Succesfully Reconciled!");

            ReconcileBarcodeTextBox.Select();
            LowStockManager(Barcode);

            RefreshData();
        }
        #endregion

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

        #region Load Unit TextBox definition
        private void InwardsBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckBarcodeExist(InwardsBarcodeTextBox.Text, Tables.StockList))
            {
                OpenDataBase();

                //Set up SQLite command
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @InwardsBarcodeTextBox.Text + "'";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Unit = $"{reader.GetValue(9)}";
                }
                CloseDataBase();
                InwardsUnitTextBox.Text = Unit;
            }
            else
            {
                return;
            }
        }

        private void OutwardsBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckBarcodeExist(OutwardsBarcodeTextBox.Text, Tables.StockList))
            {
                OpenDataBase();

                //Set up SQLite command
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @OutwardsBarcodeTextBox.Text + "'";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Unit = $"{reader.GetValue(9)}";
                }
                CloseDataBase();
                OutwardsUnitTextBox.Text = Unit;
            }
            else
            {
                return;
            }
        }
        private void ReconcileBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckBarcodeExist(ReconcileBarcodeTextBox.Text, Tables.StockList))
            {
                OpenDataBase();

                //Set up SQLite command
                var cmd = new SQLiteCommand(SQLite);
                cmd.CommandText = "SELECT * FROM StockList WHERE Barcode = '" + @ReconcileBarcodeTextBox.Text + "'";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Unit = $"{reader.GetValue(9)}";
                }
                CloseDataBase();
                ReconcileUnitTextBox.Text = Unit;
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Input Validation definition
        private bool CheckForEmptyFields(string[] Fields)
        {
            int i_max = Fields.Length;
            for (int i=0; i<i_max; i++)
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
                decimal StockAmount = Convert.ToDecimal(Input);
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

        private bool ValidateBarcode(string Barcode)
        {
            if (CheckBarcodeExist(Barcode, Tables.StockList) == false)
            {
                OpenPopUp("Item does not exist!\n\r please create a new SKU");
                return false;
            }
            return true;
        }

        #endregion
    }
}

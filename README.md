# StockingHorse
Stocking Horse Inventory Management

## BASIC
1. Download and unpack StockingHorse
2. Open StockingHorse.exe

### ADDING NEW ITEM
1. Navigate to SKU
2. Enter the item's Barcode, Name, Brand. Description, Location, Supplier, Minimum Stock, and Unit *(Optional)*
3. Press "Save" button

*Note: Kilogram and Litre units can be recorded up to a 1000th decimal place*

### INCREASING STOCK COUNT
1. Navigate to Inwards
2. Scan the barcode and insert amount to increase by
3. Click "Stock In" button

### DECREASING STOCK COUNT
1. Navigate to Outwards
2. Scan the barcode and insert amount to decrease by
3. Click "Stock Out" button

## VIEWING RECORDS

### Stock List
1. Navigate to Database > Stock List
2. Double click or right click > "Edit SKU" to alter an item

*Note: The Barcode and Unit cannot be altered. If these need to be change, remove and create the SKU*

### Low Stock
To view low stock, navigate to Database > Low Stock. When the quantity of an item reaches the minimum quantity, a slider will notify the user. When an item needs to be restocked, a yellow icon will appear next to the Database and Low Stock tab.

### Suppliers
To view Supplier cards, navigate to Database > Suppliers

## ADMIN 

### Creating & Deleting Suppliers
1. Navigate to Admin > Suppliers
2. To add supplier, fill out the required details in the "Add Supplier" form
3. To remove supplier, select a supplier from the Delete Supplier drop down and click "Delete Supplier"

### Creating & Deleting Locations
1. Navigate to Admin > Locations
2. To add a location, enter location name and click "Add Location"
3. To remove a location, select the location from the dropdown and click "Delete Location"

### Reconciling Stock
The reconciling function allows the user to remove stock that is damaged, missing, or expired.
1. Navigate toe Admin > Reconcile
2. Scan or enter the barcode of the item you want to reconcile
3. Enter the amount to reconcile by followed by the reson for reconciling
4. Press "Reconcile Item"

### Creating Reports
There are three types of reports available, Inwards, Outwards, Current Stock, and Low Stock report. All reports are generated as .csv files and stored in the Reports folder.

Inwards/ Outwards Report - Displays all inventory transactions coming in or out
Current Stock Report - Displays current inventory holding
Low Stock Report - Displays all SKUs with inventory at or below the "minimum stock" value

1. Navigate to Admin > Reports
2. Inwards and Outwards reports can be generated by selecting a To and From date and pressing the "Inwards" or "Outwards" button
3. Current Stock and Low Stock reports can be generated by selecting the "Current Stock" or "Low Stock" buttons

## NOTES
- Barcode scanner must have thier communication settings to USB or USB-Keyboard
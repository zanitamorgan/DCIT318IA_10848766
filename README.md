# DCIT318IA_10848766

PROJECT TITLE: Shoprite Inventory Management System (SIMS)

**PROJECT DESCRIPTION:**

**What Does The Application Do?**
The Shoprite Inventory Management System (SIMS) is designed to allow users, both admins and attendant to interact with the system.
Admins are able:
To manage categories
Manage products
Set new products  
Manage stock
Create and manage other users 

Reset password for users (attendants and admins)

Attendants, on the other hand, are able to: 
Start and end a till
Login with username and hashed passwords.
Generate receipts
Generate sales report for daily transactions

Screens
Splashscrn - Displayed when application is opened
SignUp.cs - Both users; admin and attendant can sign up.
Login.cs - Both users; admin and attendant can login.

Admin Screens
vendor.cs - manage users
Products.cs - manage products
CategoryForm.cs - manage categories

Attendant Screens
TillForm.cs - start or end till
StockForm.cs - view stock
TransactionForm.cs - view sales and issue receipts
ReceiptForm.cs - Input receipt data and export

**Technologies Used**
The programming language C# was used in developing this System. C# was used because it has the bandwidth to support web development.
The tools guna and binufu were used in designing the interface of the application. 

**Challenges Faced**
I kept getting exception errors at the manage users page. Also, a petty mistake such as naming a table "User" can stop your work from running. Lower and upper cases also matter very much in coding in C#.

**How To Install and Run SIMS**
Clone the project from github and run on a PC.

**How To Use SIMS**
Every "Add" button adds to the database and every delete button removes from the database. 
Use the "Edit" button to make changes to previously stored data in the database.

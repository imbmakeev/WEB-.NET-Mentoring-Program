Task 1
=======
You should create a website, that enables operations with the Northwind Database (script with DB structure and test data is attached)
Base requirements:
•	The site should be developed using ASP.Net Core 2+;
•	The application should at least work on Microsoft Windows (cross-platform is fine, but not strictly required) 
•	MS SQL Server should be used as a DB engine (you can use any edition, including Express or LocalDB)
•	EF Core is used to enable data access layer
•	If there are no special instructions, no requirements apply to the layout and styling of the pages

Base site

Create a web site with the following pages:
•	The Home page that contains a welcome message and links to other pages
•	The Categories page. Shows a list of categories without images
•	The Products page. Shows a table with the products 
o	The table contains all products fields
o	Instead of references to Category and Supplier, their names should be shown
Note:
•	All configuration parameters (connection strings, etc.) can remain in the code (hardcoded)

=======
Production
=======
DB store in solution folder /App_Data/

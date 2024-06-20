-- Write queries for following scenarios

-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(ProductId) AS TotalProducts
FROM Production.Product;

-- 2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(ProductSubcategoryID) AS ProductsInSubcategory
FROM Production.Product;

-- 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
-- ProductSubcategoryID CountedProducts
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID;

-- 4. How many products that do not have a product subcategory.
SELECT COUNT(*) AS ProductsWithoutSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

-- 5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS TotalQuantity
FROM Production.ProductInventory;

-- 6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
-- ProductID    TheSum
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

-- 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
--     Shelf      ProductID    TheSum
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100;

-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
WHERE LocationID = 10;

-- 9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
-- ProductID   Shelf      TheAvg
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf;

-- 10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
--     ProductID   Shelf      TheAvg
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf;

-- 11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
-- Color                        Class              TheCount          AvgPrice
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class;

-- Joins:

-- 12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
-- Country                        Province
SELECT CR.Name AS Country, SP.Name AS Province
FROM Person.CountryRegion CR
JOIN Person.StateProvince SP ON CR.CountryRegionCode = SP.CountryRegionCode;

-- 13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
-- Country                        Province
SELECT CR.Name AS Country, SP.Name AS Province
FROM Person.CountryRegion CR
JOIN Person.StateProvince SP ON CR.CountryRegionCode = SP.CountryRegionCode
WHERE CR.Name IN ('Germany', 'Canada');

-- Using Northwnd Database: (Use aliases for all the Joins)

-- 14. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT P.ProductName
FROM Products P
JOIN [Order Details] OD ON P.ProductID = OD.ProductID
JOIN Orders O ON OD.OrderID = O.OrderID
WHERE O.OrderDate >= '1999-07-19';

-- 15. List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 C.PostalCode, COUNT(C.PostalCode) AS TotalSales
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
GROUP BY C.PostalCode
ORDER BY TotalSales DESC;

-- 16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 C.PostalCode, COUNT(C.PostalCode) AS TotalSales
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
WHERE O.OrderDate >= '1999-07-19'
GROUP BY C.PostalCode
ORDER BY TotalSales DESC;

-- 17. List all city names and number of customers in that city.     
SELECT C.City, COUNT(C.City) AS NumberOfCustomers
FROM Customers C
GROUP BY C.City;

-- 18. List city names which have more than 2 customers, and number of customers in that city
SELECT C.City, COUNT(C.City) AS NumberOfCustomers
FROM Customers C
GROUP BY C.City
HAVING COUNT(C.City) > 2;

-- 19. List the names of customers who placed orders after 1/1/98 with order date.
SELECT C.ContactName, O.OrderDate
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE O.OrderDate > '1998-01-01';

-- 20. List the names of all customers with most recent order dates
SELECT C.ContactName, MAX(O.OrderDate) AS MostRecentOrderDate
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
GROUP BY C.ContactName;

-- 21. Display the names of all customers  along with the  count of products they bought
SELECT C.ContactName, COUNT(OD.ProductID) AS ProductsBought
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
GROUP BY C.ContactName;

-- 22. Display the customer ids who bought more than 100 Products with count of products.
SELECT C.CustomerID, COUNT(OD.ProductID) AS ProductsBought
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
GROUP BY C.CustomerID
HAVING COUNT(OD.ProductID) > 100;

-- 23. List all of the possible ways that suppliers can ship their products. Display the results as below
-- Supplier Company Name                Shipping Company Name
SELECT S.CompanyName AS SupplierCompanyName, SC.CompanyName AS ShippingCompanyName
FROM Suppliers S
CROSS JOIN Shippers SC;

-- 24. Display the products order each day. Show Order date and Product Name.
SELECT O.OrderDate, P.ProductName
FROM Orders O
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
JOIN Products P ON OD.ProductID = P.ProductID;

-- 25. Displays pairs of employees who have the same job title.
SELECT E1.FirstName + ' ' + E1.LastName AS Employee1, E2.FirstName + ' ' + E2.LastName AS Employee2, E1.Title
FROM Employees E1
JOIN Employees E2 ON E1.Title = E2.Title AND E1.EmployeeID < E2.EmployeeID;

-- 26. Display all the Managers who have more than 2 employees reporting to them.
SELECT E.FirstName + ' ' + E.LastName AS Manager, COUNT(EM.EmployeeID) AS NumberOfReports
FROM Employees E
JOIN Employees EM ON E.EmployeeID = EM.ReportsTo
GROUP BY E.FirstName, E.LastName
HAVING COUNT(EM.EmployeeID) > 2;

-- 27. Display the customers and suppliers by city. The results should have the following columns
-- City
-- Name
-- Contact Name,
-- Type (Customer or Supplier)
SELECT C.City, C.CompanyName AS Name, C.ContactName, 'Customer' AS Type
FROM Customers C
UNION
SELECT S.City, S.CompanyName AS Name, S.ContactName, 'Supplier' AS Type
FROM Suppliers S;

-- Write queries for following scenarios
-- All scenarios are based on Database NORTHWIND.

-- 1. List all cities that have both Employees and Customers.
SELECT DISTINCT E.City
FROM Employees E
JOIN Customers C ON E.City = C.City;

-- 2. List all cities that have Customers but no Employee.
-- a. Use sub-query
SELECT DISTINCT C.City
FROM Customers C
WHERE C.City NOT IN (SELECT DISTINCT E.City FROM Employees E);

-- b. Do not use sub-query
SELECT DISTINCT C.City
FROM Customers C
LEFT JOIN Employees E ON C.City = E.City
WHERE E.City IS NULL;

-- 3. List all products and their total order quantities throughout all orders.
SELECT P.ProductName, SUM(OD.Quantity) AS TotalOrderQuantity
FROM [Order Details] OD
JOIN Products P ON OD.ProductID = P.ProductID
GROUP BY P.ProductName;

-- 4. List all Customer Cities and total products ordered by that city.
SELECT C.City, SUM(OD.Quantity) AS TotalProductsOrdered
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
GROUP BY C.City;

-- 5. List all Customer Cities that have at least two customers.
-- a. Use union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2;

-- b. Use sub-query and no union
SELECT City
FROM (
    SELECT City, COUNT(*) AS CustomerCount
    FROM Customers
    GROUP BY City
) AS CustomerCities
WHERE CustomerCount >= 2;

-- 6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT C.City
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
GROUP BY C.City
HAVING COUNT(DISTINCT OD.ProductID) >= 2;

-- 7. List all Customers who have ordered products, but have the 'ship city' on the order different from their own customer cities.
SELECT DISTINCT C.CustomerID, C.CompanyName, C.City AS CustomerCity, O.ShipCity
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE C.City <> O.ShipCity;

-- 8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 
    P.ProductName,
    AVG(D.UnitPrice) AS AveragePrice,
    C.City AS MostPopularCity
FROM Products P
JOIN [Order Details] D ON P.ProductID = D.ProductID
JOIN Orders O ON D.OrderID = O.OrderID
JOIN Customers C ON O.CustomerID = C.CustomerID
GROUP BY P.ProductName, C.City
ORDER BY SUM(D.Quantity) DESC;

-- 9. List all cities that have never ordered something but we have employees there.
-- a. Use sub-query
SELECT DISTINCT E.City
FROM Employees E
WHERE E.City NOT IN (SELECT DISTINCT C.City FROM Customers C JOIN Orders O ON C.CustomerID = O.CustomerID);

-- b. Do not use sub-query
SELECT DISTINCT E.City
FROM Employees E
LEFT JOIN Customers C ON E.City = C.City
LEFT JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE O.OrderID IS NULL;

-- 10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
WITH EmployeeOrderCount AS (
    SELECT E.City, COUNT(O.OrderID) AS OrderCount
    FROM Employees E
    JOIN Orders O ON E.EmployeeID = O.EmployeeID
    GROUP BY E.City
),
CustomerOrderQuantity AS (
    SELECT C.City, SUM(OD.Quantity) AS TotalQuantity
    FROM Customers C
    JOIN Orders O ON C.CustomerID = O.CustomerID
    JOIN [Order Details] OD ON O.OrderID = OD.OrderID
    GROUP BY C.City
)
SELECT EOC.City
FROM EmployeeOrderCount EOC
JOIN CustomerOrderQuantity COQ ON EOC.City = COQ.City
WHERE EOC.OrderCount = (SELECT MAX(OrderCount) FROM EmployeeOrderCount)
  AND COQ.TotalQuantity = (SELECT MAX(TotalQuantity) FROM CustomerOrderQuantity)

-- 11. How do you remove the duplicates record of a table?
WITH CTE AS (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Column1, Column2 ORDER BY (SELECT NULL)) AS RowNum
    FROM MyTable
)
DELETE FROM CTE
WHERE RowNum > 1;

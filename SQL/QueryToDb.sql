CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name NVARCHAR(30)
);


CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name NVARCHAR(30)
);


CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

SELECT Products.Name, Categories.Name
FROM Products 
LEFT JOIN ProductCategories 
	ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories 
	ON ProductCategories.CategoryId = Categories.Id;
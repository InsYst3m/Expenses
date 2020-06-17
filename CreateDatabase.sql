Create database ExpensesGod

Use ExpensesGod
Go

Create table Expenses (
	[Id] INT Primary key not null,
	[Name] NVARCHAR(60) not null,
	[Comment] NVARCHAR(255) not null,
	[Price] MONEY not null 
);

Insert into Expenses values (1, 'test1', 'test comment 1')
Insert into Expenses values (2, 'test2', 'test comment 2')
Insert into Expenses values (3, 'test3', 'test comment 3')
Insert into Expenses values (4, 'test4', 'test comment 4')
Insert into Expenses values (5, 'test5', 'test comment 5')
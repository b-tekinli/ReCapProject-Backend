CREATE TABLE [dbo].[Rentals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[CarId] int NOT NULL,
	[CustomerId] int NOT NULL,
	[RentDate] datetime NOT NULL,
	[ReturnDate] datetime NULL,
	FOREIGN KEY (CarId) REFERENCES Cars(CarId),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)

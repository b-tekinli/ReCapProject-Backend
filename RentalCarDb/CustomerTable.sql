CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserId] int NOT NULL,
	[CompanyName] varchar(60) NOT NULL,
	FOREIGN KEY (UserId) REFERENCES Users(Id)
)

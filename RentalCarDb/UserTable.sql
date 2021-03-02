CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[FirstName] nvarchar(30) NOT NULL,
	[LastName] nvarchar(50) NOT NULL,
	[Email] nvarchar(100) NOT NULL,
	[Password] nvarchar(100) NOT NULL
)

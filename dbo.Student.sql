CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [Name] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(100) NULL
)

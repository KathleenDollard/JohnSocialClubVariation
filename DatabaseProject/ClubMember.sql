CREATE TABLE [dbo].[ClubMember]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GivenName] VARCHAR(50) NOT NULL, 
    [MiddleName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [DateOfBirth] DATETIME NOT NULL, 
    [Occupation] INT NOT NULL, 
    [MaritalStatus] INT NOT NULL, 
    [HealthStatus] INT NOT NULL, 
    [Salary] DECIMAL(18, 2) NOT NULL, 
    [NumberOfChildren] INT NOT NULL
)

CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] UNIQUEIDENTIFIER NOT NULL  DEFAULT newid(), 
    [EmployeeNumber] INT NOT NULL, 
    [Name] NVARCHAR(32) NULL, 
    [Surname] NVARCHAR(64) NULL, 
    [DateOfBirth] DATETIME NULL, 
    [DepartmentId] UNIQUEIDENTIFIER NULL, 
    [JobTitleId] UNIQUEIDENTIFIER NULL
)

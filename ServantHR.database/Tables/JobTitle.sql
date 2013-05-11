CREATE TABLE [dbo].[JobTitle]
(
	[JobTitleId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Title] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [CK_JobTitle_UniqueTitle] UNIQUE ([Title])
)

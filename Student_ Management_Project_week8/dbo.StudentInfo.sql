CREATE TABLE [dbo].[StudentInfo]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [fname] VARCHAR(50) NULL, 
    [lname] VARCHAR(50) NULL, 
    [bdate] DATE NULL, 
    [gender] VARCHAR(50) NULL, 
    [phone] NCHAR(10) NULL, 
    [address] VARCHAR(50) NULL, 
    [picture] IMAGE NULL
)

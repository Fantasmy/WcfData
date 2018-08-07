USE WcfCRUD
GO    
IF OBJECT_ID(N'WcfCRUD.dbo.Students', N'U') IS NULL
BEGIN
	-- Create rates table 
CREATE TABLE dbo.Students (
	id UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
	name [NVARCHAR](50) NOT NULL,
	surname [NVARCHAR](50) NOT NULL,
	email [NVARCHAR](50) NOT NULL,  
);
END
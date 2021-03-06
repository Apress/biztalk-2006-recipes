/****** Object:  Table [dbo].[Customer]    Script Date: 01/22/2006 12:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] [nvarchar](60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[City] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Region] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PostalCode] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RecordStatus] [tinyint] NOT NULL
) ON [PRIMARY]

go

Insert Customer (CustomerName, Address, City, Region, PostalCode, RecordStatus)
Values ('Shauna Marie', '9515 S Wally St', 'Bellevue', 'WA', '98004', 1)
Insert Customer (CustomerName, Address, City, Region, PostalCode, RecordStatus)
Values ('Pat Dean', '10034th 49th Ave NE', 'Redmond', 'WA', '95550', 1)
Insert Customer (CustomerName, Address, City, Region, PostalCode, RecordStatus)
Values ('Sherrie Long', '5015 48th Ave SW', 'Woodland Park', 'CO', '80863', 1)


USE [Adtran]
GO

/****** Object:  Table [dbo].[Flow]    Script Date: 11/27/2024 5:42:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Flow](
	[id] [int] NOT NULL,
	[LevelName] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[SendCmd] [nvarchar](50) NULL,
	[SendValue] [nvarchar](50) NULL,
	[ReValue] [nvarchar](50) NULL,
	[ReType] [nvarchar](50) NULL,
	[ReTest] [bit] NULL,
	[Result] [nvarchar](50) NULL
) ON [PRIMARY]
GO



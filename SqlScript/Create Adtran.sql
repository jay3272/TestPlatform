USE [Adtran]
GO

/****** Object:  Table [dbo].[Adtran_632V_ThroughputTest]    Script Date: 11/26/2024 5:16:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Adtran_632V_ThroughputTest](
	[tester] [varchar](10) NULL,
	[model] [varchar](10) NULL,
	[pcbsn] [varchar](20) NULL,
	[saleno] [varchar](25) NULL,
	[OLT_to_Lan1] [varchar](8) NULL,
	[Lan1_to_OLT] [varchar](8) NULL,
	[OLT_to_Lan3] [varchar](8) NULL,
	[Lan3_to_OLT] [varchar](8) NULL,
	[framelen] [varchar](4) NULL,
	[framerate] [varchar](3) NULL,
	[testduration] [varchar](3) NULL,
	[result] [varchar](10) NULL,
	[testtime] [varchar](10) NULL,
	[swver] [varchar](40) NULL,
	[ip] [varchar](20) NULL,
	[testdate] [datetime] NULL,
	[note] [varchar](200) NULL
) ON [PRIMARY]
GO



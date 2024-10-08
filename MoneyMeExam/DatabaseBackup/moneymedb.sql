USE [moneymedb]
GO
/****** Object:  Table [dbo].[tblBlacklistedDomain]    Script Date: 9/12/2024 3:07:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBlacklistedDomain](
	[BlacklistedDomainId] [int] IDENTITY(1,1) NOT NULL,
	[Domain] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBlacklistedMobile]    Script Date: 9/12/2024 3:07:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBlacklistedMobile](
	[BlacklistedMobileId] [int] IDENTITY(1,1) NOT NULL,
	[MobileNumber] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoan]    Script Date: 9/12/2024 3:07:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoan](
	[LoanId] [int] IDENTITY(1,1) NOT NULL,
	[QouteId] [int] NOT NULL,
	[FinanceAmount] [decimal](18, 7) NULL,
	[WeeklyRepayment] [decimal](18, 7) NULL,
	[TotalRepayment] [decimal](18, 7) NULL,
	[NoOfWeeks] [decimal](18, 7) NULL,
	[EstablishmentFee] [decimal](18, 7) NULL,
	[InterestPerc] [decimal](18, 7) NULL,
	[InterestAmount] [decimal](18, 7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQoute]    Script Date: 9/12/2024 3:07:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQoute](
	[QouteId] [int] IDENTITY(1,1) NOT NULL,
	[AmountRquired] [decimal](18, 7) NOT NULL,
	[Term] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Mobile] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QouteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [master]
GO
/****** Object:  Database [WIM]    Script Date: 5/16/2015 7:41:58 PM ******/
CREATE DATABASE [WIM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WIM', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.HAMZA\MSSQL\DATA\WIM.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WIM_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.HAMZA\MSSQL\DATA\WIM_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WIM] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WIM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WIM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WIM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WIM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WIM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WIM] SET ARITHABORT OFF 
GO
ALTER DATABASE [WIM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WIM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WIM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WIM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WIM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WIM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WIM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WIM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WIM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WIM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WIM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WIM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WIM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WIM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WIM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WIM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WIM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WIM] SET RECOVERY FULL 
GO
ALTER DATABASE [WIM] SET  MULTI_USER 
GO
ALTER DATABASE [WIM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WIM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WIM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WIM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WIM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WIM', N'ON'
GO
USE [WIM]
GO
/****** Object:  Table [dbo].[Beam]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beam](
	[B_ID] [int] IDENTITY(1,1) NOT NULL,
	[B_Size] [decimal](18, 0) NOT NULL,
	[B_Item_Descritpion] [nvarchar](max) NULL,
	[B_Quantity] [numeric](18, 0) NULL,
	[B_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[B_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[CL_ID] [int] IDENTITY(1,1) NOT NULL,
	[CL_First_Name] [nvarchar](40) NULL,
	[CL_Middle_Name] [nvarchar](40) NULL,
	[CL_Last_Name] [nvarchar](40) NULL,
	[CL_CNIC] [nvarchar](16) NOT NULL,
	[CL_Email] [nvarchar](50) NULL,
	[CL_Address] [nvarchar](50) NULL,
	[Cl_Designation] [nvarchar](50) NULL,
	[CL_Contact_Number] [numeric](18, 0) NULL,
	[CL_Description] [nvarchar](30) NULL,
	[CL_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[CL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client_Transport]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Transport](
	[CLT_ID] [int] IDENTITY(1,1) NOT NULL,
	[T_ID] [int] NULL,
	[CL_ID] [int] NULL,
	[CLT_Description] [nvarchar](max) NULL,
	[CLT_Quantity] [numeric](38, 0) NULL,
	[CLT_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[CLT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cloth]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cloth](
	[Clo_ID] [int] IDENTITY(1,1) NOT NULL,
	[Clo_Quality] [nvarchar](40) NULL,
	[CLo_Quantity] [numeric](18, 0) NULL,
	[CLo_Length] [decimal](18, 0) NULL,
	[C_Rate_Meter] [decimal](18, 0) NULL,
	[Clo_Description] [nvarchar](40) NULL,
	[Clo_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Clo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contract]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[C_ID] [int] IDENTITY(1,1) NOT NULL,
	[CL_ID] [int] NULL,
	[C_Date] [datetime] NULL,
	[C_Sellers] [nvarchar](40) NULL,
	[M_ID] [int] NOT NULL,
	[C_Description] [nvarchar](40) NULL,
	[C_Quantity] [numeric](38, 0) NULL,
	[C_Payment_Term] [nvarchar](40) NULL,
	[C_Delivery_Term] [nvarchar](40) NULL,
	[C_Loom_Size] [nvarchar](40) NULL,
	[C_No_Looms] [numeric](8, 0) NULL,
	[C_Quality] [nvarchar](50) NULL,
	[C_No_Bags] [numeric](18, 0) NULL,
	[C_Rate_Meter] [decimal](18, 0) NOT NULL,
	[C_Sizing_Rate] [decimal](18, 0) NOT NULL,
	[C_Weaving_Rate] [decimal](18, 0) NOT NULL,
	[C_Remarks] [nvarchar](max) NULL,
	[C_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Driver]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driver](
	[D_ID] [int] IDENTITY(1,1) NOT NULL,
	[D_Fname] [nvarchar](40) NULL,
	[D_Lname] [nvarchar](40) NULL,
	[D_Reg_no] [int] NULL,
	[D_CNIC] [nvarchar](16) NOT NULL,
	[D_Description] [nvarchar](40) NULL,
	[D_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[D_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factory_Store]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factory_Store](
	[FS_ID] [int] IDENTITY(1,1) NOT NULL,
	[TD_ID] [int] NULL,
	[FS_Type] [nvarchar](50) NULL,
	[FS_Info] [nvarchar](max) NULL,
	[FS_Space] [nvarchar](40) NULL,
	[FS_Description] [nvarchar](40) NULL,
	[FS_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[FS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Folding]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Folding](
	[F_ID] [int] IDENTITY(1,1) NOT NULL,
	[F_Description] [nvarchar](30) NULL,
	[F_Status] [nvarchar](30) NOT NULL,
	[FD_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[F_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Folding_Department]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Folding_Department](
	[FD_ID] [int] IDENTITY(1,1) NOT NULL,
	[F_ID] [int] NULL,
	[FDe_ID] [int] NULL,
	[FD_Fname] [nvarchar](30) NULL,
	[FD_LName] [nvarchar](30) NULL,
	[FD_CNIC] [nvarchar](16) NOT NULL,
	[FD_Contact] [nvarchar](30) NULL,
	[FD_Description] [nvarchar](30) NULL,
	[FD_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[FD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Folding_Detail]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Folding_Detail](
	[FDe_ID] [int] IDENTITY(1,1) NOT NULL,
	[FS_ID] [int] NULL,
	[F_ID] [int] NULL,
	[FDe_S_no] [numeric](18, 0) NULL,
	[FDe_Meter] [numeric](18, 0) NULL,
	[FDe_Total_FGC] [numeric](18, 0) NULL,
	[FDe_Total_Meter] [numeric](18, 0) NULL,
	[FDe_Party_name] [nvarchar](30) NULL,
	[FDe_Quality] [nvarchar](30) NULL,
	[FDe_Description] [nvarchar](30) NULL,
	[FDe_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[FDe_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[In_ID] [int] IDENTITY(1,1) NOT NULL,
	[In_Quality] [nvarchar](40) NULL,
	[In_Value_goods] [decimal](18, 0) NULL,
	[In_Unit_price] [decimal](36, 0) NULL,
	[In_Rate_Stax] [decimal](36, 0) NULL,
	[In_Amount_Stax] [money] NULL,
	[In_Value_Including_Stax] [money] NULL,
	[In_Date] [datetime] NULL,
	[In_Total_Amount] [money] NULL,
	[In_Seriel_no] [numeric](18, 0) NULL,
	[In_STReg_no] [nvarchar](40) NULL,
	[In_NTN_no] [nvarchar](40) NULL,
	[In_Description] [nvarchar](40) NULL,
	[In_Status] [nvarchar](30) NULL,
	[Cl_ID] [int] NOT NULL,
	[M_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[In_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manager]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[M_ID] [int] IDENTITY(1,1) NOT NULL,
	[M_First_Name] [nvarchar](40) NULL,
	[M_Last_Name] [nvarchar](40) NULL,
	[M_CNIC] [nvarchar](18) NULL,
	[M_DOB] [datetime] NOT NULL,
	[M_Email] [nvarchar](50) NULL,
	[M_Address] [nvarchar](50) NULL,
	[M_Qualification] [nvarchar](50) NULL,
	[M_Designation] [nvarchar](50) NULL,
	[M_Salary] [money] NULL,
	[M_Image] [nvarchar](max) NULL,
	[M_Hire_Date] [datetime] NOT NULL,
	[M_Retire_Date] [datetime] NULL,
	[M_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[M_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Packing_Cloth]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packing_Cloth](
	[PCLo_ID] [int] IDENTITY(1,1) NOT NULL,
	[PL_ID] [int] NULL,
	[PCLo_Total_Meter] [numeric](38, 0) NULL,
	[PCLo_Quantity] [numeric](38, 0) NULL,
	[PCLo_Description] [nvarchar](max) NULL,
	[PCLo_status] [nvarchar](40) NULL,
	[Clo_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PCLo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Packing_List]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packing_List](
	[PL_ID] [int] IDENTITY(1,1) NOT NULL,
	[M_ID] [int] NULL,
	[CL_ID] [int] NULL,
	[PL_Sno] [numeric](18, 0) NULL,
	[PL_Party] [nvarchar](40) NULL,
	[PL_FGC] [numeric](18, 0) NULL,
	[PL_Total_FGC] [numeric](18, 0) NULL,
	[PL_Quality] [nvarchar](40) NULL,
	[PL_Meter] [numeric](38, 0) NULL,
	[PL_Date] [datetime] NULL,
	[PL_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[PL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Pay_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pay_Type] [nvarchar](40) NOT NULL,
	[Pay_Date] [datetime] NOT NULL,
	[Pay_Amount] [money] NOT NULL,
	[Pay_Description] [nvarchar](40) NULL,
	[Pay_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Pay_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pro_Cloth]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pro_Cloth](
	[PC_ID] [int] IDENTITY(1,1) NOT NULL,
	[CLo_ID] [int] NOT NULL,
	[P_ID] [int] NOT NULL,
	[PC_Quantity] [numeric](18, 0) NULL,
	[PC_Description] [nvarchar](50) NULL,
	[PC_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[PC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Production]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[M_ID] [int] NULL,
	[P_Loom_No] [numeric](18, 0) NULL,
	[P_Warp] [numeric](38, 0) NULL,
	[P_Weft] [numeric](38, 0) NULL,
	[P_Unit_Day] [numeric](18, 0) NULL,
	[P_Unit_Night] [numeric](18, 0) NULL,
	[P_Date] [datetime] NULL,
	[P_Description] [nvarchar](40) NULL,
	[P_Status] [nvarchar](40) NULL,
	[PD_ID] [int] NOT NULL,
	[F_ID] [int] NOT NULL,
	[S_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Production_Department]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production_Department](
	[PD_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_ID] [int] NULL,
	[PD_Fname] [nvarchar](30) NULL,
	[PD_Lname] [nvarchar](30) NULL,
	[PD_CNIC] [nvarchar](16) NOT NULL,
	[PD_DOB] [datetime] NULL,
	[PD_Email] [nvarchar](16) NULL,
	[PD_Address] [nvarchar](30) NULL,
	[PD_Contact] [nvarchar](30) NULL,
	[PD_Description] [nvarchar](30) NULL,
	[PD_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[PD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sizing]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizing](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_Company_name] [nvarchar](40) NULL,
	[S_Date_Sent] [datetime] NULL,
	[S_Date_Received] [datetime] NULL,
	[S_Payment] [money] NULL,
	[S_Description] [nvarchar](40) NULL,
	[S_Status] [nvarchar](40) NULL,
	[SDt_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sizing_Department]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizing_Department](
	[SDt_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_ID] [int] NULL,
	[SD_ID] [int] NULL,
	[SDt_Fname] [nvarchar](40) NULL,
	[SDt_Lname] [nvarchar](40) NULL,
	[SDt_Description] [nvarchar](40) NULL,
	[SDt_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[SDt_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sizing_Detail]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizing_Detail](
	[SD_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_ID] [int] NULL,
	[SD_Yarn_Brand] [nvarchar](max) NULL,
	[SD_Quality] [nvarchar](50) NULL,
	[SD_Quantity] [numeric](18, 0) NULL,
	[SD_no_Beams] [numeric](18, 0) NULL,
	[SD_Cutcones] [numeric](18, 0) NULL,
	[SD_no_bags] [numeric](18, 0) NULL,
	[SD_Description] [nvarchar](40) NULL,
	[SD_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sizing_Transport]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizing_Transport](
	[ST_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_ID] [int] NULL,
	[T_ID] [int] NULL,
	[ST_Description] [nvarchar](40) NULL,
	[ST_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sizing_Yarn]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizing_Yarn](
	[SY_ID] [int] IDENTITY(1,1) NOT NULL,
	[Y_ID] [int] NOT NULL,
	[S_ID] [int] NOT NULL,
	[FS_ID] [int] NULL,
	[SY_Quality] [nvarchar](50) NULL,
	[SY_Description] [nvarchar](30) NULL,
	[SY_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transport]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transport](
	[T_ID] [int] IDENTITY(1,1) NOT NULL,
	[CL_ID] [int] NOT NULL,
	[M_ID] [int] NOT NULL,
	[T_Date] [datetime] NULL,
	[T_Description] [nvarchar](40) NULL,
	[T_Status] [nvarchar](40) NULL,
	[TD_ID] [int] NOT NULL,
	[ST_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transport_Department]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transport_Department](
	[TD_ID] [int] IDENTITY(1,1) NOT NULL,
	[TD_Fname] [nvarchar](40) NULL,
	[TD_Lname] [nvarchar](40) NULL,
	[TD_CNIC] [nvarchar](16) NOT NULL,
	[TD_Email] [nvarchar](16) NULL,
	[TD_Address] [nvarchar](30) NULL,
	[TD_Contact] [nvarchar](30) NULL,
	[TD_Description] [nvarchar](30) NULL,
	[TD_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[TD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transport_Detail]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transport_Detail](
	[TD_ID] [int] IDENTITY(1,1) NOT NULL,
	[T_ID] [int] NULL,
	[TD_Quantity] [numeric](38, 0) NULL,
	[CL_ID] [int] NULL,
	[TD_Quality] [nvarchar](40) NULL,
	[TD_Status] [nvarchar](40) NULL,
	[Y_ID] [int] NULL,
	[B_ID] [int] NULL,
	[TD_Description] [nvarchar](40) NULL,
	[C_ID] [int] NULL,
	[CLo_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transporting_Factory]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transporting_Factory](
	[TF_ID] [int] IDENTITY(1,1) NOT NULL,
	[T_ID] [int] NULL,
	[FS_ID] [int] NULL,
	[TF_Discription] [nvarchar](max) NULL,
	[TF_status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[TF_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yarn]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yarn](
	[Y_ID] [int] IDENTITY(1,1) NOT NULL,
	[C_Quality] [nvarchar](50) NULL,
	[C_Quantity] [nvarchar](50) NULL,
	[C_No_Bags] [numeric](38, 0) NULL,
	[Y_Description] [nvarchar](40) NULL,
	[Y_Status] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Y_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yarn_FactoryStore]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yarn_FactoryStore](
	[YFS_ID] [int] IDENTITY(1,1) NOT NULL,
	[YFS_status] [nvarchar](40) NULL,
	[Y_ID] [int] NULL,
	[FS_ID] [int] NULL,
	[YFS_Description] [nvarchar](max) NULL,
	[YFS_DATE] [datetime] NULL,
	[YFS_Quantity] [numeric](38, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[YFS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yarn_Production]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yarn_Production](
	[YP_ID] [int] IDENTITY(1,1) NOT NULL,
	[Y_ID] [int] NOT NULL,
	[P_ID] [int] NOT NULL,
	[YP_Date] [datetime] NULL,
	[YP_Description] [nvarchar](50) NULL,
	[YP_Quantity] [decimal](18, 0) NULL,
	[YP_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[YP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yarn_Transport]    Script Date: 5/16/2015 7:41:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yarn_Transport](
	[TY_ID] [int] IDENTITY(1,1) NOT NULL,
	[Y_ID] [int] NULL,
	[T_ID] [int] NULL,
	[TY_Quality] [nvarchar](30) NULL,
	[TY_Dispatch_Date] [datetime] NOT NULL,
	[TY_Description] [nvarchar](30) NULL,
	[TY_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[TY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Client__BFBD3ED7EB68092C]    Script Date: 5/16/2015 7:41:59 PM ******/
ALTER TABLE [dbo].[Client] ADD UNIQUE NONCLUSTERED 
(
	[CL_CNIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Driver__D070702322AA19E0]    Script Date: 5/16/2015 7:41:59 PM ******/
ALTER TABLE [dbo].[Driver] ADD UNIQUE NONCLUSTERED 
(
	[D_CNIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Folding___AD04AE44C7FEEEB7]    Script Date: 5/16/2015 7:41:59 PM ******/
ALTER TABLE [dbo].[Folding_Department] ADD UNIQUE NONCLUSTERED 
(
	[FD_CNIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Producti__DC0701F319C599DC]    Script Date: 5/16/2015 7:41:59 PM ******/
ALTER TABLE [dbo].[Production_Department] ADD UNIQUE NONCLUSTERED 
(
	[PD_CNIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Transpor__67C0379338B11271]    Script Date: 5/16/2015 7:41:59 PM ******/
ALTER TABLE [dbo].[Transport_Department] ADD UNIQUE NONCLUSTERED 
(
	[TD_CNIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contract] ADD  DEFAULT (getdate()) FOR [C_Date]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT (getdate()) FOR [In_Date]
GO
ALTER TABLE [dbo].[Manager] ADD  DEFAULT (getdate()) FOR [M_Hire_Date]
GO
ALTER TABLE [dbo].[Packing_List] ADD  DEFAULT (getdate()) FOR [PL_Date]
GO
ALTER TABLE [dbo].[Payment] ADD  DEFAULT (getdate()) FOR [Pay_Date]
GO
ALTER TABLE [dbo].[Production] ADD  DEFAULT (getdate()) FOR [P_Date]
GO
ALTER TABLE [dbo].[Sizing] ADD  DEFAULT (getdate()) FOR [S_Date_Sent]
GO
ALTER TABLE [dbo].[Sizing] ADD  DEFAULT (getdate()) FOR [S_Date_Received]
GO
ALTER TABLE [dbo].[Transport] ADD  DEFAULT (getdate()) FOR [T_Date]
GO
ALTER TABLE [dbo].[Yarn_FactoryStore] ADD  DEFAULT (getdate()) FOR [YFS_DATE]
GO
ALTER TABLE [dbo].[Yarn_Production] ADD  DEFAULT (getdate()) FOR [YP_Date]
GO
ALTER TABLE [dbo].[Client_Transport]  WITH CHECK ADD  CONSTRAINT [fk_Client_Transport] FOREIGN KEY([CL_ID])
REFERENCES [dbo].[Client] ([CL_ID])
GO
ALTER TABLE [dbo].[Client_Transport] CHECK CONSTRAINT [fk_Client_Transport]
GO
ALTER TABLE [dbo].[Client_Transport]  WITH CHECK ADD  CONSTRAINT [fk_Client_Transport_T_ID] FOREIGN KEY([T_ID])
REFERENCES [dbo].[Transport] ([T_ID])
GO
ALTER TABLE [dbo].[Client_Transport] CHECK CONSTRAINT [fk_Client_Transport_T_ID]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [fk_Contract_Cl_ID] FOREIGN KEY([CL_ID])
REFERENCES [dbo].[Client] ([CL_ID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [fk_Contract_Cl_ID]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [fk_Contract_M_ID] FOREIGN KEY([M_ID])
REFERENCES [dbo].[Manager] ([M_ID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [fk_Contract_M_ID]
GO
ALTER TABLE [dbo].[Factory_Store]  WITH CHECK ADD  CONSTRAINT [fk_FactoryStore_TD_ID] FOREIGN KEY([TD_ID])
REFERENCES [dbo].[Transport_Detail] ([TD_ID])
GO
ALTER TABLE [dbo].[Factory_Store] CHECK CONSTRAINT [fk_FactoryStore_TD_ID]
GO
ALTER TABLE [dbo].[Folding]  WITH CHECK ADD  CONSTRAINT [fk_Folding_FD_ID] FOREIGN KEY([FD_ID])
REFERENCES [dbo].[Folding_Department] ([FD_ID])
GO
ALTER TABLE [dbo].[Folding] CHECK CONSTRAINT [fk_Folding_FD_ID]
GO
ALTER TABLE [dbo].[Folding_Detail]  WITH CHECK ADD  CONSTRAINT [fk_Folding_Detail_F_ID] FOREIGN KEY([F_ID])
REFERENCES [dbo].[Folding] ([F_ID])
GO
ALTER TABLE [dbo].[Folding_Detail] CHECK CONSTRAINT [fk_Folding_Detail_F_ID]
GO
ALTER TABLE [dbo].[Folding_Detail]  WITH CHECK ADD  CONSTRAINT [fk_Folding_Detail_FS_ID] FOREIGN KEY([FS_ID])
REFERENCES [dbo].[Factory_Store] ([FS_ID])
GO
ALTER TABLE [dbo].[Folding_Detail] CHECK CONSTRAINT [fk_Folding_Detail_FS_ID]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [fk_Invoice_Cl_ID] FOREIGN KEY([Cl_ID])
REFERENCES [dbo].[Client] ([CL_ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [fk_Invoice_Cl_ID]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [fk_Invoice_M_ID] FOREIGN KEY([M_ID])
REFERENCES [dbo].[Manager] ([M_ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [fk_Invoice_M_ID]
GO
ALTER TABLE [dbo].[Packing_Cloth]  WITH CHECK ADD  CONSTRAINT [fk_Packing_Cloth_Clo_ID] FOREIGN KEY([Clo_ID])
REFERENCES [dbo].[Cloth] ([Clo_ID])
GO
ALTER TABLE [dbo].[Packing_Cloth] CHECK CONSTRAINT [fk_Packing_Cloth_Clo_ID]
GO
ALTER TABLE [dbo].[Packing_Cloth]  WITH CHECK ADD  CONSTRAINT [fk_Packing_Cloth_Pl_ID] FOREIGN KEY([PL_ID])
REFERENCES [dbo].[Packing_List] ([PL_ID])
GO
ALTER TABLE [dbo].[Packing_Cloth] CHECK CONSTRAINT [fk_Packing_Cloth_Pl_ID]
GO
ALTER TABLE [dbo].[Packing_List]  WITH CHECK ADD  CONSTRAINT [fk_Packinglist_Cl_ID] FOREIGN KEY([CL_ID])
REFERENCES [dbo].[Client] ([CL_ID])
GO
ALTER TABLE [dbo].[Packing_List] CHECK CONSTRAINT [fk_Packinglist_Cl_ID]
GO
ALTER TABLE [dbo].[Packing_List]  WITH CHECK ADD  CONSTRAINT [fk_Packinglist_M_ID] FOREIGN KEY([M_ID])
REFERENCES [dbo].[Manager] ([M_ID])
GO
ALTER TABLE [dbo].[Packing_List] CHECK CONSTRAINT [fk_Packinglist_M_ID]
GO
ALTER TABLE [dbo].[Pro_Cloth]  WITH CHECK ADD  CONSTRAINT [fk_Pro_Cloth_Clo_ID] FOREIGN KEY([CLo_ID])
REFERENCES [dbo].[Cloth] ([Clo_ID])
GO
ALTER TABLE [dbo].[Pro_Cloth] CHECK CONSTRAINT [fk_Pro_Cloth_Clo_ID]
GO
ALTER TABLE [dbo].[Pro_Cloth]  WITH CHECK ADD  CONSTRAINT [fk_Pro_Cloth_P_ID] FOREIGN KEY([P_ID])
REFERENCES [dbo].[Production] ([P_ID])
GO
ALTER TABLE [dbo].[Pro_Cloth] CHECK CONSTRAINT [fk_Pro_Cloth_P_ID]
GO
ALTER TABLE [dbo].[Production]  WITH CHECK ADD  CONSTRAINT [fk_Production_F_ID] FOREIGN KEY([F_ID])
REFERENCES [dbo].[Folding] ([F_ID])
GO
ALTER TABLE [dbo].[Production] CHECK CONSTRAINT [fk_Production_F_ID]
GO
ALTER TABLE [dbo].[Production]  WITH CHECK ADD  CONSTRAINT [fk_Production_M_ID] FOREIGN KEY([M_ID])
REFERENCES [dbo].[Manager] ([M_ID])
GO
ALTER TABLE [dbo].[Production] CHECK CONSTRAINT [fk_Production_M_ID]
GO
ALTER TABLE [dbo].[Production]  WITH CHECK ADD  CONSTRAINT [fk_Production_PD_ID] FOREIGN KEY([PD_ID])
REFERENCES [dbo].[Production_Department] ([PD_ID])
GO
ALTER TABLE [dbo].[Production] CHECK CONSTRAINT [fk_Production_PD_ID]
GO
ALTER TABLE [dbo].[Production]  WITH CHECK ADD  CONSTRAINT [fk_Production_S_ID] FOREIGN KEY([S_ID])
REFERENCES [dbo].[Sizing] ([S_ID])
GO
ALTER TABLE [dbo].[Production] CHECK CONSTRAINT [fk_Production_S_ID]
GO
ALTER TABLE [dbo].[Sizing]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Department1_ID] FOREIGN KEY([SDt_ID])
REFERENCES [dbo].[Sizing_Department] ([SDt_ID])
GO
ALTER TABLE [dbo].[Sizing] CHECK CONSTRAINT [fk_Sizing_Department1_ID]
GO
ALTER TABLE [dbo].[Sizing_Department]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Department_ID] FOREIGN KEY([S_ID])
REFERENCES [dbo].[Sizing] ([S_ID])
GO
ALTER TABLE [dbo].[Sizing_Department] CHECK CONSTRAINT [fk_Sizing_Department_ID]
GO
ALTER TABLE [dbo].[Sizing_Department]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Detail_ID] FOREIGN KEY([SD_ID])
REFERENCES [dbo].[Sizing_Detail] ([SD_ID])
GO
ALTER TABLE [dbo].[Sizing_Department] CHECK CONSTRAINT [fk_Sizing_Detail_ID]
GO
ALTER TABLE [dbo].[Sizing_Detail]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_ID] FOREIGN KEY([S_ID])
REFERENCES [dbo].[Sizing] ([S_ID])
GO
ALTER TABLE [dbo].[Sizing_Detail] CHECK CONSTRAINT [fk_Sizing_ID]
GO
ALTER TABLE [dbo].[Sizing_Transport]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Transport_ID] FOREIGN KEY([S_ID])
REFERENCES [dbo].[Sizing] ([S_ID])
GO
ALTER TABLE [dbo].[Sizing_Transport] CHECK CONSTRAINT [fk_Sizing_Transport_ID]
GO
ALTER TABLE [dbo].[Sizing_Transport]  WITH CHECK ADD  CONSTRAINT [fk_Transport_ID] FOREIGN KEY([T_ID])
REFERENCES [dbo].[Transport] ([T_ID])
GO
ALTER TABLE [dbo].[Sizing_Transport] CHECK CONSTRAINT [fk_Transport_ID]
GO
ALTER TABLE [dbo].[Sizing_Yarn]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Yarn_FS_ID] FOREIGN KEY([FS_ID])
REFERENCES [dbo].[Factory_Store] ([FS_ID])
GO
ALTER TABLE [dbo].[Sizing_Yarn] CHECK CONSTRAINT [fk_Sizing_Yarn_FS_ID]
GO
ALTER TABLE [dbo].[Sizing_Yarn]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Yarn_S_ID] FOREIGN KEY([S_ID])
REFERENCES [dbo].[Sizing] ([S_ID])
GO
ALTER TABLE [dbo].[Sizing_Yarn] CHECK CONSTRAINT [fk_Sizing_Yarn_S_ID]
GO
ALTER TABLE [dbo].[Sizing_Yarn]  WITH CHECK ADD  CONSTRAINT [fk_Sizing_Yarn_Y_ID] FOREIGN KEY([Y_ID])
REFERENCES [dbo].[Yarn] ([Y_ID])
GO
ALTER TABLE [dbo].[Sizing_Yarn] CHECK CONSTRAINT [fk_Sizing_Yarn_Y_ID]
GO
ALTER TABLE [dbo].[Transport]  WITH CHECK ADD  CONSTRAINT [fk_Transport_Cl_ID] FOREIGN KEY([CL_ID])
REFERENCES [dbo].[Client] ([CL_ID])
GO
ALTER TABLE [dbo].[Transport] CHECK CONSTRAINT [fk_Transport_Cl_ID]
GO
ALTER TABLE [dbo].[Transport]  WITH CHECK ADD  CONSTRAINT [fk_Transport_M_ID] FOREIGN KEY([M_ID])
REFERENCES [dbo].[Manager] ([M_ID])
GO
ALTER TABLE [dbo].[Transport] CHECK CONSTRAINT [fk_Transport_M_ID]
GO
ALTER TABLE [dbo].[Transport]  WITH CHECK ADD  CONSTRAINT [fk_Transport_ST_ID] FOREIGN KEY([ST_ID])
REFERENCES [dbo].[Sizing_Transport] ([ST_ID])
GO
ALTER TABLE [dbo].[Transport] CHECK CONSTRAINT [fk_Transport_ST_ID]
GO
ALTER TABLE [dbo].[Transport]  WITH CHECK ADD  CONSTRAINT [fk_Transport_TD_ID] FOREIGN KEY([TD_ID])
REFERENCES [dbo].[Transport_Department] ([TD_ID])
GO
ALTER TABLE [dbo].[Transport] CHECK CONSTRAINT [fk_Transport_TD_ID]
GO
ALTER TABLE [dbo].[Transport_Detail]  WITH CHECK ADD  CONSTRAINT [fk_Transport_Detail_B_ID] FOREIGN KEY([B_ID])
REFERENCES [dbo].[Beam] ([B_ID])
GO
ALTER TABLE [dbo].[Transport_Detail] CHECK CONSTRAINT [fk_Transport_Detail_B_ID]
GO
ALTER TABLE [dbo].[Transport_Detail]  WITH CHECK ADD  CONSTRAINT [fk_Transport_Detail_T_ID] FOREIGN KEY([T_ID])
REFERENCES [dbo].[Transport] ([T_ID])
GO
ALTER TABLE [dbo].[Transport_Detail] CHECK CONSTRAINT [fk_Transport_Detail_T_ID]
GO
ALTER TABLE [dbo].[Transport_Detail]  WITH CHECK ADD  CONSTRAINT [fk_Transport_Detail_Y_ID] FOREIGN KEY([Y_ID])
REFERENCES [dbo].[Yarn] ([Y_ID])
GO
ALTER TABLE [dbo].[Transport_Detail] CHECK CONSTRAINT [fk_Transport_Detail_Y_ID]
GO
ALTER TABLE [dbo].[Transport_Detail]  WITH CHECK ADD  CONSTRAINT [Transport_Detail_CLo_ID] FOREIGN KEY([CLo_ID])
REFERENCES [dbo].[Cloth] ([Clo_ID])
GO
ALTER TABLE [dbo].[Transport_Detail] CHECK CONSTRAINT [Transport_Detail_CLo_ID]
GO
ALTER TABLE [dbo].[Transporting_Factory]  WITH CHECK ADD  CONSTRAINT [fk_Transport_Factory_FS_ID] FOREIGN KEY([FS_ID])
REFERENCES [dbo].[Factory_Store] ([FS_ID])
GO
ALTER TABLE [dbo].[Transporting_Factory] CHECK CONSTRAINT [fk_Transport_Factory_FS_ID]
GO
ALTER TABLE [dbo].[Transporting_Factory]  WITH CHECK ADD  CONSTRAINT [fk_Transport_Factory_T_ID] FOREIGN KEY([T_ID])
REFERENCES [dbo].[Transport] ([T_ID])
GO
ALTER TABLE [dbo].[Transporting_Factory] CHECK CONSTRAINT [fk_Transport_Factory_T_ID]
GO
ALTER TABLE [dbo].[Yarn_FactoryStore]  WITH CHECK ADD  CONSTRAINT [fk_Yarn_FactoryStore_FS_ID] FOREIGN KEY([FS_ID])
REFERENCES [dbo].[Factory_Store] ([FS_ID])
GO
ALTER TABLE [dbo].[Yarn_FactoryStore] CHECK CONSTRAINT [fk_Yarn_FactoryStore_FS_ID]
GO
ALTER TABLE [dbo].[Yarn_FactoryStore]  WITH CHECK ADD  CONSTRAINT [fk_Yarn_FactoryStore_Y_ID] FOREIGN KEY([Y_ID])
REFERENCES [dbo].[Yarn] ([Y_ID])
GO
ALTER TABLE [dbo].[Yarn_FactoryStore] CHECK CONSTRAINT [fk_Yarn_FactoryStore_Y_ID]
GO
ALTER TABLE [dbo].[Yarn_Production]  WITH CHECK ADD  CONSTRAINT [fk_Yarn_Production_P_ID] FOREIGN KEY([P_ID])
REFERENCES [dbo].[Production] ([P_ID])
GO
ALTER TABLE [dbo].[Yarn_Production] CHECK CONSTRAINT [fk_Yarn_Production_P_ID]
GO
ALTER TABLE [dbo].[Yarn_Production]  WITH CHECK ADD  CONSTRAINT [fk_Yarn_Production_Y_ID] FOREIGN KEY([Y_ID])
REFERENCES [dbo].[Yarn] ([Y_ID])
GO
ALTER TABLE [dbo].[Yarn_Production] CHECK CONSTRAINT [fk_Yarn_Production_Y_ID]
GO
ALTER TABLE [dbo].[Yarn_Transport]  WITH CHECK ADD  CONSTRAINT [fk_Yarn_Transport_T_ID] FOREIGN KEY([T_ID])
REFERENCES [dbo].[Transport] ([T_ID])
GO
ALTER TABLE [dbo].[Yarn_Transport] CHECK CONSTRAINT [fk_Yarn_Transport_T_ID]
GO
ALTER TABLE [dbo].[Yarn_Transport]  WITH CHECK ADD  CONSTRAINT [fk_Yarn_Transport_Y_ID] FOREIGN KEY([Y_ID])
REFERENCES [dbo].[Yarn] ([Y_ID])
GO
ALTER TABLE [dbo].[Yarn_Transport] CHECK CONSTRAINT [fk_Yarn_Transport_Y_ID]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD CHECK  (([CL_CNIC] like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[Driver]  WITH CHECK ADD CHECK  (([D_CNIC] like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[Folding_Department]  WITH CHECK ADD CHECK  (([FD_CNIC] like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD CHECK  (([M_CNIC] like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[Production_Department]  WITH CHECK ADD CHECK  (([PD_CNIC] like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[Transport_Department]  WITH CHECK ADD CHECK  (([TD_CNIC] like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
USE [master]
GO
ALTER DATABASE [WIM] SET  READ_WRITE 
GO

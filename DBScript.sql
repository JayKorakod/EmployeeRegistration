USE [master]
GO
/****** Object:  Database [EFDB]    Script Date: 6/2/2563 2:23:11 ******/
CREATE DATABASE [EFDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EFDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EFDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EFDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EFDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EFDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EFDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EFDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EFDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EFDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EFDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EFDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EFDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EFDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EFDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EFDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EFDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EFDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EFDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EFDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EFDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EFDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EFDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EFDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EFDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EFDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EFDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EFDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EFDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EFDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EFDB] SET  MULTI_USER 
GO
ALTER DATABASE [EFDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EFDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EFDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EFDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EFDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EFDB] SET QUERY_STORE = OFF
GO
USE [EFDB]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 6/2/2563 2:23:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Tel] [varchar](11) NULL,
	[Department] [varchar](50) NULL,
	[Section] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Subdistrict] [varchar](50) NULL,
	[District] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[Postalcode] [varchar](6) NULL,
	[School] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [Firstname], [Lastname], [Tel], [Department], [Section], [Address], [Subdistrict], [District], [Province], [Postalcode], [School]) VALUES (1, N'Korakod', N'Kaisrikosol', N'0877777777', N'HR', N'HR Manager', N'11 Phet Kasem92/2', N'Bang Khae', N'Bang Khae Nuea', N'Bangkok', N'10166', N'KMUTNB')
INSERT [dbo].[Employee] ([EmployeeID], [Firstname], [Lastname], [Tel], [Department], [Section], [Address], [Subdistrict], [District], [Province], [Postalcode], [School]) VALUES (2, N'Piyapat', N'Jaras', N'084784562', N'Marketing', N'Marketing Manager', N'66', N'Bang Rak', N'Bang Yai', N'Phuket', N'10580', N'CU')
INSERT [dbo].[Employee] ([EmployeeID], [Firstname], [Lastname], [Tel], [Department], [Section], [Address], [Subdistrict], [District], [Province], [Postalcode], [School]) VALUES (4, N'Nawat', N'Sirisekema', N'026666666', N'Finace', N'Finace Manager', N'10', N'Subpaolo', N'German', N'Mancity', N'12000', N'KMUTT')
SET IDENTITY_INSERT [dbo].[Employee] OFF
USE [master]
GO
ALTER DATABASE [EFDB] SET  READ_WRITE 
GO

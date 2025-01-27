USE [master]
GO
/****** Object:  Database [SADM_14]    Script Date: 24/01/2025 00:28:27 ******/
CREATE DATABASE [SADM_14]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SADM_14', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SADM_14.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SADM_14_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SADM_14_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SADM_14] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SADM_14].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SADM_14] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SADM_14] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SADM_14] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SADM_14] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SADM_14] SET ARITHABORT OFF 
GO
ALTER DATABASE [SADM_14] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SADM_14] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SADM_14] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SADM_14] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SADM_14] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SADM_14] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SADM_14] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SADM_14] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SADM_14] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SADM_14] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SADM_14] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SADM_14] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SADM_14] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SADM_14] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SADM_14] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SADM_14] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SADM_14] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SADM_14] SET RECOVERY FULL 
GO
ALTER DATABASE [SADM_14] SET  MULTI_USER 
GO
ALTER DATABASE [SADM_14] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SADM_14] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SADM_14] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SADM_14] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SADM_14] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SADM_14] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SADM_14] SET QUERY_STORE = OFF
GO
USE [SADM_14]
GO
/****** Object:  User [bgu-users\romim]    Script Date: 24/01/2025 00:28:27 ******/
CREATE USER [bgu-users\romim] FOR LOGIN [bgu-users\romim] WITH DEFAULT_SCHEMA=[bgu-users\romim]
GO
/****** Object:  User [bgu-users\leahros]    Script Date: 24/01/2025 00:28:27 ******/
CREATE USER [bgu-users\leahros] FOR LOGIN [bgu-users\leahros] WITH DEFAULT_SCHEMA=[bgu-users\leahros]
GO
/****** Object:  User [bgu-users\edenq]    Script Date: 24/01/2025 00:28:27 ******/
CREATE USER [bgu-users\edenq] FOR LOGIN [bgu-users\edenq] WITH DEFAULT_SCHEMA=[bgu-users\edenq]
GO
ALTER ROLE [db_owner] ADD MEMBER [bgu-users\romim]
GO
ALTER ROLE [db_owner] ADD MEMBER [bgu-users\leahros]
GO
ALTER ROLE [db_owner] ADD MEMBER [bgu-users\edenq]
GO
/****** Object:  Schema [bgu-users\edenq]    Script Date: 24/01/2025 00:28:27 ******/
CREATE SCHEMA [bgu-users\edenq]
GO
/****** Object:  Schema [bgu-users\leahros]    Script Date: 24/01/2025 00:28:27 ******/
CREATE SCHEMA [bgu-users\leahros]
GO
/****** Object:  Schema [bgu-users\romim]    Script Date: 24/01/2025 00:28:27 ******/
CREATE SCHEMA [bgu-users\romim]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[answer] [int] NULL,
	[questionNumber] [int] NOT NULL,
	[survey] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED 
(
	[questionNumber] ASC,
	[survey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArchivedClerks]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArchivedClerks](
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[id] [varchar](50) NOT NULL,
	[phoneNumber] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idCopy] [varchar](50) NULL,
	[performanceStatus] [varchar](50) NULL,
 CONSTRAINT [pk_archivedclerks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArchivedDrivers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArchivedDrivers](
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[id] [varchar](50) NOT NULL,
	[phoneNumber] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idCopy] [varchar](50) NULL,
	[licenseCopy] [varchar](50) NULL,
	[licenseId] [varchar](50) NULL,
	[performanceStatus] [varchar](50) NULL,
	[vehicle] [varchar](50) NULL,
 CONSTRAINT [pk_archiveddrivers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArchivedOrders]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArchivedOrders](
	[id] [varchar](50) NOT NULL,
	[customerName] [varchar](100) NULL,
	[customerPhoneNumber] [varchar](100) NULL,
	[customerEmail] [varchar](100) NULL,
	[startDate] [datetime] NULL,
	[departure] [varchar](100) NULL,
	[destination] [varchar](100) NULL,
	[cargoType] [varchar](50) NULL,
	[estimatedFinishDate] [datetime] NULL,
	[orderStatus] [varchar](50) NULL,
	[driver] [varchar](50) NULL,
	[clerk] [varchar](50) NULL,
	[profit] [money] NULL,
	[vehicleType] [varchar](50) NULL,
	[totalWeight] [int] NULL,
 CONSTRAINT [pk_archivedorders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CargoType]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CargoType](
	[cargoName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cargoName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clerks]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clerks](
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[id] [varchar](50) NOT NULL,
	[phoneNumber] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idCopy] [nvarchar](100) NULL,
	[performanceStatus] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[id] [varchar](50) NOT NULL,
	[phoneNumber] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idCopy] [nvarchar](100) NULL,
	[licenseCopy] [varchar](255) NULL,
	[licenseId] [varchar](50) NULL,
	[performanceStatus] [varchar](50) NULL,
	[vehicle] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeMonthlyEvaluation]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeMonthlyEvaluation](
	[personalNote] [varchar](1000) NULL,
	[associatedMonth] [int] NOT NULL,
	[submissionDate] [datetime] NULL,
	[year] [int] NOT NULL,
	[EmployeeId] [varchar](50) NOT NULL,
	[score] [float] NULL,
 CONSTRAINT [PK_EmployeeMonthlyEvaluation] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC,
	[year] ASC,
	[associatedMonth] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OfficeManagers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfficeManagers](
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[id] [varchar](50) NOT NULL,
	[phoneNumber] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idCopy] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationalManagers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationalManagers](
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[id] [varchar](50) NOT NULL,
	[phoneNumber] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idCopy] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [varchar](50) NOT NULL,
	[customerName] [varchar](50) NULL,
	[customerPhoneNumber] [varchar](50) NULL,
	[customerEmail] [varchar](50) NULL,
	[startDate] [datetime] NULL,
	[departure] [varchar](50) NULL,
	[destination] [varchar](50) NULL,
	[cargoType] [varchar](50) NULL,
	[estimatedFinishDate] [datetime] NULL,
	[orderStatus] [varchar](50) NULL,
	[driver] [varchar](50) NULL,
	[clerk] [varchar](50) NULL,
	[profit] [money] NULL,
	[vehicleType] [varchar](50) NULL,
	[totalWeight] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatuses](
	[statusName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[statusName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[performanceStatuses]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[performanceStatuses](
	[statusName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[statusName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[questionNumber] [int] NOT NULL,
	[description] [varchar](150) NULL,
	[associatedRole] [bit] NULL,
	[hide] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[questionNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[roleName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[roleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Surveys]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Surveys](
	[headline] [varchar](50) NOT NULL,
	[completed] [bit] NULL,
	[order] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[headline] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleCondition]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleCondition](
	[conditionName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[conditionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[id] [varchar](50) NOT NULL,
	[type] [varchar](50) NULL,
	[maxCapacity] [float] NULL,
	[testDate] [date] NULL,
	[condition] [varchar](50) NULL,
	[cargoType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleType]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleType](
	[typeName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[typeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 1, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 1, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 1, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 1, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 1, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 1, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 1, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 2, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 2, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 2, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 2, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 2, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 2, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 2, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 3, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 3, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 3, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 3, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 3, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 3, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 3, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 4, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 4, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 4, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 4, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 4, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 4, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 4, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 5, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 5, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 5, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 5, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 5, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 5, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 5, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 6, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 6, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 6, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 6, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 6, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 6, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 6, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 7, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 7, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 7, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 7, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 7, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 7, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 7, N'Customer Service Survey for Order Number 987654')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 8, N'Customer Service Survey for Order Number 112233')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 8, N'Customer Service Survey for Order Number 123456')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (1, 8, N'Customer Service Survey for Order Number 345678')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (3, 8, N'Customer Service Survey for Order Number 445566')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (4, 8, N'Customer Service Survey for Order Number 654321')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (5, 8, N'Customer Service Survey for Order Number 789012')
INSERT [dbo].[Answers] ([answer], [questionNumber], [survey]) VALUES (2, 8, N'Customer Service Survey for Order Number 987654')
GO
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Yael', N'Peretz', N'111222333', N'541112223', N'yaelperetz@gmail.com', N'10 Arlozorov St, Ashdod', N'yaelper', N'Yael@123', N'C:\Documents\ID138.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Noa', N'Levi', N'123123123', N'501234567', N'noalevi@gmail.com', N'15 HaPalmach St, Be''er Sheva', N'noalevi', N'NoaPass2025', N'C:\Documents\ID135.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Adam', N'Green', N'123456789', N'541234567', N'adam.green@gmail.com', N'1 Main St, Tel Aviv', N'adamgreen', N'AdamPass2025', N'C:\Documents\ID400.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Eli', N'Dror', N'444555666', N'524445556', N'elidror@gmail.com', N'20 Rothschild Blvd, Tel Aviv', N'elid', N'SecureEli2024', N'C:\Documents\ID139.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Daniel', N'Levy', N'456789123', N'504567891', N'daniel.levy@gmail.com', N'33 HaNegev St, Be''er Sheva', N'daniell', N'LevyPass2023', N'C:\Documents\ID402.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Tomer', N'Baruch', N'555666777', N'535556667', N'tomerbaruch@outlook.com', N'33 HaNegev St, Rishon LeZion', N'tomerb', N'Tomer$ecure', N'C:\Documents\ID137.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Maya', N'Bar', N'789123456', N'537891234', N'maya.bar@outlook.com', N'7 Bialik St, Ramat Gan', N'mayab', N'Maya@Secure', N'C:\Documents\ID403.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Sarah', N'Cohen', N'987654321', N'529876543', N'sarah.cohen@yahoo.com', N'12 Herzl St, Haifa', N'sarahc', N'Sarah@2024', N'C:\Documents\ID401.png', N'archived')
INSERT [dbo].[ArchivedClerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Itay', N'Sharon', N'987987987', N'529876543', N'itay.sharon@yahoo.com', N'42 Begin St, Holon', N'itaysh', N'Password789', N'C:\Documents\ID136.png', N'archived')
GO
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Kevin', N'Lopez', N'40890123', N'0508221098', N'kevinlopez@example.com', N'56 Oak Avenue', N'kevinlopez', N'password408', N'C:\Documents\ID408.pdf', N'C:\Documents\Lic408.pdf', N'40890123', N'archived', N'35122638')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Olivia', N'Johnson', N'41123456', N'0501234567', N'oliviajohnson@example.com', N'123 Aspen Street', N'oliviajohnson', N'password411', N'C:\Documents\ID411.pdf', N'C:\Documents\Lic411.pdf', N'41123456', N'archived', N'10000005')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Liam', N'Brown', N'41456789', N'0504567890', N'liambrown@example.com', N'1010 Birch Blvd', N'liambrown', N'password414', N'C:\Documents\ID414.pdf', N'C:\Documents\Lic414.pdf', N'41456789', N'archived', N'10000009')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Liam', N'Evans', N'500123456', N'0501112223', N'liamevans@example.com', N'21 Cherry Lane', N'liamevans', N'securepass500', N'C:\Documents\ID500.pdf', N'C:\Documents\Lic500.pdf', N'5678901', N'archived', N'35122638')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Olivia', N'Moore', N'501234567', N'0501234567', N'oliviamoore@example.com', N'34 Oakwood Avenue', N'oliviamoore', N'securepass501', N'C:\Documents\ID501.pdf', N'C:\Documents\Lic501.pdf', N'6789012', N'archived', N'30091031')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Benjamin', N'Taylor', N'502345678', N'0502345678', N'benjamintaylor@example.com', N'789 Sycamore Drive', N'benjamintaylor', N'securepass502', N'C:\Documents\ID502.pdf', N'C:\Documents\Lic502.pdf', N'7890123', N'archived', N'30005003')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Charlotte', N'Anderson', N'503456789', N'0503456789', N'charlotteanderson@example.com', N'12 Forest Trail', N'charlotteanderson', N'securepass503', N'C:\Documents\ID503.pdf', N'C:\Documents\Lic503.pdf', N'8901234', N'archived', N'25960006')
INSERT [dbo].[ArchivedDrivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Elijah', N'Garcia', N'504567890', N'0504567890', N'elijahgarcia@example.com', N'55 Meadow Lane', N'elijahgarcia', N'securepass504', N'C:\Documents\ID504.pdf', N'C:\Documents\Lic504.pdf', N'9012345', N'archived', N'23317666')
GO
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'111111', N'eden', N'0546565999', N'eden@gmail.com', CAST(N'2025-01-21T00:00:00.000' AS DateTime), N'20 Yigal Alon St, Herzliya', N'35 Golan Heights Rd, Katzrin', N'hazardous', CAST(N'2025-01-30T00:00:00.000' AS DateTime), N'orderClosed', N'203567890', N'406777888', 60000.0000, N'crane', 124456)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'112233', N'Israel Electric Corporation', N'055-8899777', N'support@iec.co.il', CAST(N'2025-01-21T12:00:00.000' AS DateTime), N'19 HaNamal St, Ashdod', N'100 King George St, Jerusalem', N'electronic', CAST(N'2025-12-22T00:00:00.000' AS DateTime), N'orderClosed', N'200123456', N'403444555', 1000.0000, N'tow', 10000)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'123456', N'Rafael Advanced Defense Systems', N'054-1234567', N'rafael@defense.co.il', CAST(N'2025-01-21T08:00:00.000' AS DateTime), N'3 HaHoresh Rd, Emek Sara, Beersheba', N'12 Ashdod Port Rd, Ashdod', N'liquid', CAST(N'2025-05-05T00:00:00.000' AS DateTime), N'orderClosed', N'201234567', N'400111222', 2500.0000, N'tow', 9000)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'2222', N'amit', N'050452545', N'kdd@gmail', CAST(N'2025-01-22T00:00:00.000' AS DateTime), N'10 Rothschild Blvd, Tel Aviv', N'15 Herzl St, Tel Aviv', N'liquid', CAST(N'2025-01-30T00:00:00.000' AS DateTime), N'orderClosed', N'202345678', N'400111222', 200.3330, N'tow', 1000)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'345678', N'Elbit Systems Ltd.', N'053-4455667', N'info@elbitsystems.com', CAST(N'2024-12-07T06:45:00.000' AS DateTime), N'3 HaHoresh Rd, Emek Sara, Beersheba', N'50 Agron St, Jerusalem', N'construction', CAST(N'2024-12-08T20:15:00.000' AS DateTime), N'orderClosed', N'202345678', N'402333444', 1000.0000, N'crane', 6000)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'445566', N'Teva Pharmaceuticals', N'056-6677889', N'hr@teva.com', CAST(N'2024-12-13T14:30:00.000' AS DateTime), N'10 Begin Blvd, Petah Tikva', N'33 Haifa Port Blvd, Haifa', N'liquid', CAST(N'2024-12-14T16:45:00.000' AS DateTime), N'orderClosed', N'203567890', N'402333444', 3000.0000, N'tanker', 100)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'654321', N'Ministry of Defense', N'052-9876543', N'mod@security.gov', CAST(N'2024-12-03T09:00:00.000' AS DateTime), N'5 Kaplan St, Tel Aviv', N'45 HaTmarim Blvd, Eilat', N'hazardous', CAST(N'2024-12-04T18:00:00.000' AS DateTime), N'orderClosed', N'300987654', N'404555666', 3500.0000, N'trailer', 5000)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'789012', N'ZIM Integrated Shipping Services', N'050-1122334', N'contact@zim.com', CAST(N'2024-12-05T07:30:00.000' AS DateTime), N'15 HaTaAsiya St, Ashkelon', N'18 Port Blvd, Haifa', N'refrigerated', CAST(N'2024-12-06T19:45:00.000' AS DateTime), N'orderClosed', N'301234567', N'405666777', 2000.0000, N'tanker', 4500)
INSERT [dbo].[ArchivedOrders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'987654', N'Israeli Aerospace Industries', N'054-7766554', N'sales@iai.co.il', CAST(N'2024-12-09T10:15:00.000' AS DateTime), N'1 Herzl St, Nazareth', N'28 HaShalom Rd, Tiberias', N'electronic', CAST(N'2024-12-10T14:00:00.000' AS DateTime), N'orderClosed', N'302456789', N'406777888', 3000.0000, N'flatbed', 3000)
GO
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'')
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'agricultural')
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'construction')
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'electronic')
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'hazardous')
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'liquid')
INSERT [dbo].[CargoType] ([cargoName]) VALUES (N'refrigerated')
GO
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Anna', N'Levi', N'400111222', N'0543219876', N'annalevi@yahoo.com', N'12 Herzl St, Tel Aviv', N'annalevi', N'securePass123', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'assignedToOrder')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Daniel', N'Katz', N'401222333', N'0529871234', N'danielkatz@example.com', N'34 Ben Gurion Rd, Haifa', N'danielkatz', N'strongPass456', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'assignedToOrder')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Pam', N'beesly', N'401333551', N'0504236555', N'pamb@gmail.com', N'1725 Slough Ave, Scranton', N'Beesly', N'cici##phillip', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'assignedToOrder')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Noa', N'Cohen', N'402333444', N'0541237890', N'noacohen@example.com', N'45 Rothschild Blvd, Rishon', N'noacohen', N'clerkPass789', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'assignedToOrder')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Amit', N'Shwartz', N'403444555', N'0534567890', N'amitshwartz@example.com', N'67 Begin St, Ashdod', N'amitshwartz', N'uniquePass101', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'assignedToOrder')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Rina', N'Bar', N'404555666', N'0529876543', N'rinabar@example.com', N'89 Kaplan St, Beer Sheba', N'rinabar', N'safePass202', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'pendingForAssignment')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Yonatan', N'Eliyahu', N'405666777', N'0504432211', N'yonataneliyahu@example.com', N'23 HaNamal St, Acre', N'yonataneliyahu', N'strongPass303', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'pendingForAssignment')
INSERT [dbo].[Clerks] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [performanceStatus]) VALUES (N'Shira', N'Gold', N'406777888', N'0505544332', N'shiragold@example.com', N'12 HaPalmach St, Jerusalem', N'shiragold', N'secureClerk404', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'pendingForAssignment')
GO
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'John', N'Doe', N'200123456', N'0501234567', N'johndoe@example.com', N'123 Elm Street', N'johndoe', N'password123', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'1234567', N'assignedToOrder', N'10000004')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Mike', N'Johnson', N'201234567', N'0501122334', N'mikejohnson@example.com', N'789 Pine Street', N'mikejohnson', N'password789', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'2345678', N'assignedToOrder', N'40695005')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Chris', N'Brown', N'202345678', N'0505544332', N'chrisbrown@example.com', N'654 Cedar Street', N'chrisbrown', N'password654', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'3456789', N'assignedToOrder', N'30005003')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'David', N'Wilson', N'203567890', N'0504433221', N'romim@bgu.ac.il', N'159 Spruce Street', N'davidwilson', N'password159', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'4567890', N'assignedToOrder', N'35122738')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Jane', N'Smith', N'300987654', N'0509876543', N'janesmith@example.com', N'456 Oak Street', N'janesmith', N'password456', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'7654321', N'pendingForAssignment', N'20790002')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Emily', N'Davis', N'301234567', N'0506677889', N'emilydavis@example.com', N'321 Maple Street', N'emilydavis', N'password321', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'8765432', N'assignedToOrder', N'10569807')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Sarah', N'Taylor', N'302456789', N'0507766554', N'sarahtaylor@example.com', N'987 Birch Street', N'sarahtaylor', N'password987', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'9876543', N'assignedToOrder', N'10002301')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Linda', N'Harris', N'40123456', N'0508998765', N'lindaharris@example.com', N'47 Walnut Street', N'lindaharris', N'password401', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40123456', N'inoperative', N'47646540')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Mark', N'Walker', N'40234567', N'0509887654', N'markwalker@example.com', N'23 Pine Avenue', N'markwalker', N'password402', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40234567', N'underWarning', N'23317666')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Angela', N'Martinez', N'40345678', N'0508776543', N'angelamartinez@example.com', N'12 Spruce Lane', N'angelamartinez', N'password403', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40345678', N'underWarning', N'25960006')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Michael', N'Carter', N'40456789', N'0508665432', N'michaelcarter@example.com', N'89 Birch Road', N'michaelcarter', N'password404', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40456789', N'assignedToOrder', N'30091031')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Sophie', N'Perez', N'40567890', N'0508554321', N'sophieperez@example.com', N'66 Maple Street', N'sophieperez', N'password405', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40567890', N'underWarning', N'10000008')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Peter', N'Morris', N'40678901', N'0508443210', N'petermorris@example.com', N'11 Ash Lane', N'petermorris', N'password406', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40678901', N'underWarning', N'10569807')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Laura', N'Clark', N'40789012', N'0508332109', N'lauraclark@example.com', N'24 Willow Street', N'lauraclark', N'password407', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40789012', N'assignedToOrder', N'78939661')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Anna', N'Hall', N'40901234', N'0508110987', N'annahall@example.com', N'78 Chestnut Drive', N'annahall', N'password409', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'40901234', N'assignedToOrder', N'35122738')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Noah', N'Smith', N'41234567', N'0502345678', N'noahsmith@example.com', N'456 Willow Drive', N'noahsmith', N'password412', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'41234567', N'inoperative', N'10000006')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Emma', N'Williams', N'41345678', N'0503456789', N'emmawilliams@example.com', N'789 Cedar Lane', N'emmawilliams', N'password413', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'41345678', N'pendingForAssignment', N'10000007')
INSERT [dbo].[Drivers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy], [licenseCopy], [licenseId], [performanceStatus], [vehicle]) VALUES (N'Ava', N'Davis', N'41567890', N'0505678901', N'avadavis@example.com', N'2020 Maple Ave', N'avadavis', N'password415', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg?raw=true', N'41567890', N'pendingForHearingResults', N'10000010')
GO
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'John Doe has consistently demonstrated exceptional performance this month, earning a well-deserved rating of 4.3 out of 5. His contributions to the team have been invaluable, and his dedication to his work is commendable.', 12, CAST(N'2025-01-19T11:42:25.667' AS DateTime), 2024, N'200123456', 4.3)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'Mike successfully managed the delivery of cargo for the orders. The survey indicated mixed ratings, with customers praising his safe transportation practices but suggesting slight improvements in communication. Despite operational challenges, Mike maintained a high level of professionalism.', 12, CAST(N'2025-01-16T11:30:00.000' AS DateTime), 2024, N'201234567', 4.5)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'Chris Brown''s performance this month requires immediate attention. His customer survey score is 1 out of 5, indicating serious concerns regarding his professionalism, safe driving practices, timeliness, and communication skills.', 12, CAST(N'2025-01-23T22:40:07.620' AS DateTime), 2024, N'202345678', 1)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'David is a reliable team player. To further enhance his performance, I suggest focusing on improving his communication skills, particularly in providing proactive updates on project progress.', 12, CAST(N'2025-01-19T14:57:20.243' AS DateTime), 2024, N'203567890', 3)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'Jane displayed excellent communication skills while managing cargo for the orders. Survey feedback praised her politeness and ability to ensure safe transportation, which contributed to high customer satisfaction.', 12, CAST(N'2025-01-16T15:20:00.000' AS DateTime), 2024, N'300987654', 4)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'The survey results showcased high ratings for her politeness and effective communication. Her attention to detail during the cargo handling process was critical to maintaining the quality of goods.', 12, CAST(N'2025-01-16T16:10:00.000' AS DateTime), 2024, N'301234567', 4.75)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'Daniel has shown consistent performance, though some areas require improvement. The survey results highlighted mixed feedback on speed and response effectiveness. His proactive approach to addressing challenges contributed to order completion despite the customer’s concerns about service response times.', 12, CAST(N'2025-01-16T10:30:00.000' AS DateTime), 2024, N'401222333', 4.25)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'Survey results highlighted her ability to manage customer expectations and driver coordination effectively. Rina resolved key scheduling issues and maintained high service standards despite tight deadlines. Her proactive approach to addressing operational bottlenecks was appreciated.', 12, CAST(N'2025-01-16T16:20:00.000' AS DateTime), 2024, N'404555666', 3.75)
INSERT [dbo].[EmployeeMonthlyEvaluation] ([personalNote], [associatedMonth], [submissionDate], [year], [EmployeeId], [score]) VALUES (N'Survey feedback indicated strong ratings for safe transportation and driver professionalism, although there were slight delays in aligning schedules. Yonatan’s ability to navigate these challenges and maintain high customer satisfaction levels reflects his growing competency in coordination and communication.', 12, CAST(N'2025-01-16T17:10:00.000' AS DateTime), 2024, N'405666777', 4.75)
GO
INSERT [dbo].[OfficeManagers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy]) VALUES (N'Michael', N'Scott', N'162788204', N'0527384611', N'dundermifflin@gmail.com', N'1725 Slough Avenue, Scranton', N'WorldBestBoss', N'password', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/officeManagerIdCopy.jpg?raw=true')
GO
INSERT [dbo].[OperationalManagers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy]) VALUES (N'Galinda', N'Shiz', N'387524189', N'0503374625', N'galinda@gmail.com', N'10 HaPalmach St, Tel Aviv', N'galinda14', N'glgl4747', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true')
INSERT [dbo].[OperationalManagers] ([firstName], [lastName], [id], [phoneNumber], [email], [address], [userName], [password], [idCopy]) VALUES (N'Alphaba', N'Levi	', N'627465727', N'0529476517', N'alphaba19@gmail.com', N'48 Rothschild Ave, Rishon LeZion', N'alphy_', N'dyfineG!', N'https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/IdCopy.jpg?raw=true')
GO
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100001', N'Agro Farms', N'523456789', N'agrofarm@gmail.com', CAST(N'2025-01-20T07:30:00.000' AS DateTime), N'12 HaShalom St, Be''er Sheva', N'50 Valley Rd, Kiryat Gat', N'agricultural', CAST(N'2025-01-21T15:00:00.000' AS DateTime), N'assigned', N'40567890', N'403444555', 3000.0000, N'tanker', 17000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100002', N'BuildPro Construction', N'509876543', N'buildpro@construction.com', CAST(N'2025-01-23T09:00:00.000' AS DateTime), N'40 HaNegev St, Eilat', N'15 Herzl Blvd, Jerusalem', N'construction', CAST(N'2025-01-25T18:00:00.000' AS DateTime), N'pendingForAssignment', NULL, NULL, 5000.0000, N'crane', 15000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100003', N'CoolTrans Logistics', N'549873210', N'info@cooltrans.com', CAST(N'2025-01-22T06:00:00.000' AS DateTime), N'10 HaGiva St, Ashkelon', N'20 HaAtzmaut Rd, Haifa', N'refrigerated', CAST(N'2025-02-22T18:00:00.000' AS DateTime), N'assigned', N'202345678', N'401222333', 8000.0000, N'trailer', 4000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100004', N'GovSecure Services', N'502345678', N'govsecure@gov.il', CAST(N'2025-01-18T08:00:00.000' AS DateTime), N'25 Weizmann St, Ramat Gan', N'75 Haifa Port, Haifa', N'hazardous', CAST(N'2025-02-19T12:00:00.000' AS DateTime), N'orderClosed', N'300987654', N'402333444', 15000.0000, N'tow', 12000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100005', N'Teltech Solutions', N'541234567', N'sales@teltech.com', CAST(N'2025-01-17T07:45:00.000' AS DateTime), N'35 Begin Rd, Tel Aviv', N'60 Einstein St, Haifa', N'electronic', CAST(N'2025-01-30T14:00:00.000' AS DateTime), N'taskCompleted', N'203567890', N'400111222', 6000.0000, N'crane', 2000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100006', N'Herbal Green', N'524321987', N'greenherbs@gmail.com', CAST(N'2025-01-19T08:30:00.000' AS DateTime), N'45 Herzl Blvd, Ashdod', N'32 HaHoresh St, Tiberias', N'agricultural', CAST(N'2025-02-20T20:00:00.000' AS DateTime), N'pendingForAssignment', NULL, NULL, 2000.0000, N'tanker', 7000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100007', N'Mega Market', N'535678901', N'orders@megamarket.com', CAST(N'2025-01-24T10:00:00.000' AS DateTime), N'50 HaTikva St, Netanya', N'18 HaNamal St, Haifa', N'refrigerated', CAST(N'2025-01-24T18:00:00.000' AS DateTime), N'assigned', N'40567890', N'400111222', 4500.0000, N'trailer', 4800)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100008', N'DefenseTech Ltd', N'507654321', N'contact@defensetech.co.il', CAST(N'2025-01-26T07:00:00.000' AS DateTime), N'22 HaArava St, Beersheba', N'70 HaPalmach St, Tel Aviv', N'hazardous', CAST(N'2025-01-27T19:00:00.000' AS DateTime), N'assigned', N'302456789', N'401333551', 11000.0000, N'tow', 14000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100009', N'Alon Logistics', N'544321987', N'info@alonlogistics.com', CAST(N'2025-01-28T06:30:00.000' AS DateTime), N'12 Ben Gurion Blvd, Ashdod', N'40 HaYarkon St, Tiberias', N'construction', CAST(N'2025-01-29T20:00:00.000' AS DateTime), N'assigned', N'301234567', N'402333444', 7000.0000, N'crane', 17000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100010', N'Tiv Tam Supplies', N'546785432', N'supply@tivtam.com', CAST(N'2025-01-30T09:00:00.000' AS DateTime), N'30 Rothschild Blvd, Ramat Gan', N'25 HaNegev Blvd, Beer Sheba', N'electronic', CAST(N'2025-01-30T22:00:00.000' AS DateTime), N'taskCompleted', N'203567890', N'401222333', 5000.0000, N'crane', 2000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100011', N'GreenFields Farms', N'539876543', N'orders@greenfields.co.il', CAST(N'2025-02-02T08:00:00.000' AS DateTime), N'78 HaShalom St, Ramat Gan', N'45 HaEmek Rd, Haifa', N'agricultural', CAST(N'2025-02-02T16:00:00.000' AS DateTime), N'assigned', N'301234567', N'401222333', 3000.0000, N'tanker', 7000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100012', N'Haifa Chemicals', N'505432198', N'orders@haifachem.com', CAST(N'2025-01-31T07:15:00.000' AS DateTime), N'45 HaNamal St, Haifa', N'15 Herzl Blvd, Ramat Gan', N'liquid', CAST(N'2025-01-31T20:00:00.000' AS DateTime), N'assigned', N'300987654', N'403444555', 8000.0000, N'crane', 15000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100013', N'Blue Ocean Shipping', N'507766554', N'contact@blueocean.com', CAST(N'2025-02-03T08:45:00.000' AS DateTime), N'65 HaTamar St, Ashkelon', N'75 HaTavor St, Tiberias', N'hazardous', CAST(N'2025-02-04T20:00:00.000' AS DateTime), N'orderClosed', N'202345678', N'403444555', 12000.0000, N'tow', 12000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100014', N'High Tech Industries', N'529987654', N'contact@hti.com', CAST(N'2025-01-25T10:30:00.000' AS DateTime), N'28 Herzl Blvd, Herzliya', N'34 HaAtzmaut St, Tel Aviv', N'electronic', CAST(N'2025-01-25T17:00:00.000' AS DateTime), N'assigned', N'201234567', N'400111222', 4000.0000, N'trailer', 3500)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100015', N'Carmel Winery', N'548887776', N'logistics@carmelwinery.com', CAST(N'2025-02-01T07:00:00.000' AS DateTime), N'10 HaGefen St, Zichron Yaakov', N'20 HaHoresh St, Ramat HaSharon', N'liquid', CAST(N'2025-02-01T21:00:00.000' AS DateTime), N'assigned', N'40567890', N'402333444', 9000.0000, N'tanker', 18000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'100016', N'Negev Builders', N'503332221', N'contact@negevbuilders.com', CAST(N'2025-01-27T06:00:00.000' AS DateTime), N'35 HaMidbar St, Dimona', N'50 HaTzionut Blvd, Beersheba', N'construction', CAST(N'2025-01-28T18:00:00.000' AS DateTime), N'pendingForAssignment', NULL, NULL, 6000.0000, N'crane', 14000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'393939', N'Israeli Aerospace Indestries', N'050-5727484', N'sales@iai.co.il', CAST(N'2025-01-19T07:00:00.000' AS DateTime), N'20 Yigal Alon St, Herzliya', N'18 Port Blvd, Haifa', N'electronic', CAST(N'2025-01-19T21:00:00.000' AS DateTime), N'assigned', N'203567890', N'401222333', 2000.0000, N'tanker', 6000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'777777', N'Ministry of Defense', N'052-9876543', N'mod@security.gov', CAST(N'2024-12-20T08:15:00.000' AS DateTime), N'20 Yigal Alon St, Herzliya', N'50 Tel Aviv Port Rd, Tel Aviv', N'hazardous', CAST(N'2024-12-27T00:00:00.000' AS DateTime), N'pendingForAssignment', NULL, NULL, 10000.0000, N'tow', 5000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'888888', N'Rafael Advanced Defense Systems', N'054-1234567', N'rafael@defense.co.il', CAST(N'2024-12-18T07:00:00.000' AS DateTime), N'15 Herzl St, Tel Aviv', N'25 Einstein St, Haifa', N'liquid', CAST(N'2024-12-28T00:00:00.000' AS DateTime), N'pendingForAssignment', NULL, NULL, 8000.0000, N'crane', 15000)
INSERT [dbo].[Orders] ([id], [customerName], [customerPhoneNumber], [customerEmail], [startDate], [departure], [destination], [cargoType], [estimatedFinishDate], [orderStatus], [driver], [clerk], [profit], [vehicleType], [totalWeight]) VALUES (N'999999', N'Teva Pharmaceuticals', N'056-6677889', N'hr@teva.com', CAST(N'2025-01-19T07:00:00.000' AS DateTime), N'10 Rothschild Blvd, Tel Aviv', N'35 Golan Heights Rd, Katzrin', N'liquid', CAST(N'2025-01-19T21:00:00.000' AS DateTime), N'assigned', N'200123456', N'403444555', 15000.0000, N'crane', 9000)
GO
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'arrivedToSite')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'assigned')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'departure')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'orderClosed')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'pendingForAssignment')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'taskCompleted')
INSERT [dbo].[OrderStatuses] ([statusName]) VALUES (N'workCertificateSigned')
GO
INSERT [dbo].[performanceStatuses] ([statusName]) VALUES (N'archived')
INSERT [dbo].[performanceStatuses] ([statusName]) VALUES (N'assignedToOrder')
INSERT [dbo].[performanceStatuses] ([statusName]) VALUES (N'inoperative')
INSERT [dbo].[performanceStatuses] ([statusName]) VALUES (N'pendingForAssignment')
INSERT [dbo].[performanceStatuses] ([statusName]) VALUES (N'pendingForHearingResults')
INSERT [dbo].[performanceStatuses] ([statusName]) VALUES (N'underWarning')
GO
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (1, N'Was the clerk polite and professional?', 0, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (2, N'Did the clerk provide accurate information?', 0, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (3, N'How satisfied were you with the clerk’s speed of service?', 0, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (4, N'Did you receive a response to your problems from the clerk?', 0, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (5, N'Was the driver polite and professional?', 1, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (6, N'Did the driver ensure safe transportation of goods?', 1, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (7, N'How satisfied were you with the driver’s timelines?', 1, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (8, N'Did the driver communicate effectively throughout the delivery process?', 1, 0)
INSERT [dbo].[Questions] ([questionNumber], [description], [associatedRole], [hide]) VALUES (9, N'Did the clerk proactively offer solutions to your inquiries?', 0, 1)
GO
INSERT [dbo].[Roles] ([roleName]) VALUES (N'clerk')
INSERT [dbo].[Roles] ([roleName]) VALUES (N'driver')
INSERT [dbo].[Roles] ([roleName]) VALUES (N'officeManager')
INSERT [dbo].[Roles] ([roleName]) VALUES (N'operationalManager')
GO
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 111111', 0, N'111111')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 112233', 1, N'112233')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 123456', 1, N'123456')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 2222', 0, N'2222')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 345678', 1, N'345678')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 445566', 1, N'445566')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 654321', 1, N'654321')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 789012', 1, N'789012')
INSERT [dbo].[Surveys] ([headline], [completed], [order]) VALUES (N'Customer Service Survey for Order Number 987654', 1, N'987654')
GO
INSERT [dbo].[VehicleCondition] ([conditionName]) VALUES (N'alternative')
INSERT [dbo].[VehicleCondition] ([conditionName]) VALUES (N'disposed')
INSERT [dbo].[VehicleCondition] ([conditionName]) VALUES (N'maintenance')
INSERT [dbo].[VehicleCondition] ([conditionName]) VALUES (N'outOfService')
INSERT [dbo].[VehicleCondition] ([conditionName]) VALUES (N'proper')
GO
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000004', N'crane', 20000, CAST(N'2024-03-20' AS Date), N'proper', N'liquid')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000005', N'crane', 21000, CAST(N'2024-05-10' AS Date), N'proper', N'liquid')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000006', N'tow', 15200, CAST(N'2024-03-12' AS Date), N'maintenance', N'hazardous')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000007', N'tanker', 19000, CAST(N'2024-07-25' AS Date), N'alternative', N'agricultural')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000008', N'trailer', 5000, CAST(N'2023-12-20' AS Date), N'proper', N'refrigerated')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000009', N'crane', 1800, CAST(N'2024-01-30' AS Date), N'disposed', N'electronic')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000010', N'flatbed', 1200, CAST(N'2024-02-15' AS Date), N'proper', N'construction')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000011', N'tanker', 7500, CAST(N'2023-09-01' AS Date), N'outOfService', N'refrigerated')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000012', N'tow', 10500, CAST(N'2024-04-05' AS Date), N'maintenance', N'hazardous')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000013', N'trailer', 4600, CAST(N'2023-11-10' AS Date), N'alternative', N'agricultural')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10000014', N'crane', 18000, CAST(N'2024-08-08' AS Date), N'proper', N'construction')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10002301', N'tow', 15000, CAST(N'2024-01-01' AS Date), N'proper', N'hazardous')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'10569807', N'tanker', 18000, CAST(N'2024-06-15' AS Date), N'proper', N'agricultural')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'20790002', N'trailer', 5000, CAST(N'2023-05-15' AS Date), N'proper', N'refrigerated')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'23317666', N'crane', 1613, CAST(N'2020-11-02' AS Date), N'alternative', N'electronic')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'25960006', N'tanker', 7000, CAST(N'2023-08-08' AS Date), N'maintenance', N'refrigerated')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'30005003', N'tow', 1000, CAST(N'2023-10-10' AS Date), N'proper', N'hazardous')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'30091031', N'crane', 12986, CAST(N'2021-05-31' AS Date), N'disposed', N'construction')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'35122638', N'tow', 14203, CAST(N'2020-10-26' AS Date), N'maintenance', N'construction')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'35122738', N'tow', 14203, CAST(N'2020-10-26' AS Date), N'alternative', N'construction')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'40385837', N'trailer', 4571, CAST(N'2024-10-12' AS Date), N'outOfService', N'refrigerated')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'40695005', N'crane', 17000, CAST(N'2022-11-11' AS Date), N'proper', N'liquid')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'47646540', N'crane', 11087, CAST(N'2024-10-07' AS Date), N'maintenance', N'construction')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'78939661', N'tanker', 1217, CAST(N'2021-08-07' AS Date), N'alternative', N'agricultural')
INSERT [dbo].[Vehicles] ([id], [type], [maxCapacity], [testDate], [condition], [cargoType]) VALUES (N'93808898', N'tow', 17802, CAST(N'2024-05-01' AS Date), N'alternative', N'refrigerated')
GO
INSERT [dbo].[VehicleType] ([typeName]) VALUES (N'crane')
INSERT [dbo].[VehicleType] ([typeName]) VALUES (N'flatbed')
INSERT [dbo].[VehicleType] ([typeName]) VALUES (N'refrigirated')
INSERT [dbo].[VehicleType] ([typeName]) VALUES (N'tanker')
INSERT [dbo].[VehicleType] ([typeName]) VALUES (N'tow')
INSERT [dbo].[VehicleType] ([typeName]) VALUES (N'trailer')
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_question] FOREIGN KEY([questionNumber])
REFERENCES [dbo].[Questions] ([questionNumber])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_question]
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_Survey] FOREIGN KEY([survey])
REFERENCES [dbo].[Surveys] ([headline])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_Survey]
GO
ALTER TABLE [dbo].[ArchivedClerks]  WITH CHECK ADD  CONSTRAINT [FK_performanceStatusesArchivedClerks] FOREIGN KEY([performanceStatus])
REFERENCES [dbo].[performanceStatuses] ([statusName])
GO
ALTER TABLE [dbo].[ArchivedClerks] CHECK CONSTRAINT [FK_performanceStatusesArchivedClerks]
GO
ALTER TABLE [dbo].[ArchivedDrivers]  WITH CHECK ADD  CONSTRAINT [FK_performanceStatusesArchivedDrivers] FOREIGN KEY([performanceStatus])
REFERENCES [dbo].[performanceStatuses] ([statusName])
GO
ALTER TABLE [dbo].[ArchivedDrivers] CHECK CONSTRAINT [FK_performanceStatusesArchivedDrivers]
GO
ALTER TABLE [dbo].[ArchivedDrivers]  WITH CHECK ADD  CONSTRAINT [FK_vehicleID_Archived_Drivers] FOREIGN KEY([vehicle])
REFERENCES [dbo].[Vehicles] ([id])
GO
ALTER TABLE [dbo].[ArchivedDrivers] CHECK CONSTRAINT [FK_vehicleID_Archived_Drivers]
GO
ALTER TABLE [dbo].[ArchivedOrders]  WITH CHECK ADD  CONSTRAINT [FK_ArchivedOrders_CargoType] FOREIGN KEY([cargoType])
REFERENCES [dbo].[CargoType] ([cargoName])
GO
ALTER TABLE [dbo].[ArchivedOrders] CHECK CONSTRAINT [FK_ArchivedOrders_CargoType]
GO
ALTER TABLE [dbo].[ArchivedOrders]  WITH CHECK ADD  CONSTRAINT [FK_ArchivedOrders_Clerk] FOREIGN KEY([clerk])
REFERENCES [dbo].[Clerks] ([id])
GO
ALTER TABLE [dbo].[ArchivedOrders] CHECK CONSTRAINT [FK_ArchivedOrders_Clerk]
GO
ALTER TABLE [dbo].[ArchivedOrders]  WITH CHECK ADD  CONSTRAINT [FK_ArchivedOrders_Driver] FOREIGN KEY([driver])
REFERENCES [dbo].[Drivers] ([id])
GO
ALTER TABLE [dbo].[ArchivedOrders] CHECK CONSTRAINT [FK_ArchivedOrders_Driver]
GO
ALTER TABLE [dbo].[ArchivedOrders]  WITH CHECK ADD  CONSTRAINT [FK_ArchivedOrders_Status] FOREIGN KEY([orderStatus])
REFERENCES [dbo].[OrderStatuses] ([statusName])
GO
ALTER TABLE [dbo].[ArchivedOrders] CHECK CONSTRAINT [FK_ArchivedOrders_Status]
GO
ALTER TABLE [dbo].[ArchivedOrders]  WITH CHECK ADD  CONSTRAINT [FK_ArchivedOrders_VehicleType] FOREIGN KEY([vehicleType])
REFERENCES [dbo].[VehicleType] ([typeName])
GO
ALTER TABLE [dbo].[ArchivedOrders] CHECK CONSTRAINT [FK_ArchivedOrders_VehicleType]
GO
ALTER TABLE [dbo].[Clerks]  WITH CHECK ADD  CONSTRAINT [FK_performanceStatusesC] FOREIGN KEY([performanceStatus])
REFERENCES [dbo].[performanceStatuses] ([statusName])
GO
ALTER TABLE [dbo].[Clerks] CHECK CONSTRAINT [FK_performanceStatusesC]
GO
ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_performanceStatusesD] FOREIGN KEY([performanceStatus])
REFERENCES [dbo].[performanceStatuses] ([statusName])
GO
ALTER TABLE [dbo].[Drivers] CHECK CONSTRAINT [FK_performanceStatusesD]
GO
ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Status_Driver] FOREIGN KEY([performanceStatus])
REFERENCES [dbo].[performanceStatuses] ([statusName])
GO
ALTER TABLE [dbo].[Drivers] CHECK CONSTRAINT [FK_Status_Driver]
GO
ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [fk_vehicleID] FOREIGN KEY([vehicle])
REFERENCES [dbo].[Vehicles] ([id])
GO
ALTER TABLE [dbo].[Drivers] CHECK CONSTRAINT [fk_vehicleID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_orderC] FOREIGN KEY([clerk])
REFERENCES [dbo].[Clerks] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_orderC]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_orderD] FOREIGN KEY([driver])
REFERENCES [dbo].[Drivers] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_orderD]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_OrdersCargoType] FOREIGN KEY([cargoType])
REFERENCES [dbo].[CargoType] ([cargoName])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_OrdersCargoType]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [fk_vehicleTypefororders] FOREIGN KEY([vehicleType])
REFERENCES [dbo].[VehicleType] ([typeName])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [fk_vehicleTypefororders]
GO
ALTER TABLE [dbo].[Surveys]  WITH CHECK ADD  CONSTRAINT [FK_OrderSurveys] FOREIGN KEY([order])
REFERENCES [dbo].[ArchivedOrders] ([id])
GO
ALTER TABLE [dbo].[Surveys] CHECK CONSTRAINT [FK_OrderSurveys]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_CargoType] FOREIGN KEY([cargoType])
REFERENCES [dbo].[CargoType] ([cargoName])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_CargoType]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_VehicleCondition] FOREIGN KEY([condition])
REFERENCES [dbo].[VehicleCondition] ([conditionName])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_VehicleCondition]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_VehicleType] FOREIGN KEY([type])
REFERENCES [dbo].[VehicleType] ([typeName])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_VehicleType]
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Answers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_Answers]
AS
Select*from dbo.Answers

GO
/****** Object:  StoredProcedure [dbo].[Get_All_Archived_Orders]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_All_Archived_Orders]
AS
Select*from dbo.ArchivedOrders

GO
/****** Object:  StoredProcedure [dbo].[Get_all_Clerks]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_Clerks]
AS
Select*from dbo.Clerks

GO
/****** Object:  StoredProcedure [dbo].[Get_All_Drivers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_All_Drivers]
AS
Select*from dbo.Drivers
GO
/****** Object:  StoredProcedure [dbo].[Get_all_EmployeeMonthlyEvaluation]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_EmployeeMonthlyEvaluation]
AS
Select*from dbo.EmployeeMonthlyEvaluation

GO
/****** Object:  StoredProcedure [dbo].[Get_all_OperationalManager]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Get_all_OperationalManager]
as
select * from OperationalManagers
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Orders]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_all_Orders]
AS
Select*
from dbo.Orders
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Questions]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_Questions]
AS
Select*from dbo.Questions

GO
/****** Object:  StoredProcedure [dbo].[Get_all_Surveys]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Get_all_Surveys]
as 
select * from Surveys
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Vehicles]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_all_Vehicles]
AS
Select*from dbo.vehicles
GO
/****** Object:  StoredProcedure [dbo].[Get_OfficeManager]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  procedure [dbo].[Get_OfficeManager]
as 
select * from OfficeManagers
GO
/****** Object:  StoredProcedure [dbo].[SP_add_Clerk]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_add_Clerk]
    @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50) ,
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50), 
	@performanceStatus VARCHAR(50)
  
AS
INSERT INTO dbo.Clerks
Values (@firstName,
    @lastName,
    @id,
    @phoneNumber,
    @email,
    @address,
    @userName,
    @password,
    @idCopy,
	@performanceStatus)
GO
/****** Object:  StoredProcedure [dbo].[SP_add_Driver]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_add_Driver] 
    @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50) ,
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50),
    @licenseCopy VARCHAR(50),
    @licenseId VARCHAR(50),
	@performancestatus VARCHAR(50),
	@vehicle VARCHAR(50)
AS
INSERT INTO dbo.Drivers
Values (@firstName,
    @lastName,
    @id,
    @phoneNumber,
    @email,
    @address,
    @userName,
    @password,
    @idCopy,
    @licenseCopy,
    @licenseId,
	@performancestatus,
	@vehicle)
GO
/****** Object:  StoredProcedure [dbo].[SP_add_EmployeeMonthlyEvaluation]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_add_EmployeeMonthlyEvaluation]
@personalNote VARCHAR(1000),
@associatedMonth INT,
@submissionDate DATETIME,
@year INT,
@EmployeeId VARCHAR(50),
@score FLOAT

as 

insert into dbo.EmployeeMonthlyEvaluation
values
(
@personalNote,
@associatedMonth,
@submissionDate,
@year,
@EmployeeId,
@score
)

GO
/****** Object:  StoredProcedure [dbo].[sp_add_officeManager]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_add_officeManager] 
    @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50) ,
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50)
  
AS
INSERT INTO dbo.officeManagers
Values (@firstName,
    @lastName,
    @id,
    @phoneNumber,
    @email,
    @address,
    @userName,
    @password,
    @idCopy)
GO
/****** Object:  StoredProcedure [dbo].[sp_add_OperationalManager]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_add_OperationalManager]
    @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50) ,
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50)
  
AS
INSERT INTO dbo.OperationalManagers
Values (@firstName,
    @lastName,
    @id,
    @phoneNumber,
    @email,
    @address,
    @userName,
    @password,
    @idCopy)
GO
/****** Object:  StoredProcedure [dbo].[SP_add_Question]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_add_Question]
    @questionNumber INT,
    @description VARCHAR(150),
    @associatedRole BIT,
    @hide BIT
AS
INSERT INTO dbo.Questions
Values (@questionNumber,
    @description,
    @associatedRole,
    @hide)

GO
/****** Object:  StoredProcedure [dbo].[SP_add_Survey]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_add_Survey]
    @headline VARCHAR(50),
	@completed BIT,
	@order VARCHAR(50)
AS
INSERT INTO dbo.Surveys
Values (@headline,
		@completed,
		@order)
GO
/****** Object:  StoredProcedure [dbo].[SP_add_vehicle]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_add_vehicle]
	@id VARCHAR(50),
    @type VARCHAR(50),
    @maxCapacity FLOAT,
    @testDate DATE,
    @condition VARCHAR(50),
    @cargoType VARCHAR(50)
AS
INSERT INTO dbo.Vehicles
VALUES (  @id,
    @type,
    @maxCapacity,
    @testDate,
    @condition,
    @cargoType 
)

GO
/****** Object:  StoredProcedure [dbo].[SP_archive_clerk]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_archive_clerk]
    @ClerkId varchar(50)
AS
BEGIN
    -- Insert the record into ArchivedClerks
    INSERT INTO dbo.ArchivedClerks
    SELECT
		firstName,
		lastName,
		id,
		phoneNumber,
		email,
		[address],
		userName,
		[password],
		idCopy,
		performanceStatus
		
    FROM dbo.Clerks
    WHERE id = @ClerkId;

    -- Delete the record from drivers
    DELETE FROM dbo.Clerks
    WHERE id = @ClerkId;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_archive_driver]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_archive_driver]
    @DriverId varchar(50)
AS
BEGIN
    -- Insert the record into ArchivedDrivers
    INSERT INTO dbo.ArchivedDrivers
    SELECT
		firstName,
		lastName,
		id,
		phoneNumber,
		email,
		[address],
		userName,
		[password],
		idCopy,
		licenseCopy,
		licenseId,
		performanceStatus,
		vehicle
		
    FROM dbo.Drivers
    WHERE id = @DriverId;

    -- Delete the record from drivers
    DELETE FROM dbo.Drivers
    WHERE id = @DriverId;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_archive_order]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_archive_order]
    @orderId varchar(50)
AS
BEGIN
    -- Insert the record into ArchivedOrders
    INSERT INTO dbo.ArchivedOrders
    SELECT 
        id,
        customerName,
        customerPhoneNumber,
        customerEmail,
        startDate,
        departure,
        destination,
        cargoType,
        estimatedFinishDate,
        orderStatus,
        driver,
        clerk,
        profit,
        vehicleType,
        totalWeight
    FROM dbo.Orders
    WHERE id = @orderId;

    -- Delete the record from Orders
    DELETE FROM dbo.Orders
    WHERE id = @orderId;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_delete_driver]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_delete_driver] @id VARCHAR(50)
AS
Delete from dbo.Drivers
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_delete_vehicle]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_delete_vehicle] @id VARCHAR(50)
AS
Delete from dbo.Vehicles
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Archived_Clerks]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_Get_All_Archived_Clerks]
AS
Select*from dbo.ArchivedClerks
-------

GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Archived_Drivers]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_Get_All_Archived_Drivers]
AS
Select*from dbo.ArchivedDrivers

----------
GO
/****** Object:  StoredProcedure [dbo].[SP_update_Clerk]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_update_Clerk]
   @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50),
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50)

AS
BEGIN
	UPDATE dbo.Clerks
	SET
		firstName = @firstName,
		lastName = @lastName,
		phoneNumber  = @phoneNumber,
		email = @email,
		[address] = @address,
		userName = @userName ,
		[password] = @password ,
		idCopy = @idCopy

WHERE id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Clerk_Status]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Update_Clerk_Status]

    @id VARCHAR(50),
	@performanceStatus VARCHAR(50)=null
AS
BEGIN
UPDATE dbo.Clerks
SET
performanceStatus = COALESCE(@performanceStatus, performanceStatus)
WHERE id = @id;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_update_driver]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_update_driver]
    @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50),
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50),
    @licenseCopy VARCHAR(50),
    @licenseId VARCHAR(50)
AS
BEGIN
    UPDATE dbo.Drivers
    SET 
        firstName = @firstName,
        lastName = @lastName,
        phoneNumber = @phoneNumber,
        email = @email,
        address = @address,
        userName = @userName,
        password = @password,
        idCopy = @idCopy,
        licenseCopy = @licenseCopy,
        licenseId = @licenseId
    WHERE id = @id;

	end
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Driver_Status]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Update_Driver_Status]

    @id VARCHAR(50),
	@performanceStatus VARCHAR(50)=null
AS
BEGIN
UPDATE dbo.Drivers
SET
performanceStatus = COALESCE(@performanceStatus, performanceStatus)
WHERE id = @id;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_driverVehicle]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_driverVehicle] @id varchar(50), @vehicleID varchar (50)
AS
Update dbo.Drivers
SET
vehicle=@vehicleID
WHERE id=@id
GO
/****** Object:  StoredProcedure [dbo].[SP_update_officeManager]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_update_officeManager]
   @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50),
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50)

AS
BEGIN
	UPDATE dbo.OfficeManagers
	SET
		firstName = @firstName,
		lastName = @lastName,
		phoneNumber  = @phoneNumber,
		email = @email,
		[address] = @address,
		userName = @userName ,
		[password] = @password ,
		idCopy = @idCopy

WHERE id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_update_OperationalManager]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_update_OperationalManager]
   @firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @id VARCHAR(50),
    @phoneNumber VARCHAR(20),
    @email VARCHAR(100),
    @address VARCHAR(100),
    @userName VARCHAR(50),
    @password VARCHAR(50),
    @idCopy VARCHAR(50)

AS
BEGIN
	UPDATE dbo.OperationalManagers
	SET
		firstName = @firstName,
		lastName = @lastName,
		phoneNumber  = @phoneNumber,
		email = @email,
		[address] = @address,
		userName = @userName ,
		[password] = @password ,
		idCopy = @idCopy

WHERE id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_orderClerk]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_orderClerk] @id varchar(50), @clerkID varchar (50)
AS
Update dbo.Orders
SET
clerk=@clerkID
WHERE id=@id
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_orderDriver]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_orderDriver] @id varchar(50), @driver varchar (50)
AS
Update dbo.Orders
SET
driver=@driver
WHERE id=@id
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_orderStatus]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_orderStatus] @id varchar(50), @orderStatus varchar (50)
AS
Update dbo.Orders
SET
orderStatus=@orderStatus
WHERE id=@id
GO
/****** Object:  StoredProcedure [dbo].[SP_update_question]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_update_question]
    @questionNumber INT = Null,
    @description VARCHAR(150) = Null,
    @associatedRole BIT = Null,
    @hide BIT = Null
AS
BEGIN
UPDATE dbo.Questions
SET
questionNumber = COALESCE(@questionNumber, questionNumber),
[description] = COALESCE(@description, [description]),
associatedRole  = COALESCE(@associatedRole, associatedRole),
hide = COALESCE(@hide, hide)
WHERE questionNumber = @questionNumber;
END


GO
/****** Object:  StoredProcedure [dbo].[SP_update_vehicle]    Script Date: 24/01/2025 00:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_update_vehicle]
	@id VARCHAR(50),
    @type VARCHAR(50) = NULL,
    @maxCapacity FLOAT = NULL,
    @testDate DATE = NULL,
    @condition VARCHAR(50) = NULL,
    @cargoType VARCHAR(50) = NULL
AS
BEGIN
	UPDATE dbo.Vehicles
	SET
    [type] = COALESCE(@type, [type]),
    maxCapacity = COALESCE(@maxCapacity,maxCapacity),
    testDate = COALESCE(@testDate, testDate),
    condition = COALESCE(@condition, condition),
    cargoType = COALESCE(@cargoType, cargoType)
	  WHERE id = @id;
END 

GO
USE [master]
GO
ALTER DATABASE [SADM_14] SET  READ_WRITE 
GO

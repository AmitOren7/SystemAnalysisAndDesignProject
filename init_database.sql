USE [master]
GO
/****** Object:  Database [SADM_14]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  User [bgu-users\romim]    Script Date: 23/01/2025 23:03:55 ******/
CREATE USER [bgu-users\romim] FOR LOGIN [bgu-users\romim] WITH DEFAULT_SCHEMA=[bgu-users\romim]
GO
/****** Object:  User [bgu-users\leahros]    Script Date: 23/01/2025 23:03:55 ******/
CREATE USER [bgu-users\leahros] FOR LOGIN [bgu-users\leahros] WITH DEFAULT_SCHEMA=[bgu-users\leahros]
GO
/****** Object:  User [bgu-users\edenq]    Script Date: 23/01/2025 23:03:55 ******/
CREATE USER [bgu-users\edenq] FOR LOGIN [bgu-users\edenq] WITH DEFAULT_SCHEMA=[bgu-users\edenq]
GO
ALTER ROLE [db_owner] ADD MEMBER [bgu-users\romim]
GO
ALTER ROLE [db_owner] ADD MEMBER [bgu-users\leahros]
GO
ALTER ROLE [db_owner] ADD MEMBER [bgu-users\edenq]
GO
/****** Object:  Schema [bgu-users\edenq]    Script Date: 23/01/2025 23:03:55 ******/
CREATE SCHEMA [bgu-users\edenq]
GO
/****** Object:  Schema [bgu-users\leahros]    Script Date: 23/01/2025 23:03:55 ******/
CREATE SCHEMA [bgu-users\leahros]
GO
/****** Object:  Schema [bgu-users\romim]    Script Date: 23/01/2025 23:03:55 ******/
CREATE SCHEMA [bgu-users\romim]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[ArchivedClerks]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[ArchivedDrivers]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[ArchivedOrders]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[CargoType]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Clerks]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Drivers]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[EmployeeMonthlyEvaluation]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[OfficeManagers]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[OperationalManagers]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[performanceStatuses]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Questions]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Roles]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Surveys]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[VehicleCondition]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[Vehicles]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  Table [dbo].[VehicleType]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[Get_all_Answers]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_Answers]
AS
Select*from dbo.Answers

GO
/****** Object:  StoredProcedure [dbo].[Get_All_Archived_Orders]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_All_Archived_Orders]
AS
Select*from dbo.ArchivedOrders

GO
/****** Object:  StoredProcedure [dbo].[Get_all_Clerks]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_Clerks]
AS
Select*from dbo.Clerks

GO
/****** Object:  StoredProcedure [dbo].[Get_All_Drivers]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_All_Drivers]
AS
Select*from dbo.Drivers
GO
/****** Object:  StoredProcedure [dbo].[Get_all_EmployeeMonthlyEvaluation]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_EmployeeMonthlyEvaluation]
AS
Select*from dbo.EmployeeMonthlyEvaluation

GO
/****** Object:  StoredProcedure [dbo].[Get_all_OperationalManager]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Get_all_OperationalManager]
as
select * from OperationalManagers
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Orders]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_all_Orders]
AS
Select*
from dbo.Orders
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Questions]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Get_all_Questions]
AS
Select*from dbo.Questions

GO
/****** Object:  StoredProcedure [dbo].[Get_all_Surveys]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Get_all_Surveys]
as 
select * from Surveys
GO
/****** Object:  StoredProcedure [dbo].[Get_all_Vehicles]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Get_all_Vehicles]
AS
Select*from dbo.vehicles
GO
/****** Object:  StoredProcedure [dbo].[Get_OfficeManager]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  procedure [dbo].[Get_OfficeManager]
as 
select * from OfficeManagers
GO
/****** Object:  StoredProcedure [dbo].[SP_add_Clerk]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_add_Driver]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_add_EmployeeMonthlyEvaluation]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_add_officeManager]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_add_OperationalManager]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_add_Question]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_add_Survey]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_add_vehicle]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_archive_clerk]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_archive_driver]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_archive_order]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_delete_driver]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_delete_driver] @id VARCHAR(50)
AS
Delete from dbo.Drivers
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_delete_vehicle]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_delete_vehicle] @id VARCHAR(50)
AS
Delete from dbo.Vehicles
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Archived_Clerks]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_Get_All_Archived_Clerks]
AS
Select*from dbo.ArchivedClerks
-------

GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Archived_Drivers]    Script Date: 23/01/2025 23:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_Get_All_Archived_Drivers]
AS
Select*from dbo.ArchivedDrivers

----------
GO
/****** Object:  StoredProcedure [dbo].[SP_update_Clerk]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Update_Clerk_Status]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_update_driver]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Update_Driver_Status]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Update_driverVehicle]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_update_officeManager]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_update_OperationalManager]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Update_orderClerk]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Update_orderDriver]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Update_orderStatus]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_update_question]    Script Date: 23/01/2025 23:03:55 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_update_vehicle]    Script Date: 23/01/2025 23:03:55 ******/
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

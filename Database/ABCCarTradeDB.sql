USE [master]
GO
/****** Object:  Database [ABCCarTradersDB]    Script Date: 11/7/2024 9:57:55 AM ******/
CREATE DATABASE [ABCCarTradersDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ABCCarTradersDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ABCCarTradersDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ABCCarTradersDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ABCCarTradersDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ABCCarTradersDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ABCCarTradersDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ABCCarTradersDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ABCCarTradersDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ABCCarTradersDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ABCCarTradersDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ABCCarTradersDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ABCCarTradersDB] SET  MULTI_USER 
GO
ALTER DATABASE [ABCCarTradersDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ABCCarTradersDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ABCCarTradersDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ABCCarTradersDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ABCCarTradersDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ABCCarTradersDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ABCCarTradersDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [ABCCarTradersDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ABCCarTradersDB]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[car_id] [int] IDENTITY(1,1) NOT NULL,
	[car_type] [varchar](50) NOT NULL,
	[car_brand] [varchar](50) NOT NULL,
	[car_color] [int] NOT NULL,
	[car_fueleconomy] [float] NOT NULL,
	[car_engine_power] [float] NOT NULL,
	[car_manufacture_date] [date] NOT NULL,
	[car_price] [float] NOT NULL,
	[car_picture] [varbinary](max) NOT NULL,
	[entry_user] [int] NOT NULL,
	[entry_date] [date] NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[car_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarColor]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarColor](
	[color_id] [int] IDENTITY(1,1) NOT NULL,
	[color_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CarColor] PRIMARY KEY CLUSTERED 
(
	[color_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarPart]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarPart](
	[carpart_id] [int] IDENTITY(1,1) NOT NULL,
	[carpart_name] [varchar](50) NOT NULL,
	[carpart_car_id] [int] NOT NULL,
	[carpart_manufacture_date] [date] NOT NULL,
	[carpart_price] [float] NOT NULL,
	[carpart_description] [varchar](200) NOT NULL,
	[carpart_color_id] [int] NOT NULL,
	[carpart_picture] [image] NOT NULL,
	[entry_user] [int] NOT NULL,
	[entry_date] [date] NOT NULL,
 CONSTRAINT [PK_CarPart] PRIMARY KEY CLUSTERED 
(
	[carpart_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[order_id] [int] NOT NULL,
	[car_id] [int] NULL,
	[car_part_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[order_date] [date] NOT NULL,
	[order_status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[login_id] [int] IDENTITY(1,1) NOT NULL,
	[login_username] [varchar](50) NOT NULL,
	[login_password] [varchar](50) NOT NULL,
	[login_user_id] [int] NOT NULL,
	[login_role_id] [int] NOT NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[login_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[user_role_id] [int] IDENTITY(1,1) NOT NULL,
	[user_role_description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[user_role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/7/2024 9:57:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_firstname] [varchar](50) NULL,
	[user_lastname] [varchar](50) NULL,
	[user_fullname] [varchar](50) NOT NULL,
	[user_email] [varchar](50) NOT NULL,
	[user_contactno] [varchar](10) NULL,
	[user_address] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_CarColor] FOREIGN KEY([car_color])
REFERENCES [dbo].[CarColor] ([color_id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_CarColor]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Users] FOREIGN KEY([entry_user])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Users]
GO
ALTER TABLE [dbo].[CarPart]  WITH CHECK ADD  CONSTRAINT [FK_CarPart_Car] FOREIGN KEY([carpart_car_id])
REFERENCES [dbo].[Car] ([car_id])
GO
ALTER TABLE [dbo].[CarPart] CHECK CONSTRAINT [FK_CarPart_Car]
GO
ALTER TABLE [dbo].[CarPart]  WITH CHECK ADD  CONSTRAINT [FK_CarPart_CarColor] FOREIGN KEY([carpart_color_id])
REFERENCES [dbo].[CarColor] ([color_id])
GO
ALTER TABLE [dbo].[CarPart] CHECK CONSTRAINT [FK_CarPart_CarColor]
GO
ALTER TABLE [dbo].[CarPart]  WITH CHECK ADD  CONSTRAINT [FK_CarPart_Users] FOREIGN KEY([entry_user])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[CarPart] CHECK CONSTRAINT [FK_CarPart_Users]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Car] FOREIGN KEY([car_id])
REFERENCES [dbo].[Car] ([car_id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Car]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_CarPart] FOREIGN KEY([car_part_id])
REFERENCES [dbo].[CarPart] ([carpart_id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_CarPart]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([order_id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Order]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Order_Users]
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_UserRole] FOREIGN KEY([login_role_id])
REFERENCES [dbo].[UserRole] ([user_role_id])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_UserRole]
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_Users] FOREIGN KEY([login_user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_Users]
GO
USE [master]
GO
ALTER DATABASE [ABCCarTradersDB] SET  READ_WRITE 
GO

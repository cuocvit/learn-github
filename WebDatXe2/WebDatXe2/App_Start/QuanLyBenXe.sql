USE [master]
GO
/****** Object:  Database [QuanLyBenXe]    Script Date: 11/26/2023 9:39:01 PM ******/
CREATE DATABASE [QuanLyBenXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBenXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER04\MSSQL\DATA\QuanLyBenXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBenXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER04\MSSQL\DATA\QuanLyBenXe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyBenXe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBenXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBenXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBenXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBenXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBenXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBenXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBenXe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBenXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBenXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBenXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBenXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBenXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyBenXe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBenXe', N'ON'
GO
ALTER DATABASE [QuanLyBenXe] SET QUERY_STORE = OFF
GO
USE [QuanLyBenXe]
GO
/****** Object:  Table [dbo].[admin_account]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](110) NULL,
	[username] [nvarchar](110) NULL,
	[password] [nvarchar](110) NULL,
	[name] [nvarchar](110) NULL,
	[phone] [nvarchar](110) NULL,
	[address] [nvarchar](110) NULL,
 CONSTRAINT [PK_admin_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buser_account]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buser_account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[account] [nvarchar](110) NULL,
	[password] [nvarchar](110) NULL,
	[name] [nvarchar](110) NULL,
	[phone] [nvarchar](110) NULL,
	[email] [nvarchar](110) NULL,
	[address] [nvarchar](110) NULL,
 CONSTRAINT [PK_buser_account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buses]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](210) NULL,
	[phone_number] [nvarchar](50) NULL,
	[avatar] [nchar](310) NULL,
	[status_confirm] [bit] NULL,
	[status_update] [bit] NULL,
	[buser_id] [int] NULL,
	[status_delete] [bit] NULL,
 CONSTRAINT [PK_buses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[checkpoints]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[checkpoints](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](110) NULL,
	[id_buses] [int] NULL,
 CONSTRAINT [PK_checkpoints] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cmt]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cmt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cmt] [nvarchar](max) NULL,
	[user_id] [int] NULL,
	[parent_cmt_id] [int] NULL,
 CONSTRAINT [PK_cmt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[discount]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[discount](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](110) NULL,
	[discount_percentage] [float] NULL,
	[trip_id] [int] NULL,
	[about] [nvarchar](110) NULL,
 CONSTRAINT [PK_discount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[guest_account]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[guest_account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](110) NULL,
	[password] [nvarchar](110) NULL,
	[name] [nvarchar](110) NULL,
	[email] [nvarchar](110) NULL,
	[address] [nvarchar](110) NULL,
	[phone] [nvarchar](110) NULL,
 CONSTRAINT [PK_guest_account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transactions]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transactions](
	[id] [uniqueidentifier] NOT NULL,
	[user_id] [int] NULL,
	[guest_id] [int] NULL,
	[trip_id] [int] NULL,
	[total_money] [float] NULL,
	[phone_number] [nvarchar](110) NULL,
	[name] [nvarchar](110) NULL,
	[email] [nchar](110) NULL,
	[address] [nchar](110) NULL,
	[date_success] [datetime] NULL,
	[type_pay] [int] NULL,
	[status] [bit] NULL,
	[note] [nvarchar](max) NULL,
 CONSTRAINT [PK_transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trip]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trip](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[start_point] [nvarchar](310) NULL,
	[end_point] [nvarchar](310) NULL,
	[cost] [int] NULL,
	[chair] [int] NULL,
	[status_confirm] [bit] NULL,
	[status_update] [bit] NULL,
	[status_delete] [bit] NULL,
	[id_discount] [int] NULL,
	[vehicle_id] [int] NULL,
 CONSTRAINT [PK_trip] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trip_details]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trip_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_start] [date] NULL,
	[time_start] [time](7) NULL,
	[date_end] [date] NULL,
	[time_end] [time](7) NULL,
	[total] [int] NULL,
	[trip_id] [int] NULL,
 CONSTRAINT [PK_trip_time] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehicle]    Script Date: 11/26/2023 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehicle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](210) NULL,
	[license_plate] [nvarchar](100) NULL,
	[type] [nvarchar](50) NULL,
	[avatar] [nvarchar](310) NULL,
	[status_confirm] [int] NULL,
	[status_update] [int] NULL,
	[status_delete] [int] NULL,
	[id_buses] [int] NULL,
 CONSTRAINT [PK_vehicle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admin_account] ON 

INSERT [dbo].[admin_account] ([id], [email], [username], [password], [name], [phone], [address]) VALUES (1, N'admin                                                                                                         ', NULL, N'admin', N'Quốc Việt', NULL, NULL)
SET IDENTITY_INSERT [dbo].[admin_account] OFF
GO
SET IDENTITY_INSERT [dbo].[buser_account] ON 

INSERT [dbo].[buser_account] ([id], [account], [password], [name], [phone], [email], [address]) VALUES (1, N'admin', N'admin', N'Đức Thuận', NULL, NULL, NULL)
INSERT [dbo].[buser_account] ([id], [account], [password], [name], [phone], [email], [address]) VALUES (2, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[buser_account] ([id], [account], [password], [name], [phone], [email], [address]) VALUES (3, N'a', N'b', N'c', NULL, NULL, NULL)
INSERT [dbo].[buser_account] ([id], [account], [password], [name], [phone], [email], [address]) VALUES (4, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[buser_account] OFF
GO
SET IDENTITY_INSERT [dbo].[buses] ON 

INSERT [dbo].[buses] ([id], [name], [phone_number], [avatar], [status_confirm], [status_update], [buser_id], [status_delete]) VALUES (1, N'Nhà xe Đức Thuận', N'093883743', N'https://thixaphutho.net/wp-content/uploads/2018/01/nha-xe-duc-thuan-thanh-thuy-my-dinh-3.jpg.webp                                                                                                                                                                                                                     ', 1, 0, NULL, 0)
INSERT [dbo].[buses] ([id], [name], [phone_number], [avatar], [status_confirm], [status_update], [buser_id], [status_delete]) VALUES (2, N'Nhà xe Thái Sơn', N'093847384', N'https://thixaphutho.net/wp-content/uploads/2018/01/nha-xe-duc-thuan-thanh-thuy-my-dinh-3.jpg.webp                                                                                                                                                                                                                     ', 1, 0, NULL, 0)
INSERT [dbo].[buses] ([id], [name], [phone_number], [avatar], [status_confirm], [status_update], [buser_id], [status_delete]) VALUES (3, N'Nhà xe Thiên Thai', N'024885335', N'https://thixaphutho.net/wp-content/uploads/2018/01/nha-xe-duc-thuan-thanh-thuy-my-dinh-3.jpg.webp                                                                                                                                                                                                                     ', 1, 0, NULL, 0)
INSERT [dbo].[buses] ([id], [name], [phone_number], [avatar], [status_confirm], [status_update], [buser_id], [status_delete]) VALUES (4, N'Nhà xe Mỹ Đình', N'098284747', N'https://thixaphutho.net/wp-content/uploads/2018/01/nha-xe-duc-thuan-thanh-thuy-my-dinh-3.jpg.webp                                                                                                                                                                                                                     ', 0, 0, NULL, 0)
SET IDENTITY_INSERT [dbo].[buses] OFF
GO
SET IDENTITY_INSERT [dbo].[guest_account] ON 

INSERT [dbo].[guest_account] ([id], [username], [password], [name], [email], [address], [phone]) VALUES (1, N'admin', N'admin', N'Nguyễn Quốc Việt', N'viet@gmail.com', N'Phú Thọ', N'094858585')
SET IDENTITY_INSERT [dbo].[guest_account] OFF
GO
SET IDENTITY_INSERT [dbo].[trip] ON 

INSERT [dbo].[trip] ([id], [start_point], [end_point], [cost], [chair], [status_confirm], [status_update], [status_delete], [id_discount], [vehicle_id]) VALUES (1, N'Bình Định', N'Sài Gòn', 200000, 30, 0, 0, 0, NULL, 1)
INSERT [dbo].[trip] ([id], [start_point], [end_point], [cost], [chair], [status_confirm], [status_update], [status_delete], [id_discount], [vehicle_id]) VALUES (2, N'Phú Thọ', N'Hà Nội', 70000, 25, 0, 0, 0, NULL, 1)
INSERT [dbo].[trip] ([id], [start_point], [end_point], [cost], [chair], [status_confirm], [status_update], [status_delete], [id_discount], [vehicle_id]) VALUES (3, N'Việt Trì', N'Hà Nội', 70000, 35, 0, 0, 0, NULL, 2)
INSERT [dbo].[trip] ([id], [start_point], [end_point], [cost], [chair], [status_confirm], [status_update], [status_delete], [id_discount], [vehicle_id]) VALUES (4, N'Bình Định', N'Sài Gòn', 150000, 25, 0, 0, 0, NULL, 2)
SET IDENTITY_INSERT [dbo].[trip] OFF
GO
SET IDENTITY_INSERT [dbo].[trip_details] ON 

INSERT [dbo].[trip_details] ([id], [date_start], [time_start], [date_end], [time_end], [total], [trip_id]) VALUES (1, CAST(N'2023-11-23' AS Date), CAST(N'09:30:00' AS Time), CAST(N'2023-11-23' AS Date), CAST(N'11:30:00' AS Time), 3, 1)
INSERT [dbo].[trip_details] ([id], [date_start], [time_start], [date_end], [time_end], [total], [trip_id]) VALUES (2, CAST(N'2023-11-23' AS Date), CAST(N'16:30:00' AS Time), CAST(N'2023-11-23' AS Date), CAST(N'18:00:00' AS Time), 10, 1)
INSERT [dbo].[trip_details] ([id], [date_start], [time_start], [date_end], [time_end], [total], [trip_id]) VALUES (3, CAST(N'2023-11-23' AS Date), CAST(N'06:00:00' AS Time), CAST(N'2023-11-23' AS Date), CAST(N'10:00:00' AS Time), 11, 2)
INSERT [dbo].[trip_details] ([id], [date_start], [time_start], [date_end], [time_end], [total], [trip_id]) VALUES (4, CAST(N'2023-11-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'2023-11-23' AS Date), CAST(N'16:00:00' AS Time), 10, 4)
SET IDENTITY_INSERT [dbo].[trip_details] OFF
GO
SET IDENTITY_INSERT [dbo].[vehicle] ON 

INSERT [dbo].[vehicle] ([id], [name], [license_plate], [type], [avatar], [status_confirm], [status_update], [status_delete], [id_buses]) VALUES (1, N'Đức Thuận 1', N'19A-395858', N'Giường nằm', N'https://thixaphutho.net/wp-content/uploads/2018/01/nha-xe-duc-thuan-thanh-thuy-my-dinh-1.jpg.webp', NULL, NULL, NULL, 1)
INSERT [dbo].[vehicle] ([id], [name], [license_plate], [type], [avatar], [status_confirm], [status_update], [status_delete], [id_buses]) VALUES (2, N'Thiên Thai 1', N'20L-938843', N'Ngồi', N'https://thixaphutho.net/wp-content/uploads/2018/01/nha-xe-duc-thuan-thanh-thuy-my-dinh-1.jpg.webp', NULL, NULL, NULL, 3)
INSERT [dbo].[vehicle] ([id], [name], [license_plate], [type], [avatar], [status_confirm], [status_update], [status_delete], [id_buses]) VALUES (3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[vehicle] ([id], [name], [license_plate], [type], [avatar], [status_confirm], [status_update], [status_delete], [id_buses]) VALUES (4, N'Đức Thuận 2', N'19A-198485', N'Ngồi', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2eKCdr5AFADjOQchshMm85riqOW5iM_jl4zbMhTvK4u5KK2EOM_1QM7Q1Dz_8Zbn3oJk&usqp=CAU', NULL, NULL, NULL, 1)
INSERT [dbo].[vehicle] ([id], [name], [license_plate], [type], [avatar], [status_confirm], [status_update], [status_delete], [id_buses]) VALUES (5, N'Thái Sơn 1', N'20L-199494', N'Nằm', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQFNnirK4bQ4oxYmskfzOPKuswoqtUsnYZZlw&usqp=CAU', NULL, NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[vehicle] OFF
GO
ALTER TABLE [dbo].[buses] ADD  CONSTRAINT [DF_buses_status_confirm]  DEFAULT ((0)) FOR [status_confirm]
GO
ALTER TABLE [dbo].[buses] ADD  CONSTRAINT [DF_buses_status_update]  DEFAULT ((0)) FOR [status_update]
GO
ALTER TABLE [dbo].[buses] ADD  CONSTRAINT [DF_buses_status_delete]  DEFAULT ((0)) FOR [status_delete]
GO
ALTER TABLE [dbo].[transactions] ADD  CONSTRAINT [DF_transactions_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[trip] ADD  CONSTRAINT [DF_trip_status_confirm]  DEFAULT ((0)) FOR [status_confirm]
GO
ALTER TABLE [dbo].[trip] ADD  CONSTRAINT [DF_trip_status_update]  DEFAULT ((0)) FOR [status_update]
GO
ALTER TABLE [dbo].[trip] ADD  CONSTRAINT [DF_trip_status_delete]  DEFAULT ((0)) FOR [status_delete]
GO
ALTER TABLE [dbo].[buses]  WITH CHECK ADD  CONSTRAINT [FK_buses_buser_account] FOREIGN KEY([buser_id])
REFERENCES [dbo].[buser_account] ([id])
GO
ALTER TABLE [dbo].[buses] CHECK CONSTRAINT [FK_buses_buser_account]
GO
ALTER TABLE [dbo].[checkpoints]  WITH CHECK ADD  CONSTRAINT [FK_checkpoints_buses] FOREIGN KEY([id_buses])
REFERENCES [dbo].[buses] ([id])
GO
ALTER TABLE [dbo].[checkpoints] CHECK CONSTRAINT [FK_checkpoints_buses]
GO
ALTER TABLE [dbo].[cmt]  WITH CHECK ADD  CONSTRAINT [FK_cmt_cmt1] FOREIGN KEY([parent_cmt_id])
REFERENCES [dbo].[cmt] ([id])
GO
ALTER TABLE [dbo].[cmt] CHECK CONSTRAINT [FK_cmt_cmt1]
GO
ALTER TABLE [dbo].[cmt]  WITH CHECK ADD  CONSTRAINT [FK_cmt_guest_account] FOREIGN KEY([user_id])
REFERENCES [dbo].[guest_account] ([id])
GO
ALTER TABLE [dbo].[cmt] CHECK CONSTRAINT [FK_cmt_guest_account]
GO
ALTER TABLE [dbo].[transactions]  WITH CHECK ADD  CONSTRAINT [FK_transactions_guest_account] FOREIGN KEY([guest_id])
REFERENCES [dbo].[guest_account] ([id])
GO
ALTER TABLE [dbo].[transactions] CHECK CONSTRAINT [FK_transactions_guest_account]
GO
ALTER TABLE [dbo].[transactions]  WITH CHECK ADD  CONSTRAINT [FK_transactions_trip] FOREIGN KEY([trip_id])
REFERENCES [dbo].[trip] ([id])
GO
ALTER TABLE [dbo].[transactions] CHECK CONSTRAINT [FK_transactions_trip]
GO
ALTER TABLE [dbo].[trip]  WITH CHECK ADD  CONSTRAINT [FK_trip_discount] FOREIGN KEY([id_discount])
REFERENCES [dbo].[discount] ([id])
GO
ALTER TABLE [dbo].[trip] CHECK CONSTRAINT [FK_trip_discount]
GO
ALTER TABLE [dbo].[trip]  WITH CHECK ADD  CONSTRAINT [FK_trip_vehicle] FOREIGN KEY([vehicle_id])
REFERENCES [dbo].[vehicle] ([id])
GO
ALTER TABLE [dbo].[trip] CHECK CONSTRAINT [FK_trip_vehicle]
GO
ALTER TABLE [dbo].[trip_details]  WITH CHECK ADD  CONSTRAINT [FK_trip_time_trip] FOREIGN KEY([trip_id])
REFERENCES [dbo].[trip] ([id])
GO
ALTER TABLE [dbo].[trip_details] CHECK CONSTRAINT [FK_trip_time_trip]
GO
ALTER TABLE [dbo].[vehicle]  WITH CHECK ADD  CONSTRAINT [FK_vehicle_buses] FOREIGN KEY([id_buses])
REFERENCES [dbo].[buses] ([id])
GO
ALTER TABLE [dbo].[vehicle] CHECK CONSTRAINT [FK_vehicle_buses]
GO
/****** Object:  StoredProcedure [dbo].[GetTripDetails]    Script Date: 11/26/2023 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripDetails]
    @TripId INT,
    @TripDetailsId INT
AS
BEGIN
    SELECT 
        trip.id AS 'trip_id', 
        trip_details.id AS 'trip_details_id', 
        vehicle.id AS 'vehicle_id',
        buses.id AS 'buses_id',
        start_point, 
        end_point, 
        cost, 
        (chair - total) AS 'so_ghe_trong', 
        date_start, 
        date_end,
		time_start,
		time_end,
        vehicle.name AS 'ten_xe', 
        vehicle.avatar AS 'anh_xe', 
        buses.avatar AS 'anh_nxe',
        buses.name AS 'ten_nxe'
    FROM 
        trip
    INNER JOIN 
        trip_details ON trip.id = trip_details.trip_id
    INNER JOIN 
        vehicle ON trip.vehicle_id = vehicle.id
    INNER JOIN 
        buses ON vehicle.id_buses = buses.id
    WHERE 
        trip.id = @TripId AND trip_details.id = @TripDetailsId
END
GO
/****** Object:  StoredProcedure [dbo].[SearchTrips]    Script Date: 11/26/2023 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchTrips]
    @StartPoint NVARCHAR(255) = NULL,
    @EndPoint NVARCHAR(255) = NULL,
    @DateStart DATE = NULL,
    @TimeStart TIME = NULL,
    @TimeEnd TIME = NULL,
    @VehicleType NVARCHAR(255) = NULL,
	@SortOrder NVARCHAR(10) = 'ASC'
AS
BEGIN
    SELECT
        trip.id,
        trip_details.id AS trip_details_id,
        vehicle.type AS vehicle_type,
        trip.cost,
        trip.start_point,
        trip.end_point,
        trip_details.time_start,
        trip_details.time_end,
        (trip.chair - trip_details.total) AS [Chair]
    FROM
        trip
    INNER JOIN
        trip_details ON trip.id = trip_details.trip_id
    INNER JOIN
        vehicle ON trip.vehicle_id = vehicle.id
    WHERE
        (@StartPoint IS NULL OR start_point = @StartPoint)
        AND (@EndPoint IS NULL OR end_point = @EndPoint)
        AND (@DateStart IS NULL OR date_start = @DateStart)
        AND (@TimeStart IS NULL OR time_start = @TimeStart)
        AND (@TimeEnd IS NULL OR time_end = @TimeEnd)
        AND (@VehicleType IS NULL OR vehicle.type = @VehicleType)
	ORDER BY
        trip.cost * CASE WHEN @SortOrder = 'DESC' THEN -1 ELSE 1 END
END
GO
/****** Object:  StoredProcedure [dbo].[SearchTrips1]    Script Date: 11/26/2023 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchTrips1]
    @StartPoint NVARCHAR(255) = NULL,
    @EndPoint NVARCHAR(255) = NULL,
    @DateStart DATE = NULL
AS
BEGIN
    SELECT
        trip.id,
        trip_details.id AS trip_details_id,
        vehicle.type AS vehicle_type,
        trip.cost,
        trip.start_point,
        trip.end_point,
        trip_details.time_start,
        trip_details.time_end,
        (trip.chair - trip_details.total) AS [Chair]
    FROM
        trip
    INNER JOIN
        trip_details ON trip.id = trip_details.trip_id
    INNER JOIN
        vehicle ON trip.vehicle_id = vehicle.id
    WHERE
        (@StartPoint IS NULL OR start_point = @StartPoint)
        AND (@EndPoint IS NULL OR end_point = @EndPoint)
        AND (@DateStart IS NULL OR CONVERT(DATE, date_start) = @DateStart)
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyBenXe] SET  READ_WRITE 
GO

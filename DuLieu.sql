USE [master]
GO
/****** Object:  Database [QLBanHang]    Script Date: 24-Mar-24 12:12:39 ******/
CREATE DATABASE [QLBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBanHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBanHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLBanHang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBanHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QLBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBanHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBanHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLBanHang] SET QUERY_STORE = OFF
GO
USE [QLBanHang]
GO
/****** Object:  Table [dbo].[tblChatLieu]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatLieu](
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[TenChatLieu] [ntext] NOT NULL,
 CONSTRAINT [PK_tblChatLieu] PRIMARY KEY CLUSTERED 
(
	[MaChatLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHDBan]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDBan](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[GiamGia] [int] NULL,
	[ThanhTien] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChiTietHDBan] PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHang]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHang](
	[MaHang] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [nvarchar](50) NULL,
	[DonGiaBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHDBan]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHDBan](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MaKhach] [nvarchar](50) NULL,
	[NgayBan] [date] NULL,
	[TongTien] [ntext] NULL,
 CONSTRAINT [PK_tblHDBan] PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhach]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhach](
	[MaKhach] [nvarchar](50) NOT NULL,
	[TenKhach] [nvarchar](50) NOT NULL,
	[DiaChi] [ntext] NULL,
	[SoDienThoai] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [ntext] NULL,
	[NgaySinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 24-Mar-24 12:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](50) NOT NULL,
	[typeLogin] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'001', N'Vải')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'002', N'Sắt')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'003', N'Đồng')
GO
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD22320240', N'002', 12, 0, N'3840')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD22320240', N'003', 20, 0, N'500')
GO
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [SoLuong], [DonGiaNhap], [DonGiaBan]) VALUES (N'001', N'Áo', 8, N'200', N'250')
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [SoLuong], [DonGiaNhap], [DonGiaBan]) VALUES (N'002', N'Sách', 134, N'250', N'320')
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [SoLuong], [DonGiaNhap], [DonGiaBan]) VALUES (N'003', N'Bimbim', 535, N'20', N'25')
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [SoLuong], [DonGiaNhap], [DonGiaBan]) VALUES (N'004', N'Mì Chính', 2000, N'25', N'30')
GO
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [MaKhach], [NgayBan], [TongTien]) VALUES (N'HD22320240', N'001', N'001', CAST(N'2024-03-22' AS Date), N'4340')
GO
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai], [NgaySinh], [GhiChu]) VALUES (N'001', N'Nguyễn Thanh Bình', N'Hà Nội', N'0329990540', CAST(N'2003-02-20' AS Date), N'ok')
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai], [NgaySinh], [GhiChu]) VALUES (N'002', N'Nguyễn Văn A', N'Đà Nẵng', N'0354567457', CAST(N'2000-03-04' AS Date), NULL)
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai], [NgaySinh], [GhiChu]) VALUES (N'003', N'Lê Văn Tú', N'HCM', N'0245757569', CAST(N'2001-08-16' AS Date), NULL)
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai], [NgaySinh], [GhiChu]) VALUES (N'004', N'Phùng Lập Dị', N'HCM', N'0356457548', CAST(N'1999-04-09' AS Date), NULL)
GO
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh]) VALUES (N'001', N'Nguyễn Thanh Bình', N'Nam', N'Hà Nội', N'20-02-2003')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh]) VALUES (N'002', N'Trịnh Thúy An', N'Nữ', N'HCM', N'02-04-2000')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh]) VALUES (N'003', N'Nguyễn Văn Bách', N'Nam', N'Hà Nội', N'17-12-2001')
GO
INSERT [dbo].[tblUser] ([userName], [passWord], [typeLogin]) VALUES (N'admin', N'123', N'admin')
GO
ALTER TABLE [dbo].[tblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDBan_tblHDBan] FOREIGN KEY([MaHDBan])
REFERENCES [dbo].[tblHDBan] ([MaHDBan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDBan] CHECK CONSTRAINT [FK_tblChiTietHDBan_tblHDBan]
GO
ALTER TABLE [dbo].[tblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDBan_tblSanPham] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tblHang] ([MaHang])
GO
ALTER TABLE [dbo].[tblChiTietHDBan] CHECK CONSTRAINT [FK_tblChiTietHDBan_tblSanPham]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblKhachHang] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tblKhach] ([MaKhach])
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblKhachHang]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tblNhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblNhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLBanHang] SET  READ_WRITE 
GO

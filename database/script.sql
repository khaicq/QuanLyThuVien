USE [master]
GO
/****** Object:  Database [DBQuanLyThuVien]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE DATABASE [DBQuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBQuanLyThuVien', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DBQuanLyThuVien.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBQuanLyThuVien_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DBQuanLyThuVien_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBQuanLyThuVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBQuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBQuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBQuanLyThuVien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DBQuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBQuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBQuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBQuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBQuanLyThuVien] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DBQuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBQuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [DBQuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBQuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBQuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBQuanLyThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DBQuanLyThuVien]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BinhLuans]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuans](
	[IDBinhLuan] [int] IDENTITY(1,1) NOT NULL,
	[IDDocGia] [int] NOT NULL,
	[TenDocGia] [nvarchar](max) NOT NULL,
	[IDSach] [int] NOT NULL,
	[ThoiGian] [datetime2](7) NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
 CONSTRAINT [PK_BinhLuans] PRIMARY KEY CLUSTERED 
(
	[IDBinhLuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiNhanhs]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanhs](
	[IDChiNhanh] [int] IDENTITY(1,1) NOT NULL,
	[TenChiNhanh] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[NgayThanhLap] [datetime2](7) NOT NULL,
	[IDQuanLy] [int] NOT NULL,
	[IDNhanVien] [int] NOT NULL,
 CONSTRAINT [PK_ChiNhanhs] PRIMARY KEY CLUSTERED 
(
	[IDChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocGias]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGias](
	[TaiKhoan] [nvarchar](max) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[LoaiDocGia] [int] NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[IDDocGia] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_DocGias] PRIMARY KEY CLUSTERED 
(
	[IDDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSaches]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSaches](
	[IDLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiSaches] PRIMARY KEY CLUSTERED 
(
	[IDLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MuonSaches]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonSaches](
	[IDPhieu] [int] IDENTITY(1,1) NOT NULL,
	[IDSach] [int] NOT NULL,
	[TinhTrangSach] [nvarchar](max) NOT NULL,
	[PhiMuon] [int] NOT NULL,
	[TienCoc] [int] NOT NULL,
	[NgayMuon] [datetime2](7) NOT NULL,
	[IDDocGia] [int] NOT NULL,
	[IDNhanVien] [int] NOT NULL,
	[TenChiNhanh] [nvarchar](max) NULL,
	[TrangThai] [int] NOT NULL,
	[NgayTra] [datetime2](7) NOT NULL,
	[NgayTraThuc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MuonSaches] PRIMARY KEY CLUSTERED 
(
	[IDPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanViens]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanViens](
	[IDNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [nvarchar](max) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[LoaiNhanVien] [int] NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[IDChiNhanh] [int] NOT NULL,
 CONSTRAINT [PK_NhanViens] PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SachChiNhanhs]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SachChiNhanhs](
	[IDSachChiNhanh] [int] IDENTITY(1,1) NOT NULL,
	[IDSach] [int] NOT NULL,
	[IDChiNhanh] [int] NOT NULL,
	[SoSachCon] [int] NOT NULL,
	[TongSoLuong] [int] NOT NULL,
 CONSTRAINT [PK_SachChiNhanhs] PRIMARY KEY CLUSTERED 
(
	[IDSachChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Saches]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saches](
	[IDSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](max) NOT NULL,
	[IDLoai] [int] NOT NULL,
	[TacGia] [nvarchar](max) NULL,
	[NhaXuatBan] [nvarchar](max) NULL,
	[NamXuatBan] [int] NOT NULL,
	[SoTrang] [int] NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[XepHangTb] [real] NOT NULL,
	[SoDanhGia] [int] NOT NULL,
	[DanhGia] [int] NOT NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[TienMua] [int] NOT NULL,
	[TienMuon] [int] NOT NULL,
 CONSTRAINT [PK_Saches] PRIMARY KEY CLUSTERED 
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[yeuCauThemSaches]    Script Date: 2/20/2019 7:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yeuCauThemSaches](
	[IDYeuCau] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](max) NOT NULL,
	[TacGia] [nvarchar](max) NULL,
 CONSTRAINT [PK_yeuCauThemSaches] PRIMARY KEY CLUSTERED 
(
	[IDYeuCau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_BinhLuans_IDsach]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_BinhLuans_IDsach] ON [dbo].[BinhLuans]
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MuonSaches_IDDocGia]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_MuonSaches_IDDocGia] ON [dbo].[MuonSaches]
(
	[IDDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MuonSaches_IDNhanVien]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_MuonSaches_IDNhanVien] ON [dbo].[MuonSaches]
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MuonSaches_IDSach]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_MuonSaches_IDSach] ON [dbo].[MuonSaches]
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NhanViens_IDChiNhanh]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_NhanViens_IDChiNhanh] ON [dbo].[NhanViens]
(
	[IDChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SachChiNhanhs_IDChiNhanh]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_SachChiNhanhs_IDChiNhanh] ON [dbo].[SachChiNhanhs]
(
	[IDChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SachChiNhanhs_IDSach]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_SachChiNhanhs_IDSach] ON [dbo].[SachChiNhanhs]
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Saches_IDLoai]    Script Date: 2/20/2019 7:43:46 PM ******/
CREATE NONCLUSTERED INDEX [IX_Saches_IDLoai] ON [dbo].[Saches]
(
	[IDLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MuonSaches] ADD  DEFAULT ((0)) FOR [IDDocGia]
GO
ALTER TABLE [dbo].[MuonSaches] ADD  DEFAULT ((0)) FOR [IDNhanVien]
GO
ALTER TABLE [dbo].[MuonSaches] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[MuonSaches] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [NgayTra]
GO
ALTER TABLE [dbo].[MuonSaches] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [NgayTraThuc]
GO
ALTER TABLE [dbo].[NhanViens] ADD  DEFAULT ((0)) FOR [IDChiNhanh]
GO
ALTER TABLE [dbo].[SachChiNhanhs] ADD  DEFAULT ((0)) FOR [SoSachCon]
GO
ALTER TABLE [dbo].[SachChiNhanhs] ADD  DEFAULT ((0)) FOR [TongSoLuong]
GO
ALTER TABLE [dbo].[Saches] ADD  DEFAULT ((0)) FOR [DanhGia]
GO
ALTER TABLE [dbo].[Saches] ADD  DEFAULT ((0)) FOR [TienMua]
GO
ALTER TABLE [dbo].[Saches] ADD  DEFAULT ((0)) FOR [TienMuon]
GO
ALTER TABLE [dbo].[BinhLuans]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuans_Saches_IDsach] FOREIGN KEY([IDSach])
REFERENCES [dbo].[Saches] ([IDSach])
GO
ALTER TABLE [dbo].[BinhLuans] CHECK CONSTRAINT [FK_BinhLuans_Saches_IDsach]
GO
ALTER TABLE [dbo].[MuonSaches]  WITH CHECK ADD  CONSTRAINT [FK_MuonSaches_DocGias_IDDocGia] FOREIGN KEY([IDDocGia])
REFERENCES [dbo].[DocGias] ([IDDocGia])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuonSaches] CHECK CONSTRAINT [FK_MuonSaches_DocGias_IDDocGia]
GO
ALTER TABLE [dbo].[MuonSaches]  WITH CHECK ADD  CONSTRAINT [FK_MuonSaches_NhanViens_IDNhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanViens] ([IDNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuonSaches] CHECK CONSTRAINT [FK_MuonSaches_NhanViens_IDNhanVien]
GO
ALTER TABLE [dbo].[MuonSaches]  WITH CHECK ADD  CONSTRAINT [FK_MuonSaches_Saches_IDSach] FOREIGN KEY([IDSach])
REFERENCES [dbo].[Saches] ([IDSach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuonSaches] CHECK CONSTRAINT [FK_MuonSaches_Saches_IDSach]
GO
ALTER TABLE [dbo].[NhanViens]  WITH CHECK ADD  CONSTRAINT [FK_NhanViens_ChiNhanhs_IDChiNhanh] FOREIGN KEY([IDChiNhanh])
REFERENCES [dbo].[ChiNhanhs] ([IDChiNhanh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanViens] CHECK CONSTRAINT [FK_NhanViens_ChiNhanhs_IDChiNhanh]
GO
ALTER TABLE [dbo].[SachChiNhanhs]  WITH CHECK ADD  CONSTRAINT [FK_SachChiNhanhs_ChiNhanhs_IDChiNhanh] FOREIGN KEY([IDChiNhanh])
REFERENCES [dbo].[ChiNhanhs] ([IDChiNhanh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SachChiNhanhs] CHECK CONSTRAINT [FK_SachChiNhanhs_ChiNhanhs_IDChiNhanh]
GO
ALTER TABLE [dbo].[SachChiNhanhs]  WITH CHECK ADD  CONSTRAINT [FK_SachChiNhanhs_Saches_IDSach] FOREIGN KEY([IDSach])
REFERENCES [dbo].[Saches] ([IDSach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SachChiNhanhs] CHECK CONSTRAINT [FK_SachChiNhanhs_Saches_IDSach]
GO
ALTER TABLE [dbo].[Saches]  WITH CHECK ADD  CONSTRAINT [FK_Saches_LoaiSaches_IDLoai] FOREIGN KEY([IDLoai])
REFERENCES [dbo].[LoaiSaches] ([IDLoai])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Saches] CHECK CONSTRAINT [FK_Saches_LoaiSaches_IDLoai]
GO
USE [master]
GO
ALTER DATABASE [DBQuanLyThuVien] SET  READ_WRITE 
GO

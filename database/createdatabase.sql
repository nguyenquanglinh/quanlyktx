create database [QuanLyKTX]
go
USE [QuanLyKTX]
GO
/****** Object:  Table [dbo].[CongToDien]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongToDien](
	[maCongToDien] [char](10) NOT NULL,
	[chiSoCu] [char](10) NULL,
	[chiSoMoi] [char](10) NULL,
	[maDaiLy] [char](10) NULL,
 CONSTRAINT [PK_CongToDien] PRIMARY KEY CLUSTERED 
(
	[maCongToDien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CongToNuoc]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongToNuoc](
	[maCongToNuoc] [char](10) NOT NULL,
	[chiSoCu] [char](10) NULL,
	[chiSoMoi] [char](10) NULL,
	[maDaiLy] [char](10) NULL,
 CONSTRAINT [PK_CongToNuoc] PRIMARY KEY CLUSTERED 
(
	[maCongToNuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DaiLy]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DaiLy](
	[maDaiLy] [char](10) NOT NULL,
	[tenDaiLy] [char](10) NULL,
	[SDT] [char](11) NULL,
	[diaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_DaiLy] PRIMARY KEY CLUSTERED 
(
	[maDaiLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[maDichVu] [char](10) NOT NULL,
	[tenDichVu] [nvarchar](50) NULL,
	[maDaiLy] [char](10) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[maDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHoaDon] [char](10) NOT NULL,
	[maNhanVien] [char](10) NULL,
	[maPhong] [char](10) NULL,
	[makhu] [char](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonDienChiTiet]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonDienChiTiet](
	[maCongToDien] [char](10) NOT NULL,
	[ngayThang] [date] NULL,
	[donGia] [char](10) NULL,
	[tongTien] [char](20) NULL,
	[maHoaDon] [char](10) NOT NULL,
 CONSTRAINT [PK_HoaDonDienChiTiet] PRIMARY KEY CLUSTERED 
(
	[maCongToDien] ASC,
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonNuocChiTiet]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNuocChiTiet](
	[maCongToNuoc] [char](10) NOT NULL,
	[ngayThang] [date] NULL,
	[donGia] [char](10) NULL,
	[tongTien] [char](20) NULL,
	[maHoaDon] [char](10) NOT NULL,
 CONSTRAINT [PK_HoaDonNuocChiTiet] PRIMARY KEY CLUSTERED 
(
	[maCongToNuoc] ASC,
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HopDong](
	[maHopDong] [char](10) NOT NULL,
	[maSinhVien] [char](10) NULL,
	[maNhanVien] [char](10) NULL,
	[soPhong] [char](10) NULL,
	[khuNha] [char](10) NULL,
	[ngayLap] [date] NULL,
	[ngayBatDau] [date] NULL,
	[ngayKetThuc] [date] NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[maHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khu]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khu](
	[maKhu] [char](10) NOT NULL,
	[tenKhu] [nvarchar](50) NULL,
	[tinhTrang] [nvarchar](50) NULL,
	[moTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khu] PRIMARY KEY CLUSTERED 
(
	[maKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [char](10) NOT NULL,
	[HoVaTen] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](5) NULL,
	[diaChi] [nvarchar](50) NULL,
	[chucVu] [nvarchar](50) NULL,
	[SDT] [char](11) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[maPhong] [char](10) NOT NULL,
	[tenPhong] [nvarchar](50) NOT NULL,
	[maKhu] [char](10) NULL,
	[soLuongSV] [int] NULL,
	[tinhTrang] [nvarchar](50) NULL,
	[moTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phong_1] PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [char](10) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[CMND] [char](15) NULL,
	[SDT] [char](11) NULL,
	[lopKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 12/15/2020 10:56:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongBao](
	[maThongBao] [char](10) NOT NULL,
	[ngayLap] [date] NULL,
	[noiDung] [nvarchar](4000) NULL,
	[maNhanVien] [char](10) NULL,
 CONSTRAINT [PK_ThongBao] PRIMARY KEY CLUSTERED 
(
	[maThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SinhVien] ([maSinhVien], [hoTen], [ngaySinh], [CMND], [SDT], [lopKhoa]) VALUES (N'1         ', N'nguyễn văn 1', CAST(N'1999-01-01' AS Date), N'12345678901    ', N'1234567890 ', N'test')
INSERT [dbo].[SinhVien] ([maSinhVien], [hoTen], [ngaySinh], [CMND], [SDT], [lopKhoa]) VALUES (N'2         ', N'nguyễn văn 2', CAST(N'1999-01-02' AS Date), N'12345678902    ', N'1234567891 ', N'test')
INSERT [dbo].[SinhVien] ([maSinhVien], [hoTen], [ngaySinh], [CMND], [SDT], [lopKhoa]) VALUES (N'3         ', N'nguyễn văn 3', CAST(N'1999-03-01' AS Date), N'1234567893     ', N'1234567892 ', N'test')
ALTER TABLE [dbo].[CongToDien]  WITH CHECK ADD  CONSTRAINT [FK_CongToDien_DaiLy] FOREIGN KEY([maDaiLy])
REFERENCES [dbo].[DaiLy] ([maDaiLy])
GO
ALTER TABLE [dbo].[CongToDien] CHECK CONSTRAINT [FK_CongToDien_DaiLy]
GO
ALTER TABLE [dbo].[CongToNuoc]  WITH CHECK ADD  CONSTRAINT [FK_CongToNuoc_DaiLy] FOREIGN KEY([maDaiLy])
REFERENCES [dbo].[DaiLy] ([maDaiLy])
GO
ALTER TABLE [dbo].[CongToNuoc] CHECK CONSTRAINT [FK_CongToNuoc_DaiLy]
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DichVu_DaiLy] FOREIGN KEY([maDaiLy])
REFERENCES [dbo].[DaiLy] ([maDaiLy])
GO
ALTER TABLE [dbo].[DichVu] CHECK CONSTRAINT [FK_DichVu_DaiLy]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Khu] FOREIGN KEY([makhu])
REFERENCES [dbo].[Khu] ([maKhu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Khu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Phong] FOREIGN KEY([maPhong])
REFERENCES [dbo].[Phong] ([maPhong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Phong]
GO
ALTER TABLE [dbo].[HoaDonDienChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonDienChiTiet_CongToDien] FOREIGN KEY([maCongToDien])
REFERENCES [dbo].[CongToDien] ([maCongToDien])
GO
ALTER TABLE [dbo].[HoaDonDienChiTiet] CHECK CONSTRAINT [FK_HoaDonDienChiTiet_CongToDien]
GO
ALTER TABLE [dbo].[HoaDonDienChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonDienChiTiet_HoaDon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HoaDon] ([maHoaDon])
GO
ALTER TABLE [dbo].[HoaDonDienChiTiet] CHECK CONSTRAINT [FK_HoaDonDienChiTiet_HoaDon]
GO
ALTER TABLE [dbo].[HoaDonNuocChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNuocChiTiet_CongToNuoc] FOREIGN KEY([maCongToNuoc])
REFERENCES [dbo].[CongToNuoc] ([maCongToNuoc])
GO
ALTER TABLE [dbo].[HoaDonNuocChiTiet] CHECK CONSTRAINT [FK_HoaDonNuocChiTiet_CongToNuoc]
GO
ALTER TABLE [dbo].[HoaDonNuocChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNuocChiTiet_HoaDon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HoaDon] ([maHoaDon])
GO
ALTER TABLE [dbo].[HoaDonNuocChiTiet] CHECK CONSTRAINT [FK_HoaDonNuocChiTiet_HoaDon]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_NhanVien]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_SinhVien] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_SinhVien]
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD  CONSTRAINT [FK_ThongBao_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[ThongBao] CHECK CONSTRAINT [FK_ThongBao_NhanVien]
GO

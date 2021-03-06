USE master
CREATE DATABASE [DA_QLTV]
GO
USE [DA_QLTV]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA]
(
	[MaDG] [nchar](10) NOT NULL,
	[TenDG] [nchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT] [nchar](20) NULL,
	[NgaySinh] [smalldatetime] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NOT NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT] [nchar](20) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[TaiKhoan] [nchar](20) NULL,
	[MatKhau] [nchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NXB]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB]
(
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nchar](100) NOT NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [nchar](10) NOT NULL,
	[MaDG] [nchar](10) NOT NULL,
	[NgayMuon] [smalldatetime] NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_PHIEUMUON]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PHIEUMUON](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[HanTra] [smalldatetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nchar](100) NOT NULL,
	[Gia] [bigint] NULL,
	[MaNXB] [nchar](10) NULL,
	[MaTL] [nchar](10) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [nchar](10) NOT NULL,
	[TenTL] [nchar](100) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRASACH]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRASACH](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[NgayTra] [smalldatetime] NOT NULL,
	[PhatQuaHan] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[dsmuon]    Script Date: 12/21/2020 8:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE view [dbo].[dsmuon] as select distinct dg.TenDG,s.TenSach,pm.NgayMuon,qlpm.HanTra,ts.PhatQuaHan from PHIEUMUON pm join QL_PHIEUMUON qlpm on pm.MaPM=qlpm.MaPM join DOCGIA dg on pm.MaDG=dg.MaDG join TRASACH ts on ts.MaPM=qlpm.MaPM join SACH s on s.MaSach=qlpm.MaSach  
GO
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG01', N'Nguyễn Minh Hoàng', N'Nam', N'Tịnh An  ', N'038917267', CAST(N'1998-11-27 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG02', N'Nguyễn Thị Thái Bình', N'Nữ', N'Quận 7 ', N'0545789987', CAST(N'1998-01-27 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG03', N'Lê Hà Uyên Nhi ', N'Nữ ', N'Tịnh Hà  ', N'01257995654', CAST(N'1977-02-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG04', N'Nguyễn Phan Quỳnh Như', N'Nữ', N'Tịnh An ', N'0214842210 ', CAST(N'1998-11-27 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG05', N'Nguyễn Minh Nghĩa', N'Nam', N'Quảng Nam', N'024564090', CAST(N'1998-11-27 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG06', N'Nguyễn Phương', N'Nam', N'Gia Lai', N'0245661432', CAST(N'1998-06-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG07', N'Phạm Lương Bích Phương', N'Nữ', N'Đà Lạt', N'0245678979', CAST(N'2000-03-15 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG08', N'Lâm Thị Ngọc Hương', N'Nữ', N'Đăk Lắc', N'0245694657', CAST(N'1999-10-28 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG09', N'Nguyễn Thị Thu Huyền', N'Nữ', N'Vũng Tàu', N'0245562231', CAST(N'2001-5-15 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG010', N'Lê Đức Minh Quân', N'Nam', N'Quận 2', N'0345562256', CAST(N'2001-4-11 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG011', N'Nguyễn Thị Ngọc Trâm', N'Nữ', N'Kon Tum', N'0334463026', CAST(N'2001-20-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT], [NgaySinh]) VALUES (N'DG012', N'Nguyễn Thiên Thảo', N'Nữ', N'Quảng Trị', N'0445569609', CAST(N'2001-09-23 00:00:00' AS SmallDateTime))


INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [NgaySinh], [TaiKhoan], [MatKhau]) VALUES (N'NV01', N'Lê Văn Thành', N'Nam', N'Kon Tum ', N'0123456789', CAST(N'2000-08-01 00:00:00' AS SmallDateTime), N'thanh123', N'123')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [NgaySinh], [TaiKhoan], [MatKhau]) VALUES (N'NV02', N'Võ Hoàng Thái ', N'Nữ', N'Hóc Môn ', N'02221554', CAST(N'2000-11-27 00:00:00' AS SmallDateTime), NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [NgaySinh], [TaiKhoan], [MatKhau]) VALUES (N'NV03', N'Hoàng Hôn Tháng Bảy', N'Nam', N'TP. Hồ Chí Minh', N'012225548', CAST(N'2002-12-19 00:00:00' AS SmallDateTime), NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [NgaySinh], [TaiKhoan], [MatKhau]) VALUES (N'NV04', N'Tình Khúc Vàng', N'Nam', N'Đà Nẵng', N'0111111111', CAST(N'1999-12-24 00:00:00' AS SmallDateTime), NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [NgaySinh], [TaiKhoan], [MatKhau]) VALUES (N'NV05', N'Lê Minh Hiếu', N'Nâm', N'Hà Đông', N'0123456788', CAST(N'2000-12-12 00:00:00' AS SmallDateTime), N'111', N'111')

INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB001', N'Giáo dục ', N'An Phú Sinh,Quảng Ngãi ', N'01234546')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB002', N'Tiền Phong  ', N'Quận 7, TP. Hồ Chí Minh', N'011111245664')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB003', N'Tuổi Trẻ', N'An Phú Sinh, tp Quảng Ngãi ', N'02315646')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB004', N'Giáo dục', N'Đông Hà, tp Quảng Trị', N'02315647')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB005', N'Tuổi Trẻ', N'Lâm Đồng, tp Đà Lạt ', N'02315647')

INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM001', N'DG01', CAST(N'2020-12-22 00:00:00' AS SmallDateTime), N'NV02')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM002', N'DG03', CAST(N'2020-11-20 00:00:00' AS SmallDateTime), N'NV01 ')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM003', N'DG02', CAST(N'2020-11-22 00:00:00' AS SmallDateTime), N'NV02 ')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM004', N'DG04', CAST(N'2020-11-22 00:00:00' AS SmallDateTime), N'NV01 ')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM005', N'DG05', CAST(N'2020-11-22 00:00:00' AS SmallDateTime), N'NV01')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM006 ', N'DG01', CAST(N'2020-12-22 00:00:00' AS SmallDateTime), N'NV02')

INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra]) VALUES (N'PM001', N'S001', CAST(N'2020-12-22 00:00:00' AS SmallDateTime))
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra]) VALUES (N'PM002', N'S003', CAST(N'2020-12-25 00:00:00' AS SmallDateTime))
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra]) VALUES (N'PM003', N'S006', CAST(N'2020-12-23 00:00:00' AS SmallDateTime))
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra]) VALUES (N'PM006', N'S005', CAST(N'2020-12-25 00:00:00' AS SmallDateTime))
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra]) VALUES (N'PM004', N'S005', CAST(N'2020-12-25 00:00:00' AS SmallDateTime))
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra]) VALUES (N'PM005', N'S004', CAST(N'2020-12-27 00:00:00' AS SmallDateTime))

INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [TinhTrang]) VALUES (N'S001  ', N'Lập trình hướng đối tượng  ', 120, N'NXB001', N'TL01 ', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [TinhTrang]) VALUES (N'S002  ', N'Công nghệ phần miềm ', 78, N'NXB001 ', N'TL01 ', 0)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [TinhTrang]) VALUES (N'S003 ', N'Toán đại cương', 45, N'NXB001', N'TL02 ', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [TinhTrang]) VALUES (N'S004  ', N'Toán đại cương ', 45, N'NXB001', N'TL02', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [TinhTrang]) VALUES (N'S005 ', N'Vật Lý đại cương ', 50, N'NXB001', N'TL01', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [TinhTrang]) VALUES (N'S006 ', N'Cấu trúc dữ liệu', 68, N'NXB001', N'TL01', 1)

INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL01', N'Công nghệ Thông tin')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL02', N'Toán ')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL03', N'Tạp chí')

INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [MaNV], [NgayTra], [PhatQuaHan]) VALUES (N'PM001', N'S001', N'NV02', CAST(N'2020-12-22 00:00:00' AS SmallDateTime), 10000)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [MaNV], [NgayTra], [PhatQuaHan]) VALUES (N'PM002', N'S003', N'NV01 ', CAST(N'2020-12-25 00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [MaNV], [NgayTra], [PhatQuaHan]) VALUES (N'PM003', N'S006', N'NV02 ', CAST(N'2020-12-23 00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [MaNV], [NgayTra], [PhatQuaHan]) VALUES (N'PM006', N'S005', N'NV02', CAST(N'2020-12-25 00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [MaNV], [NgayTra], [PhatQuaHan]) VALUES (N'PM004', N'S005 ', N'NV01 ', CAST(N'2020-12-25 00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [MaNV], [NgayTra], [PhatQuaHan]) VALUES (N'PM005', N'S004 ', N'NV01 ', CAST(N'2020-12-27 00:00:00' AS SmallDateTime), 0)
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[QL_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_QL_PHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[QL_PHIEUMUON] CHECK CONSTRAINT [FK_QL_PHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[QL_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_QL_PHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[QL_PHIEUMUON] CHECK CONSTRAINT [FK_QL_PHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NXB]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI1] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI1]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_NHANVIEN]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_PHIEUMUON]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_SACH]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[4] 2[27] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "pm"
            Begin Extent = 
               Top = 145
               Left = 404
               Bottom = 266
               Right = 568
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qlpm"
            Begin Extent = 
               Top = 17
               Left = 43
               Bottom = 121
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dg"
            Begin Extent = 
               Top = 2
               Left = 404
               Bottom = 123
               Right = 568
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "ts"
            Begin Extent = 
               Top = 146
               Left = 42
               Bottom = 267
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 240
               Left = 240
               Bottom = 361
               Right = 404
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'dsmuon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'dsmuon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'dsmuon'
GO

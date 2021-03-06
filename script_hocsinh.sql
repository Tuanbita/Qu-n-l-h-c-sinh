USE [master]
GO
/****** Object:  Database [TruongTHPT]    Script Date: 11/22/2016 11:37:04 PM ******/
CREATE DATABASE [TruongTHPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TruongTHPT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TruongTHPT.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TruongTHPT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TruongTHPT_log.ldf' , SIZE = 10240KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TruongTHPT] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TruongTHPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TruongTHPT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TruongTHPT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TruongTHPT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TruongTHPT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TruongTHPT] SET ARITHABORT OFF 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TruongTHPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TruongTHPT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TruongTHPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TruongTHPT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TruongTHPT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TruongTHPT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TruongTHPT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TruongTHPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TruongTHPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TruongTHPT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TruongTHPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TruongTHPT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TruongTHPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TruongTHPT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TruongTHPT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TruongTHPT] SET  MULTI_USER 
GO
ALTER DATABASE [TruongTHPT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TruongTHPT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TruongTHPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TruongTHPT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TruongTHPT]
GO
/****** Object:  StoredProcedure [dbo].[Sua_TTHS]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sua_TTHS]
 (@MaHS nchar(10),
	@HovaTen nvarchar(50),
	@GT nchar(3),
	@NgaySinh date,
	@DiaChi  nvarchar(50),
	@PhuHuynh nvarchar(50),
	@TenLop nchar(3),
	@QueQuan nchar(50))
AS
BEGIN
update tblHocSinh 
set 
 hovaten=@HovaTen,
	gt=@GT ,
	NgaySinh=@NgaySinh,
	DiaChi=@DiaChi ,
	PhuHuynh=@PhuHuynh ,
	MaLop=(select malop  from tblLop where tenLop=@tenlop ) ,
	QueQuan=@QueQuan
where mahs=@MaHS
END
GO
/****** Object:  StoredProcedure [dbo].[suaGiaoVien]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[suaGiaoVien] (@MaGV nchar(10),@HoTen nvarchar(50),@GT nchar(3),@NgaySinh date,@DiaChi nvarchar(50),@SDT int,@Luong int,@MaMon nchar(4))
	-- Add the parameters for the stored procedure her
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	UPDATE tblGiaoVien SET MaGV = @MaGV, HoTen=@HoTen, GT = @GT, NgaySinh=@NgaySinh, DiaChi = @DiaChi, SDT = @SDT, Luong=@Luong, MaMon=@MaMon
						   WHERE MaGV = @MaGV 
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END





GO
/****** Object:  StoredProcedure [dbo].[themGiaoVien]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[themGiaoVien] (@MaGV nchar(10),@HoTen nvarchar(50),@GT nchar(3),@NgaySinh date,@DiaChi nvarchar(50),@SDT int,@Luong int,@MaMon nchar(10))
	-- Add the parameters for the stored procedure her
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	INSERT INTO tblGiaoVien(MaGV, HoTen, GT, NgaySinh, DiaChi, SDT, Luong, MaMon)
    VALUES(@MaGV, @HoTen, @GT, @NgaySinh, @DiaChi, @SDT, @Luong, @MaMon)
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END


GO
/****** Object:  StoredProcedure [dbo].[ThemHS]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemHS] (@MaHS nchar(10),
	@HovaTen nvarchar(50),
	@GT nchar(3),
	@NgaySinh date,
	@DiaChi  nvarchar(50),
	@PhuHuynh nvarchar(50),
	@TenLop nchar(3),
	@QueQuan nchar(50))
	-- Add the parameters for the stored procedure her
AS
BEGIN
declare @malop nchar(10)
select @malop= malop  from tblLop where tenLop=@tenlop
insert into tblHocSinh values(@MaHS,
	@HovaTen,
	@GT ,
	@NgaySinh,
	@DiaChi ,
	@PhuHuynh ,
	@MaLop ,
	@QueQuan)
END
GO
/****** Object:  StoredProcedure [dbo].[xoaGiaoVien]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[xoaGiaoVien] (@MaGV nchar(10))
	-- Add the parameters for the stored procedure her
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.	
	DELETE FROM tblGiaoVien WHERE MaGV = @MaGV
	DELETE FROM tblLop WHERE GVCN=@MaGV 
	DELETE FROM tblHocSinh WHERE tblHocSinh.MaLop=(SELECT MaLop FROM tblLop WHERE GVCN=@MaGV)
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END



GO
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[MaGV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GT] [nchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Luong] [bigint] NULL,
	[MaMon] [nchar](4) NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHocSinh]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocSinh](
	[MaHS] [nchar](10) NOT NULL,
	[HovaTen] [nvarchar](50) NOT NULL,
	[GT] [nchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[PhuHuynh] [nvarchar](50) NULL,
	[MaLop] [nchar](10) NULL,
	[QueQuan] [nchar](50) NULL,
 CONSTRAINT [PK_tblHocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[UuTien] [int] NULL,
 CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLop](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nchar](3) NOT NULL,
	[GVCN] [nchar](10) NULL,
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonHoc](
	[MaMon] [nchar](4) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[SoTiet/tuan] [int] NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTTGD]    Script Date: 11/22/2016 11:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTTGD](
	[HoTen] [nvarchar](50) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[TenLop] [nchar](10) NULL,
 CONSTRAINT [PK_tblTTGD] PRIMARY KEY CLUSTERED 
(
	[HoTen] ASC,
	[TenMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000001', N'Bùi Thu Lâm', N'Nam', CAST(0xC3150B00 AS Date), N'Nghệ An', NULL, NULL, N'MH02')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000002', N'Nguyễn Hoàng Long', N'Nam', CAST(0xC3150B00 AS Date), N'Hải Phòng', NULL, NULL, N'MH05')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000003', N'Tống Minh Đức', N'Nam', CAST(0xC3150B00 AS Date), N'Thanh Hóa', NULL, NULL, N'MH01')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000004', N'Hà Đại Dương', N'Nu ', CAST(0xC3150B00 AS Date), N'Hà Tĩnh', NULL, NULL, N'MH06')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000005', N'Trần Nguyên Ngọc', N'Nu ', CAST(0xC3150B00 AS Date), N'Hòa Bình', NULL, NULL, N'MH03')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000006', N'Nguyễn Việt Hùng', N'Nam', CAST(0xC3150B00 AS Date), N'Hải Dương', NULL, NULL, N'MH01')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000007', N'Tạ Minh Thanh', N'Nam', CAST(0xC3150B00 AS Date), N'Ninh Bình', NULL, NULL, N'MH07')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000008', N'Nguyễn Quang Uy', N'Nam', CAST(0xC3150B00 AS Date), N'An Giang', NULL, NULL, N'MH05')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000009', N'Lưu Hồng Dũng', N'Nam', NULL, N'Điện Biên', NULL, NULL, N'MH04')
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'f         ', N'r', N'nu ', CAST(0xB41D0B00 AS Date), N'v', N'g', NULL, N's                                                 ')
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'h         ', N'a', N'n  ', CAST(0xB41D0B00 AS Date), N'a', N'a', NULL, N'd                                                 ')
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'HS0000001 ', N'a', N'nu ', CAST(0xB41D0B00 AS Date), N'a', N'a', N'LOP0000001', N'd                                                 ')
INSERT [dbo].[tblHocSinh] ([MaHS], [HovaTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop], [QueQuan]) VALUES (N'o         ', N'r', N'nu ', CAST(0xB41D0B00 AS Date), N'v', N'g', NULL, N's                                                 ')
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'admin2', N'admin2', 0)
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'admin3', N'admin3', 1)
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'admin4', N'admin4', 0)
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'admin5', N'admin4', 1)
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'admin8', N'admin5', 1)
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'adminN', N'adminN', 1)
INSERT [dbo].[tblLogin] ([Username], [Pass], [UuTien]) VALUES (N'TH49', N'TH49', 1)
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000001', N'10A', N'Trịnh A   ')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000002', N'10B', N'Trịnh C   ')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH01', N'Toán', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH02', N'Vật Lý', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH03', N'Hóa Học', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH04', N'Ngữ Văn', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH05', N'Lịch Sử', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH06', N'Địa Lý', NULL)
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon], [SoTiet/tuan]) VALUES (N'MH07', N'Tiếng Anh', NULL)
INSERT [dbo].[tblTTGD] ([HoTen], [TenMon], [TenLop]) VALUES (N'Bùi Thu Lâm', N'Vật Lý', N'10B       ')
INSERT [dbo].[tblTTGD] ([HoTen], [TenMon], [TenLop]) VALUES (N'Nguyễn Hoàng ', N'Toán', N'10C       ')
INSERT [dbo].[tblTTGD] ([HoTen], [TenMon], [TenLop]) VALUES (N'Nguyễn Hoàng Long', N'Toán', N'10C       ')
INSERT [dbo].[tblTTGD] ([HoTen], [TenMon], [TenLop]) VALUES (N'Quynh Nga', N'Ngữ Văn', N'12A       ')
ALTER TABLE [dbo].[tblLogin] ADD  CONSTRAINT [DF_tblLogin_UuTien]  DEFAULT ((0)) FOR [UuTien]
GO
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblMonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblMonHoc]
GO
ALTER TABLE [dbo].[tblHocSinh]  WITH CHECK ADD  CONSTRAINT [FK_tblHocSinh_tblLop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLop] ([MaLop])
GO
ALTER TABLE [dbo].[tblHocSinh] CHECK CONSTRAINT [FK_tblHocSinh_tblLop]
GO
USE [master]
GO
ALTER DATABASE [TruongTHPT] SET  READ_WRITE 
GO

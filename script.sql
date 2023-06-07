USE [kres]
GO
/****** Object:  Table [dbo].[ogrenci]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenci](
	[ogrenciID] [int] IDENTITY(1,1) NOT NULL,
	[adi] [nchar](10) NULL,
	[soyadi] [nchar](10) NULL,
	[cinsiyet] [bit] NULL,
	[dogumtarihi] [date] NULL,
	[tcno] [int] NULL,
	[ogrencino] [int] NULL,
	[durumu] [bit] NULL,
 CONSTRAINT [PK_ogrenci] PRIMARY KEY CLUSTERED 
(
	[ogrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrencisinif]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrencisinif](
	[ogrencisinifID] [int] IDENTITY(1,1) NOT NULL,
	[ogrenciID] [int] NULL,
	[sinifID] [int] NULL,
 CONSTRAINT [PK_ogrencisinif] PRIMARY KEY CLUSTERED 
(
	[ogrencisinifID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenciveli]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenciveli](
	[ogrenciveliID] [int] IDENTITY(1,1) NOT NULL,
	[ogrenciID] [int] NULL,
	[veliID] [int] NULL,
 CONSTRAINT [PK_ogrenciveli] PRIMARY KEY CLUSTERED 
(
	[ogrenciveliID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogretmen]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogretmen](
	[ogretmenID] [int] IDENTITY(1,1) NOT NULL,
	[adi] [nvarchar](max) NULL,
	[soyadi] [nvarchar](max) NULL,
	[tcno] [nvarchar](max) NULL,
	[tel] [nvarchar](max) NULL,
	[adres] [nvarchar](max) NULL,
	[maas] [nvarchar](max) NULL,
	[mail] [nvarchar](max) NULL,
	[cinsiyet] [bit] NULL,
	[dogumtarihi] [date] NULL,
 CONSTRAINT [PK_ogretmen] PRIMARY KEY CLUSTERED 
(
	[ogretmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[siniflar]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[siniflar](
	[sinifID] [int] IDENTITY(1,1) NOT NULL,
	[sinifadi] [nchar](10) NULL,
 CONSTRAINT [PK_siniflar] PRIMARY KEY CLUSTERED 
(
	[sinifID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinifogretmen]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinifogretmen](
	[sinifogretmenID] [int] IDENTITY(1,1) NOT NULL,
	[sinifID] [int] NULL,
	[ogretmenID] [int] NULL,
 CONSTRAINT [PK_sinifogretmen] PRIMARY KEY CLUSTERED 
(
	[sinifogretmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veli]    Script Date: 8.06.2023 01:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veli](
	[veliID] [int] IDENTITY(1,1) NOT NULL,
	[adi] [nvarchar](max) NULL,
	[soyadi] [nvarchar](max) NULL,
	[tcno] [nvarchar](max) NULL,
	[cinsiyet] [bit] NULL,
	[adres] [nvarchar](max) NULL,
	[tel] [nvarchar](max) NULL,
 CONSTRAINT [PK_veli] PRIMARY KEY CLUSTERED 
(
	[veliID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ogrenci] ON 

INSERT [dbo].[ogrenci] ([ogrenciID], [adi], [soyadi], [cinsiyet], [dogumtarihi], [tcno], [ogrencino], [durumu]) VALUES (1, N'Osman     ', N'Ak        ', 1, CAST(N'2023-01-04' AS Date), 1111111111, 6546854, NULL)
INSERT [dbo].[ogrenci] ([ogrenciID], [adi], [soyadi], [cinsiyet], [dogumtarihi], [tcno], [ogrencino], [durumu]) VALUES (2, N'İrem      ', N'Eroğlu    ', 1, CAST(N'2023-01-04' AS Date), 454545455, 4514232, NULL)
INSERT [dbo].[ogrenci] ([ogrenciID], [adi], [soyadi], [cinsiyet], [dogumtarihi], [tcno], [ogrencino], [durumu]) VALUES (3, N'İrreemm   ', N'Erooğluu  ', 0, CAST(N'2023-06-22' AS Date), 135165, 65465, NULL)
SET IDENTITY_INSERT [dbo].[ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[ogrenciveli] ON 

INSERT [dbo].[ogrenciveli] ([ogrenciveliID], [ogrenciID], [veliID]) VALUES (1, 3, 1)
SET IDENTITY_INSERT [dbo].[ogrenciveli] OFF
GO
SET IDENTITY_INSERT [dbo].[veli] ON 

INSERT [dbo].[veli] ([veliID], [adi], [soyadi], [tcno], [cinsiyet], [adres], [tel]) VALUES (1, N'Osman', N'Ak', N'1313131313', 0, N'asdfasd', N'456665')
SET IDENTITY_INSERT [dbo].[veli] OFF
GO
ALTER TABLE [dbo].[ogrencisinif]  WITH CHECK ADD  CONSTRAINT [FK_ogrencisinif_ogrenci] FOREIGN KEY([ogrenciID])
REFERENCES [dbo].[ogrenci] ([ogrenciID])
GO
ALTER TABLE [dbo].[ogrencisinif] CHECK CONSTRAINT [FK_ogrencisinif_ogrenci]
GO
ALTER TABLE [dbo].[ogrencisinif]  WITH CHECK ADD  CONSTRAINT [FK_ogrencisinif_siniflar] FOREIGN KEY([sinifID])
REFERENCES [dbo].[siniflar] ([sinifID])
GO
ALTER TABLE [dbo].[ogrencisinif] CHECK CONSTRAINT [FK_ogrencisinif_siniflar]
GO
ALTER TABLE [dbo].[ogrenciveli]  WITH CHECK ADD  CONSTRAINT [FK_ogrenciveli_ogrenci] FOREIGN KEY([ogrenciID])
REFERENCES [dbo].[ogrenci] ([ogrenciID])
GO
ALTER TABLE [dbo].[ogrenciveli] CHECK CONSTRAINT [FK_ogrenciveli_ogrenci]
GO
ALTER TABLE [dbo].[ogrenciveli]  WITH CHECK ADD  CONSTRAINT [FK_ogrenciveli_veli] FOREIGN KEY([veliID])
REFERENCES [dbo].[veli] ([veliID])
GO
ALTER TABLE [dbo].[ogrenciveli] CHECK CONSTRAINT [FK_ogrenciveli_veli]
GO
ALTER TABLE [dbo].[sinifogretmen]  WITH CHECK ADD  CONSTRAINT [FK_sinifogretmen_ogretmen] FOREIGN KEY([ogretmenID])
REFERENCES [dbo].[ogretmen] ([ogretmenID])
GO
ALTER TABLE [dbo].[sinifogretmen] CHECK CONSTRAINT [FK_sinifogretmen_ogretmen]
GO
ALTER TABLE [dbo].[sinifogretmen]  WITH CHECK ADD  CONSTRAINT [FK_sinifogretmen_siniflar] FOREIGN KEY([sinifID])
REFERENCES [dbo].[siniflar] ([sinifID])
GO
ALTER TABLE [dbo].[sinifogretmen] CHECK CONSTRAINT [FK_sinifogretmen_siniflar]
GO

USE [santorini]
GO
/****** Object:  Table [dbo].[address]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[address](
	[ida] [int] IDENTITY(1,1) NOT NULL,
	[country] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[street] [nvarchar](50) NULL,
	[house] [nvarchar](50) NULL,
	[flat] [nvarchar](50) NULL,
	[idp] [int] NULL,
	[idc] [int] NULL,
 CONSTRAINT [PK__address__DC501A0F20846142] PRIMARY KEY CLUSTERED 
(
	[ida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cafe]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cafe](
	[idc] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK__cafe__DC501A0DB24829A9] PRIMARY KEY CLUSTERED 
(
	[idc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personal]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal](
	[idp] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[lastname] [nvarchar](50) NULL,
	[birth] [date] NULL,
	[seria_pasport] [int] NULL,
	[number_pasport] [int] NULL,
	[ids] [int] NULL,
	[idc] [int] NULL,
 CONSTRAINT [PK__personal__DC501A004FB79A7E] PRIMARY KEY CLUSTERED 
(
	[idp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[idpr] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[date_get] [date] NULL,
	[before_date] [date] NULL,
	[price] [money] NULL,
	[quality] [nvarchar](50) NULL,
	[how_much] [nvarchar](50) NULL,
	[idsp] [int] NULL,
	[idc] [int] NULL,
 CONSTRAINT [PK__product__9DB75512CE76A904] PRIMARY KEY CLUSTERED 
(
	[idpr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supply]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supply](
	[idsp] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK__supply__9DBB2CF28FDC4ABB] PRIMARY KEY CLUSTERED 
(
	[idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[telephone]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telephone](
	[idt] [int] IDENTITY(1,1) NOT NULL,
	[number] [nvarchar](50) NULL,
	[idp] [int] NULL,
 CONSTRAINT [PK__telephon__DC501A7C96B0E47B] PRIMARY KEY CLUSTERED 
(
	[idt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[work]    Script Date: 28.06.2022 16:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[work](
	[ids] [int] IDENTITY(1,1) NOT NULL,
	[salary] [money] NULL,
	[position] [nvarchar](50) NULL,
	[qualification] [nvarchar](50) NULL,
	[efficiency] [nvarchar](50) NULL,
	[experience] [nvarchar](50) NULL,
 CONSTRAINT [PK__work__DC501A7DF15272FA] PRIMARY KEY CLUSTERED 
(
	[ids] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[address] ON 

INSERT [dbo].[address] ([ida], [country], [city], [street], [house], [flat], [idp], [idc]) VALUES (3, N'Russia', N'Sochi', N'Karla Libknehta', N'13B', NULL, NULL, 1)
INSERT [dbo].[address] ([ida], [country], [city], [street], [house], [flat], [idp], [idc]) VALUES (7, N'Russia', N'Sochi', N'Konstitucii', N'5', N'14', 3, NULL)
INSERT [dbo].[address] ([ida], [country], [city], [street], [house], [flat], [idp], [idc]) VALUES (8, N'Россия', N'Сочи', N'Абрикосовая', N'27', NULL, NULL, 2)
INSERT [dbo].[address] ([ida], [country], [city], [street], [house], [flat], [idp], [idc]) VALUES (11, N'Россия', N'Санкт-Петербург', N'Розенблюма', N'23А', N'13', 4, NULL)
INSERT [dbo].[address] ([ida], [country], [city], [street], [house], [flat], [idp], [idc]) VALUES (13, N'Россия', N'Сочи', N'Бытха', N'24', N'', 0, 1)
SET IDENTITY_INSERT [dbo].[address] OFF
GO
SET IDENTITY_INSERT [dbo].[cafe] ON 

INSERT [dbo].[cafe] ([idc], [name]) VALUES (1, N'Santorini')
INSERT [dbo].[cafe] ([idc], [name]) VALUES (2, N'Санторини')
SET IDENTITY_INSERT [dbo].[cafe] OFF
GO
SET IDENTITY_INSERT [dbo].[personal] ON 

INSERT [dbo].[personal] ([idp], [name], [surname], [lastname], [birth], [seria_pasport], [number_pasport], [ids], [idc]) VALUES (3, N'виталий', N'макаров', N'фёдорович', CAST(N'1993-04-09' AS Date), 6060, 606060, 1, 1)
INSERT [dbo].[personal] ([idp], [name], [surname], [lastname], [birth], [seria_pasport], [number_pasport], [ids], [idc]) VALUES (4, N'егор', N'побирский', N'андреевич', CAST(N'1999-01-01' AS Date), 4040, 251345, 2, 2)
INSERT [dbo].[personal] ([idp], [name], [surname], [lastname], [birth], [seria_pasport], [number_pasport], [ids], [idc]) VALUES (5, N'Роман', N'Кукушкин', N'Андреевич', CAST(N'2002-02-06' AS Date), 607080, 2323, 3, 1)
INSERT [dbo].[personal] ([idp], [name], [surname], [lastname], [birth], [seria_pasport], [number_pasport], [ids], [idc]) VALUES (7, N'Валерия', N'Зорина', N'Андреевна', CAST(N'2000-06-16' AS Date), 6060, 227801, 4, 1)
INSERT [dbo].[personal] ([idp], [name], [surname], [lastname], [birth], [seria_pasport], [number_pasport], [ids], [idc]) VALUES (8, N'Софья', N'Зорина', N'Андреевна', CAST(N'2004-07-07' AS Date), 317, 856795, 3, 1)
SET IDENTITY_INSERT [dbo].[personal] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([idpr], [name], [date_get], [before_date], [price], [quality], [how_much], [idsp], [idc]) VALUES (1, N'перец', CAST(N'2022-06-23' AS Date), CAST(N'2022-06-30' AS Date), 3000.0000, N'среднее', N'13', 1, 2)
INSERT [dbo].[product] ([idpr], [name], [date_get], [before_date], [price], [quality], [how_much], [idsp], [idc]) VALUES (3, N'листья салата', CAST(N'2022-06-23' AS Date), CAST(N'2022-06-30' AS Date), 4500.0000, N'среднее', N'345', 1, 2)
SET IDENTITY_INSERT [dbo].[product] OFF
GO
SET IDENTITY_INSERT [dbo].[supply] ON 

INSERT [dbo].[supply] ([idsp], [name]) VALUES (1, N'Sklad')
INSERT [dbo].[supply] ([idsp], [name]) VALUES (2, N'цех')
SET IDENTITY_INSERT [dbo].[supply] OFF
GO
SET IDENTITY_INSERT [dbo].[telephone] ON 

INSERT [dbo].[telephone] ([idt], [number], [idp]) VALUES (1, N'89883642212', 3)
SET IDENTITY_INSERT [dbo].[telephone] OFF
GO
SET IDENTITY_INSERT [dbo].[work] ON 

INSERT [dbo].[work] ([ids], [salary], [position], [qualification], [efficiency], [experience]) VALUES (1, 32000.0000, N'повар', N'средняя квалификация', N'средняя эффективность', N'5')
INSERT [dbo].[work] ([ids], [salary], [position], [qualification], [efficiency], [experience]) VALUES (2, 48000.0000, N'администратор', N'хорошая квалификация', N'средняя эффективность', N'5')
INSERT [dbo].[work] ([ids], [salary], [position], [qualification], [efficiency], [experience]) VALUES (3, 32000.0000, N'доставщик', N'высокая квалификация', N'высокая эффективность', N'10')
INSERT [dbo].[work] ([ids], [salary], [position], [qualification], [efficiency], [experience]) VALUES (4, 28000.0000, N'бармен', N'средняя квалификация', N'высокая эффективность', N'0')
SET IDENTITY_INSERT [dbo].[work] OFF
GO
ALTER TABLE [dbo].[address]  WITH NOCHECK ADD  CONSTRAINT [FK__address__idc__31EC6D26] FOREIGN KEY([idc])
REFERENCES [dbo].[cafe] ([idc])
GO
ALTER TABLE [dbo].[address] NOCHECK CONSTRAINT [FK__address__idc__31EC6D26]
GO
ALTER TABLE [dbo].[address]  WITH NOCHECK ADD  CONSTRAINT [FK__address__idp__30F848ED] FOREIGN KEY([idp])
REFERENCES [dbo].[personal] ([idp])
GO
ALTER TABLE [dbo].[address] NOCHECK CONSTRAINT [FK__address__idp__30F848ED]
GO
ALTER TABLE [dbo].[personal]  WITH CHECK ADD  CONSTRAINT [FK__personal__idc__2E1BDC42] FOREIGN KEY([idc])
REFERENCES [dbo].[cafe] ([idc])
GO
ALTER TABLE [dbo].[personal] CHECK CONSTRAINT [FK__personal__idc__2E1BDC42]
GO
ALTER TABLE [dbo].[personal]  WITH CHECK ADD  CONSTRAINT [FK__personal__ids__2D27B809] FOREIGN KEY([ids])
REFERENCES [dbo].[work] ([ids])
GO
ALTER TABLE [dbo].[personal] CHECK CONSTRAINT [FK__personal__ids__2D27B809]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK__product__idc__286302EC] FOREIGN KEY([idc])
REFERENCES [dbo].[cafe] ([idc])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK__product__idc__286302EC]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK__product__idsp__276EDEB3] FOREIGN KEY([idsp])
REFERENCES [dbo].[supply] ([idsp])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK__product__idsp__276EDEB3]
GO
ALTER TABLE [dbo].[telephone]  WITH CHECK ADD  CONSTRAINT [FK__telephone__idp__34C8D9D1] FOREIGN KEY([idp])
REFERENCES [dbo].[personal] ([idp])
GO
ALTER TABLE [dbo].[telephone] CHECK CONSTRAINT [FK__telephone__idp__34C8D9D1]
GO

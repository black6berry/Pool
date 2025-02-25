USE [Pool]
GO
/****** Object:  Table [dbo].[Abonement]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abonement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[NumberVisitId] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberVisit]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberVisit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Variety] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pool]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[TypeId] [int] NOT NULL,
	[TrenerId] [int] NOT NULL,
 CONSTRAINT [PK_Pool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoldTiket]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoldTiket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AbonementId] [int] NOT NULL,
	[PoolId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_SoldTiket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trener]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trener](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SNP] [nvarchar](50) NOT NULL,
	[GroupId] [int] NOT NULL,
	[Phone] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Coach] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/14/2022 1:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Patronomic] [nvarchar](50) NOT NULL,
	[Phone] [nchar](10) NOT NULL,
	[AboonementId] [int] NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Pasword] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Abonement] ON 

INSERT [dbo].[Abonement] ([Id], [Number], [CategoryId], [NumberVisitId], [Price]) VALUES (7, N'1012', 3, 3, 3000)
INSERT [dbo].[Abonement] ([Id], [Number], [CategoryId], [NumberVisitId], [Price]) VALUES (8, N'1010', 2, 4, 5000)
INSERT [dbo].[Abonement] ([Id], [Number], [CategoryId], [NumberVisitId], [Price]) VALUES (9, N'1013', 1, 2, 2000)
INSERT [dbo].[Abonement] ([Id], [Number], [CategoryId], [NumberVisitId], [Price]) VALUES (10, N'1015', 3, 4, 5000)
INSERT [dbo].[Abonement] ([Id], [Number], [CategoryId], [NumberVisitId], [Price]) VALUES (11, N'1020', 4, 3, 3000)
SET IDENTITY_INSERT [dbo].[Abonement] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Начинающие')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Подростки')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Взрослые')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Спортсмены')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Number], [CategoryId], [UserId]) VALUES (1, N'201', 1, 1)
INSERT [dbo].[Group] ([Id], [Number], [CategoryId], [UserId]) VALUES (2, N'202', 2, 1)
INSERT [dbo].[Group] ([Id], [Number], [CategoryId], [UserId]) VALUES (3, N'203', 3, 2)
INSERT [dbo].[Group] ([Id], [Number], [CategoryId], [UserId]) VALUES (4, N'203', 3, 3)
INSERT [dbo].[Group] ([Id], [Number], [CategoryId], [UserId]) VALUES (5, N'204', 4, 2)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[NumberVisit] ON 

INSERT [dbo].[NumberVisit] ([Id], [Quantity]) VALUES (1, N'1 раз')
INSERT [dbo].[NumberVisit] ([Id], [Quantity]) VALUES (2, N'2 раза')
INSERT [dbo].[NumberVisit] ([Id], [Quantity]) VALUES (3, N'3 раза')
INSERT [dbo].[NumberVisit] ([Id], [Quantity]) VALUES (4, N'5 раз')
SET IDENTITY_INSERT [dbo].[NumberVisit] OFF
GO
SET IDENTITY_INSERT [dbo].[Pool] ON 

INSERT [dbo].[Pool] ([Id], [Name], [Address], [TypeId], [TrenerId]) VALUES (9, N'Водичка', N'Некрасовкий проспект, дом 24', 3, 1)
INSERT [dbo].[Pool] ([Id], [Name], [Address], [TypeId], [TrenerId]) VALUES (10, N'И вас вылечим', N'Улица 1905 года, дом 10', 2, 2)
INSERT [dbo].[Pool] ([Id], [Name], [Address], [TypeId], [TrenerId]) VALUES (11, N'Лужица', N'Осенний бульвар, дом 23', 1, 3)
INSERT [dbo].[Pool] ([Id], [Name], [Address], [TypeId], [TrenerId]) VALUES (12, N'Капля', N'Строгинсикй бульвар,дом 13', 3, 4)
INSERT [dbo].[Pool] ([Id], [Name], [Address], [TypeId], [TrenerId]) VALUES (15, N'Спортикс', N'Весенний бульвар дом 24', 2, 5)
SET IDENTITY_INSERT [dbo].[Pool] OFF
GO
SET IDENTITY_INSERT [dbo].[SoldTiket] ON 

INSERT [dbo].[SoldTiket] ([Id], [AbonementId], [PoolId], [UserId], [Date]) VALUES (1, 7, 9, 1, CAST(N'2022-11-12T11:11:11.000' AS DateTime))
INSERT [dbo].[SoldTiket] ([Id], [AbonementId], [PoolId], [UserId], [Date]) VALUES (3, 8, 10, 2, CAST(N'2022-08-10T14:02:14.000' AS DateTime))
INSERT [dbo].[SoldTiket] ([Id], [AbonementId], [PoolId], [UserId], [Date]) VALUES (7, 9, 11, 2, CAST(N'2022-10-10T10:30:10.000' AS DateTime))
INSERT [dbo].[SoldTiket] ([Id], [AbonementId], [PoolId], [UserId], [Date]) VALUES (8, 11, 12, 1, CAST(N'2022-03-09T14:50:31.000' AS DateTime))
INSERT [dbo].[SoldTiket] ([Id], [AbonementId], [PoolId], [UserId], [Date]) VALUES (9, 10, 12, 3, CAST(N'2022-02-11T08:00:55.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[SoldTiket] OFF
GO
SET IDENTITY_INSERT [dbo].[Trener] ON 

INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (1, N'Семёнов Александр Викторович', 2, N'8999123456')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (2, N'Каренина Мария Леонидовна ', 1, N'8999123457')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (3, N'Чумак Аркадий Алексеевич', 3, N'8999123455')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (4, N'Куприна Анастасия Андреевна', 4, N'8999123453')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (5, N'Петров Кирилл Андреевич', 5, N'8999123452')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (6, N'Куприков Илья Борисович', 1, N'8999123451')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (7, N'Чайка Карина Витальевна', 3, N'8229123456')
INSERT [dbo].[Trener] ([Id], [SNP], [GroupId], [Phone]) VALUES (8, N'Батьков Михаил Ильич', 4, N'8999123458')
SET IDENTITY_INSERT [dbo].[Trener] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([Id], [Name]) VALUES (1, N'Спортивный')
INSERT [dbo].[Type] ([Id], [Name]) VALUES (2, N'Оздоровительный')
INSERT [dbo].[Type] ([Id], [Name]) VALUES (3, N'Комбинированный')
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Surname], [Patronomic], [Phone], [AboonementId], [Login], [Pasword]) VALUES (1, N'Сергей', N'Тунеядец', N'Петрович', N'1234567890', 7, N'1', N'1')
INSERT [dbo].[User] ([Id], [Name], [Surname], [Patronomic], [Phone], [AboonementId], [Login], [Pasword]) VALUES (2, N'Елена', N'Сочкова', N'Викторовна', N'2345678900', 8, N'2', N'2')
INSERT [dbo].[User] ([Id], [Name], [Surname], [Patronomic], [Phone], [AboonementId], [Login], [Pasword]) VALUES (3, N'Алиса', N'Большеногова', N'Владимировна', N'3333345678', 9, N'3', N'3')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Abonement]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Abonement] CHECK CONSTRAINT [FK_Ticket_Category]
GO
ALTER TABLE [dbo].[Abonement]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_NumberVisit] FOREIGN KEY([NumberVisitId])
REFERENCES [dbo].[NumberVisit] ([Id])
GO
ALTER TABLE [dbo].[Abonement] CHECK CONSTRAINT [FK_Ticket_NumberVisit]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Category1] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Category1]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_User]
GO
ALTER TABLE [dbo].[Pool]  WITH CHECK ADD  CONSTRAINT [FK_Pool_Trener] FOREIGN KEY([TrenerId])
REFERENCES [dbo].[Trener] ([Id])
GO
ALTER TABLE [dbo].[Pool] CHECK CONSTRAINT [FK_Pool_Trener]
GO
ALTER TABLE [dbo].[Pool]  WITH CHECK ADD  CONSTRAINT [FK_Pool_Type] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([Id])
GO
ALTER TABLE [dbo].[Pool] CHECK CONSTRAINT [FK_Pool_Type]
GO
ALTER TABLE [dbo].[SoldTiket]  WITH CHECK ADD  CONSTRAINT [FK_SoldTiket_Pool] FOREIGN KEY([PoolId])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[SoldTiket] CHECK CONSTRAINT [FK_SoldTiket_Pool]
GO
ALTER TABLE [dbo].[SoldTiket]  WITH CHECK ADD  CONSTRAINT [FK_SoldTiket_Ticket] FOREIGN KEY([AbonementId])
REFERENCES [dbo].[Abonement] ([Id])
GO
ALTER TABLE [dbo].[SoldTiket] CHECK CONSTRAINT [FK_SoldTiket_Ticket]
GO
ALTER TABLE [dbo].[SoldTiket]  WITH CHECK ADD  CONSTRAINT [FK_SoldTiket_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[SoldTiket] CHECK CONSTRAINT [FK_SoldTiket_User]
GO
ALTER TABLE [dbo].[Trener]  WITH CHECK ADD  CONSTRAINT [FK_Coach_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Trener] CHECK CONSTRAINT [FK_Coach_Group]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Ticket] FOREIGN KEY([AboonementId])
REFERENCES [dbo].[Abonement] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Ticket]
GO

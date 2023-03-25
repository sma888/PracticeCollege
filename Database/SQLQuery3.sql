
CREATE DATABASE [CarDealership] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CarDealership] SET QUERY_STORE = OFF
GO
USE [CarDealership]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 25.03.2023 10:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 25.03.2023 10:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BrandID] [int] NOT NULL,
	[Model] [nvarchar](30) NOT NULL,
	[VIN] [nvarchar](16) NOT NULL,
	[Color] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 25.03.2023 10:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](70) NOT NULL,
	[Surname] [nvarchar](70) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 25.03.2023 10:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](70) NOT NULL,
	[Surname] [nvarchar](70) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[Age] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sell]    Script Date: 25.03.2023 10:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sell](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NULL,
	[ManagerID] [int] NULL,
	[CarID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 25.03.2023 10:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[Amount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Manager] ON 
GO
INSERT [dbo].[Manager] ([ID], [FirstName], [Surname], [MiddleName], [Age], [Login], [Password]) VALUES (12, N'�������', N'�������', N'���������', 18, N'123', N'123')
GO
INSERT [dbo].[Manager] ([ID], [FirstName], [Surname], [MiddleName], [Age], [Login], [Password]) VALUES (51, N'���1', N'�������1', N'��������1', 20, N'1', N'1')
GO
INSERT [dbo].[Manager] ([ID], [FirstName], [Surname], [MiddleName], [Age], [Login], [Password]) VALUES (52, N'���2', N'�������2', N'��������2', 44, N'2', N'2')
GO
INSERT [dbo].[Manager] ([ID], [FirstName], [Surname], [MiddleName], [Age], [Login], [Password]) VALUES (53, N'���3', N'�������3', N'��������3', 30, N'3', N'3')
GO
INSERT [dbo].[Manager] ([ID], [FirstName], [Surname], [MiddleName], [Age], [Login], [Password]) VALUES (55, N'asdfghjk', N'kjhgfds', N'hjvbn', 46, N'fdgsdf', N'gsdf')
GO
SET IDENTITY_INSERT [dbo].[Manager] OFF
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brand] ([ID])
GO
ALTER TABLE [dbo].[Sell]  WITH CHECK ADD FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[Sell]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Sell]  WITH CHECK ADD FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Manager] ([ID])
GO
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
USE [master]
GO
ALTER DATABASE [CarDealership] SET  READ_WRITE 
GO

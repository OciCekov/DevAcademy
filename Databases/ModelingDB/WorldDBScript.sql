USE [master]
GO
/****** Object:  Database [WorldDB]    Script Date: 23-Aug-14 19:24:54 PM ******/
CREATE DATABASE [WorldDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorldDB', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\WorldDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WorldDB_log', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\WorldDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WorldDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorldDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorldDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorldDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorldDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorldDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorldDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorldDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorldDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorldDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorldDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorldDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorldDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorldDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorldDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorldDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorldDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorldDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorldDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorldDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorldDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorldDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorldDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorldDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorldDB] SET RECOVERY FULL 
GO
ALTER DATABASE [WorldDB] SET  MULTI_USER 
GO
ALTER DATABASE [WorldDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorldDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorldDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorldDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WorldDB', N'ON'
GO
USE [WorldDB]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 23-Aug-14 19:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Address_ID] [int] IDENTITY(1,1) NOT NULL,
	[Address_Text] [text] NULL,
	[Town_ID] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Address_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 23-Aug-14 19:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Continents](
	[Continent_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[Continent_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 23-Aug-14 19:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Country_ID] [int] IDENTITY(1,1) NOT NULL,
	[Country_Name] [nvarchar](50) NULL,
	[Continent_ID] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Country_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 23-Aug-14 19:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Person_ID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Address_ID] [int] NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Person_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 23-Aug-14 19:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[Town_ID] [int] IDENTITY(1,1) NOT NULL,
	[Country_ID] [int] NOT NULL,
	[Town_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[Town_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (1, N'In the middle', 1)
INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (2, N'Of pretty', 2)
INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (3, N'much ', 3)
INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (4, N'nowhere', 4)
INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (5, N'or maybe', 5)
INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (6, N'somewhere', 6)
INSERT [dbo].[Addresses] ([Address_ID], [Address_Text], [Town_ID]) VALUES (7, N'just don''t know where', 7)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (1, N'Africa')
INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (2, N'Norrth America')
INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (3, N'Asia')
INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (4, N'Australia')
INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (5, N'Europe')
INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (6, N'Antarctica')
INSERT [dbo].[Continents] ([Continent_ID], [Name]) VALUES (7, N'South America')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (1, N'China', 3)
INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (2, N'Nigeria', 1)
INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (3, N'Mexico', 2)
INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (4, N'Brazil', 7)
INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (5, NULL, 6)
INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (6, N'Russia', 5)
INSERT [dbo].[Countries] ([Country_ID], [Country_Name], [Continent_ID]) VALUES (7, N'Australia', 4)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (1, N'Pesho', N'Georgiev', 1)
INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (2, N'Gosho', N'Peshov', 4)
INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (3, N'Dimitrishko', NULL, 6)
INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (4, N'Le', N'Penguin', 5)
INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (5, N'Jon', N'Dow', 2)
INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (6, N'Marry', N'Jane', 3)
INSERT [dbo].[Persons] ([Person_ID], [First_Name], [Last_Name], [Address_ID]) VALUES (7, N'That''s', N'All', 7)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (1, 1, N'Shanghai')
INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (2, 2, N'Lagos')
INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (3, 3, N'Mexico City')
INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (4, 4, N'Sao Paolo')
INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (5, 5, NULL)
INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (6, 6, N'Moscow')
INSERT [dbo].[Towns] ([Town_ID], [Country_ID], [Town_Name]) VALUES (7, 7, N'Sydney')
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([Town_ID])
REFERENCES [dbo].[Towns] ([Town_ID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([Continent_ID])
REFERENCES [dbo].[Continents] ([Continent_ID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Addresses] FOREIGN KEY([Address_ID])
REFERENCES [dbo].[Addresses] ([Address_ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([Country_ID])
REFERENCES [dbo].[Countries] ([Country_ID])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [WorldDB] SET  READ_WRITE 
GO

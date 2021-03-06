USE [master]
GO
/****** Object:  Database [TypicalUniversity]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
CREATE DATABASE [TypicalUniversity]
 
ALTER DATABASE [TypicalUniversity] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TypicalUniversity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ARITHABORT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TypicalUniversity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TypicalUniversity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TypicalUniversity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TypicalUniversity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TypicalUniversity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TypicalUniversity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TypicalUniversity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TypicalUniversity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TypicalUniversity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TypicalUniversity] SET RECOVERY FULL 
GO
ALTER DATABASE [TypicalUniversity] SET  MULTI_USER 
GO
ALTER DATABASE [TypicalUniversity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TypicalUniversity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TypicalUniversity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TypicalUniversity] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TypicalUniversity', N'ON'
GO
USE [TypicalUniversity]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepartmentProfessors]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentProfessors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL,
 CONSTRAINT [PK_DepartmentProfessors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultiId] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NULL,
	[EmailId] [int] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorCourses]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorCourses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProfessorId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_ProfessorCourses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[Salary] [money] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorsTitles]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorsTitles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL,
 CONSTRAINT [PK_ProfessorsTitles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentCourses]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCourses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentCourses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[FacultyNumber] [int] NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 24.8.2014 г. 11:35:59 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [Name], [DepartmentId]) VALUES (2, N'Reinforced Concrete', 4)
INSERT [dbo].[Courses] ([Id], [Name], [DepartmentId]) VALUES (3, N'Wood strucutres', 3)
INSERT [dbo].[Courses] ([Id], [Name], [DepartmentId]) VALUES (4, N'Architecture', 1)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [FacultiId]) VALUES (1, N'Architecture', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultiId]) VALUES (2, N'Landshaft', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultiId]) VALUES (3, N'Structural Mechanics', 2)
INSERT [dbo].[Departments] ([Id], [Name], [FacultiId]) VALUES (4, N'Steel Structures', 2)
INSERT [dbo].[Departments] ([Id], [Name], [FacultiId]) VALUES (5, N'Concrete Structures', 2)
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (1, N'Architectural')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (2, N'Structural')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (3, N'Hydro')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (4, N'Geodesy')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId], [EmailId]) VALUES (18, N'Lazar', N'Dimitrov', NULL, NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId], [EmailId]) VALUES (19, N'Georgi', N'Petrov', NULL, NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId], [EmailId]) VALUES (20, N'Stoil', N'Ivanov', NULL, NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId], [EmailId]) VALUES (21, N'Ivan', N'Markov', NULL, NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId], [EmailId]) VALUES (22, N'Georgi', N'Linkov', NULL, NULL)
INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [AddressId], [EmailId]) VALUES (23, N'Dimitar', N'Dimitrov', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Professors] ON 

INSERT [dbo].[Professors] ([Id], [PersonId], [Salary]) VALUES (1, 21, 10000.0000)
INSERT [dbo].[Professors] ([Id], [PersonId], [Salary]) VALUES (2, 22, 10202.0000)
INSERT [dbo].[Professors] ([Id], [PersonId], [Salary]) VALUES (3, 23, 11103.0000)
SET IDENTITY_INSERT [dbo].[Professors] OFF
SET IDENTITY_INSERT [dbo].[ProfessorsTitles] ON 

INSERT [dbo].[ProfessorsTitles] ([Id], [TitleId], [ProfessorId]) VALUES (1, 1, 1)
INSERT [dbo].[ProfessorsTitles] ([Id], [TitleId], [ProfessorId]) VALUES (2, 2, 1)
INSERT [dbo].[ProfessorsTitles] ([Id], [TitleId], [ProfessorId]) VALUES (3, 2, 3)
INSERT [dbo].[ProfessorsTitles] ([Id], [TitleId], [ProfessorId]) VALUES (4, 3, 2)
SET IDENTITY_INSERT [dbo].[ProfessorsTitles] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [PersonId], [FacultyNumber], [FacultyId]) VALUES (1, 18, 13455, 2)
INSERT [dbo].[Students] ([Id], [PersonId], [FacultyNumber], [FacultyId]) VALUES (2, 19, 13456, 2)
INSERT [dbo].[Students] ([Id], [PersonId], [FacultyNumber], [FacultyId]) VALUES (3, 20, 9786, 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([Id], [Title]) VALUES (1, N'Ph.D')
INSERT [dbo].[Titles] ([Id], [Title]) VALUES (2, N'academician')
INSERT [dbo].[Titles] ([Id], [Title]) VALUES (3, N'senior assistant')
INSERT [dbo].[Titles] ([Id], [Title]) VALUES (4, N'junior assistant')
SET IDENTITY_INSERT [dbo].[Titles] OFF
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[DepartmentProfessors]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentProfessors_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[DepartmentProfessors] CHECK CONSTRAINT [FK_DepartmentProfessors_Departments]
GO
ALTER TABLE [dbo].[DepartmentProfessors]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentProfessors_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[DepartmentProfessors] CHECK CONSTRAINT [FK_DepartmentProfessors_Professors]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultiId])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[ProfessorCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[ProfessorCourses] CHECK CONSTRAINT [FK_ProfessorCourses_Courses]
GO
ALTER TABLE [dbo].[ProfessorCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorCourses_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[ProfessorCourses] CHECK CONSTRAINT [FK_ProfessorCourses_Professors]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Persons] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persons] ([Id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Persons]
GO
ALTER TABLE [dbo].[ProfessorsTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsTitles_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[ProfessorsTitles] CHECK CONSTRAINT [FK_ProfessorsTitles_Professors]
GO
ALTER TABLE [dbo].[ProfessorsTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsTitles_Titles] FOREIGN KEY([TitleId])
REFERENCES [dbo].[Titles] ([Id])
GO
ALTER TABLE [dbo].[ProfessorsTitles] CHECK CONSTRAINT [FK_ProfessorsTitles_Titles]
GO
ALTER TABLE [dbo].[StudentCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[StudentCourses] CHECK CONSTRAINT [FK_StudentCourses_Courses]
GO
ALTER TABLE [dbo].[StudentCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourses_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[StudentCourses] CHECK CONSTRAINT [FK_StudentCourses_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Persons] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persons] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Persons]
GO
USE [master]
GO
ALTER DATABASE [TypicalUniversity] SET  READ_WRITE 
GO

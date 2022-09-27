USE [master]
GO
/****** Object:  Database [TPPAV]    Script Date: 14/9/2022 20:37:17 ******/
CREATE DATABASE [TPPAV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TPPAV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TPPAV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TPPAV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TPPAV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TPPAV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPPAV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPPAV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPPAV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPPAV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPPAV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPPAV] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPPAV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TPPAV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPPAV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPPAV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPPAV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPPAV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPPAV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPPAV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPPAV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPPAV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TPPAV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPPAV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPPAV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPPAV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPPAV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPPAV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPPAV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPPAV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPPAV] SET  MULTI_USER 
GO
ALTER DATABASE [TPPAV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPPAV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPPAV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPPAV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPPAV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TPPAV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TPPAV] SET QUERY_STORE = OFF
GO
USE [TPPAV]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 14/9/2022 20:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14/9/2022 20:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NOT NULL,
	[apellido] [varchar](255) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Comprador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Perfil3', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (12, N'Perfil4', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (2, 1, N'valentina', N'123', N'vale@gmaiñ.com', N'S', 0, N'brocanelli', N'vale')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (3, 2, N'administrador', N'hola', N'adm@gmail.com', N'S', 0, N'hunziker', N'admin')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (5, 2, N'celina', N'123', N'celihunziker@gmail.com', N'S', 0, N'hunziker', N'celi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (6, 3, N'santiago', N'123', N'santi@gmail.com', N'S', 0, N'hunziker', N'santi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (7, 2, N'pilar', N'123', N'pilu@gmail.com', N'S', 0, N'hunziker', N'pili')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (9, 1, N'judith', N'123', N'jm@gmail.com', N'S', 0, N'hunziker', N'judi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (10, 3, N'santitroll', N'123', N'santitroll@gmail.com', N'S', 0, N'hunziker', N'troll')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (11, 3, N'valentina', N'1234', N'vale@hotmail.com', N'S', 0, N'hunziker', N'valentina')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (12, 1, N'florencia', N'123', N'florencia@gmail.com', N'S', 0, N'hunziker', N'flor')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (13, 1, N'paula', N'123', N'pcadabal@gmail.com', N'S', 0, N'cadabal', N'pau')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_nombreUsuario]    Script Date: 14/9/2022 20:37:17 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [UQ_nombreUsuario] UNIQUE NONCLUSTERED 
(
	[nombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [TPPAV] SET  READ_WRITE 
GO

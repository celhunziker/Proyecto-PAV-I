USE [master]
GO
/****** Object:  Database [TPPAV2]    Script Date: 4/10/2022 11:45:10 ******/
CREATE DATABASE [TPPAV2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TPPAV2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TPPAV2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TPPAV2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TPPAV2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TPPAV2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPPAV2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPPAV2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPPAV2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPPAV2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPPAV2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPPAV2] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPPAV2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TPPAV2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPPAV2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPPAV2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPPAV2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPPAV2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPPAV2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPPAV2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPPAV2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPPAV2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TPPAV2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPPAV2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPPAV2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPPAV2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPPAV2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPPAV2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPPAV2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPPAV2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPPAV2] SET  MULTI_USER 
GO
ALTER DATABASE [TPPAV2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPPAV2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPPAV2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPPAV2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPPAV2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TPPAV2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TPPAV2] SET QUERY_STORE = OFF
GO
USE [TPPAV2]
GO
/****** Object:  Table [dbo].[Clases]    Script Date: 4/10/2022 11:45:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clases](
	[id_clase] [int] IDENTITY(1,1) NOT NULL,
	[id_disciplina] [int] NOT NULL,
	[horario] [time](0) NOT NULL,
	[diaSemana] [nvarchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Clases] PRIMARY KEY CLUSTERED 
(
	[id_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplinas]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplinas](
	[id_disciplina] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Disciplinas] PRIMARY KEY CLUSTERED 
(
	[id_disciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas_Tarjetas]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas_Tarjetas](
	[id_marca_tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Marcas_Tarjetas] PRIMARY KEY CLUSTERED 
(
	[id_marca_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 4/10/2022 11:45:11 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[marca] [int] NOT NULL,
	[contenido] [float] NOT NULL,
	[unidad_de_medida] [int] NOT NULL,
	[tipo_producto] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[id_marca_tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[nro_tarjeta] [int] NOT NULL,
	[fecha_venc] [date] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Tarjetas] PRIMARY KEY CLUSTERED 
(
	[nro_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Productos]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Productos](
	[id_tipo_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
	[descripcion] [nchar](250) NULL,
 CONSTRAINT [PK_Tipos_Productos] PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[id_clase] [int] NOT NULL,
	[fecha_hora] [datetime] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unidades_de_medida]    Script Date: 4/10/2022 11:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidades_de_medida](
	[Id_unidad_medida] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Unidades_de_medida] PRIMARY KEY CLUSTERED 
(
	[Id_unidad_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 4/10/2022 11:45:11 ******/
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
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (1, N'CelinaSport', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (2, N'ValeX', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (3, N'SuperSanti', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (4, N'CrossVale', NULL)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Comprador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Perfil3', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (12, N'Perfil4', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado]) VALUES (1, 1, 2, 2, 2, N'holu', N'Gatorade roja', 0)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado]) VALUES (2, 2, 4, 1, 1, NULL, N'Proteina Power', 0)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado]) VALUES (3, 3, 0.5, 1, 2, N'hola', N'piña', 0)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado]) VALUES (4, 3, 52, 1, 2, N'jjj', N'ggg', 0)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado]) VALUES (5, 2, 0.5, 1, 5, N'muy buenas!', N'hola', 0)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado]) VALUES (6, 3, 0.6, 1, 5, N'hol', N'buru', 0)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_Productos] ON 

INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (1, N'Proteína', 0, N'Proteina rica                                                                                                                                                                                                                                             ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (2, N'Creatina', 0, N'Creatina para santis                                                                                                                                                                                                                                      ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (3, N'Bebida energética', 0, NULL)
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (4, N'Barra de cereal', 0, NULL)
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (5, N'Granola', 0, NULL)
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (6, N'Agua', 1, N'Agua sin gas                                                                                                                                                                                                                                              ')
SET IDENTITY_INSERT [dbo].[Tipos_Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Unidades_de_medida] ON 

INSERT [dbo].[Unidades_de_medida] ([Id_unidad_medida], [Nombre], [borrado]) VALUES (1, N'gramos', 0)
INSERT [dbo].[Unidades_de_medida] ([Id_unidad_medida], [Nombre], [borrado]) VALUES (2, N'litros', 0)
SET IDENTITY_INSERT [dbo].[Unidades_de_medida] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (2, 1, N'valeria', N'123', N'vale@gmaiñ.com', N'S', 1, N'brocanelli', N'vale')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (3, 1, N'administradoree', N'hola', N'adm@gmail.com', N'S', 0, N'hunziker', N'ppe')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (5, 2, N'celina', N'123', N'celihunziker@gmail.com', N'S', 1, N'hunziker', N'celi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (6, 3, N'santiagoooo', N'123', N'santi@gmail.com', N'S', 0, N'hunziker', N'santi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (7, 2, N'pilarcita', N'123', N'pilu@gmail.com', N'S', 1, N'hunziker', N'pilar')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (9, 1, N'judith', N'123', N'jm@gmail.com', N'S', 1, N'hunziker', N'judi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (10, 3, N'santitroll', N'123', N'santitroll@gmail.com', N'S', 0, N'hunziker', N'troll')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (11, 3, N'valentinapppp', N'1234', N'vale@hotmail.com', N'S', 1, N'hunziker', N'valentina')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (12, 1, N'florenciaa', N'123', N'florencia@gmail.com', N'S', 0, N'hunziker', N'florr')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (13, 1, N'paula', N'123', N'pcadabal@gmail.com', N'S', 0, N'cadabal', N'pau')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (14, 2, N'vvvll', N'ikk', N'kk', N'S', 0, N'kkk', N'kkk')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (19, 2, N'pilar', N'123', N'pili@gmail.com', N'S', 0, N'brocanelli', N'piluchi')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (20, 2, N'pp', N'lll', N'hhh', N'S', 0, N'ooo', N'valeeeeee')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (21, 2, N'KKK', N'KKKK', N'LLL', N'S', 1, N'KK', N'OOOOO')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (22, 2, N'pedro', N'ppp', N'kk', N'S', 1, N'oooo', N'kkkkk')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (23, 2, N'pp', N'pp', N'kk', N'S', 0, N'kkk', N'fedu')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario]) VALUES (24, 1, N'jjj', N'kkk', N'jj', N'S', 0, N'lll', N'holaaaaa')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  Index [IX_Productos]    Script Date: 4/10/2022 11:45:11 ******/
CREATE NONCLUSTERED INDEX [IX_Productos] ON [dbo].[Productos]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_nombreUsuario]    Script Date: 4/10/2022 11:45:11 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [UQ_nombreUsuario] UNIQUE NONCLUSTERED 
(
	[nombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clases]  WITH CHECK ADD  CONSTRAINT [FK_Clases_Disciplinas] FOREIGN KEY([id_disciplina])
REFERENCES [dbo].[Disciplinas] ([id_disciplina])
GO
ALTER TABLE [dbo].[Clases] CHECK CONSTRAINT [FK_Clases_Disciplinas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([marca])
REFERENCES [dbo].[Marcas] ([id_marca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Tipos_Productos] FOREIGN KEY([tipo_producto])
REFERENCES [dbo].[Tipos_Productos] ([id_tipo_producto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Tipos_Productos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Unidades_De_Medida] FOREIGN KEY([unidad_de_medida])
REFERENCES [dbo].[Unidades_de_medida] ([Id_unidad_medida])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Unidades_De_Medida]
GO
ALTER TABLE [dbo].[Tarjetas]  WITH CHECK ADD  CONSTRAINT [FK_Tarjetas_Marca_Tarjetas] FOREIGN KEY([id_marca_tarjeta])
REFERENCES [dbo].[Marcas_Tarjetas] ([id_marca_tarjeta])
GO
ALTER TABLE [dbo].[Tarjetas] CHECK CONSTRAINT [FK_Tarjetas_Marca_Tarjetas]
GO
ALTER TABLE [dbo].[Tarjetas]  WITH CHECK ADD  CONSTRAINT [FK_Tarjetas_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Tarjetas] CHECK CONSTRAINT [FK_Tarjetas_Usuarios]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Clases] FOREIGN KEY([id_clase])
REFERENCES [dbo].[Clases] ([id_clase])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Clases]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
USE [master]
GO
ALTER DATABASE [TPPAV2] SET  READ_WRITE 
GO

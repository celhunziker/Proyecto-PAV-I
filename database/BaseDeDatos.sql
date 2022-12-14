USE [master]
GO
/****** Object:  Database [TPPAV2]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Clases]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Descuentos]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuentos](
	[id_descuento] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[porcentaje] [float] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Descuentos] PRIMARY KEY CLUSTERED 
(
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Cobros]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Cobros](
	[id_detalle_cobro] [int] IDENTITY(1,1) NOT NULL,
	[id_medio_cobro] [int] NOT NULL,
	[id_marca_banco] [int] NULL,
	[id_marca_tarjeta] [int] NULL,
	[cuotas] [int] NULL,
	[monto] [float] NOT NULL,
	[valor_cuota] [float] NULL,
	[codigo_autorizacion] [int] NULL,
	[id_factura] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Detalles_Cobros] PRIMARY KEY CLUSTERED 
(
	[id_detalle_cobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Facturas]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Facturas](
	[id_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
	[id_producto] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Detalles_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplinas]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Facturas]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario_vendedor] [int] NOT NULL,
	[id_tipo_factura] [int] NOT NULL,
	[total] [float] NOT NULL,
	[id_descuento] [int] NULL,
	[borrado] [bit] NOT NULL,
	[id_usuario_cliente] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[nroFactura] [varchar](50) NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Marcas_Bancos]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas_Bancos](
	[id_marca_banco] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Marcas_Bancos] PRIMARY KEY CLUSTERED 
(
	[id_marca_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas_Tarjetas]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Medios_Pagos]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medios_Pagos](
	[id_medio_cobro] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Medios_Pagos] PRIMARY KEY CLUSTERED 
(
	[id_medio_cobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 15/11/2022 16:28:53 ******/
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
	[borrado] [bit] NOT NULL,
	[precio] [float] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Clientes]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Clientes](
	[id_tipo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](250) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Tipos_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Facturas]    Script Date: 15/11/2022 16:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Facturas](
	[id_tipo_factura] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Tipos_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_tipo_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Productos]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Turnos]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Unidades_de_medida]    Script Date: 15/11/2022 16:28:53 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/11/2022 16:28:53 ******/
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
	[CUIT] [bigint] NOT NULL,
	[direccion] [nchar](250) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clases] ON 

INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (2, 1, CAST(N'08:00:00' AS Time), N'lunes', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (3, 1, CAST(N'12:00:00' AS Time), N'lunes', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (4, 2, CAST(N'13:00:00' AS Time), N'martes', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (5, 3, CAST(N'18:00:00' AS Time), N'jueves', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (6, 6, CAST(N'20:00:00' AS Time), N'miercoles', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (7, 5, CAST(N'09:00:00' AS Time), N'miercoles', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (8, 3, CAST(N'17:00:00' AS Time), N'martes', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (9, 2, CAST(N'17:11:00' AS Time), N'miercoles', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (10, 6, CAST(N'10:00:00' AS Time), N'martes', 0)
INSERT [dbo].[Clases] ([id_clase], [id_disciplina], [horario], [diaSemana], [borrado]) VALUES (11, 2, CAST(N'20:00:00' AS Time), N'jueves', 0)
SET IDENTITY_INSERT [dbo].[Clases] OFF
GO
SET IDENTITY_INSERT [dbo].[Descuentos] ON 

INSERT [dbo].[Descuentos] ([id_descuento], [codigo], [porcentaje], [borrado]) VALUES (2, N'CLIENTE_NUEVO', 50, 0)
INSERT [dbo].[Descuentos] ([id_descuento], [codigo], [porcentaje], [borrado]) VALUES (3, N'FELICES_FIESTAS', 15, 0)
INSERT [dbo].[Descuentos] ([id_descuento], [codigo], [porcentaje], [borrado]) VALUES (4, N'PRIMAVERA', 25, 0)
INSERT [dbo].[Descuentos] ([id_descuento], [codigo], [porcentaje], [borrado]) VALUES (5, N'BLACK_FRIDAY', 60, 0)
SET IDENTITY_INSERT [dbo].[Descuentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalles_Cobros] ON 

INSERT [dbo].[Detalles_Cobros] ([id_detalle_cobro], [id_medio_cobro], [id_marca_banco], [id_marca_tarjeta], [cuotas], [monto], [valor_cuota], [codigo_autorizacion], [id_factura], [borrado]) VALUES (1, 2, 3, 1, NULL, 26300, NULL, 555, 17, 0)
INSERT [dbo].[Detalles_Cobros] ([id_detalle_cobro], [id_medio_cobro], [id_marca_banco], [id_marca_tarjeta], [cuotas], [monto], [valor_cuota], [codigo_autorizacion], [id_factura], [borrado]) VALUES (2, 3, 1, 3, NULL, 10000, NULL, 5, 18, 0)
SET IDENTITY_INSERT [dbo].[Detalles_Cobros] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalles_Facturas] ON 

INSERT [dbo].[Detalles_Facturas] ([id_detalle_factura], [id_factura], [cantidad], [subtotal], [id_producto], [borrado]) VALUES (18, 16, 1, 88, 9, 0)
INSERT [dbo].[Detalles_Facturas] ([id_detalle_factura], [id_factura], [cantidad], [subtotal], [id_producto], [borrado]) VALUES (19, 16, 1, 1000, 5, 0)
INSERT [dbo].[Detalles_Facturas] ([id_detalle_factura], [id_factura], [cantidad], [subtotal], [id_producto], [borrado]) VALUES (20, 17, 5, 500, 4, 0)
INSERT [dbo].[Detalles_Facturas] ([id_detalle_factura], [id_factura], [cantidad], [subtotal], [id_producto], [borrado]) VALUES (21, 17, 5, 25000, 2, 0)
INSERT [dbo].[Detalles_Facturas] ([id_detalle_factura], [id_factura], [cantidad], [subtotal], [id_producto], [borrado]) VALUES (22, 17, 8, 800, 4, 0)
INSERT [dbo].[Detalles_Facturas] ([id_detalle_factura], [id_factura], [cantidad], [subtotal], [id_producto], [borrado]) VALUES (23, 18, 2, 10000, 2, 0)
SET IDENTITY_INSERT [dbo].[Detalles_Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Disciplinas] ON 

INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (1, N'zumba', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (2, N'musculacion', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (3, N'crossfit', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (4, N'yoga', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (5, N'pilates', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (6, N'funcional', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (7, N'spinning', 0)
INSERT [dbo].[Disciplinas] ([id_disciplina], [nombre], [borrado]) VALUES (8, N'natación', 0)
SET IDENTITY_INSERT [dbo].[Disciplinas] OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([id_factura], [id_usuario_vendedor], [id_tipo_factura], [total], [id_descuento], [borrado], [id_usuario_cliente], [fecha], [nroFactura]) VALUES (16, 3, 1, 1088, NULL, 0, 10, CAST(N'2022-10-17' AS Date), N'5')
INSERT [dbo].[Facturas] ([id_factura], [id_usuario_vendedor], [id_tipo_factura], [total], [id_descuento], [borrado], [id_usuario_cliente], [fecha], [nroFactura]) VALUES (17, 3, 1, 26300, NULL, 0, 2, CAST(N'2022-11-15' AS Date), N'00000017')
INSERT [dbo].[Facturas] ([id_factura], [id_usuario_vendedor], [id_tipo_factura], [total], [id_descuento], [borrado], [id_usuario_cliente], [fecha], [nroFactura]) VALUES (18, 3, 3, 10000, NULL, 0, 2, CAST(N'2022-11-15' AS Date), N'00000018')
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (1, N'Gatorade', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (2, N'Fine Power', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (3, N'ENA', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (4, N'OLYMPIC', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (6, N'MUECAS', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (7, N'Integra', 0)
INSERT [dbo].[Marcas] ([id_marca], [nombre], [borrado]) VALUES (8, N'Ultra Tech', 0)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas_Bancos] ON 

INSERT [dbo].[Marcas_Bancos] ([id_marca_banco], [nombre], [borrado]) VALUES (1, N'Galicia', 0)
INSERT [dbo].[Marcas_Bancos] ([id_marca_banco], [nombre], [borrado]) VALUES (2, N'Macro', 0)
INSERT [dbo].[Marcas_Bancos] ([id_marca_banco], [nombre], [borrado]) VALUES (3, N'ICBC', 0)
SET IDENTITY_INSERT [dbo].[Marcas_Bancos] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas_Tarjetas] ON 

INSERT [dbo].[Marcas_Tarjetas] ([id_marca_tarjeta], [nombre], [borrado]) VALUES (1, N'MasterCard', 0)
INSERT [dbo].[Marcas_Tarjetas] ([id_marca_tarjeta], [nombre], [borrado]) VALUES (2, N'VISA', 0)
INSERT [dbo].[Marcas_Tarjetas] ([id_marca_tarjeta], [nombre], [borrado]) VALUES (3, N'AmericanExpress', 0)
SET IDENTITY_INSERT [dbo].[Marcas_Tarjetas] OFF
GO
SET IDENTITY_INSERT [dbo].[Medios_Pagos] ON 

INSERT [dbo].[Medios_Pagos] ([id_medio_cobro], [nombre], [borrado]) VALUES (1, N'Efectivo', 0)
INSERT [dbo].[Medios_Pagos] ([id_medio_cobro], [nombre], [borrado]) VALUES (2, N'Crédito', 0)
INSERT [dbo].[Medios_Pagos] ([id_medio_cobro], [nombre], [borrado]) VALUES (3, N'Débito', 0)
INSERT [dbo].[Medios_Pagos] ([id_medio_cobro], [nombre], [borrado]) VALUES (4, N'Transferencia', 0)
SET IDENTITY_INSERT [dbo].[Medios_Pagos] OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Cliente', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Profesor', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Cajero', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (12, N'Vendedor', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (1, 1, 0.5, 2, 3, N'Alimento líquidp a base de sales. Sabor manzana', N'Gatorade Manzana', 0, 200.9, 50)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (2, 3, 930, 1, 1, N'Contiene un blend de máxima pureza.', N'Whey Protein', 0, 5000, 43)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (3, 2, 11.5, 1, 7, N'Suplemento dietario dietético a base de colágeno.', N'Colageno Red Super Fruit', 0, 500, 50)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (4, 6, 45, 1, 4, N' Alimentos honestos.', N'Barra de Cereal Banana y Dulce de Leche', 0, 100, 5)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (5, 4, 60, 1, 8, N'Todo lo necesario para entrenamientos.', N'Barra Proteica Coco', 0, 1000, 4)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (6, 7, 240, 1, 5, N'Alimentos complejos que nutren y nos cuidan', N'Granola Clásica', 0, 835, 51)
INSERT [dbo].[Productos] ([id_producto], [marca], [contenido], [unidad_de_medida], [tipo_producto], [descripcion], [nombre], [borrado], [precio], [stock]) VALUES (9, 8, 150, 1, 2, N'Monohidrato de Creatina', N'Creatina', 0, 9000, 10)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_Clientes] ON 

INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (1, N'Responsable Inscripto                                                                                                                                                                                                                                     ', 0)
INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (2, N'Monotribustista                                                                                                                                                                                                                           Monotributista  ', 0)
INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (3, N'Consumidor Final                                                                                                                                                                                                                                          ', 0)
INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (4, N'Exento en el IVA                                                                                                                                                                                                                                          ', 0)
SET IDENTITY_INSERT [dbo].[Tipos_Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_Facturas] ON 

INSERT [dbo].[Tipos_Facturas] ([id_tipo_factura], [nombre], [borrado]) VALUES (1, N'Tipo A', 0)
INSERT [dbo].[Tipos_Facturas] ([id_tipo_factura], [nombre], [borrado]) VALUES (2, N'Tipo B', 0)
INSERT [dbo].[Tipos_Facturas] ([id_tipo_factura], [nombre], [borrado]) VALUES (3, N'Tipo C', 0)
SET IDENTITY_INSERT [dbo].[Tipos_Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_Productos] ON 

INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (1, N'Proteína', 0, N'Proteina rica                               Aporta los aminoácidos y micronutrientes que son clave en la dieta de deportistas                                                                                                                             ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (2, N'Creatina', 0, N'Se utiliza para mejorar el rendimiento del ejercicio y la masa muscular.                                                                                                                                                                                  ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (3, N'Bebida energética', 0, N' bebidas analcohólicas, generalmente gasificadas, compuestas principalmente por cafeína e hidratos de carbono.                                                                                                                                            ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (4, N'Barra de cereal', 0, N'La barrita de cereal es rica en fibras, ideal para revertir el tránsito lento. ​Es un gran suplemento dietario.                                                                                                                                           ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (5, N'Granola', 0, N'La granola es un alimento cuya base se realiza con frutos secos (almendras y/o nueces), avena, mezclado con miel y horneado hasta quedar crujiente.                                                                                                       ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (6, N'Agua', 1, N'Agua sin gas                                                                                                                                                                                                                                              ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (7, N'Colageno', 0, N'El colágeno es un elemento muy importante en nuestra alimentación, es esencial en la ejecución de muchas de nuestras actividades diarias y está encargada de dar estructura, firmeza y elasticidad a la piel y mantiene la salud de tus músculos          ')
INSERT [dbo].[Tipos_Productos] ([id_tipo_producto], [nombre], [borrado], [descripcion]) VALUES (8, N'Barra Proteica', 0, N'Las barritas proteicas son barritas enriquecidas con proteínas. Por ello contribuyen a aumentar y conservar la masa muscular.                                                                                                                             ')
SET IDENTITY_INSERT [dbo].[Tipos_Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Unidades_de_medida] ON 

INSERT [dbo].[Unidades_de_medida] ([Id_unidad_medida], [Nombre], [borrado]) VALUES (1, N'gramos', 0)
INSERT [dbo].[Unidades_de_medida] ([Id_unidad_medida], [Nombre], [borrado]) VALUES (2, N'litros', 0)
SET IDENTITY_INSERT [dbo].[Unidades_de_medida] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (2, 1, N'Valeria', N'123', N'vale@gmaiñ.com', N'S', 0, N'brocanelli', N'valeria', 55111111112, N'Calle las heras 1                                                                                                                                                                                                                                         ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (3, 12, N'Celina', N'hola', N'celina@gmail.com', N'S', 0, N'hunziker', N'ppe', 55112211112, N'recta martinolli 22                                                                                                                                                                                                                                       ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (5, 2, N'Paula', N'123', N'pau@gmail.com', N'S', 0, N'hunziker', N'paula', 55111188112, N'nuñez 1000                                                                                                                                                                                                                                                ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (6, 3, N'Santiago', N'123', N'santi@gmail.com', N'S', 0, N'hunziker', N'santi', 55881111112, N'nuñez 88                                                                                                                                                                                                                                                  ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (7, 2, N'Pilar', N'123', N'pilu@gmail.com', N'S', 0, N'hunziker', N'pilar', 55115551112, N'gauss 22                                                                                                                                                                                                                                                  ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (9, 1, N'Judith', N'123', N'jm@gmail.com', N'S', 0, N'hunziker', N'judi', 55111100112, N'gauss 4                                                                                                                                                                                                                                                   ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (10, 3, N'Juan', N'123', N'juan@gmail.com', N'S', 0, N'hunziker', N'juan', 55111771112, N'gauss 2                                                                                                                                                                                                                                                   ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (11, 3, N'Agusto', N'123', N'agusto@hotmail.com', N'S', 0, N'hunziker', N'agusto', 55111111177, N'tejeda 66                                                                                                                                                                                                                                                 ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (12, 1, N'Florencia', N'123', N'florencia@gmail.com', N'S', 0, N'hunziker', N'flor', 55115511112, N'tejeda 7                                                                                                                                                                                                                                                  ')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [nombre], [password], [email], [estado], [borrado], [apellido], [nombreUsuario], [CUIT], [direccion]) VALUES (13, 1, N'Martin', N'123', N'martin@gmail.com', N'S', 0, N'cadabal', N'martin', 55111111100, N'gauss 6                                                                                                                                                                                                                                                   ')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  Index [IX_Productos]    Script Date: 15/11/2022 16:28:53 ******/
CREATE NONCLUSTERED INDEX [IX_Productos] ON [dbo].[Productos]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_nombreUsuario]    Script Date: 15/11/2022 16:28:53 ******/
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
ALTER TABLE [dbo].[Detalles_Cobros]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Cobros_Facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturas] ([id_factura])
GO
ALTER TABLE [dbo].[Detalles_Cobros] CHECK CONSTRAINT [FK_Detalles_Cobros_Facturas]
GO
ALTER TABLE [dbo].[Detalles_Cobros]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Cobros_Marcas_Bancos1] FOREIGN KEY([id_marca_banco])
REFERENCES [dbo].[Marcas_Bancos] ([id_marca_banco])
GO
ALTER TABLE [dbo].[Detalles_Cobros] CHECK CONSTRAINT [FK_Detalles_Cobros_Marcas_Bancos1]
GO
ALTER TABLE [dbo].[Detalles_Cobros]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Cobros_Marcas_Tarjetas1] FOREIGN KEY([id_marca_tarjeta])
REFERENCES [dbo].[Marcas_Tarjetas] ([id_marca_tarjeta])
GO
ALTER TABLE [dbo].[Detalles_Cobros] CHECK CONSTRAINT [FK_Detalles_Cobros_Marcas_Tarjetas1]
GO
ALTER TABLE [dbo].[Detalles_Cobros]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Cobros_Medios_Pagos1] FOREIGN KEY([id_medio_cobro])
REFERENCES [dbo].[Medios_Pagos] ([id_medio_cobro])
GO
ALTER TABLE [dbo].[Detalles_Cobros] CHECK CONSTRAINT [FK_Detalles_Cobros_Medios_Pagos1]
GO
ALTER TABLE [dbo].[Detalles_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Facturas_Facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturas] ([id_factura])
GO
ALTER TABLE [dbo].[Detalles_Facturas] CHECK CONSTRAINT [FK_Detalles_Facturas_Facturas]
GO
ALTER TABLE [dbo].[Detalles_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Facturas_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Detalles_Facturas] CHECK CONSTRAINT [FK_Detalles_Facturas_Productos]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Descuentos] FOREIGN KEY([id_descuento])
REFERENCES [dbo].[Descuentos] ([id_descuento])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Descuentos]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Tipos_Facturas] FOREIGN KEY([id_tipo_factura])
REFERENCES [dbo].[Tipos_Facturas] ([id_tipo_factura])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Tipos_Facturas]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuarios] FOREIGN KEY([id_usuario_cliente])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuarios]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuarios1] FOREIGN KEY([id_usuario_vendedor])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuarios1]
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

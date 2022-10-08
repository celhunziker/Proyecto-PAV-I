
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
/****** Object:  Table [dbo].[Tipos_Facturas]    Script Date: 8/10/2022 18:51:21 ******/
SET ANSI_NULLS ON

SET IDENTITY_INSERT [dbo].[Tipos_Clientes] ON 

INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (1, N'Responsable Inscripto                                                                                                                                                                                                                                     ', 0)
INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (2, N'Monotribustista                                                                                                                                                                                                                           Monotributista  ', 0)
INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (3, N'Consumidor Final                                                                                                                                                                                                                                          ', 0)
INSERT [dbo].[Tipos_Clientes] ([id_tipo_cliente], [nombre], [borrado]) VALUES (4, N'Exento en el IVA                                                                                                                                                                                                                                          ', 0)
SET IDENTITY_INSERT [dbo].[Tipos_Clientes] OFF

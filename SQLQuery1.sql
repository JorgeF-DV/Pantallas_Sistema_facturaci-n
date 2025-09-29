USE [[DBFACTURAS]]]
GO
/****** Object:  Table [dbo].[TBLCATEGORIA_PROD]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCATEGORIA_PROD](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[StrDescripcion] [varchar](60) NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifico] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLCLIENTES]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCLIENTES](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[StrNombre] [varchar](55) NULL,
	[NumDocumento] [bigint] NULL,
	[StrDireccion] [varchar](70) NULL,
	[StrTelefono] [varchar](30) NULL,
	[StrEmail] [varchar](50) NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifica] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLDETALLE_FACTURA]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLDETALLE_FACTURA](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NOT NULL,
	[NumCantidad] [int] NULL,
	[IdProducto] [int] NOT NULL,
	[NumPrecio] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLEMPLEADO]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLEMPLEADO](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[strNombre] [varchar](50) NOT NULL,
	[NumDocumento] [bigint] NOT NULL,
	[StrDireccion] [varchar](100) NULL,
	[StrTelefono] [varchar](50) NULL,
	[StrEmail] [varchar](50) NULL,
	[IdRolEmpleado] [int] NULL,
	[DtmIngreso] [datetime] NULL,
	[DtmRetiro] [datetime] NULL,
	[strDatosAdicionales] [nvarchar](max) NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifico] [varchar](50) NULL,
 CONSTRAINT [PK_TBLEMPLEADO] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLESTADO_FACTURA]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLESTADO_FACTURA](
	[IdEstadoFactura] [int] IDENTITY(1,1) NOT NULL,
	[StrDescripcion] [varchar](30) NULL,
 CONSTRAINT [PK_TBLESTADO_FACTURA] PRIMARY KEY CLUSTERED 
(
	[IdEstadoFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLFACTURA]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLFACTURA](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[DtmFecha] [datetime] NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[NumDescuento] [float] NULL,
	[NumImpuesto] [float] NULL,
	[NumValorTotal] [float] NULL,
	[IdEstado] [int] NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifica] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLPRODUCTO]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLPRODUCTO](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[StrNombre] [varchar](70) NOT NULL,
	[StrCodigo] [varchar](30) NOT NULL,
	[NumPrecioCompra] [float] NOT NULL,
	[NumPrecioVenta] [float] NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[StrDetalle] [varchar](50) NULL,
	[strFoto] [varchar](50) NULL,
	[NumStock] [int] NULL,
	[DtmFechaModifica] [datetime] NOT NULL,
	[StrUsuarioModifica] [varchar](40) NOT NULL,
 CONSTRAINT [PK__TBLPRODU__09889210A63187C7] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLROLES]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLROLES](
	[IdRolEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[StrDescripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TBLROLES] PRIMARY KEY CLUSTERED 
(
	[IdRolEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSEGURIDAD]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSEGURIDAD](
	[IdSeguridad] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[StrUsuario] [varchar](50) NULL,
	[StrClave] [varchar](50) NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifico] [varchar](50) NULL,
 CONSTRAINT [PK_TBLSEGURIDAD] PRIMARY KEY CLUSTERED 
(
	[IdSeguridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLCATEGORIA_PROD] ON 

INSERT [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1, N'Tecnología', CAST(N'2021-03-13T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (2, N'Alimentos', CAST(N'2021-03-13T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (3, N'Carnes', CAST(N'2021-03-13T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLCATEGORIA_PROD] OFF
SET IDENTITY_INSERT [dbo].[TBLCLIENTES] ON 

INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1, N'javier Alberto saldarriaga canito saludos', 71684754, N'calle la misma zzzzzz', N'435346436', N'javier@gmail.com', CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (2, N'Rosmira Giraldo perez ', 71677854, N'calle 65 nto 22 33', N'2345566', N'pruebarosmi@gmail.com', CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (5, N'Claudio del socorro', 456789, N'lolita avenida carlos', N'33333', N'3333@eee.com', CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1012, N'davicito saldarriaguito', 2222222, N'calle la misma', N'23454', N'javiy2k@gmail.com', CAST(N'2019-05-07T10:27:54.253' AS DateTime), N'javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1022, N'pedro paramo', 7777777, N'calle', N'12345', N'javi@javi.com', CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1028, N'pepe grillo en casa', 2342343, N'calle la misma', N'2342353', N'asdas@sad.com', CAST(N'2020-11-07T19:14:28.200' AS DateTime), N'javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1029, N'333pepe grillo en casa', 2342343, N'calle 65 c nro 91-130 interior 208', N'3117185300', N'javier.saldarriaga@pascualbravo.edu.co', CAST(N'2020-11-07T19:17:53.990' AS DateTime), N'javier')
SET IDENTITY_INSERT [dbo].[TBLCLIENTES] OFF
SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] ON 

INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1, N'Julian Alberto tabares Cano ', 71688655, N'calle 67 c nro 9092 ffff', N'2345566', N'javiy2k@gmail.com', 1, CAST(N'2019-01-17T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Buen trabajador, dedicado y cumplido', CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (2, N'Rosmira Giraldo naranjo perez ', 78655543, N'Calle 8 nro 99- 34 rr', N'345678', N'rosmi2809@gmail.com', 1, CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Exelente', CAST(N'2020-09-11T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (3, N'David Saldarriaga Canosito', 345678, N'calle la misma de siempre', N'345678', N'david@22222.com', 3, CAST(N'2019-02-06T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'es el mejor sssssss', CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1011, N'javier saldarriaga Cano13333333333333', 71688655, N'calle 67 c nro 9092 ffff', N'2345566', N'javiy2k@gmail.com', 1, CAST(N'2019-01-17T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Buen trabajador, dedicado y cumplido', CAST(N'2020-03-05T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1016, N'javier saldarriaga Cano111', 71688655, N'calle 67 c nro 9092', N'2345566', N'javiy2k@gmail.com', 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Buen trabajador, dedicado y cumplido', CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] OFF
SET IDENTITY_INSERT [dbo].[TBLESTADO_FACTURA] ON 

INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (1, N'Pendiente Pago')
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (2, N'Pagada')
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (3, N'Anulada')
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (4, N'Vencida')
SET IDENTITY_INSERT [dbo].[TBLESTADO_FACTURA] OFF
SET IDENTITY_INSERT [dbo].[TBLFACTURA] ON 

INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (2, CAST(N'2021-01-01T00:00:00.000' AS DateTime), 1, 2, 66, 23, 123456, 1, CAST(N'2021-01-01T00:00:00.000' AS DateTime), N'pepe')
INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (3, CAST(N'2021-01-01T00:00:00.000' AS DateTime), 2, 3, 0, 0, 400000, 2, CAST(N'2021-01-01T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (6, CAST(N'2021-03-01T00:00:00.000' AS DateTime), 2, 1, 5, 19, 500000, 2, CAST(N'2021-03-01T00:00:00.000' AS DateTime), N'julio')
INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (7, CAST(N'2021-03-09T00:00:00.000' AS DateTime), 5, 2, 6, 7, 5555555, 3, CAST(N'2021-03-14T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (8, CAST(N'2021-03-01T00:00:00.000' AS DateTime), 1022, 2, 0, 19, 475900, 1, CAST(N'2021-03-14T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (9, CAST(N'2021-03-23T00:00:00.000' AS DateTime), 1029, 2, 1, 1, 1, 2, CAST(N'2021-03-14T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLFACTURA] ([IdFactura], [DtmFecha], [IdCliente], [IdEmpleado], [NumDescuento], [NumImpuesto], [NumValorTotal], [IdEstado], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (10, CAST(N'2021-03-01T00:00:00.000' AS DateTime), 5, 3, 5, 19, 450000, 1, CAST(N'2021-03-14T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLFACTURA] OFF
SET IDENTITY_INSERT [dbo].[TBLPRODUCTO] ON 

INSERT [dbo].[TBLPRODUCTO] ([IdProducto], [StrNombre], [StrCodigo], [NumPrecioCompra], [NumPrecioVenta], [IdCategoria], [StrDetalle], [strFoto], [NumStock], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1, N'tablet marca lenovo ', N'0023400', 1235600, 210000000, 1, N'nuevo de fabrica', N'ninguna', 4, CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLPRODUCTO] ([IdProducto], [StrNombre], [StrCodigo], [NumPrecioCompra], [NumPrecioVenta], [IdCategoria], [StrDetalle], [strFoto], [NumStock], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (2, N'TECLADOS BLUETOOTH STANDAR ', N'0065400', 35600, 210000, 2, N'nuevo de fabrica2', N'ninguna', 4, CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLPRODUCTO] ([IdProducto], [StrNombre], [StrCodigo], [NumPrecioCompra], [NumPrecioVenta], [IdCategoria], [StrDetalle], [strFoto], [NumStock], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (4, N'pantallas ', N'34343534', 32435, 345345, 2, N'ddddd', N'ddddd', 23, CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLPRODUCTO] ([IdProducto], [StrNombre], [StrCodigo], [NumPrecioCompra], [NumPrecioVenta], [IdCategoria], [StrDetalle], [strFoto], [NumStock], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (5, N'televisor led 54 pulgadas ', N'234444', 2000000, 3000000, 1, N'es un excelente producto', N'c:', 5, CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLPRODUCTO] OFF
SET IDENTITY_INSERT [dbo].[TBLROLES] ON 

INSERT [dbo].[TBLROLES] ([IdRolEmpleado], [StrDescripcion]) VALUES (1, N'Gerente')
INSERT [dbo].[TBLROLES] ([IdRolEmpleado], [StrDescripcion]) VALUES (2, N'Secretaria')
INSERT [dbo].[TBLROLES] ([IdRolEmpleado], [StrDescripcion]) VALUES (3, N'Operario')
INSERT [dbo].[TBLROLES] ([IdRolEmpleado], [StrDescripcion]) VALUES (4, N'Administrativo')
SET IDENTITY_INSERT [dbo].[TBLROLES] OFF
SET IDENTITY_INSERT [dbo].[TBLSEGURIDAD] ON 

INSERT [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1002, 1, N'admin', N'1234', CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1003, 2, N'rosmi', N'asdf', CAST(N'2019-08-23T14:56:31.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1005, 3, N'pepe', N'123', CAST(N'2019-09-23T15:38:31.380' AS DateTime), N'javier')
INSERT [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (2008, 1016, N'sapo', N'logo', CAST(N'2020-09-02T09:46:13.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLSEGURIDAD] OFF
ALTER TABLE [dbo].[TBLDETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_TBLDETALLE_FACTURA_TBLFACTURA] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[TBLFACTURA] ([IdFactura])
GO
ALTER TABLE [dbo].[TBLDETALLE_FACTURA] CHECK CONSTRAINT [FK_TBLDETALLE_FACTURA_TBLFACTURA]
GO
ALTER TABLE [dbo].[TBLDETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_TBLDETALLE_FACTURA_TBLPRODUCTO] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[TBLPRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[TBLDETALLE_FACTURA] CHECK CONSTRAINT [FK_TBLDETALLE_FACTURA_TBLPRODUCTO]
GO
ALTER TABLE [dbo].[TBLEMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_TBLEMPLEADO_TBLROLES] FOREIGN KEY([IdRolEmpleado])
REFERENCES [dbo].[TBLROLES] ([IdRolEmpleado])
GO
ALTER TABLE [dbo].[TBLEMPLEADO] CHECK CONSTRAINT [FK_TBLEMPLEADO_TBLROLES]
GO
ALTER TABLE [dbo].[TBLFACTURA]  WITH CHECK ADD  CONSTRAINT [FK_TBLFACTURA_TBLCLIENTES] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[TBLCLIENTES] ([IdCliente])
GO
ALTER TABLE [dbo].[TBLFACTURA] CHECK CONSTRAINT [FK_TBLFACTURA_TBLCLIENTES]
GO
ALTER TABLE [dbo].[TBLFACTURA]  WITH CHECK ADD  CONSTRAINT [FK_TBLFACTURA_TBLEMPLEADO] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[TBLEMPLEADO] ([IdEmpleado])
GO
ALTER TABLE [dbo].[TBLFACTURA] CHECK CONSTRAINT [FK_TBLFACTURA_TBLEMPLEADO]
GO
ALTER TABLE [dbo].[TBLFACTURA]  WITH CHECK ADD  CONSTRAINT [FK_TBLFACTURA_TBLESTADO_FACTURA] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura])
GO
ALTER TABLE [dbo].[TBLFACTURA] CHECK CONSTRAINT [FK_TBLFACTURA_TBLESTADO_FACTURA]
GO
ALTER TABLE [dbo].[TBLPRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK__TBLPRODUC__IdCat__440B1D61] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[TBLCATEGORIA_PROD] ([IdCategoria])
GO
ALTER TABLE [dbo].[TBLPRODUCTO] CHECK CONSTRAINT [FK__TBLPRODUC__IdCat__440B1D61]
GO
ALTER TABLE [dbo].[TBLSEGURIDAD]  WITH CHECK ADD  CONSTRAINT [FK_TBLSEGURIDAD_TBLEMPLEADO] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[TBLEMPLEADO] ([IdEmpleado])
GO
ALTER TABLE [dbo].[TBLSEGURIDAD] CHECK CONSTRAINT [FK_TBLSEGURIDAD_TBLEMPLEADO]
GO
ALTER TABLE [dbo].[TBLDETALLE_FACTURA]  WITH CHECK ADD CHECK  (([NumCantidad]>(0)))
GO
ALTER TABLE [dbo].[TBLDETALLE_FACTURA]  WITH CHECK ADD CHECK  (([NumPrecio]>(0.0)))
GO
/****** Object:  StoredProcedure [dbo].[actualizar_CategoriaProd]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[actualizar_CategoriaProd]
			 @IdCategoria int, 
			 @StrDescripcion varchar(60),
			 @DtmFechaModifica  datetime,
			 @StrUsuarioModifico  varchar(20)  
as
--actualizar_CategoriaProd[dbo].[]
if NOT EXISTS (select IdCategoria from TBLCATEGORIA_PROD where IdCategoria=@IdCategoria)

INSERT INTO TBLCATEGORIA_PROD(
           StrDescripcion
           ,DtmFechaModifica
           ,StrUsuarioModifico)
     VALUES
           (
           @StrDescripcion, 
           @DtmFechaModifica,  
           @StrUsuarioModifico)
 else
 
UPDATE  TBLCATEGORIA_PROD
   SET   StrDescripcion  = @StrDescripcion 
      , DtmFechaModifica  = @DtmFechaModifica 
      , StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE    IdCategoria  =  @IdCategoria
GO
/****** Object:  StoredProcedure [dbo].[actualizar_CategoriaProducto]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_CategoriaProducto]
@IdCategoria int,@Strdescripcion varchar(50),@DtmFechaModifica datetime,@StrUsuarioModifico varchar(10)

as
--Actualiza Categoria de los productos
if NOT EXISTS (select IdCategoria from [TBLCATEGORIA_PROD] where IdCategoria=@IdCategoria)
	insert into TBLCATEGORIA_PROD(StrDescripcion,DtmFechaModifica,StrUsuarioModifico)
	values(@StrDescripcion,@DtmFechaModifica,@StrUsuarioModifico)
else
 update TBLCATEGORIA_PROD set StrDescripcion=@StrDescripcion,DtmFechaModifica=@DtmFechaModifica,StrUsuarioModifico=@StrUsuarioModifico where IdCategoria=@IdCategoria

GO
/****** Object:  StoredProcedure [dbo].[actualizar_Cliente]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Cliente]
@IdCliente int, @StrNombre varchar(55),@NumDocumento bigint,@StrDireccion varchar(70), @StrTelefono varchar(30),@StrEmail varchar(50), @StrUsuarioModifica varchar(10),@DtmFechaModifica datetime
as
--- Procedimiento para ingresar o actualizar  el registro de un cliente 
if NOT EXISTS (select IdCliente from TBLCLIENTES where IdCliente=@IdCliente)

insert into TBLCLIENTES( StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail,DtmFechaModifica, StrUsuarioModifica)
 values( @StrNombre,@NumDocumento,@StrDireccion , @StrTelefono,@StrEmail,@DtmFechaModifica, @StrUsuarioModifica)

 else
 
 update TBLCLIENTES set StrNombre= @StrNombre,NumDocumento=@NumDocumento,StrDireccion=@StrDireccion ,StrTelefono= @StrTelefono,StrEmail=@StrEmail,DtmFechaModifica= @DtmFechaModifica,  StrUsuarioModifica= @StrUsuarioModifica  where IdCliente=@IdCliente


GO
/****** Object:  StoredProcedure [dbo].[actualizar_Empleado]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Empleado]
			 @IdEmpleado int,
			 @strNombre varchar(50), 
			 @NumDocumento  bigint,
			 @StrDireccion varchar(50)   
			,@StrTelefono  varchar(20)   
			,@StrEmail  varchar(50)   
			,@IdRolEmpleado int  
			,@DtmIngreso  datetime  
			,@DtmRetiro  datetime  
			,@strDatosAdicionales  nvarchar(250)  
			,@DtmFechaModifica  datetime  
			,@StrUsuarioModifico  varchar(20)  
as
--Actualiza empleado[dbo].[]
if NOT EXISTS (select IdEmpleado from TBLEMPLEADO where IdEmpleado= @IdEmpleado)

INSERT INTO TBLEMPLEADO(
           strNombre
           ,NumDocumento
           ,StrDireccion
           ,StrTelefono
           ,StrEmail
           ,IdRolEmpleado
           ,DtmIngreso
           ,DtmRetiro
           ,strDatosAdicionales
           ,DtmFechaModifica
           ,StrUsuarioModifico)
     VALUES
           (@strNombre,
           @NumDocumento, 
           @StrDireccion, 
           @StrTelefono, 
           @StrEmail,  
           @IdRolEmpleado,  
           @DtmIngreso,  
           @DtmRetiro,  
           @strDatosAdicionales, 
           @DtmFechaModifica,  
           @StrUsuarioModifico)
 else
 

UPDATE  TBLEMPLEADO
   SET  strNombre  =  @strNombre 
      , NumDocumento  = @NumDocumento 
      , StrDireccion = @StrDireccion 
      , StrTelefono  = @StrTelefono 
      , StrEmail  = @StrEmail 
      , IdRolEmpleado  = @IdRolEmpleado 
      , DtmIngreso  = @DtmIngreso 
      , DtmRetiro  = @DtmRetiro 
      , strDatosAdicionales  = @strDatosAdicionales 
      , DtmFechaModifica  = @DtmFechaModifica 
      , StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE    IdEmpleado =  @IdEmpleado 
GO
/****** Object:  StoredProcedure [dbo].[actualizar_Factura]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Factura]
@IdFactura int, @DtmFecha datetime, @IdCliente  int, @IdEmpleado  int  , @NumDescuento  float  ,@NumImpuesto  float,@NumValorTotal  float, @IdEstado  int, @DtmFechaModifica datetime,@StrUsuarioModifica varchar(10)
as
--- Procedimiento para ingresar o actualizar  el registro de un cliente 
if NOT EXISTS (select IdFactura  from TBLFACTURA where IdFactura=@IdFactura)

insert into TBLFACTURA( DtmFecha, IdCliente, IdEmpleado, NumDescuento, NumImpuesto ,NumValorTotal,IdEstado,DtmFechaModifica, StrUsuarioModifica)
 values(@DtmFecha, @IdCliente, @IdEmpleado, @NumDescuento, @NumImpuesto ,@NumValorTotal,@IdEstado,@DtmFechaModifica, @StrUsuarioModifica)

 else
 
 update TBLFACTURA set DtmFecha=@DtmFecha,IdCliente= @IdCliente,IdEmpleado= @IdEmpleado,NumDescuento= @NumDescuento,NumImpuesto= @NumImpuesto ,NumValorTotal=@NumValorTotal,IdEstado=@IdEstado,@DtmFechaModifica=DtmFechaModifica,DtmFechaModifica= @DtmFechaModifica,  StrUsuarioModifica= @StrUsuarioModifica  where IdFactura=@IdFactura


GO
/****** Object:  StoredProcedure [dbo].[actualizar_Producto]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[actualizar_Producto]
		@IdProducto int,
		@StrNombre  varchar(70),
        @StrCodigo varchar(30),
        @NumPrecioCompra float,
        @NumPrecioVenta float,
        @IdCategoria int,
        @StrDetalle varchar(50),
        @strFoto varchar(50),
        @NumStock int,
        @DtmFechaModifica datetime,
        @StrUsuarioModifica varchar(40)
 
as
--pregunta para realizar actualización 
if NOT EXISTS (select IdProducto from TBLPRODUCTO where IdProducto= @IdProducto)

INSERT INTO TBLPRODUCTO(
            StrNombre
           ,StrCodigo
           ,NumPrecioCompra
           ,NumPrecioVenta
           ,IdCategoria
           ,StrDetalle
           ,strFoto
           ,NumStock
           ,DtmFechaModifica
           ,StrUsuarioModifica)
     VALUES
           (
			@StrNombre ,
			@StrCodigo ,
			@NumPrecioCompra,
			@NumPrecioVenta,
			@IdCategoria,
			@StrDetalle,
			@strFoto ,
			@NumStock ,
			@DtmFechaModifica ,
			@StrUsuarioModifica)
 else
 

UPDATE  TBLPRODUCTO
   SET  StrNombre  = @StrNombre 
      , StrCodigo  = @StrCodigo 
      , NumPrecioCompra = @NumPrecioCompra 
      , NumPrecioVenta  = @NumPrecioVenta 
      , IdCategoria = @IdCategoria
      , StrDetalle  = @StrDetalle
      , strFoto  = @strFoto  
      , NumStock   = @NumStock 
      , DtmFechaModifica  = @DtmFechaModifica 
      , StrUsuarioModifica  = @StrUsuarioModifica 
 WHERE   IdProducto  = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[actualizar_Seguridad]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Seguridad]
@IdEmpleado int,@StrUsuario varchar(50),@StrClave varchar(50),@DtmFechaModifica datetime,@StrUsuarioModifico varchar(10)

as
--Actualiza usuarioseguridad
if NOT EXISTS (select IdEmpleado from TBLSEGURIDAD where IdEmpleado=@IdEmpleado)
insert into TBLSEGURIDAD(IdEmpleado,StrUsuario,StrClave,DtmFechaModifica,StrUsuarioModifico)
 values(@IdEmpleado,@StrUsuario,@StrClave,@DtmFechaModifica,@StrUsuarioModifico)

 else
 update TBLSEGURIDAD set IdEmpleado=@IdEmpleado,StrUsuario=@StrUsuario,StrClave=@StrClave,DtmFechaModifica=@DtmFechaModifica,StrUsuarioModifico=@StrUsuarioModifico where IdEmpleado=@IdEmpleado

GO
/****** Object:  StoredProcedure [dbo].[Eliminar_CategoriaProducto]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Eliminar_CategoriaProducto]
@IdCategoria int
as

delete from [dbo].[TBLCATEGORIA_PROD] where  @IdCategoria=@IdCategoria
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Cliente]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_Cliente]
@IdCliente int
as
--- Procedimiento para borrar el registro de un cliente 
delete from TBLCLIENTES where  IdCliente=@IdCliente
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Empleado]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_Empleado]
@IdEmpleado int
as

delete from TBLEMPLEADO where  IdEmpleado=@IdEmpleado
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Producto]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Eliminar_Producto]
@IdProducto int
as

delete from  TBLPRODUCTO  where  IdProducto=@IdProducto
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Seguridad]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Eliminar_Seguridad]
@IdEmpleado int
as

delete from TBLSEGURIDAD where  IdEmpleado=@IdEmpleado
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaFactura]    Script Date: 15/03/2021 6:58:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Javier Saldarriaga Cano
-- Create date: 2021-01-01
-- Description:	Procedimiento de consulta para listar las facturas
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaFactura]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT        TBLFACTURA.IdFactura as Nro_Factura,  FORMAT( TBLFACTURA.DtmFecha, 'dd/MM/yyyy', 'en-US' ) AS 'Fecha', TBLCLIENTES.StrNombre as Cliente, TBLEMPLEADO.strNombre AS Empledo, TBLESTADO_FACTURA.StrDescripcion as Estado
	FROM            TBLFACTURA INNER JOIN
							 TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura INNER JOIN
							 TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente INNER JOIN
							 TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado
END
GO
USE [master]
GO
ALTER DATABASE [[DBFACTURAS]]] SET  READ_WRITE 
GO
USE [DBFACTURAS]
GO
CREATE TABLE [dbo].[TBLCATEGORIA_PROD](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[StrDescripcion] [varchar](60) NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifico] [varchar](40) NULL,
PRIMARY KEY CLUSTERED ([IdCategoria] ASC))
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
PRIMARY KEY CLUSTERED ([IdCliente] ASC))
GO
CREATE TABLE [dbo].[TBLDETALLE_FACTURA](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NOT NULL,
	[NumCantidad] [int] NULL,
	[IdProducto] [int] NOT NULL,
	[NumPrecio] [float] NULL,
PRIMARY KEY CLUSTERED ([IdDetalle] ASC))
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
 CONSTRAINT [PK_TBLEMPLEADO] PRIMARY KEY CLUSTERED ([IdEmpleado] ASC))
GO
CREATE TABLE [dbo].[TBLESTADO_FACTURA](
	[IdEstadoFactura] [int] IDENTITY(1,1) NOT NULL,
	[StrDescripcion] [varchar](30) NULL,
 CONSTRAINT [PK_TBLESTADO_FACTURA] PRIMARY KEY CLUSTERED ([IdEstadoFactura] ASC))
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
PRIMARY KEY CLUSTERED ([IdFactura] ASC))
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
 CONSTRAINT [PK__TBLPRODU__09889210A63187C7] PRIMARY KEY CLUSTERED ([IdProducto] ASC))
GO
CREATE TABLE [dbo].[TBLROLES](
	[IdRolEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[StrDescripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TBLROLES] PRIMARY KEY CLUSTERED ([IdRolEmpleado] ASC))
GO
CREATE TABLE [dbo].[TBLSEGURIDAD](
	[IdSeguridad] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[StrUsuario] [varchar](50) NULL,
	[StrClave] [varchar](50) NULL,
	[DtmFechaModifica] [datetime] NULL,
	[StrUsuarioModifico] [varchar](50) NULL,
 CONSTRAINT [PK_TBLSEGURIDAD] PRIMARY KEY CLUSTERED ([IdSeguridad] ASC))
GO
SET IDENTITY_INSERT [dbo].[TBLCATEGORIA_PROD] ON 
INSERT [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1, N'Tecnología', CAST(N'2021-03-13T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (2, N'Alimentos', CAST(N'2021-03-13T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (3, N'Carnes', CAST(N'2021-03-13T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLCATEGORIA_PROD] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLCLIENTES] ON 
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1, N'javier Alberto saldarriaga canito saludos', 71684754, N'calle la misma zzzzzz', N'435346436', N'javier@gmail.com', CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (2, N'Rosmira Giraldo perez ', 71677854, N'calle 65 nto 22 33', N'2345566', N'pruebarosmi@gmail.com', CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (5, N'Claudio del socorro', 456789, N'lolita avenida carlos', N'33333', N'3333@eee.com', CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLCLIENTES] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] ON 
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1, N'Julian Alberto tabares Cano ', 71688655, N'calle 67 c nro 9092 ffff', N'2345566', N'javiy2k@gmail.com', 1, CAST(N'2019-01-17T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Buen trabajador, dedicado y cumplido', CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (2, N'Rosmira Giraldo naranjo perez ', 78655543, N'Calle 8 nro 99- 34 rr', N'345678', N'rosmi2809@gmail.com', 1, CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Exelente', CAST(N'2020-09-11T00:00:00.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLESTADO_FACTURA] ON 
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (1, N'Pendiente Pago')
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (2, N'Pagada')
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (3, N'Anulada')
INSERT [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (4, N'Vencida')
SET IDENTITY_INSERT [dbo].[TBLESTADO_FACTURA] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLSEGURIDAD] ON 
INSERT [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1002, 1, N'admin', N'1234', CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1003, 2, N'rosmi', N'asdf', CAST(N'2019-08-23T14:56:31.000' AS DateTime), N'Javier')
SET IDENTITY_INSERT [dbo].[TBLSEGURIDAD] OFF
GO
-- ... y el resto de los INSERTs y CREATE PROCEDUREs ...
CREATE procedure [dbo].[actualizar_Cliente]
@IdCliente int, @StrNombre varchar(55),@NumDocumento bigint,@StrDireccion varchar(70), @StrTelefono varchar(30),@StrEmail varchar(50), @StrUsuarioModifica varchar(10),@DtmFechaModifica datetime
as
if NOT EXISTS (select IdCliente from TBLCLIENTES where IdCliente=@IdCliente)
insert into TBLCLIENTES( StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail,DtmFechaModifica, StrUsuarioModifica)
 values( @StrNombre,@NumDocumento,@StrDireccion , @StrTelefono,@StrEmail,@DtmFechaModifica, @StrUsuarioModifica)
 else
 update TBLCLIENTES set StrNombre= @StrNombre,NumDocumento=@NumDocumento,StrDireccion=@StrDireccion ,StrTelefono= @StrTelefono,StrEmail=@StrEmail,DtmFechaModifica= @DtmFechaModifica,  StrUsuarioModifica= @StrUsuarioModifica  where IdCliente=@IdCliente
GO
CREATE procedure [dbo].[Eliminar_Cliente]
@IdCliente int
as
delete from TBLCLIENTES where  IdCliente=@IdCliente
GO
-- (Aquí irían todos los demás CREATE PROCEDURE del script original)
-- 1. BORRAMOS LOS DATOS EXISTENTES PARA ASEGURAR UNA CARGA LIMPIA
DELETE FROM [dbo].[TBLDETALLE_FACTURA];
DELETE FROM [dbo].[TBLFACTURA];
DELETE FROM [dbo].[TBLSEGURIDAD];
DELETE FROM [dbo].[TBLEMPLEADO];
DELETE FROM [dbo].[TBLCLIENTES];
DELETE FROM [dbo].[TBLPRODUCTO];
DELETE FROM [dbo]. [TBLCATEGORIA_PROD];
DELETE FROM [dbo].[TBLROLES];
DELETE FROM [dbo].[TBLESTADO_FACTURA];
GO

-- 2. INSERTAMOS LA LISTA COMPLETA Y CORRECTA DE DATOS DEL PROFESOR
SET IDENTITY_INSERT [dbo].[TBLCATEGORIA_PROD] ON 
INSERT INTO [dbo].[TBLCATEGORIA_PROD] ([IdCategoria], [StrDescripcion], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1, N'Tecnología', GETDATE(), N'Admin'), (2, N'Alimentos', GETDATE(), N'Admin'), (3, N'Carnes', GETDATE(), N'Admin')
SET IDENTITY_INSERT [dbo].[TBLCATEGORIA_PROD] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLCLIENTES] ON 
INSERT INTO [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail]) VALUES (1, N'Javier Alberto Saldarriaga', 71684754, N'Calle la Misma 123', N'435346436', N'javier@gmail.com'), (2, N'Rosmira Giraldo Perez', 71677854, N'Calle 65 Nro 22-33', N'2345566', N'rosmi@gmail.com'), (5, N'Claudio del Socorro', 456789, N'Avenida Carlos', N'33333', N'claudio@email.com'), (1012, N'David Saldarriaga', 2222222, N'Calle Falsa 456', N'23454', N'david@email.com'), (1022, N'Pedro Paramo', 7777777, N'Comala', N'12345', N'paramo@email.com')
SET IDENTITY_INSERT [dbo].[TBLCLIENTES] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLROLES] ON 
INSERT INTO [dbo].[TBLROLES] ([IdRolEmpleado], [StrDescripcion]) VALUES (1, N'Gerente'), (2, N'Secretaria'), (3, N'Operario'), (4, N'Administrativo')
SET IDENTITY_INSERT [dbo].[TBLROLES] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] ON 
INSERT INTO [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso]) VALUES (1, N'Julian Tabares Cano', 71688655, N'Calle 67 Nro 90-92', N'2345566', N'julian@email.com', 1, GETDATE()), (2, N'Rosmira Giraldo Naranjo', 78655543, N'Calle 8 Nro 99-34', N'345678', N'rosmira@email.com', 1, GETDATE()), (3, N'David Saldarriaga', 345678, N'Calle de Siempre', N'345678', N'david.s@email.com', 3, GETDATE())
SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLPRODUCTO] ON 
INSERT INTO [dbo].[TBLPRODUCTO] ([IdProducto], [StrNombre], [StrCodigo], [NumPrecioCompra], [NumPrecioVenta], [IdCategoria], [NumStock], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1, N'Tablet Lenovo', N'0023400', 1235600, 2100000, 1, 4, GETDATE(), N'Admin'), (2, N'Teclado Bluetooth', N'0065400', 35600, 210000, 1, 4, GETDATE(), N'Admin'), (4, N'Pantalla 24 pulgadas', N'34343534', 32435, 345345, 1, 23, GETDATE(), N'Admin'), (5, N'Televisor LED 54 pulgadas', N'234444', 2000000, 3000000, 1, 5, GETDATE(), N'Admin')
SET IDENTITY_INSERT [dbo].[TBLPRODUCTO] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLESTADO_FACTURA] ON 
INSERT INTO [dbo].[TBLESTADO_FACTURA] ([IdEstadoFactura], [StrDescripcion]) VALUES (1, N'Pendiente Pago'), (2, N'Pagada'), (3, N'Anulada'), (4, N'Vencida')
SET IDENTITY_INSERT [dbo].[TBLESTADO_FACTURA] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLSEGURIDAD] ON 
INSERT INTO [dbo].[TBLSEGURIDAD] ([IdSeguridad], [IdEmpleado], [StrUsuario], [StrClave]) VALUES (1002, 1, N'admin', N'1234'), (1003, 2, N'rosmi', N'asdf'), (1005, 3, N'pepe', N'123')
SET IDENTITY_INSERT [dbo].[TBLSEGURIDAD] OFF
GO
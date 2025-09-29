-- BORRAMOS LOS DATOS EXISTENTES DE LAS TABLAS PRINCIPALES
DELETE FROM [dbo].[TBLSEGURIDAD];
DELETE FROM [dbo].[TBLCLIENTES];
DELETE FROM [dbo].[TBLEMPLEADO];
DELETE FROM [dbo].[TBLPRODUCTO];
DELETE FROM [dbo].[TBLCATEGORIA_PROD];
DELETE FROM [dbo].[TBLROLES];
GO

-- AHORA, INSERTAMOS LA LISTA COMPLETA Y CORRECTA DE DATOS

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
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1012, N'davicito saldarriaguito', 2222222, N'calle la misma', N'23454', N'javiy2k@gmail.com', CAST(N'2019-05-07T10:27:54.253' AS DateTime), N'javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1022, N'pedro paramo', 7777777, N'calle', N'12345', N'javi@javi.com', CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1028, N'pepe grillo en casa', 2342343, N'calle la misma', N'2342353', N'asdas@sad.com', CAST(N'2020-11-07T19:14:28.200' AS DateTime), N'javier')
INSERT [dbo].[TBLCLIENTES] ([IdCliente], [StrNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [DtmFechaModifica], [StrUsuarioModifica]) VALUES (1029, N'333pepe grillo en casa', 2342343, N'calle 65 c nro 91-130 interior 208', N'3117185300', N'javier.saldarriaga@pascualbravo.edu.co', CAST(N'2020-11-07T19:17:53.990' AS DateTime), N'javier')
SET IDENTITY_INSERT [dbo].[TBLCLIENTES] OFF
GO

SET IDENTITY_INSERT [dbo].[TBLEMPLEADO] ON 
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1, N'Julian Alberto tabares Cano ', 71688655, N'calle 67 c nro 9092 ffff', N'2345566', N'javiy2k@gmail.com', 1, CAST(N'2019-01-17T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Buen trabajador, dedicado y cumplido', CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (2, N'Rosmira Giraldo naranjo perez ', 78655543, N'Calle 8 nro 99- 34 rr', N'345678', N'rosmi2809@gmail.com', 1, CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Exelente', CAST(N'2020-09-11T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (3, N'David Saldarriaga Canosito', 345678, N'calle la misma de siempre', N'345678', N'david@22222.com', 3, CAST(N'2019-02-06T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'es el mejor sssssss', CAST(N'2021-03-12T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1011, N'javier saldarriaga Cano13333333333333', 71688655, N'calle 67 c nro 9092 ffff', N'2345566', N'javiy2k@gmail.com', 1, CAST(N'2019-01-17T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Buen trabajador, dedicado y cumplido', CAST(N'2020-03-05T00:00:00.000' AS DateTime), N'Javier')
INSERT [dbo].[TBLEMPLEADO] ([IdEmpleado], [strNombre], [NumDocumento], [StrDireccion], [StrTelefono], [StrEmail], [IdRolEmpleado], [DtmIngreso], [DtmRetiro], [strDatosAdicionales], [DtmFechaModifica], [StrUsuarioModifico]) VALUES (1016, N'javier saldar
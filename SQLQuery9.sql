USE [DBFACTURAS]
GO

CREATE procedure [dbo].[actualizar_CategoriaProd]
			 @IdCategoria int, 
			 @StrDescripcion varchar(60),
			 @DtmFechaModifica  datetime,
			 @StrUsuarioModifico  varchar(20)  
as
if NOT EXISTS (select IdCategoria from TBLCATEGORIA_PROD where IdCategoria=@IdCategoria)
INSERT INTO TBLCATEGORIA_PROD(StrDescripcion, DtmFechaModifica, StrUsuarioModifico)
     VALUES (@StrDescripcion, @DtmFechaModifica, @StrUsuarioModifico)
 else
UPDATE  TBLCATEGORIA_PROD
   SET   StrDescripcion  = @StrDescripcion, DtmFechaModifica  = @DtmFechaModifica, StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE IdCategoria  =  @IdCategoria
GO

CREATE procedure [dbo].[actualizar_Cliente]
@IdCliente int, @StrNombre varchar(55),@NumDocumento bigint,@StrDireccion varchar(70), @StrTelefono varchar(30),@StrEmail varchar(50), @StrUsuarioModifica varchar(10),@DtmFechaModifica datetime
as
if NOT EXISTS (select IdCliente from TBLCLIENTES where IdCliente=@IdCliente)
insert into TBLCLIENTES( StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail,DtmFechaModifica, StrUsuarioModifica)
 values( @StrNombre,@NumDocumento,@StrDireccion , @StrTelefono,@StrEmail,@DtmFechaModifica, @StrUsuarioModifica)
 else
 update TBLCLIENTES set StrNombre= @StrNombre,NumDocumento=@NumDocumento,StrDireccion=@StrDireccion ,StrTelefono= @StrTelefono,StrEmail=@StrEmail,DtmFechaModifica= @DtmFechaModifica,  StrUsuarioModifica= @StrUsuarioModifica  where IdCliente=@IdCliente
GO

CREATE procedure [dbo].[actualizar_Empleado]
			 @IdEmpleado int, @strNombre varchar(50), @NumDocumento  bigint, @StrDireccion varchar(50), @StrTelefono  varchar(20), @StrEmail  varchar(50), @IdRolEmpleado int, @DtmIngreso  datetime, @DtmRetiro  datetime, @strDatosAdicionales  nvarchar(250), @DtmFechaModifica  datetime, @StrUsuarioModifico  varchar(20)  
as
if NOT EXISTS (select IdEmpleado from TBLEMPLEADO where IdEmpleado= @IdEmpleado)
INSERT INTO TBLEMPLEADO(strNombre,NumDocumento,StrDireccion,StrTelefono,StrEmail,IdRolEmpleado,DtmIngreso,DtmRetiro,strDatosAdicionales,DtmFechaModifica,StrUsuarioModifico)
     VALUES (@strNombre, @NumDocumento, @StrDireccion, @StrTelefono, @StrEmail, @IdRolEmpleado, @DtmIngreso, @DtmRetiro, @strDatosAdicionales, @DtmFechaModifica, @StrUsuarioModifico)
 else
UPDATE  TBLEMPLEADO
   SET  strNombre  =  @strNombre, NumDocumento  = @NumDocumento, StrDireccion = @StrDireccion, StrTelefono  = @StrTelefono, StrEmail  = @StrEmail, IdRolEmpleado  = @IdRolEmpleado, DtmIngreso  = @DtmIngreso, DtmRetiro  = @DtmRetiro, strDatosAdicionales  = @strDatosAdicionales, DtmFechaModifica  = @DtmFechaModifica, StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE IdEmpleado = @IdEmpleado 
GO

CREATE procedure [dbo].[actualizar_Producto]
		@IdProducto int, @StrNombre  varchar(70), @StrCodigo varchar(30), @NumPrecioCompra float, @NumPrecioVenta float, @IdCategoria int, @StrDetalle varchar(50), @strFoto varchar(50), @NumStock int, @DtmFechaModifica datetime, @StrUsuarioModifica varchar(40)
as
if NOT EXISTS (select IdProducto from TBLPRODUCTO where IdProducto= @IdProducto)
INSERT INTO TBLPRODUCTO(StrNombre,StrCodigo,NumPrecioCompra,NumPrecioVenta,IdCategoria,StrDetalle,strFoto,NumStock,DtmFechaModifica,StrUsuarioModifica)
     VALUES (@StrNombre, @StrCodigo, @NumPrecioCompra, @NumPrecioVenta, @IdCategoria, @StrDetalle, @strFoto, @NumStock, @DtmFechaModifica, @StrUsuarioModifica)
 else
UPDATE TBLPRODUCTO
   SET  StrNombre  = @StrNombre, StrCodigo  = @StrCodigo, NumPrecioCompra = @NumPrecioCompra, NumPrecioVenta  = @NumPrecioVenta, IdCategoria = @IdCategoria, StrDetalle  = @StrDetalle, strFoto  = @strFoto, NumStock   = @NumStock, DtmFechaModifica  = @DtmFechaModifica, StrUsuarioModifica  = @StrUsuarioModifica 
 WHERE IdProducto  = @IdProducto
GO

CREATE procedure [dbo].[actualizar_Seguridad]
@IdEmpleado int,@StrUsuario varchar(50),@StrClave varchar(50),@DtmFechaModifica datetime,@StrUsuarioModifico varchar(10)
as
if NOT EXISTS (select IdEmpleado from TBLSEGURIDAD where IdEmpleado=@IdEmpleado)
insert into TBLSEGURIDAD(IdEmpleado,StrUsuario,StrClave,DtmFechaModifica,StrUsuarioModifico)
 values(@IdEmpleado,@StrUsuario,@StrClave,@DtmFechaModifica,@StrUsuarioModifico)
 else
 update TBLSEGURДAD set StrUsuario=@StrUsuario,StrClave=@StrClave,DtmFechaModifica=@DtmFechaModifica,StrUsuarioModifico=@StrUsuarioModifico where IdEmpleado=@IdEmpleado
GO

CREATE procedure [dbo].[Eliminar_Cliente]
@IdCliente int
as
delete from TBLCLIENTES where IdCliente=@IdCliente
GO

CREATE procedure [dbo].[Eliminar_Empleado]
@IdEmpleado int
as
delete from TBLEMPLEADO where IdEmpleado=@IdEmpleado
GO

CREATE procedure [dbo].[Eliminar_Producto]
@IdProducto int
as
delete from TBLPRODUCTO where IdProducto=@IdProducto
GO

CREATE PROCEDURE [dbo].[SpConsultaFactura]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TBLFACTURA.IdFactura as Nro_Factura, FORMAT( TBLFACTURA.DtmFecha, 'dd/MM/yyyy', 'en-US' ) AS 'Fecha', TBLCLIENTES.StrNombre as Cliente, TBLEMPLEADO.strNombre AS Empledo, TBLESTADO_FACTURA.StrDescripcion as Estado
	FROM TBLFACTURA INNER JOIN
		TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura INNER JOIN
		TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente INNER JOIN
		TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado
END
GO
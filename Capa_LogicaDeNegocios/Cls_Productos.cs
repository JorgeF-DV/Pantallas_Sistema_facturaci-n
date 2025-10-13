using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public double C_NumPrecioCompra { get; set; }
        public double C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public int C_NumStock { get; set; }

        private Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarProductos()
        {
            return AccesoDatos.EjecutarConsulta("SELECT IdProducto, StrNombre, StrCodigo, NumPrecioVenta FROM TBLPRODUCTO");
        }
        

        public DataTable ConsultarCategorias()
        {
            // Llama al método de la capa de datos para traer las categorías
            return AccesoDatos.EjecutarConsulta("SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD");
        }
        public DataTable ConsultarProductoPorId(int id)
        {
            return AccesoDatos.EjecutarConsulta($"SELECT * FROM TBLPRODUCTO WHERE IdProducto = {id}");
        }

        public string GuardarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdProducto", C_IdProducto));
                lst.Add(new Cls_Parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_Parametros("@StrCodigo", C_StrCodigo));
                lst.Add(new Cls_Parametros("@NumPrecioCompra", C_NumPrecioCompra));
                lst.Add(new Cls_Parametros("@NumPrecioVenta", C_NumPrecioVenta));
                lst.Add(new Cls_Parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_Parametros("@StrDetalle", C_StrDetalle));
                lst.Add(new Cls_Parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_Parametros("@strFoto", "ninguna"));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifica", "jorge"));

                mensaje = AccesoDatos.Ejecutar_procedimiento("actualizar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ACTUALIZACIÓN: " + ex.Message;
            }
            return mensaje;
        }

        public string EliminarProducto(int id)
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdProducto", id));
                mensaje = AccesoDatos.Ejecutar_procedimiento("Eliminar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ELIMINACIÓN: " + ex.Message;
            }
            return mensaje;
        }
    }
}
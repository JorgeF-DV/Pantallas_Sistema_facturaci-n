using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Clientes 
    {
        public int C_IdCliente { get; set; }
        public string C_StrNombre { get; set; }
        public long C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }

        private Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarClientes()
        {
            return AccesoDatos.EjecutarConsulta("SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM TBLCLIENTES");
        }

        public DataTable ConsultarClientePorId(int id)
        {
            return AccesoDatos.EjecutarConsulta($"SELECT StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM TBLCLIENTES WHERE IdCliente = {id}");
        }

        public string GuardarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdCliente", C_IdCliente));
                lst.Add(new Cls_Parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_Parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_Parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_Parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_Parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifica", "jorge"));

                mensaje = AccesoDatos.Ejecutar_procedimiento("actualizar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ACTUALIZACIÓN: " + ex.Message;
            }
            return mensaje;
        }

        public string EliminarCliente(int id)
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdCliente", id));
                mensaje = AccesoDatos.Ejecutar_procedimiento("Eliminar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ELIMINACIÓN: " + ex.Message;
            }
            return mensaje;
        }
    }
}
using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Seguridad
    {
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        private Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarEmpleados()
        {
            return AccesoDatos.EjecutarConsulta("SELECT IdEmpleado, strNombre FROM TBLEMPLEADO");
        }

        public DataTable Consulta_SeguridadEmpleado(int IdEmpleado)
        {
            return AccesoDatos.EjecutarConsulta($"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = {IdEmpleado}");
        }

        public string ActualizarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_Parametros("@StrUsuario", C_StrUsuario));
                lst.Add(new Cls_Parametros("@StrClave", C_StrClave));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                mensaje = AccesoDatos.Ejecutar_procedimiento("actualizar_Seguridad", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ACTUALIZACIÓN DE SEGURIDAD: " + ex.Message;
            }
            return mensaje;
        }
    }
}
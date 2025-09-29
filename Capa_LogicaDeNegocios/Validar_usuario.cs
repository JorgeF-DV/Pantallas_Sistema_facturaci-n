using Capa_AccesoDatos;
using System;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Validar_usuario
    {
        public string StrUsuario { get; set; }
        public string StrClave { get; set; }
        public int IdEmpleado { get; private set; }

        private Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();

        public bool ValidarUsuario() 
        {
            try
            {
                string sentencia = $"SELECT IdEmpleado FROM TBLSEGURIDAD WHERE StrUsuario = '{StrUsuario}' AND StrClave = '{StrClave}'";
                DataTable dt = Acceso.EjecutarConsulta(sentencia);

                if (dt.Rows.Count > 0)
                {
                    IdEmpleado = Convert.ToInt32(dt.Rows[0][0]);
                    return true; // Devuelve verdadero si encontró al usuario
                }
                else
                {
                    IdEmpleado = 0;
                    return false; // Devuelve falso si no encontró nada
                }
            }
            catch (Exception)
            {
                IdEmpleado = 0;
                return false;
            }
        }
    }
}
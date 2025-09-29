using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        // Propiedades que corresponden a los campos de la tabla TBLEMPLEADO
        public int C_IdEmpleado { get; set; }
        public string C_strNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        private Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Método para consultar todos los empleados
        public DataTable Consulta_Empleado()
        {
            return AccesoDatos.EjecutarConsulta("SELECT * FROM TBLEMPLEADO");
        }

        // Método para consultar los roles
        public DataTable ConsultarRol()
        {
            return AccesoDatos.EjecutarConsulta("SELECT * FROM TBLROLES");
        }

        // Método para guardar o actualizar un empleado
        public string ActualizarEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();

                // Añadimos los parámetros para el procedimiento almacenado
                lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_Parametros("@strNombre", C_strNombre));
                lst.Add(new Cls_Parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_Parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_Parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_Parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_Parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_Parametros("@DtmIngreso", C_DtmIngreso));
                lst.Add(new Cls_Parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_Parametros("@strDatosAdicionales", C_strDatosAdicionales));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                // Ejecutamos el procedimiento
                mensaje = AccesoDatos.Ejecutar_procedimiento("actualizar_Empleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ACTUALIZACIÓN EN EMPLEADO: " + ex.Message;
            }
            return mensaje;
        }

        // 
        public DataTable ConsultarRoles()
        {
            // Llama al método de la capa de datos
            return AccesoDatos.EjecutarConsulta("SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES");
     
        }



        // Método para consultar un solo empleado por su ID
        public DataTable Consulta_Empleado_Por_Id(int IdEmpleado)
        {
            // Llama al método genérico de la capa de datos para ejecutar la consulta
            return AccesoDatos.EjecutarConsulta($"SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = {IdEmpleado}");
        }



        public string EliminaEmpleado()
        {
            string mensaje = "";
            try
            {
                // Creamos una lista de parámetros para enviar al procedimiento almacenado
                List<Capa_AccesoDatos.Cls_Parametros> lst = new List<Capa_AccesoDatos.Cls_Parametros>();

                // Solo necesitamos un parámetro: el ID del empleado a borrar
                lst.Add(new Capa_AccesoDatos.Cls_Parametros("@IdEmpleado", C_IdEmpleado));

                // Llamamos al método genérico de la capa de datos
             
                mensaje = AccesoDatos.Ejecutar_procedimiento("Eliminar_Empleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ELIMINACIÓN DEL EMPLEADO: " + ex.Message;
            }
            return mensaje;
        }

    }

}
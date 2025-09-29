using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class Cls_Acceso_Datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader lectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        
        string stringConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=DBFACTURAS;Integrated Security=True";

        public string AbrirBd()
        {
            string resultado = "";
            try
            {
                conexion = new SqlConnection(stringConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                resultado = "ERROR: No se estableció la conexión con la Base de datos - " + ex;
            }
            return resultado;
        }

        public string CerrarBd()
        {
            string resultado = "";
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR: Falló al Cerrar la conexión " + ex;
            }
            return resultado;
        }

        public string Ejecutar_procedimiento(string procedimiento, List<Cls_Parametros> lst)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(procedimiento, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].DireccionParametro == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].DireccionParametro == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                }
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "ERROR: Falló la Operación: " + ex;
            }
            return salida;
        }

        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
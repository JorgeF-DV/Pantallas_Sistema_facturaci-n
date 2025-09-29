using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_AccesoDatos
{
    public class Cls_Parametros
    {
        //DEFINIMOS PARAMETROS ATRIBUTOS
        public string Nombre { get; set; }          // Nombre del parametro
        public object Valor { get; set; }           // Valor parametro
        public SqlDbType TipoDato { get; set; }     // tipo de dato
        public Int32 Tamaño { get; set; }           // longitud parametro
        public ParameterDirection DireccionParametro { get; set; } // direccion parametro, Input, Output.

        // CONSTRUCTOR PARAMETROS ENTRADA
        public Cls_Parametros(string objNombre, object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            DireccionParametro = ParameterDirection.Input;
        }

        //CONSTRUCTOR PARAMETROS SALIDA
        public Cls_Parametros(string objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            DireccionParametro = ParameterDirection.Output;
        }
    }
}
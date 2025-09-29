using System;
using System.Data;
using System.Data.SqlClient; // Importante: para poder hablar con SQL Server

namespace Pantallas_Sistema_facturación
{
    // Hacemos la clase 'public' para poder usarla desde los formularios
    public class AccesoDatos
    {
        // 1. LA CONEXIÓN A LA BASE DE DATOS
        // Esta "cadena de conexión" le dice a C# dónde está tu base de datos.
        // Apunta al servidor local (LocalDB) y a la base de datos DBFACTURAS que creamos.
        private SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=DBFACTURAS;Integrated Security=True");


        // 2. MÉTODO PARA OBTENER TODOS LOS CLIENTES (LEER)
        public DataTable ObtenerClientes()
        {
            // Escribimos la consulta SQL para traer todos los datos de la tabla de clientes.
            string consulta = "SELECT IdCliente, StrNombre AS Nombre, NumDocumento AS Documento, StrDireccion AS Direccion, StrTelefono AS Telefono, StrEmail AS Email FROM TBLCLIENTES";

            // El SqlDataAdapter es el puente entre la base de datos y nuestra aplicación.
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            // Creamos una tabla en memoria para guardar los resultados.
            DataTable dt = new DataTable();

            // Llenamos la tabla en memoria con los datos de la base de datos.
            adaptador.Fill(dt);

            return dt; // Devolvemos la tabla con los datos.
        }

        // 3. MÉTODO PARA GUARDAR O ACTUALIZAR UN CLIENTE (CREAR Y ACTUALIZAR)
        public void GuardarCliente(int idCliente, string nombre, string documento, string direccion, string telefono, string email)
        {
            conexion.Open(); // Abrimos la conexión
            string consulta;

            // Si el idCliente es 0, es un cliente nuevo (INSERT).
            if (idCliente == 0)
            {
                consulta = "INSERT INTO TBLCLIENTES (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail) VALUES (@nombre, @documento, @direccion, @telefono, @email)";
            }
            // Si el idCliente es diferente de 0, es uno existente (UPDATE).
            else
            {
                consulta = "UPDATE TBLCLIENTES SET StrNombre = @nombre, NumDocumento = @documento, StrDireccion = @direccion, StrTelefono = @telefono, StrEmail = @email WHERE IdCliente = @idCliente";
            }

            // El SqlCommand ejecuta la instrucción en la base de datos.
            SqlCommand comando = new SqlCommand(consulta, conexion);

            // Usar parámetros (@nombre, @documento, etc.) es la forma SEGURA de pasar datos para evitar ataques.
            if (idCliente != 0)
            {
                comando.Parameters.AddWithValue("@idCliente", idCliente);
            }
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);

            comando.ExecuteNonQuery(); // Ejecutamos el comando
            conexion.Close(); // Cerramos la conexión
        }

        // 4. MÉTODO PARA ELIMINAR UN CLIENTE (BORRAR)
        public void EliminarCliente(int idCliente)
        {
            conexion.Open();
            string consulta = "DELETE FROM TBLCLIENTES WHERE IdCliente = @idCliente";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // --- MÉTODOS PARA PRODUCTOS ---

        public DataTable ObtenerProductos()
        {
            string consulta = "SELECT * FROM TBLPRODUCTO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable ObtenerCategorias()
        {
            string consulta = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public void GuardarProducto(int id, string nombre, string codigo, double pCompra, double pVenta, int idCategoria, string detalle, int stock)
        {
            conexion.Open();
            // Indicamos que vamos a ejecutar un procedimiento almacenado
            SqlCommand comando = new SqlCommand("actualizar_Producto", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            // Añadimos los parámetros que el procedimiento espera
            comando.Parameters.AddWithValue("@IdProducto", id);
            comando.Parameters.AddWithValue("@StrNombre", nombre);
            comando.Parameters.AddWithValue("@StrCodigo", codigo);
            comando.Parameters.AddWithValue("@NumPrecioCompra", pCompra);
            comando.Parameters.AddWithValue("@NumPrecioVenta", pVenta);
            comando.Parameters.AddWithValue("@IdCategoria", idCategoria);
            comando.Parameters.AddWithValue("@StrDetalle", detalle);
            comando.Parameters.AddWithValue("@NumStock", stock);
            // Estos son campos obligatorios en la BD, les pasamos valores por defecto
            comando.Parameters.AddWithValue("@strFoto", "ninguna");
            comando.Parameters.AddWithValue("@DtmFechaModifica", DateTime.Now);
            comando.Parameters.AddWithValue("@StrUsuarioModifica", "user"); // Puedes cambiarlo por un usuario real

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarProducto(int idProducto)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("Eliminar_Producto", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.ExecuteNonQuery();
            conexion.Close();
       
        }

        // --- MÉTODOS PARA SEGURIDAD ---

        // Este método obtiene la lista de todos los empleados para llenar el menú desplegable.
        public DataTable ObtenerEmpleadosParaDropdown()
        {
            string consulta = "SELECT IdEmpleado, strNombre FROM TBLEMPLEADO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        // Este método busca los datos de seguridad de un empleado específico por su ID.
        public DataTable ObtenerSeguridadPorEmpleado(int idEmpleado)
        {
            string consulta = "SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = @idEmpleado";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        // Este método llama al procedimiento almacenado que creó tu profesor para actualizar los datos.
        public void ActualizarSeguridad(int idEmpleado, string usuario, string clave)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("actualizar_Seguridad", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            // Añadimos los parámetros que el procedimiento espera
            comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@StrUsuario", usuario);
            comando.Parameters.AddWithValue("@StrClave", clave);
            // Estos son campos obligatorios en la BD, les pasamos valores por defecto
            comando.Parameters.AddWithValue("@DtmFechaModifica", DateTime.Now);
            comando.Parameters.AddWithValue("@StrUsuarioModifico", "admin"); // O el usuario actual

            comando.ExecuteNonQuery();
            conexion.Close();
     
        }

        // --- MÉTODO PARA VALIDAR EL LOGIN ---

        public bool ValidarUsuario(string usuario, string clave)
        {
            conexion.Open();

            // Consulta SQL que busca una coincidencia exacta de usuario y clave en la tabla de seguridad
            string consulta = "SELECT * FROM TBLSEGURIDAD WHERE StrUsuario = @usuario AND StrClave = @clave";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);

            // El SqlDataReader es ideal para leer el resultado de una consulta
            SqlDataReader lector = comando.ExecuteReader();

            // El método .HasRows nos devuelve 'true' si la consulta encontró al menos una fila (un usuario)
            if (lector.HasRows)
            {
                conexion.Close();
                return true; // El usuario y la clave son correctos
            }
            else
            {
                conexion.Close();
                return false; // No se encontró ninguna coincidencia
            }
        }

        // --- MÉTODO PARA ROLES ---
        public DataTable ObtenerRoles()
        {
            string consulta = "SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }



}


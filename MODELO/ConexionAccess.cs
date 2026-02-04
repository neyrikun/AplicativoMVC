using System;
using System.Data; // Necesario para DataTable y otros objetos de datos
using System.Data.OleDb;
using System.Diagnostics; // Necesario para OleDbConnection, OleDbCommand, etc.

namespace MODELO
{
    public class ConexionAccess
    {
        // Tu cadena de conexión, ajusta la ruta a tu archivo .accdb
        // Asegúrate de que el archivo esté en el directorio de salida del proyecto o usa una ruta absoluta.
        static string Ruta = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "DataBase",
            "Neptuno.mdb"
        );

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta + ";Persist Security Info=False;";
        private OleDbConnection conexion;

        public ConexionAccess()
        {
            // Inicializa la conexión
            Debug.Write("\nRUTA ES:" + Ruta + "\n\n");
            conexion = new OleDbConnection(cadenaConexion);
        }

        // Método para abrir la conexión
        public bool AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    return true;
                }
                return true; // Ya estaba abierta
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        // Método para ejecutar comandos que no devuelven datos (INSERT, UPDATE, DELETE)
        public string EjecutarComando(string sql)
        {
            string result = null;
            if (AbrirConexion())
            {
                OleDbCommand comando = new OleDbCommand(sql, conexion);
                try
                {
                    comando.ExecuteNonQuery(); // Ejecuta el comando
                    CerrarConexion();
                    //return true;
                    return result;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error al ejecutar comando: " + ex.Message);
                    result = "Error al ejecutar comando: " + ex.Message.ToString();
                    CerrarConexion();
                    //return false;
                    return result;
                }
            }
            return result;
        }

        // Método para ejecutar consultas que devuelven datos (SELECT)
        public DataTable EjecutarConsulta(string sql)
        {
            DataTable dt = new DataTable();
            if (AbrirConexion())
            {
                OleDbCommand comando = new OleDbCommand(sql, conexion);
                try
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(dt); // Llena el DataTable con los resultados
                    CerrarConexion();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error al ejecutar consulta: " + ex.Message);
                    CerrarConexion();
                }
            }
            return dt;
        }

        // Para usar la clase:
        // public static void Main(string[] args)
        // {
        //     ConexionAccess db = new ConexionAccess();
        //     // Ejemplo de INSERT
        //     // db.EjecutarComando("INSERT INTO TablaUsuarios (Nombre, Email) VALUES ('Juan', 'juan@ejemplo.com')");
        //
        //     // Ejemplo de SELECT
        //     DataTable datos = db.EjecutarConsulta("SELECT * FROM TablaUsuarios");
        //     foreach (DataRow fila in datos.Rows)
        //     {
        //         Console.WriteLine($"ID: {fila["ID"]}, Nombre: {fila["Nombre"]}");
        //     }
        // }
        /*public static void Main(string[] args)
        {
             ConexionAccess db = new ConexionAccess();
        //     // Ejemplo de INSERT
             // db.EjecutarComando("INSERT INTO TablaUsuarios (Nombre, Email) VALUES ('Juan', 'juan@ejemplo.com')");
        //
        //     // Ejemplo de SELECT
             DataTable datos = db.EjecutarConsulta("SELECT IdProducto,NombreProducto,PrecioUnidad FROM Productos");
             foreach (DataRow fila in datos.Rows)
             {
                 Console.WriteLine($"ID: {fila["IdProducto"]}, Nombre: {fila["NombreProducto"]}");
             }
         }*/
    }
}
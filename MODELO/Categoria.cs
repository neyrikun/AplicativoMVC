using System.Data;

namespace MODELO
{
    public class Categoria
    {
        public int idCategoria { get; set; }

        public string nombreCategoria { get; set; }

        public Categoria()
        {

        }

        public DataTable GetAll()
        {

            ConexionAccess db = new ConexionAccess();
            //     // Ejemplo de INSERT
            // db.EjecutarComando("INSERT INTO TablaUsuarios (Nombre, Email) VALUES ('Juan', 'juan@ejemplo.com')");
            //
            //     // Ejemplo de SELECT
            //DataTable datos = db.EjecutarConsulta("SELECT IdProducto,NombreProducto,PrecioUnidad FROM Productos");
            DataTable datos = db.EjecutarConsulta("SELECT IdCategoría,NombreCategoría  FROM Categorías");

            return datos;
        }

    }
}
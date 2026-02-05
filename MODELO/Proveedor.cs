using System.Data;

namespace MODELO
{
    public class Proveedor
    {
        public int idProveedor { get; set; }

        public string nombreCompania { get; set; }

        public Proveedor() { }

        public DataTable GetAll()
        {

            ConexionAccess db = new ConexionAccess();
            //     // Ejemplo de INSERT
            // db.EjecutarComando("INSERT INTO TablaUsuarios (Nombre, Email) VALUES ('Juan', 'juan@ejemplo.com')");
            //
            //     // Ejemplo de SELECT
            //DataTable datos = db.EjecutarConsulta("SELECT IdProducto,NombreProducto,PrecioUnidad FROM Productos");
            DataTable datos = db.EjecutarConsulta("SELECT IdProveedor,NombreCompañía  FROM Proveedores");

            return datos;
        }

    }
}

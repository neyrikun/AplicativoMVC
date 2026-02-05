using System.Data;
using System.Diagnostics;

namespace MODELO
{
    public class Producto
    {
        //Número asignado a un producto nuevo.
        public int idProducto { get; set; }

        public string nombreProducto { get; set; }

        //Igual al Id. de la tabla Proveedores.
        public int idProveedor { get; set; }

        //Igual al Id. de la tabla Categorías.
        public int idCategoria { get; set; }

        //(por ej. caja de 24, botella de 1 litro).
        public string cantidadPorUnidad { get; set; }

        public double precioUnidad { get; set; }

        public int unidadesEnExistencia { get; set; }

        public int unidadesEnPedido { get; set; }

        //Cantidad de unidades mínima en existencia.
        public int nivelNuevoPedido { get; set; }

        //Sí indica que el elemento no está disponible.
        public string suspendido { get; set; }


        public Producto() {}
        //public Producto(int id) { }
        
        public DataTable GetAll()
        {

            ConexionAccess db = new ConexionAccess();
            // Ejemplo de SELECT
            //DataTable datos = db.EjecutarConsulta("SELECT IdProducto,NombreProducto,PrecioUnidad FROM Productos");
            //DataTable datos = db.EjecutarConsulta("SELECT * FROM Productos");
            //DataTable datos = db.EjecutarConsulta("SELECT t1.IdProducto,t1.NombreProducto,pr.NombreCompañía AS Proveedor, t1.NombreCategoría AS Categoría, t1.CantidadPorUnidad,t1.PrecioUnidad,t1.UnidadesEnExistencia,t1.UnidadesEnPedido,t1.NivelNuevoPedido,t1.Suspendido FROM (SELECT p.*, c.NombreCategoría FROM Productos AS p INNER JOIN Categorías AS c ON p.IdCategoría = c.IdCategoría) AS t1 INNER JOIN Proveedores AS pr ON t1.IdProveedor = pr.IdProveedor;");




            string sql = "SELECT * FROM Productos";
            Debug.WriteLine(sql);
            DataTable datos = db.EjecutarConsulta(sql);

            return datos;
        }

        public string InsertarProducto(string nombre, int idProv, int idCat, string cantUnid, double precUnid, int unidExist)
        {

            ConexionAccess db = new ConexionAccess();
            //https://stackoverflow.com/questions/35112959/insert-into-access-database-query-error-in-c-sharp
            // Ejemplo de INSERT
            return db.EjecutarComando("INSERT INTO Productos (NombreProducto, IdProveedor,IdCategoría," +
                "CantidadPorUnidad,PrecioUnidad,UnidadesEnExistencia) VALUES ('" + nombre + "','" + idProv +
                "','" + idCat + "','" + cantUnid + "','" + precUnid + "','" + unidExist + "')");

        }
    }
}

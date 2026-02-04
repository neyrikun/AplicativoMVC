using MODELO;
using System.Data;

namespace CONTROLADOR
{
    public class ControlerProductoRegistrar
    {
        private Producto oProd = new Producto();
        public DataTable GetCategorias()
        {
            Categoria oCat = new Categoria();
            DataTable dtCat = oCat.GetAll();
            return dtCat;
        }

        public DataTable GetProveedores()
        {
            Proveedor oProv = new Proveedor();
            DataTable dtProv = oProv.GetAll();
            return dtProv;
        }

        public string insertar(string nombre, int idProv, int idCat, string cantUnid, double precUnid, int unidExist)
        {
            return oProd.InsertarProducto(nombre, idProv, idCat, cantUnid, precUnid, unidExist);
        }
    }
}

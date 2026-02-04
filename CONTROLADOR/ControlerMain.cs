using MODELO;
using System.Data;
using System.Diagnostics;

namespace CONTROLADOR
{
    public class ControlerMain
    {
        public DataTable GetList()
        {
            Producto oProd = new Producto();
            DataTable dtProd = oProd.GetAll();
            return dtProd;
        }
    }
}
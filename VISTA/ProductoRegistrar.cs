using CONTROLADOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicativoMVC
{
    public partial class ProductoRegistrar : Form
    {
        private ControlerProductoRegistrar oControlerProductoRegistrar = new ControlerProductoRegistrar();

        public ProductoRegistrar()
        {
            InitializeComponent();
        }

        private void ProductoRegistrar_Load(object sender, EventArgs e)
        {
            ComboProveedor.DataSource = oControlerProductoRegistrar.GetProveedores();
            // Si es un objeto, especifica el DisplayMember y ValueMember
            ComboProveedor.DisplayMember = "NombreCompañía"; // Propiedad a mostrar
            ComboProveedor.ValueMember = "IdProveedor";      // Propiedad para el valor

            ComboCategoría.DataSource = oControlerProductoRegistrar.GetCategorias();
            // Si es un objeto, especifica el DisplayMember y ValueMember
            ComboCategoría.DisplayMember = "NombreCategoría"; // Propiedad a mostrar
            ComboCategoría.ValueMember = "IdCategoría";      // Propiedad para el valor
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelProveedor_Click(object sender, EventArgs e)
        {

        }

        private void LabelPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}

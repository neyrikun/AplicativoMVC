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
        private ProductoRegistrarControler oProductoRegistrarControler = new ProductoRegistrarControler();

        public ProductoRegistrar()
        {
            InitializeComponent();
        }

        private void ProductoRegistrar_Load(object sender, EventArgs e)
        {
            //Vinculación a una fuente de datos(DataBinding)
            //Para colecciones más grandes o datos de bases de datos, usa DataSource.
            ComboProveedor.DataSource = oProductoRegistrarControler.GetProveedores();
            // Si es un objeto, especifica el DisplayMember y ValueMember
            ComboProveedor.DisplayMember = "NombreCompañía"; // Propiedad a mostrar
            ComboProveedor.ValueMember = "IdProveedor";      // Propiedad para el valor



            ComboCategoría.DataSource = oProductoRegistrarControler.GetCategorias();
            // Si es un objeto, especifica el DisplayMember y ValueMember
            ComboCategoría.DisplayMember = "NombreCategoría"; // Propiedad a mostrar
            ComboCategoría.ValueMember = "IdCategoría";      // Propiedad para el valor
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string warning = oProductoRegistrarControler.insertar(TBoxNombre.Text, int.Parse(ComboProveedor.SelectedValue.ToString()),
                 int.Parse(ComboCategoría.SelectedValue.ToString()), TBoxCantidadPorUnidad.Text, double.Parse(TBoxPrecioPorUnidad.Text), int.Parse(TBoxUnidadesEnExistencia.Text));
            if (warning != null)
                MessageBox.Show(warning);
            else
            {
                MessageBox.Show("Data saved successfuly...!");
                Main vMain = new Main();
                this.Close();
                vMain.Show();
            }
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

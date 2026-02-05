using CONTROLADOR;

namespace AplicativoMVC
{
    public partial class Main : Form
    {
        private ControlerMain oControlerMain = new ControlerMain();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataGridProductos.DataSource = oControlerMain.GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoRegistrar PR = new ProductoRegistrar();
            PR.Visible = true;
        }
    }
}

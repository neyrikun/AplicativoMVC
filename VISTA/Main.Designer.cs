namespace AplicativoMVC
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AgregarProducto = new Button();
            DataGridProductos = new DataGridView();
            Contenedor = new TableLayoutPanel();
            Botones = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DataGridProductos).BeginInit();
            Contenedor.SuspendLayout();
            Botones.SuspendLayout();
            SuspendLayout();
            // 
            // AgregarProducto
            // 
            AgregarProducto.Dock = DockStyle.Right;
            AgregarProducto.Location = new Point(457, 3);
            AgregarProducto.Name = "AgregarProducto";
            AgregarProducto.Size = new Size(160, 38);
            AgregarProducto.TabIndex = 0;
            AgregarProducto.Text = "Agregar Producto";
            AgregarProducto.UseVisualStyleBackColor = true;
            AgregarProducto.Click += button1_Click;
            // 
            // DataGridProductos
            // 
            DataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridProductos.Dock = DockStyle.Fill;
            DataGridProductos.Location = new Point(13, 63);
            DataGridProductos.Name = "DataGridProductos";
            DataGridProductos.Size = new Size(620, 374);
            DataGridProductos.TabIndex = 1;
            // 
            // Contenedor
            // 
            Contenedor.ColumnCount = 1;
            Contenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Contenedor.Controls.Add(Botones, 0, 0);
            Contenedor.Controls.Add(DataGridProductos, 0, 1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 0);
            Contenedor.Name = "Contenedor";
            Contenedor.Padding = new Padding(10);
            Contenedor.RowCount = 2;
            Contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Contenedor.Size = new Size(646, 450);
            Contenedor.TabIndex = 2;
            // 
            // Botones
            // 
            Botones.ColumnCount = 2;
            Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Botones.Controls.Add(AgregarProducto, 1, 0);
            Botones.Dock = DockStyle.Fill;
            Botones.Location = new Point(13, 13);
            Botones.Name = "Botones";
            Botones.RowCount = 1;
            Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Botones.Size = new Size(620, 44);
            Botones.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(Contenedor);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridProductos).EndInit();
            Contenedor.ResumeLayout(false);
            Botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AgregarProducto;
        private DataGridView DataGridProductos;
        private TableLayoutPanel Contenedor;
        private TableLayoutPanel Botones;
    }
}

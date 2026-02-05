namespace AplicativoMVC
{
    partial class ProductoRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Aceptar = new Button();
            Cancelar = new Button();
            Campos = new TableLayoutPanel();
            Nombre = new TableLayoutPanel();
            LabelNombre = new Label();
            TBoxNombre = new TextBox();
            Proveedor = new TableLayoutPanel();
            LabelProveedor = new Label();
            ComboProveedor = new ComboBox();
            Categoría = new TableLayoutPanel();
            LabelCategoria = new Label();
            ComboCategoría = new ComboBox();
            CantidadPorUnidad = new TableLayoutPanel();
            LabelCantidadPorUnidad = new Label();
            TBoxCantidadPorUnidad = new TextBox();
            PrecioPorUnidad = new TableLayoutPanel();
            LabelSimboloDolar = new Label();
            LabelPrecioPorUnidad = new Label();
            TBoxPrecioPorUnidad = new TextBox();
            UnidadesEnExistencia = new TableLayoutPanel();
            LabelUnidadesEnExistencia = new Label();
            TBoxUnidadesEnExistencia = new TextBox();
            Contenedor = new TableLayoutPanel();
            Botones = new TableLayoutPanel();
            Campos.SuspendLayout();
            Nombre.SuspendLayout();
            Proveedor.SuspendLayout();
            Categoría.SuspendLayout();
            CantidadPorUnidad.SuspendLayout();
            PrecioPorUnidad.SuspendLayout();
            UnidadesEnExistencia.SuspendLayout();
            Contenedor.SuspendLayout();
            Botones.SuspendLayout();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.Dock = DockStyle.Fill;
            Aceptar.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aceptar.Location = new Point(188, 5);
            Aceptar.Margin = new Padding(5);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(174, 39);
            Aceptar.TabIndex = 0;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Dock = DockStyle.Fill;
            Cancelar.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancelar.Location = new Point(5, 5);
            Cancelar.Margin = new Padding(5);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(173, 39);
            Cancelar.TabIndex = 1;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Campos
            // 
            Campos.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Campos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Campos.Controls.Add(Nombre, 0, 0);
            Campos.Controls.Add(Proveedor, 0, 1);
            Campos.Controls.Add(Categoría, 0, 2);
            Campos.Controls.Add(CantidadPorUnidad, 0, 3);
            Campos.Controls.Add(PrecioPorUnidad, 0, 4);
            Campos.Controls.Add(UnidadesEnExistencia, 0, 5);
            Campos.Dock = DockStyle.Fill;
            Campos.Location = new Point(13, 13);
            Campos.Name = "Campos";
            Campos.RowCount = 7;
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Campos.Size = new Size(367, 307);
            Campos.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.ColumnCount = 2;
            Nombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Nombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Nombre.Controls.Add(LabelNombre, 0, 0);
            Nombre.Controls.Add(TBoxNombre, 1, 0);
            Nombre.Dock = DockStyle.Fill;
            Nombre.Location = new Point(4, 4);
            Nombre.Name = "Nombre";
            Nombre.RowCount = 1;
            Nombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Nombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Nombre.Size = new Size(359, 44);
            Nombre.TabIndex = 0;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombre.Location = new Point(5, 5);
            LabelNombre.Margin = new Padding(5);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(169, 34);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre";
            LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TBoxNombre
            // 
            TBoxNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TBoxNombre.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBoxNombre.Location = new Point(182, 8);
            TBoxNombre.Name = "TBoxNombre";
            TBoxNombre.Size = new Size(174, 27);
            TBoxNombre.TabIndex = 1;
            // 
            // Proveedor
            // 
            Proveedor.ColumnCount = 2;
            Proveedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Proveedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Proveedor.Controls.Add(LabelProveedor, 0, 0);
            Proveedor.Controls.Add(ComboProveedor, 1, 0);
            Proveedor.Dock = DockStyle.Fill;
            Proveedor.Location = new Point(4, 55);
            Proveedor.Name = "Proveedor";
            Proveedor.RowCount = 1;
            Proveedor.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Proveedor.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Proveedor.Size = new Size(359, 44);
            Proveedor.TabIndex = 1;
            // 
            // LabelProveedor
            // 
            LabelProveedor.AutoSize = true;
            LabelProveedor.Dock = DockStyle.Fill;
            LabelProveedor.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelProveedor.Location = new Point(5, 5);
            LabelProveedor.Margin = new Padding(5);
            LabelProveedor.Name = "LabelProveedor";
            LabelProveedor.Size = new Size(169, 34);
            LabelProveedor.TabIndex = 0;
            LabelProveedor.Text = "Proveedor";
            LabelProveedor.TextAlign = ContentAlignment.MiddleLeft;
            LabelProveedor.Click += LabelProveedor_Click;
            // 
            // ComboProveedor
            // 
            ComboProveedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboProveedor.FormattingEnabled = true;
            ComboProveedor.Location = new Point(182, 10);
            ComboProveedor.Name = "ComboProveedor";
            ComboProveedor.Size = new Size(174, 23);
            ComboProveedor.TabIndex = 1;
            // 
            // Categoría
            // 
            Categoría.ColumnCount = 2;
            Categoría.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Categoría.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Categoría.Controls.Add(LabelCategoria, 0, 0);
            Categoría.Controls.Add(ComboCategoría, 1, 0);
            Categoría.Dock = DockStyle.Fill;
            Categoría.Location = new Point(4, 106);
            Categoría.Name = "Categoría";
            Categoría.RowCount = 1;
            Categoría.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Categoría.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Categoría.Size = new Size(359, 44);
            Categoría.TabIndex = 2;
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Dock = DockStyle.Fill;
            LabelCategoria.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelCategoria.Location = new Point(5, 5);
            LabelCategoria.Margin = new Padding(5);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(169, 34);
            LabelCategoria.TabIndex = 0;
            LabelCategoria.Text = "Categoría";
            LabelCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComboCategoría
            // 
            ComboCategoría.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboCategoría.FormattingEnabled = true;
            ComboCategoría.Location = new Point(182, 10);
            ComboCategoría.Name = "ComboCategoría";
            ComboCategoría.Size = new Size(174, 23);
            ComboCategoría.TabIndex = 1;
            // 
            // CantidadPorUnidad
            // 
            CantidadPorUnidad.ColumnCount = 2;
            CantidadPorUnidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CantidadPorUnidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CantidadPorUnidad.Controls.Add(LabelCantidadPorUnidad, 0, 0);
            CantidadPorUnidad.Controls.Add(TBoxCantidadPorUnidad, 1, 0);
            CantidadPorUnidad.Dock = DockStyle.Fill;
            CantidadPorUnidad.Location = new Point(4, 157);
            CantidadPorUnidad.Name = "CantidadPorUnidad";
            CantidadPorUnidad.RowCount = 1;
            CantidadPorUnidad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CantidadPorUnidad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CantidadPorUnidad.Size = new Size(359, 44);
            CantidadPorUnidad.TabIndex = 3;
            // 
            // LabelCantidadPorUnidad
            // 
            LabelCantidadPorUnidad.AutoSize = true;
            LabelCantidadPorUnidad.Dock = DockStyle.Fill;
            LabelCantidadPorUnidad.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelCantidadPorUnidad.Location = new Point(5, 5);
            LabelCantidadPorUnidad.Margin = new Padding(5);
            LabelCantidadPorUnidad.Name = "LabelCantidadPorUnidad";
            LabelCantidadPorUnidad.Size = new Size(169, 34);
            LabelCantidadPorUnidad.TabIndex = 0;
            LabelCantidadPorUnidad.Text = "Cantidad por unidad";
            LabelCantidadPorUnidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TBoxCantidadPorUnidad
            // 
            TBoxCantidadPorUnidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TBoxCantidadPorUnidad.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBoxCantidadPorUnidad.Location = new Point(182, 8);
            TBoxCantidadPorUnidad.Name = "TBoxCantidadPorUnidad";
            TBoxCantidadPorUnidad.Size = new Size(174, 27);
            TBoxCantidadPorUnidad.TabIndex = 1;
            // 
            // PrecioPorUnidad
            // 
            PrecioPorUnidad.ColumnCount = 3;
            PrecioPorUnidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            PrecioPorUnidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PrecioPorUnidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PrecioPorUnidad.Controls.Add(LabelSimboloDolar, 1, 0);
            PrecioPorUnidad.Controls.Add(LabelPrecioPorUnidad, 0, 0);
            PrecioPorUnidad.Controls.Add(TBoxPrecioPorUnidad, 2, 0);
            PrecioPorUnidad.Dock = DockStyle.Fill;
            PrecioPorUnidad.Location = new Point(4, 208);
            PrecioPorUnidad.Name = "PrecioPorUnidad";
            PrecioPorUnidad.RowCount = 1;
            PrecioPorUnidad.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PrecioPorUnidad.Size = new Size(359, 44);
            PrecioPorUnidad.TabIndex = 4;
            // 
            // LabelSimboloDolar
            // 
            LabelSimboloDolar.AutoSize = true;
            LabelSimboloDolar.Dock = DockStyle.Fill;
            LabelSimboloDolar.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSimboloDolar.Location = new Point(162, 5);
            LabelSimboloDolar.Margin = new Padding(1, 5, 1, 5);
            LabelSimboloDolar.Name = "LabelSimboloDolar";
            LabelSimboloDolar.Size = new Size(15, 34);
            LabelSimboloDolar.TabIndex = 2;
            LabelSimboloDolar.Text = "$";
            LabelSimboloDolar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelPrecioPorUnidad
            // 
            LabelPrecioPorUnidad.AutoSize = true;
            LabelPrecioPorUnidad.Dock = DockStyle.Fill;
            LabelPrecioPorUnidad.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPrecioPorUnidad.Location = new Point(5, 5);
            LabelPrecioPorUnidad.Margin = new Padding(5);
            LabelPrecioPorUnidad.Name = "LabelPrecioPorUnidad";
            LabelPrecioPorUnidad.Size = new Size(151, 34);
            LabelPrecioPorUnidad.TabIndex = 0;
            LabelPrecioPorUnidad.Text = "Precio por unidad";
            LabelPrecioPorUnidad.TextAlign = ContentAlignment.MiddleLeft;
            LabelPrecioPorUnidad.Click += LabelPrecio_Click;
            // 
            // TBoxPrecioPorUnidad
            // 
            TBoxPrecioPorUnidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TBoxPrecioPorUnidad.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBoxPrecioPorUnidad.Location = new Point(181, 8);
            TBoxPrecioPorUnidad.Name = "TBoxPrecioPorUnidad";
            TBoxPrecioPorUnidad.Size = new Size(175, 27);
            TBoxPrecioPorUnidad.TabIndex = 1;
            // 
            // UnidadesEnExistencia
            // 
            UnidadesEnExistencia.ColumnCount = 2;
            UnidadesEnExistencia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UnidadesEnExistencia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UnidadesEnExistencia.Controls.Add(LabelUnidadesEnExistencia, 0, 0);
            UnidadesEnExistencia.Controls.Add(TBoxUnidadesEnExistencia, 1, 0);
            UnidadesEnExistencia.Dock = DockStyle.Fill;
            UnidadesEnExistencia.Location = new Point(4, 259);
            UnidadesEnExistencia.Name = "UnidadesEnExistencia";
            UnidadesEnExistencia.RowCount = 1;
            UnidadesEnExistencia.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            UnidadesEnExistencia.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            UnidadesEnExistencia.Size = new Size(359, 44);
            UnidadesEnExistencia.TabIndex = 5;
            // 
            // LabelUnidadesEnExistencia
            // 
            LabelUnidadesEnExistencia.AutoSize = true;
            LabelUnidadesEnExistencia.Dock = DockStyle.Fill;
            LabelUnidadesEnExistencia.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUnidadesEnExistencia.Location = new Point(5, 5);
            LabelUnidadesEnExistencia.Margin = new Padding(5);
            LabelUnidadesEnExistencia.Name = "LabelUnidadesEnExistencia";
            LabelUnidadesEnExistencia.Size = new Size(169, 34);
            LabelUnidadesEnExistencia.TabIndex = 0;
            LabelUnidadesEnExistencia.Text = "Unidades en existencia";
            LabelUnidadesEnExistencia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TBoxUnidadesEnExistencia
            // 
            TBoxUnidadesEnExistencia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TBoxUnidadesEnExistencia.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBoxUnidadesEnExistencia.Location = new Point(182, 8);
            TBoxUnidadesEnExistencia.Name = "TBoxUnidadesEnExistencia";
            TBoxUnidadesEnExistencia.Size = new Size(174, 27);
            TBoxUnidadesEnExistencia.TabIndex = 1;
            // 
            // Contenedor
            // 
            Contenedor.ColumnCount = 1;
            Contenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Contenedor.Controls.Add(Campos, 0, 0);
            Contenedor.Controls.Add(Botones, 0, 1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 0);
            Contenedor.Name = "Contenedor";
            Contenedor.Padding = new Padding(10);
            Contenedor.RowCount = 2;
            Contenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            Contenedor.Size = new Size(393, 388);
            Contenedor.TabIndex = 2;
            // 
            // Botones
            // 
            Botones.ColumnCount = 2;
            Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Botones.Controls.Add(Aceptar, 1, 0);
            Botones.Controls.Add(Cancelar, 0, 0);
            Botones.Dock = DockStyle.Fill;
            Botones.Location = new Point(13, 326);
            Botones.Name = "Botones";
            Botones.RowCount = 1;
            Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Botones.Size = new Size(367, 49);
            Botones.TabIndex = 1;
            // 
            // ProductoRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 388);
            Controls.Add(Contenedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductoRegistrar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Producto";
            Load += ProductoRegistrar_Load;
            Campos.ResumeLayout(false);
            Nombre.ResumeLayout(false);
            Nombre.PerformLayout();
            Proveedor.ResumeLayout(false);
            Proveedor.PerformLayout();
            Categoría.ResumeLayout(false);
            Categoría.PerformLayout();
            CantidadPorUnidad.ResumeLayout(false);
            CantidadPorUnidad.PerformLayout();
            PrecioPorUnidad.ResumeLayout(false);
            PrecioPorUnidad.PerformLayout();
            UnidadesEnExistencia.ResumeLayout(false);
            UnidadesEnExistencia.PerformLayout();
            Contenedor.ResumeLayout(false);
            Botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Aceptar;
        private Button Cancelar;
        private TableLayoutPanel Botones;
        private TableLayoutPanel Contenedor;
        private TableLayoutPanel Nombre;
        private TableLayoutPanel Campos;
        private Label LabelNombre;
        private TextBox TBoxNombre;
        private TableLayoutPanel Proveedor;
        private Label LabelProveedor;
        private TableLayoutPanel Categoría;
        private Label LabelCategoria;
        private ComboBox ComboCategoría;
        private ComboBox ComboProveedor;
        private TableLayoutPanel PrecioPorUnidad;
        private Label LabelPrecioPorUnidad;
        private TextBox TBoxPrecioPorUnidad;
        private TableLayoutPanel CantidadPorUnidad;
        private Label LabelCantidadPorUnidad;
        private TextBox TBoxCantidadPorUnidad;
        private Label LabelSimboloDolar;
        private TableLayoutPanel UnidadesEnExistencia;
        private Label LabelUnidadesEnExistencia;
        private TextBox TBoxUnidadesEnExistencia;
    }
}
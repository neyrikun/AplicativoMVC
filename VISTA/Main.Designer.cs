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
            ((System.ComponentModel.ISupportInitialize)DataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // AgregarProducto
            // 
            AgregarProducto.Location = new Point(613, 32);
            AgregarProducto.Name = "AgregarProducto";
            AgregarProducto.Size = new Size(160, 49);
            AgregarProducto.TabIndex = 0;
            AgregarProducto.Text = "Agregar Producto";
            AgregarProducto.UseVisualStyleBackColor = true;
            AgregarProducto.Click += button1_Click;
            // 
            // DataGridProductos
            // 
            DataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridProductos.Location = new Point(25, 101);
            DataGridProductos.Name = "DataGridProductos";
            DataGridProductos.Size = new Size(748, 326);
            DataGridProductos.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridProductos);
            Controls.Add(AgregarProducto);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AgregarProducto;
        private DataGridView DataGridProductos;
    }
}

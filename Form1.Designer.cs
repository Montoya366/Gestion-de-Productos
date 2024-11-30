namespace DataGridView
{
    partial class Form1
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
            dtgvProductos = new System.Windows.Forms.DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            lblInformacion = new Label();
            btnAdicionar = new Button();
            btnBorrar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio });
            dtgvProductos.Location = new Point(19, 276);
            dtgvProductos.Margin = new Padding(3, 4, 3, 4);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.ReadOnly = true;
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.Size = new Size(425, 241);
            dtgvProductos.TabIndex = 0;
            dtgvProductos.CellClick += dtgvProductos_CellClick;
            dtgvProductos.CellContentClick += dtgvProductos_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo del producto";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre del producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio del Producto";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblCodigo.Location = new Point(19, 78);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(193, 28);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo del producto:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(220, 79);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(50, 27);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblNombre.Location = new Point(11, 126);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(203, 28);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del Producto:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblPrecio.Location = new Point(19, 176);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(186, 28);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 126);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 27);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(221, 176);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(195, 27);
            txtPrecio.TabIndex = 6;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe Print", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInformacion.Location = new Point(36, 216);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(61, 23);
            lblInformacion.TabIndex = 7;
            lblInformacion.Text = "Estado..";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(580, 332);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(115, 51);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(580, 408);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(115, 47);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 19);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 10;
            label1.Text = "Gestion de Productos\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_11_29_a_las_20_14_49_882e226b;
            pictureBox1.Location = new Point(464, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 244);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 12;
            label2.Text = "Informacion:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 530);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnBorrar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblInformacion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(dtgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gestion de Productos ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label lblInformacion;
        private Button btnAdicionar;
        private Button btnBorrar;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}

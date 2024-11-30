using System.Linq.Expressions;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Codigo para adicionar filas o columnas
            int n = dtgvProductos.Rows.Add();
            //colocacr informacion
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;

            //limpiamos los txts
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";


        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                object cellValue = (string)dtgvProductos.Rows[n].Cells[1].Value;
                if (cellValue != null && cellValue is string)
                {
                    lblInformacion.Text = (string)cellValue;
                }
                else
                {
                    lblInformacion.Text = "Valores no admitidos";
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {


            if (n != -1 && n < dtgvProductos.Rows.Count)
            {
                dtgvProductos.Rows.RemoveAt(n);
                n = -1;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila valida para borrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            {
                dtgvProductos.Rows.RemoveAt(n);
            }




        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.MaxLength = 4;
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvProductos.ReadOnly = true;

            dtgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtgvProductos.MultiSelect = false;

            foreach (DataGridViewColumn column in dtgvProductos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}

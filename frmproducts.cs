using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoApi
{
    public partial class frmproducts : Form
    {
        public frmproducts()
        {
            InitializeComponent();
        }
        String id = "";
        private void frmproducs_Load(object sender, EventArgs e)
        {

            getProducts("products");
        }

        private void dgproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getProducts(String url)
        {
            var dt = new DataTable();
            Api.Response(ref dt, url);
            if (dt.Rows.Count > 0)
            {
                dgproducts.DataSource = dt;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                getProducts($"products/search?q={txtbuscar.Text}");
            }
            else
            {
                getProducts("products");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Realmente desea eliminar el producto?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                var dt = new DataTable();
                id = dgproducts.SelectedCells[0].Value.ToString();
                Api.DeleteResponse(ref dt, $"products/{id}");
                if (dt.Rows.Count > 0)
                {
                    dgproducts.DataSource = dt;
                }
            }


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Realmente desea editar el producto?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                showFoms();
            }
        }
        private void showFoms()
        {
            var frm = new frmaddproducts(id);
            frm.ShowDialog();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            showFoms();
        }
    }
}

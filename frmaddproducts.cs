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
    public partial class frmaddproducts : Form
    {
        private string id = "1";
        string valor = "add";
        public frmaddproducts(string id =  "")
        {
            InitializeComponent();
            //this.id = id;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            agregar();
        }
        private void agregar()
        {
            var mensaje = "";
            var paramss = new product();
            paramss.Title = txtproducto.Text;
            paramss.Description = txtdescripcion.Text;
            paramss.Price = txtprecio.Text;
            paramss.DiscountPercentage = txtdescuento.Text;
            paramss.Rating = txtclasificacion.Text;
            paramss.Stock = txtstock.Text;
            paramss.Brand = txtmarca.Text;
            paramss.Category = txtcategoria.Text;
            paramss.Thumbnail = urlimg1.Text;
            paramss.Img0 = urlimg3.Text;
            paramss.Img1 = urlimg4.Text;
            paramss.Img2 = urlimg5.Text;
            paramss.Img3 = urlimg6.Text;
            Api.add(ref mensaje, paramss);
            if (mensaje != "ok")
            {
                lblmensaje.Text =  mensaje;
            }
            else
            {
                Dispose();
            }
        }

        private void frmaddproducts_Load(object sender, EventArgs e)
        {
            if (id != "")
            {
                valor = id;
                getProduct();
            }
        }
        private void getProduct()
        {
            var dt = new DataTable();
            var pamss = new product();
            Api.getResponse(ref pamss, $"products/{id}");
            txtproducto.Text = pamss.Title;
            txtdescripcion.Text = pamss.Description;
            txtprecio.Text = pamss.Price;
            txtdescuento.Text = pamss.DiscountPercentage;
            txtclasificacion.Text = pamss.Rating;
            txtstock.Text = pamss.Stock;
            txtmarca.Text = pamss.Brand;
            txtcategoria.Text = pamss.Category;
            urlimg1.Text = pamss.Thumbnail;
           
            urlimg3.Text = pamss.Img0;
            urlimg4.Text = pamss.Img1;
            urlimg5.Text = pamss.Img2;
            urlimg6.Text = pamss.Img3;

        }
    }
}

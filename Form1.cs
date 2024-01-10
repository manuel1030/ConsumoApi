using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsumoApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            var responseMensaje = "";
            Api.responseLogin(ref responseMensaje ,txtusurs.Text, txtpass.Text);
            if (responseMensaje != "")
            {
                label1.Text = responseMensaje;
            }
            else
            {
                Dispose();
                var frm = new frmproducts();
                frm.ShowDialog
                    ();
            }
        }
    }
}

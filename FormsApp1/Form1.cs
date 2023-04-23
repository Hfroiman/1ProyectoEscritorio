using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string textoingresado = txtNombre.Text;
            lblMostrar.Text = "Hola " + textoingresado + ", bienvenido..";
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            string nuevocolor = txtcolor.Text;
            lvcolores.Items.Add(nuevocolor);
        }
    }
}

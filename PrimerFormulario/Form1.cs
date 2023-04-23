using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerFormulario
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            cbxestadocivil.Items.Add("Casado");
            cbxestadocivil.Items.Add("soltero");
            cbxestadocivil.Items.Add("divorsiado");
        }

        private void btMostrarDatos_Click(object sender, EventArgs e)
        {
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            DateTime Nacimiento = dtpFechanacimiento.Value;
            string Genero;
            if (chbHombre.Checked)
                Genero = "Hombre";
            else if (chbMujer.Checked)
                Genero = "Mujer";
            else
                Genero = "otro";

            string Estadocivil = cbxestadocivil.SelectedItem.ToString();
            string hijos = rbthijos.Checked == true ? "Si tengo hijos. " : "No tengo hijos.";
            string canthijos = Nudcanthijos.Value.ToString();

            ///Como mostrar los datos.
            MessageBox.Show(Apellido + ", " + Nombre+ ", fecha de nacimiento: "+Nacimiento+". Es del genero: " + Genero + "-- Estado civil: " + Estadocivil+ ". Posee " +canthijos+ " hijos.");
                
        }
    }
}

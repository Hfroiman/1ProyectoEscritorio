using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            try
            {
                int rta = Sumar();
                lblresultado.Text = "Resultado de la cuenta es: " + rta;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un inconveniente, "+ex);
            }
        }
        private int Sumar()
        {
            try
            {
                int n1, n2, rta;
                n1 = int.Parse(txtn1.Text);
                n2 = int.Parse(txtn2.Text);
                rta = n1 + n2;
                return rta;
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

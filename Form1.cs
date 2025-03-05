using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcion_if_5toA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Su edad es " + txtEdad.Text + " años");
            }
            else
            {
                MessageBox.Show("Ingrese una edad valida");
            }
        }
    }
}


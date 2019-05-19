using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCSharp_2.Capitulo5
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int num, fac;
            num = Convert.ToInt32(NumerotextBox.Text); // Converting to Integer

           fac = 1;
           for (int i = 1; i <= 1; i++)
           {
              fac *= i;
           }

             ResultadotextBox.Text = fac.ToString();

            
        }
    }
}

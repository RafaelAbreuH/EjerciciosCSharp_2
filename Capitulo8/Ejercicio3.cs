using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCSharp_2.Capitulo8
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            Horalabel.Text = " " + DateTime.Now.ToShortTimeString() + "  " + DateTime.Now.ToShortDateString();
        }
    }
}

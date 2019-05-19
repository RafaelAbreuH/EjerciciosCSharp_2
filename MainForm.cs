using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosCSharp_2.Capitulo5;
using EjerciciosCSharp_2.Capitulo7;
using EjerciciosCSharp_2.Capitulo6;
using EjerciciosCSharp_2.Capitulo8;
namespace EjerciciosCSharp_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Capitulo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Capitulo6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //,,,
        private void Ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo5.Ejercicio4 ver = new Capitulo5.Ejercicio4();
            ver.Show(); 
        }

        private void Ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo6.Ejercicio1 ver = new Capitulo6.Ejercicio1();
            ver.Show();
        }

        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo7.Ejercicio2 ver = new Capitulo7.Ejercicio2();
            ver.Show();
        }

        private void Ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo7.Ejercicio5 ver = new Capitulo7.Ejercicio5();
            ver.Show();
        }

        private void Ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo8.Ejercicio3 ver = new Capitulo8.Ejercicio3();
            ver.Show();
        }

        private void Ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Capitulo8.Ejercicio5 ver = new Capitulo8.Ejercicio5();
            ver.Show();
        }
    }
}

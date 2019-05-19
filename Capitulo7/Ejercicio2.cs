using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCSharp_2.Capitulo7
{
    public partial class Ejercicio2 : Form
    {
        private Hashtable diccionario = new Hashtable();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(PalabratextBox.Text))            {
                errorProvider1.SetError(PalabratextBox, "Digite una palabra");
            }

            else
            {
                if (diccionario.Contains(PalabratextBox.Text))
                {
                    DefiniciontextBox.Text = (String)diccionario[PalabratextBox.Text];
                }
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(PalabratextBox.Text))
            {
                errorProvider1.SetError(PalabratextBox, "Digita una palabra");
            }

            if (string.IsNullOrWhiteSpace(DefiniciontextBox.Text))
            {
                errorProvider1.SetError(DefiniciontextBox, "No puede estar vacio el campo de Definicion.");
            }
            else
            if (!diccionario.Contains(PalabratextBox.Text.ToLower()))
            {
                diccionario.Add(PalabratextBox.Text.ToLower(), (string)DefiniciontextBox.Text);
                PalabratextBox.Text = string.Empty;
                DefiniciontextBox.Text = string.Empty;
            }
        }
    }
}

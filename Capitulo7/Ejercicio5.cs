using System;
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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(string.IsNullOrWhiteSpace(NombretextBox.Text))
                errorProvider1.SetError(NombretextBox, "Campo nombre no debe estar vacio");

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
                errorProvider1.SetError(TelefonomaskedTextBox, "Campo telefono no debe estar vacio");
            else
            {
                ListViewItem lista = new ListViewItem(NombretextBox.Text);
                lista.SubItems.Add(TelefonomaskedTextBox.Text);
                ListalistView.Items.Add(lista);

            }


        }
    }
}

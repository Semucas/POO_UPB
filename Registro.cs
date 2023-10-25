using demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPB
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Visible = false;
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            
    string nombre = textBox1.Text.Trim();
            string direccion = textBox2.Text.Trim(); 
            string estadoCivil = listBox1.SelectedItem?.ToString(); 

            
            if (string.IsNullOrEmpty(nombre) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.");
                return;
            }

            
            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, ingrese una dirección válida.");
                return;
            }

            
            if (string.IsNullOrEmpty(estadoCivil))
            {
                MessageBox.Show("Por favor, seleccione un estado civil.");
                return;
            }

            MessageBox.Show("Registro exitoso");

        }
    }
}

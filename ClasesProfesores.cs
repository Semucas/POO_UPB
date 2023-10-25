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
    public partial class ClasesProfesores : Form
    {
        public ClasesProfesores()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Tus estudiantes para POO son : Muñoz, Perez, Banegas, Messi");
                
            }
            if(checkedListBox1.SelectedIndex == 1) 
            {
                MessageBox.Show("Tus estudiantes para Lógica son : Jose, Roni , Alvarez");

            }
        }
    }
}

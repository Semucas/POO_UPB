using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPB;

namespace demo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            controlBotones();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox_ID.Text.Trim().StartsWith("123"))
            {
                ClasesProfesores clasesProfesoresForm = new ClasesProfesores();
                clasesProfesoresForm.Show();

            }
            else
            {
                botonIngresar.Enabled = false;
                Matricula matriculaForm = new Matricula();
                matriculaForm.Show();

            }
            
            this.Hide();







        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void controlBotones()
        {
            
            if(textBox_ID.Text.Trim().Length == 9  && textBox_ID.Text.Trim().All(char.IsDigit))
            {

                botonIngresar.Enabled = true;
                errorProvider1.SetError(textBox_ID, "");

            }
            else
            {
                if (textBox_ID.Text.Trim().All(char.IsDigit) == false && textBox_ID.Text.Trim().Length > 0 )
                {
                    botonIngresar.Enabled = false;
                    errorProvider1.SetError(textBox_ID, "Solo puedes ingresar números");
                }
                else
                {
                    botonIngresar.Enabled = false;
                    errorProvider1.SetError(textBox_ID, "El ID debe contener 9 dígitos");
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro RegistroForm = new Registro();
            RegistroForm.Show();
            this.Hide();


        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

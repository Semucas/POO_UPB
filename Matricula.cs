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
    public partial class Matricula : Form

    {
        private List<string> cursosMatriculados = new List<string>();

        public Matricula()
        {   
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

            



            if (ListaCursosDisponibles.SelectedIndex >= 0)
            {
               
                string cursoSeleccionado = ListaCursosDisponibles.SelectedItem.ToString();

               
                cursosMatriculados.Add(cursoSeleccionado);

              
                    
                 MessageBox.Show($"Curso matriculado: {cursoSeleccionado}");
                

            }
            else
            {
              
                MessageBox.Show("Por favor, selecciona un curso para matricularte.");
            }
        }

        private void Matricula_Load(object sender, EventArgs e)
        {

        }
    }
}

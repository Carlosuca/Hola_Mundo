using System;
using System.Windows.Forms;

namespace Laboratorio09_practico
{
    public partial class AddSignature : UserControl
    {
        public AddSignature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos.");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO MATERIA(nombre) VALUES('{textBox1.Text}')");

                    MessageBox.Show("Los datos de la materia se han registrado correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error.");
                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Facturacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login()
        {
            NpgsqlConnection conex = new NpgsqlConnection();
            string cadena = "select usuario, clave from usuario_table where usuario='" + textBox1.Text + "' and clave= '" + textBox2.Text + "';";
            conex.ConnectionString = "Username= postgres; Password=nokia610; Host =localhost;Port=5432;Database=Facturacion";
            conex.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(cadena, conex);
            NpgsqlDataReader reader;
            reader = cmd.ExecuteReader();



            if (reader.Read())
            {
                MessageBox.Show("Acceso autorizado", "Sistema");
            }
            else
            {
                MessageBox.Show("Acceso no autorizado", "Sistema");
            }

            conex.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}

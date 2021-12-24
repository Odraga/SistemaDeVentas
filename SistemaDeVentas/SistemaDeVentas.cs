using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class SistemaDeVentas : Form
    {
        public SistemaDeVentas()
        {
            InitializeComponent();
            
        }

        private void SistemaDeVentas_Load(object sender, EventArgs e)
        {
            actualiza();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            usuario.Usuario = textBoxUsuario.Text;
            usuario.Nombre = textBoxNombre.Text;
            usuario.Contrasena = textBoxContrasena.Text;
            usuario.ConContrasena = textBoxConContrasena.Text;
            if (radioButtonAdministrador.Checked == true)
            {
                usuario.IdTipo = 1;
            }
            if (radioButtonUsuario.Checked == true)
            {
                usuario.IdTipo = 2;
            }
            try
            {
                Control control = new Control();

                string respuesta = control.CtrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Usuario Registrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxUsuario.Text = "";
                    textBoxContrasena.Text = "";
                    textBoxConContrasena.Text = "";
                    textBoxNombre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            actualiza();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            actualiza();
        }

        private void actualiza()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string query = "SELECT * FROM usuarios";
            MySqlCommand actualiza = new MySqlCommand(query, conexion);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = actualiza;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewDB.DataSource = tabla;
        }
    }
}

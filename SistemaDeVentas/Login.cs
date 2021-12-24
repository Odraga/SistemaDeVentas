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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBoxEnviar_Click(object sender, EventArgs e)
        {
            comprobar();
        }

        private void comprobar()
        {
            string usuario = textBoxUsuario.Text;
            string contrasena = textBoxContrasena.Text;

            Usuarios user = new Usuarios();

            try
            {
                Control ctrl = new Control();

                string respuesta = ctrl.CtrLogin(usuario, contrasena);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    
                        SistemaDeVentas sistema = new SistemaDeVentas();
                        sistema.Visible = true;
                        this.Visible = false;
                        MessageBox.Show("Bienvenido prro :A");
                    
                        MessageBox.Show("No tienes suficientes permisos.");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al intentar conectarse a la base de datos!", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "127.0.0.1";
            string baseDatos = "prueba";
            string puerto = "3306";
            string nombreUsuario = "root";
            string contrasena = "root";

            string cadenaConexion = "datasource = " + servidor + "; port = " + puerto + "; username = " + nombreUsuario
                + "; password = " + contrasena + "; database = " + baseDatos + ";";

            MySqlConnection sqlConexion = new MySqlConnection(cadenaConexion);
            try
            {
                sqlConexion.Open();

                //se hacen las peticiones necesarias en este espacio

                MessageBox.Show("Conectados");
                sqlConexion.Close();
            }
            catch (Exception)
            {
                //manda una excepcion si la conexion no es exitosa
                MessageBox.Show("Hubo un problema al intentar conectarse a la base de datos!", "Oops! hubo un problema!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return sqlConexion;
        }
    }
}

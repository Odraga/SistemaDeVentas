using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    class Modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string query = "INSERT INTO usuarios(usuario,nombre,contrasena,id_tipo) " +
                "VALUES(@usuario, @nombre, @contrasena, @idTipo)";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
            comando.Parameters.AddWithValue("@idTipo", usuario.IdTipo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
        public bool existeUsuario (string usuario)
        {
            MySqlDataReader reader;

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string query = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string query = "SELECT id, usuario, nombre, contrasena, id_tipo FROM usuarios WHERE usuario = '" + usuario + "';";

            MySqlCommand comando = new MySqlCommand(query, conexion);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Nombre = reader["nombre"].ToString();
                usr.Contrasena = reader["contrasena"].ToString();
                usr.IdTipo = int.Parse(reader["id_tipo"].ToString());
                MessageBox.Show("ID: "+usr.Id + "\n Nombre: " + usr.Nombre + "\n Cotraseña: " + usr.Contrasena + "\n Tipo: " + usr.IdTipo);
            }

            //MessageBox.Show(usr.Id+"\n"+usr.Nombre+"\n"+usr.Contrasena+"\n"+usr.IdTipo);
            return usr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    class Usuarios
    {
        int id, idTipo;
        string usuario, contrasena, conContrasena, nombre;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string ConContrasena { get => conContrasena; set => conContrasena = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}

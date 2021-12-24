using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    class Control
    {
        public string CtrLogin(string usuario, string contrasena)
        {
            Modelo modelo = new Modelo();

            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "El Usuario no existe";
                }
                else
                {
                    if (datosUsuario.Contrasena != contrasena)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden.";
                    }
                }
            }

            return respuesta;
        }

        public string CtrlRegistro (Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Nombre)
                || string.IsNullOrEmpty(usuario.Contrasena) || string.IsNullOrEmpty(usuario.ConContrasena))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                if (usuario.Contrasena == usuario.ConContrasena)
                {
                    if (usuario.IdTipo == 1 || usuario.IdTipo == 2) 
                    {
                        if (modelo.existeUsuario(usuario.Usuario))
                        {
                            respuesta = "El usuario ya existe";
                        }
                        else
                        {
                            modelo.registro(usuario);
                        } 
                    }
                    else
                    {
                        respuesta = "Debe seleccionar el permiso de este usuario";
                    }

                }
                else
                {
                    respuesta = "Las contraseñas no son iguales.";
                }
            }

            return respuesta;
        }
    }
}

using CapaDatos.Entidades;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica.Entidades
{
    public class cls_UserManager
    {
        private cls_UsuarioQ usuarioQ = new cls_UsuarioQ();

        public DataTable BuscarUsuario(string datos)
        {
            try
            {
                return usuarioQ.ReadUser(datos);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la búsqueda de usuarios: {ex.Message}");
                throw;
            }
        }

        // Método para agregar un nuevo usuario
        public void AgregarUsuario(cls_Usuario nuevoUsuario)
        {
            try
            {
                if (ValidarDatosUsuario(nuevoUsuario))
                {
                    usuarioQ.CreateUser(nuevoUsuario);
                }
                else
                {
                    throw new Exception("Los datos del usuario no son válidos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar usuario: {ex.Message}");
                throw;
            }
        }

        // Método para editar un usuario existente
        public void ModificarUsuario(cls_Usuario usuario)
        {
            try
            {
                if (ValidarDatosUsuario(usuario))
                {
                    usuarioQ.UpdateUser(usuario);
                }
                else
                {
                    throw new Exception("Los datos del usuario no son válidos para la actualización.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar usuario: {ex.Message}");
                throw;
            }
        }


        // Método para eliminar un usuario por ID
        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                usuarioQ.DeleteUser(idUsuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
                throw;
            }
        }


        // Método para listar todos los usuarios
        //public List<cls_Usuario> ObtenerUsuarios()
        //{
        //    return usuarioQ.ObtenerUsuarios();
        //}

        // Método para verificar tipo de usuario y abrir el formulario adecuado
        //public void AbrirFormularioSegunUsuario(cls_Usuario usuario)
        //{
        //    if (usuario.Familia_Usuario == "Admin")
        //    {
        //        frmMenuAdmin menuAdmin = new frmMenuAdmin();
        //        menuAdmin.Show();
        //    }
        //    else
        //    {
        //        frmMenuUser menuUser = new frmMenuUser();
        //        menuUser.Show();
        //    }
        //}


        

        // Método para validar datos del usuario
        private bool ValidarDatosUsuario(cls_Usuario usuario)
        {
            
            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.ContraseñaActual))
            {
                return false;
            }
            return true;
        }
    }
}

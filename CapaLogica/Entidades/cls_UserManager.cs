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

        public List<cls_Usuario> BuscarUsuario(string datos)
        {
            try
            {
                DataTable resultado = usuarioQ.ReadUser(datos);
                List<cls_Usuario> listaUsuarios = new List<cls_Usuario>();

                foreach (DataRow row in resultado.Rows)
                {
                    cls_Usuario usuario = new cls_Usuario
                    {
                        IdUsuario = Convert.ToInt32(row["id_usuario"]),
                        IdEmpleado = Convert.ToInt32(row["id_empleado"]),
                        FechaAlta = Convert.ToDateTime(row["fecha_alta"]),
                        FechaBaja = row["fecha_baja"] != DBNull.Value ? Convert.ToDateTime(row["fecha_baja"]) : (DateTime?)null,
                        Estado = row["estado"] != DBNull.Value ? Convert.ToBoolean(row["estado"]) : false,
                        Usuario = row["usuario"].ToString(),
                        ContraseñaActual = row["contraseña_actual"].ToString(),
                        FechaUltIngreso = row["fecha_ult_ingreso"] != DBNull.Value ? Convert.ToDateTime(row["fecha_ult_ingreso"]) : (DateTime?)null,
                        ContraseñaAleatoria = row["contraseña_aleatoria"].ToString(),
                        IdPregunta = Convert.ToInt32(row["id_pregunta"])
                    };

                    listaUsuarios.Add(usuario);
                }

                return listaUsuarios;
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

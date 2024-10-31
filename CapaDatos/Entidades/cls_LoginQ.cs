using CapaDatos.ConexionBD;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos.Entidades
{
    public class cls_LoginQ : cls_EjecutarQ
    {
        #region Login Querys
        // Método para obtener un usuario por su nombre de usuario
        public cls_Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            cls_Usuario usuario = null;
            string query = "SELECT * FROM Usuarios WHERE usuario = @nombreUsuario";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@nombreUsuario", nombreUsuario)
            };

            try
            {
                DataTable resultado = ConsultaRead(query, parametros);

                if (resultado.Rows.Count > 0)
                {
                    DataRow fila = resultado.Rows[0];
                    usuario = new cls_Usuario
                    {
                        IdUsuario = Convert.ToInt32(fila["id_usuario"]),
                        IdEmpleado = Convert.ToInt32(fila["id_empleado"]),
                        FechaAlta = Convert.ToDateTime(fila["fecha_alta"]),
                        FechaBaja = fila["fecha_baja"] == DBNull.Value ? null : (DateTime?)fila["fecha_baja"],
                        Estado = Convert.ToBoolean(fila["estado"]),
                        Usuario = fila["usuario"].ToString(),
                        ContraseñaActual = fila["contraseña_actual"].ToString(),
                        FechaUltIngreso = fila["fecha_ult_ingreso"] == DBNull.Value ? null : (DateTime?)fila["fecha_ult_ingreso"],
                        ContraseñaAleatoria = fila["contraseña_aleatoria"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener usuario por nombre: {ex.Message}");
                throw;
            }
            return usuario;
        }

        // Método para validar si la contraseña coincide
        public bool ValidarContraseña(string nombreUsuario, string contraseña)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @nombreUsuario AND contraseña_actual = @contraseña";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@nombreUsuario", nombreUsuario),
                new SqlParameter("@contraseña", contraseña)
            };

            try
            {
                DataTable resultado = ConsultaRead(query, parametros);
                if (resultado.Rows.Count > 0)
                {
                    int coincidencias = Convert.ToInt32(resultado.Rows[0][0]);
                    return coincidencias > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al validar contraseña: {ex.Message}");
                throw;
            }
            return false; // Si no hay resultados, se retorna false
        }

        // Método para actualizar la contraseña de un usuario
        public void ActualizarContraseña(int idUsuario, string nuevaContraseña)
        {
            string query = "UPDATE Usuarios SET contraseña_actual = @nuevaContraseña WHERE id_usuario = @idUsuario";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@nuevaContraseña", nuevaContraseña),
                new SqlParameter("@idUsuario", idUsuario)
            };

            try
            {
                ConsultaWrite(query, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar contraseña: {ex.Message}");
                throw;
            }
        }

        // Método para bloquear al usuario (modificar el estado a inactivo)
        public void BloquearUsuario(int usuarioId)
        {
            string query = "UPDATE Usuarios SET estado = 1, fecha_baja = GETDATE() WHERE id_usuario = @usuarioId";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@usuarioId", usuarioId)
            };

            ConsultaWrite(query, parameters);
        }

        // Método para desbloquear al usuario (modificar el estado a activo)
        public void DesbloquearUsuario(int idUsuario)
        {
            string query = "UPDATE Usuarios SET estado = 0 WHERE id_usuario = @idUsuario";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@idUsuario", idUsuario)
            };

            try
            {
                ConsultaWrite(query, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al desbloquear usuario: {ex.Message}");
                throw;
            }
        }

        // Método para registrar el último ingreso del usuario
        public void RegistrarIngreso(int idUsuario)
        {
            string query = "UPDATE Usuarios SET fecha_ult_ingreso = @fechaUltIngreso WHERE id_usuario = @idUsuario";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@fechaUltIngreso", DateTime.Now),
                new SqlParameter("@idUsuario", idUsuario)
            };

            try
            {
                ConsultaWrite(query, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar ingreso: {ex.Message}");
                throw;
            }
        }
        #endregion

    }
}
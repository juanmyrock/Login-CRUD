using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaDatos.ConexionBD; // Donde se encuentra cls_EjecutarQ
using CapaEntidades;       // Donde se encuentra la entidad cls_Usuario

namespace CapaDatos.Entidades
{
    public class cls_UsuarioQ : cls_EjecutarQ
    {
        public DataTable ReadUser(string datos)
        {
            DataTable resultado = null;
            try
            {
                string sSQL;
                List<SqlParameter> listaParametros = new List<SqlParameter>();
                if (string.IsNullOrEmpty(datos))
                {
                    sSQL = "SELECT * FROM Usuarios";
                }
                else
                {
                    sSQL = "SELECT * FROM Usuarios WHERE usuario LIKE @datos";
                    listaParametros.Add(new SqlParameter("@datos", "%" + datos.Trim() + "%"));
                }
                resultado = ConsultaRead(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al buscar usuarios", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al buscar usuarios", ex);
            }
            return resultado;
        }



        // Método para agregar un usuario en la base de datos
        public void CreateUser(cls_Usuario usuario)
        {
            try
            {
                string sSQL = "INSERT INTO Usuarios (id_empleado, fecha_alta, fecha_baja, estado, usuario, contraseña_actual, fecha_ult_ingreso, contraseña_aleatoria, id_pregunta) " +
                              "VALUES (@id_empleado, @fecha_alta, @fecha_baja, @estado, @usuario, @contraseña_actual, @fecha_ult_ingreso, @contraseña_aleatoria)";
                List<SqlParameter> listaParametros = new List<SqlParameter>
        {
            new SqlParameter("@id_empleado", usuario.IdEmpleado),
            new SqlParameter("@fecha_alta", usuario.FechaAlta),
            new SqlParameter("@fecha_baja", usuario.FechaBaja),
            new SqlParameter("@estado", usuario.Estado),
            new SqlParameter("@usuario", usuario.Usuario),
            new SqlParameter("@contraseña_actual", usuario.ContraseñaActual),
            new SqlParameter("@fecha_ult_ingreso", usuario.FechaUltIngreso),
            new SqlParameter("@contraseña_aleatoria", usuario.ContraseñaAleatoria),
        };
                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al agregar usuario", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al agregar usuario", ex);
            }
        }


        // Método para editar un usuario
        public void UpdateUser(cls_Usuario usuario)
        {
            try
            {
                string sSQL = "UPDATE Usuarios SET id_empleado = @id_empleado, fecha_alta = @fecha_alta, fecha_baja = @fecha_baja, " +
                              "estado = @estado, usuario = @usuario, contraseña_actual = @contraseña_actual, " +
                              "fecha_ult_ingreso = @fecha_ult_ingreso, contraseña_aleatoria = @contraseña_aleatoria " +
                              "WHERE id_usuario = @id_usuario";

                List<SqlParameter> listaParametros = new List<SqlParameter>
        {
            new SqlParameter("@id_empleado", usuario.IdEmpleado),
            new SqlParameter("@fecha_alta", usuario.FechaAlta),
            new SqlParameter("@fecha_baja", usuario.FechaBaja),
            new SqlParameter("@estado", usuario.Estado),
            new SqlParameter("@usuario", usuario.Usuario),
            new SqlParameter("@contraseña_actual", usuario.ContraseñaActual),
            new SqlParameter("@fecha_ult_ingreso", usuario.FechaUltIngreso),
            new SqlParameter("@contraseña_aleatoria", usuario.ContraseñaAleatoria),
        };

                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al modificar usuario", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al modificar usuario", ex);
            }
        }


        // Método para eliminar un usuario
        public void DeleteUser(int idUsuario)
        {
            try
            {
                string sSQL = "DELETE FROM Usuarios WHERE id_usuario = @id_usuario";

                List<SqlParameter> listaParametros = new List<SqlParameter>
        {
            new SqlParameter("@id_usuario", idUsuario)
        };

                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al eliminar usuario", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al eliminar usuario", ex);
            }
        }

        
    }
}

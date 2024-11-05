using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ConexionBD;
using System.Net;

namespace CapaDatos.Entidades
{
    public class cls_EmpleadoQ : cls_EjecutarQ
    {
        //Método para obtener la tabla de empleados
        public DataTable ReadEmpleado(int idEmpleado)
        {
            DataTable resultado = null;
            try
            {
                string sSQL = "SELECT * FROM Empleados WHERE id_empleado = @id_empleado";
                List<SqlParameter> listaParametros = new List<SqlParameter>
                {
                    new SqlParameter("@id_empleado", idEmpleado)
                };
                resultado = ConsultaRead(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al buscar el empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al buscar el empleado", ex);
            }
            return resultado;
        }



        // Método para agregar un empleado en la base de datos
        public void CreateEmpleado(int idEmpleado, string nombre, string apellido, int idSexo, int idTipoDni, string dni,
                            DateTime fechaNac, string email, string telefono, int idLocalidad, string calle,
                            int numeroCalle, int idCargo, bool estado)
        {
            try
            {
                string sSQL = "INSERT INTO Empleados (nombre, apellido, id_sexo, id_tipodni, dni, fecha_nac, email, telefono, id_localidad, calle, numero_calle, id_cargo, estado) " +
                              "VALUES (@nombre, @apellido, @id_sexo, @id_tipodni, @dni, @fecha_nac, @correo, @telefono, @id_localidad, @calle, @numero_calle, @id_cargo, @estado)";
                List<SqlParameter> listaParametros = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", nombre),
                    new SqlParameter("@apellido", apellido),
                    new SqlParameter("@id_sexo", idSexo),
                    new SqlParameter("@id_tipodni", idTipoDni),
                    new SqlParameter("@dni", dni),
                    new SqlParameter("@fecha_nac", fechaNac),
                    new SqlParameter("@correo", email),
                    new SqlParameter("@telefono", telefono),
                    new SqlParameter("@id_localidad", idLocalidad),
                    new SqlParameter("@calle", calle),
                    new SqlParameter("@numero_calle", numeroCalle),
                    new SqlParameter("@id_cargo", idCargo),
                    new SqlParameter("@estado", estado)
                };
                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al agregar empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al agregar empleado", ex);
            }
        }


        // Método para editar un empleado
        public void UpdateEmpleado(int idEmpleado, string nombre, string apellido, int idSexo, int idTipoDni, string dni,
                            DateTime fechaNac, string email, string telefono, int idLocalidad, string calle,
                            int numeroCalle, int idCargo, bool estado)
        {
            try
            {
                string sSQL = "UPDATE Empleados SET nombre = @nombre, apellido = @apellido, " +
                              "id_sexo = @id_sexo, id_tipodni = @id_tipodni, dni = @dni, " +
                              "fecha_nac = @fecha_nac, email = @correo, telefono = @telefono, id_localidad = @id_localidad, " +
                              "calle = @calle, numero_calle = @numero_calle, id_cargo = @id_cargo, estado = @estado " +
                              "WHERE id_empleado = @id_empleado";

                List<SqlParameter> listaParametros = new List<SqlParameter>
                {
                    new SqlParameter("@id_empleado", idEmpleado),
                    new SqlParameter("@nombre", nombre),
                    new SqlParameter("@apellido", apellido),
                    new SqlParameter("@id_sexo", idSexo),
                    new SqlParameter("@id_tipodni", idTipoDni),
                    new SqlParameter("@dni", dni),
                    new SqlParameter("@fecha_nac", fechaNac),
                    new SqlParameter("@correo", email),
                    new SqlParameter("@telefono", telefono),
                    new SqlParameter("@id_localidad", idLocalidad),
                    new SqlParameter("@calle", calle),
                    new SqlParameter("@numero_calle", numeroCalle),
                    new SqlParameter("@id_cargo", idCargo),
                    new SqlParameter("@estado", estado)
                };

                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al modificar empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al modificar empleado", ex);
            }
        }


        // Método para eliminar un empleado
        public void DeleteEmpleado(int idEmpleado)
        {
            try
            {
                string sSQL = "DELETE FROM Empleados WHERE id_empleado = @id_empleado";

                List<SqlParameter> listaParametros = new List<SqlParameter>
        {
            new SqlParameter("@id_empleado", idEmpleado)
        };

                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al eliminar empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al eliminar empleado", ex);
            }
        }
    }
}

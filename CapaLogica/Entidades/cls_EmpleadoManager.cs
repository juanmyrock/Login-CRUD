using CapaDatos.Entidades;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;

namespace CapaLogica.Entidades
{
    public class cls_EmpleadoManager
    {
        private cls_EmpleadoQ datos_emp = new cls_EmpleadoQ();

        // Método para obtener empleados 
        public DataTable ObtenerEmpleados()
        {
            return datos_emp.ReadAllEmpleados();
        }

        // Método para agregar un nuevo empleado
        public void AgregarEmpleado(cls_Empleado empleado)
        {
            try
            {
                datos_emp.CreateEmpleado(
                    empleado.Nombre,
                    empleado.Apellido,
                    empleado.IdSexo,
                    empleado.IdTipoDni,
                    empleado.Dni,
                    empleado.FechaNac,
                    empleado.Email,
                    empleado.Telefono,
                    empleado.IdLocalidad,
                    empleado.Calle,
                    empleado.NumeroCalle,
                    empleado.IdCargo,
                    empleado.Estado
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar empleado: {ex.Message}");
                throw;
            }
        }

        // Método para modificar la información de un empleado
        public void ModificarEmpleado(cls_Empleado empleado)
        {
            try
            {
                datos_emp.UpdateEmpleado(
                    empleado.IdEmpleado,
                    empleado.Nombre,
                    empleado.Apellido,
                    empleado.IdSexo,
                    empleado.IdTipoDni,
                    empleado.Dni,
                    empleado.FechaNac,
                    empleado.Email,
                    empleado.Telefono,
                    empleado.IdLocalidad,
                    empleado.Calle,
                    empleado.NumeroCalle,
                    empleado.IdCargo,
                    empleado.Estado
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar empleado: {ex.Message}");
                throw;
            }
        }

        // Método para eliminar un empleado por ID
        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                datos_emp.DeleteEmpleado(idEmpleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar empleado: {ex.Message}");
                throw;
            }
        }

        public List<cls_Empleado> ObtenerListaEmpleados()
        {
            DataTable empleadosTable = ObtenerEmpleados();
            var empleadosList = new List<cls_Empleado>();
            
            foreach (DataRow row in empleadosTable.Rows)
            {
                
                var empleado = new cls_Empleado(
                    Convert.ToInt32(row["id_empleado"]), 
                    row["nombre"].ToString(), 
                    row["apellido"].ToString(),
                    Convert.ToInt32(row["id_sexo"]),
                    Convert.ToInt32(row["id_tipodni"]), 
                    row["dni"].ToString(),
                    (DateTime)row["fecha_nac"], 
                    row["email"].ToString(), 
                    row["telefono"].ToString(), 
                    Convert.ToInt32(row["id_localidad"]),
                    row["calle"].ToString(), 
                    Convert.ToInt32(row["numero_calle"]), 
                    Convert.ToInt32(row["id_cargo"]), 
                    Convert.ToBoolean(row["estado"])
                );

                
                empleadosList.Add(empleado);

            }
            return empleadosList;
        }






    //    public void AsignarValoresEmpleado(cls_Empleado empleado, string nombre, string apellido, int idSexo, int idTipoDni, string dni,
    //                                        DateTime fechaNac, string email, string telefono, int idLocalidad, string calle,
    //                                        int numeroCalle, int idCargo, bool estado)
    //    {
    //        empleado.nombre = nombre;
    //        empleado.apellido = apellido;
    //        empleado.idSexo = idSexo;
    //        empleado.idTipoDni = idTipoDni;
    //        empleado.dni = dni;
    //        empleado.fechaNac = fechaNac;
    //        empleado.email = email;
    //        empleado.telefono = telefono;
    //        empleado.idLocalidad = idLocalidad;
    //        empleado.calle = calle;
    //        empleado.numeroCalle = numeroCalle;
    //        empleado.idCargo = idCargo;
    //        empleado.estado = estado;
    //    }

    }
}

using System;

namespace CapaEntidades
{
    public class cls_Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdSexo { get; set; }
        public int IdTipoDni { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdLocalidad { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }
        public int IdCargo { get; set; }
        public bool Estado { get; set; } // Activo o inactivo

        // Constructor vacío para instancias por defecto
        public cls_Empleado() { }

        // Constructor para inicializar todos los campos
        public cls_Empleado(int idEmpleado, string nombre, string apellido, int idSexo, int idTipoDni, string dni,
                            DateTime fechaNac, string email, string telefono, int idLocalidad, string calle,
                            int numeroCalle, int idCargo, bool estado)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            IdSexo = idSexo;
            IdTipoDni = idTipoDni;
            Dni = dni;
            FechaNac = fechaNac;
            Email = email;
            Telefono = telefono;
            IdLocalidad = idLocalidad;
            Calle = calle;
            NumeroCalle = numeroCalle;
            IdCargo = idCargo;
            Estado = estado;
        }
        public cls_Empleado(string nombre, string apellido, int idSexo, int idTipoDni, string dni,
                            DateTime fechaNac, string email, string telefono, int idLocalidad, string calle,
                            int numeroCalle, int idCargo, bool estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            IdSexo = idSexo;
            IdTipoDni = idTipoDni;
            Dni = dni;
            FechaNac = fechaNac;
            Email = email;
            Telefono = telefono;
            IdLocalidad = idLocalidad;
            Calle = calle;
            NumeroCalle = numeroCalle;
            IdCargo = idCargo;
            Estado = estado;
        }
    }
}

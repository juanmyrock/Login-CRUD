using System;

namespace CapaEntidades
{
    public class cls_Usuario
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; } 
        public bool Estado { get; set; }        
        public string Usuario { get; set; }
        public string ContraseñaActual { get; set; }
        public DateTime? FechaUltIngreso { get; set; }
        public string ContraseñaAleatoria { get; set; } 
        public int IdPregunta { get; set; }

        // Constructor vacío para instancias por defecto
        public cls_Usuario() { }

        // Constructor para inicializar todos los campos
        public cls_Usuario(int idUsuario, int idEmpleado, DateTime fechaAlta, DateTime? fechaBaja, bool estado,
                           string usuario, string contraseñaActual, DateTime? fechaUltIngreso, string contraseñaAleatoria, int idPregunta)
        {
            IdUsuario = idUsuario;
            IdEmpleado = idEmpleado;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Estado = estado;
            Usuario = usuario;
            ContraseñaActual = contraseñaActual;
            FechaUltIngreso = fechaUltIngreso;
            ContraseñaAleatoria = contraseñaAleatoria;
            IdPregunta = idPregunta;
        }
    }
}

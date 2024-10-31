using CapaDatos.Entidades;
using System;

namespace CapaLogica.Login
{
    public class cls_LoginManager
    {
        private cls_ConfigSeguridadQ datosConfig = new cls_ConfigSeguridadQ();
        private cls_LoginQ loginQ = new cls_LoginQ();

        private int intentos = 0; // Contador de intentos fallidos
        private string ultimoUsuario = ""; // Almacena el último usuario que intentó iniciar sesión

        public bool LoginUser(string nombreUsuario, string contraseña)
        {
            // Verificar si el usuario está bloqueado
            if (UsuarioBloqueado(nombreUsuario))
            {
                Console.WriteLine("El usuario está bloqueado.");
                return false;
            }

            // Verificar credenciales
            bool validCredencial = loginQ.ValidarContraseña(nombreUsuario, contraseña);
            if (!validCredencial)
            {
                IncrementarIntentosFallidos(nombreUsuario);
                return false;
            }
            else
            {
                // Reiniciar intentos al ingresar correctamente
                intentos = 0;
                ultimoUsuario = string.Empty; // Resetear el último usuario

                // Registrar el ingreso del usuario
                RegistrarIngreso(nombreUsuario);
                return true;
            }
        }

        private void IncrementarIntentosFallidos(string nombreUsuario)
        {
            if (ultimoUsuario != nombreUsuario)
            {
                ultimoUsuario = nombreUsuario;
                intentos = 1;
            }
            else
            {
                intentos++;
            }

            int intentosPermitidos = datosConfig.ObtenerIntentosPermitidos();
            if (intentos >= intentosPermitidos)
            {
                BloquearUsuario(nombreUsuario);
            }
        }

        public int ObtenerIntentosRestantes(string nombreUsuario)
        {
            int intentosPermitidos = datosConfig.ObtenerIntentosPermitidos();
            return intentosPermitidos - intentos;
        }

        public void BloquearUsuario(string nombreUsuario)
        {
            var usuario = loginQ.ObtenerUsuarioPorNombre(nombreUsuario);
            if (usuario != null)
            {
                loginQ.BloquearUsuario(usuario.IdUsuario);
            }
        }

        public bool UsuarioBloqueado(string nombreUsuario)
        {
            var usuario = loginQ.ObtenerUsuarioPorNombre(nombreUsuario);
            return usuario != null && usuario.Estado; // Verifica si el estado es 'true' (bloqueado)
        }

        public void RegistrarIngreso(string nombreUsuario)
        {
            var usuario = loginQ.ObtenerUsuarioPorNombre(nombreUsuario);
            if (usuario != null)
            {
                loginQ.RegistrarIngreso(usuario.IdUsuario);
            }
        }
    }
}

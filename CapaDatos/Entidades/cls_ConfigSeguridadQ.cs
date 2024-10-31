using CapaDatos.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class cls_ConfigSeguridadQ : cls_EjecutarQ
    {
        public int ObtenerIntentosPermitidos()
        {
            int intentosPermitidos = 3; // Valor por defecto en caso de error en la configuración

            string query = "SELECT param_num FROM ConfigSeguridad WHERE configuracion = 'cant_intentos' AND valor_configuracion = 1";
            DataTable result = ConsultaRead(query);

            if (result != null && result.Rows.Count > 0)
            {
                object valor = result.Rows[0]["param_num"];
                if (valor != null && valor != DBNull.Value)
                {
                    intentosPermitidos = Convert.ToInt32(valor);
                }
            }

            return intentosPermitidos;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Utilidades;

namespace CapaComun
{
    public class cls_LlenarCombos
    {
        private cls_LlenarCombosQ llenar = new cls_LlenarCombosQ();

        public DataTable LlenarCombos( string NombreTabla, string CampoID, string CampoDescrip, string Condicion = "")
        {
        
            DataTable datos = llenar.CargarCMB(CampoID, CampoDescrip, NombreTabla,""); // Obtener datos del método CargarCMB de cls_LlenarCombosQ

            if (datos != null && datos.Rows.Count > 0)
            {
                return datos;
            }
            else
            {
                // Manejo de caso en que no se obtienen datos
                Console.WriteLine("No se encontraron datos para llenar el ComboBox.");
                return null;
            }
        }
    }
}

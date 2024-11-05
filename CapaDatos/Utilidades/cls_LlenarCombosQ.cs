using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ConexionBD;

namespace CapaDatos.Utilidades
{
    public class cls_LlenarCombosQ : cls_EjecutarQ
    {

        public DataTable CargarCMB(string campoid, string campodescrip, string tabla, string condicion)
        {
            string sSql;
            if (string.IsNullOrEmpty(condicion))
            {
                sSql = $"SELECT {campoid}, {campodescrip} FROM {tabla} ORDER BY {campodescrip}";
            }
            else
            {
                sSql = $"SELECT {campoid}, {campodescrip} FROM {tabla} WHERE {condicion} ORDER BY {campodescrip}";
            }

            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>(); // Lista para los parámetros de consulta (si es necesario)
                return ConsultaRead(sSql, parametros); // Llama al método ConsultaRead de cls_EjecutarQ
            }
            catch (Exception ex)
            {
                // Manejo de errores específico de esta consulta
                Console.WriteLine($"Error al cargar ComboBox: {ex.Message}");
                return null; // Devuelve null en caso de error
            }
        }
    }
}

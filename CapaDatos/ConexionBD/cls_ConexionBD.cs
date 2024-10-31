using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos.ConexionBD
{
    public abstract class cls_ConexionBD
    {
        private readonly string conexion;         //"conexion" solo es accesible dentro de esta clase que es donde se declara.
                                                  //Además una vez que se inicializa su valor no puede ser modificado,
                                                  //solo puede ser establecido adentro del constructor de la clase en este caso.
        public cls_ConexionBD()
        {
            conexion = ConfigurationManager.ConnectionStrings["ConexionLoginBD"].ConnectionString; //mayor seguridad implementando la cadena de conexión en otro archivo
                                                                                                   //App.config en la capa de inicializacion del proyecto
        }

        protected SqlConnection GetConexion()  //Property que devuelve la conexion
        {
            return new SqlConnection(conexion);  //Devuelve una nueva instancia de SqlConnection utilizando la cadena de conexión.
        }

    }
}

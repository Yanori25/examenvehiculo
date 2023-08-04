using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace ExamenVehiculo.CapaModelo
{
    internal class Conexion
    {

        public Conexion() { }


        public SqlConnection GetConexion(string Conexion)
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ToString());
        }

    }
}

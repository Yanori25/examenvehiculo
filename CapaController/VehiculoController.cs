using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamenVehiculo.CapaModelo;


namespace ExamenVehiculo.CapaController
{
    class VehiculoController
    {

        public bool Modificar(VehiculoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute updvehiculo " + Modelo.IdVehiculo + " , '"
                         + Modelo.DescripcionVehiculo + "' , '"
                          + Modelo.MarcaVehiculo + "' , '"
                           + Modelo.ModeloVehiculo + "' , "
                            + Modelo.AniooVehiculo + " , '"
                             + Modelo.FechaApertura + "' , '"
                              + Modelo.Activo + "' "
                              ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se modifico exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }



        public bool eliminar(VehiculoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute delvehiculo " + Modelo.IdVehiculo + " ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se elimino exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }


        public bool Crear(VehiculoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute addvehiculo " + Modelo.IdVehiculo + " , '"
                         + Modelo.DescripcionVehiculo + "' , '"
                          + Modelo.MarcaVehiculo + "' , '"
                           + Modelo.ModeloVehiculo + "' , "
                            + Modelo.AniooVehiculo + " , '"
                             + Modelo.FechaApertura + "' , '"
                              + Modelo.Activo + "'  "
                              ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se agrego exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public DataTable ListarVehiculos()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();



            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showvehiculos", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;



        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVehiculo.CapaModelo
{
    class VehiculoModel
    {
        public int IdVehiculo { get; set; }

        public string DescripcionVehiculo { get; set; }
        public string MarcaVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public int AniooVehiculo { get; set; }
        public DateTime FechaApertura { get; set; }




        public bool Activo { get; set; }

        public static DataTable ListarVehiculos { get; set; }

        public VehiculoModel() { }

    }
}

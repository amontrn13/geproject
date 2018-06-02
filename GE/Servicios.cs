using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE
{
    class Servicios
    {
     
        public String Servicio { get; set; }
        public String Id_Servicio { get; set; }
        public int Horas { get; set; }
        public int Comision { get; set; }

        public Servicios(String Servicio, String Id_Servicio, int Horas, int Comision)
        {
            this.Servicio = Servicio;
            this.Id_Servicio = Id_Servicio;
            this.Horas = Horas;
            this.Comision = Comision;
        }

    }
}

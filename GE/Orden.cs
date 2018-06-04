using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE
{
    
    class Orden
    {
        public int ID { get; set; }
        public String Cliente { get; set; }
        public String Codigo_Servicios { get; set; }

        public Orden(int ID, String Cliente, String Codigo_Servicios) {
            this.ID = ID;
            this.Cliente = Cliente;
            this.Codigo_Servicios = Codigo_Servicios;
        }
    }
}

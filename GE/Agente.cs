using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_GUI
{
    class Agente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public ArrayList Codigo_Servicios { get; set; }


        public Agente(int ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            Codigo_Servicios = new ArrayList();
        }

        public void AgregarCodigo(string codigo)
        {
            Codigo_Servicios.Add(codigo);
        }
    }
}

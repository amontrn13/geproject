using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE
{
    class Agente
    {
        public int ID{ get; set; }
  
        public string Nombre { get; set; }
        public ArrayList Codigo_Servicios { get; set; }

        public ArrayList Ordenes { get; set; }

        public Agente(int ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Codigo_Servicios = new ArrayList();
            this.Ordenes = new ArrayList();
        }


        public void AgregarCodigo(string codigo)
        {
            this.Codigo_Servicios.Add(codigo);
        }
        
        private string getCodigo_Servicios()
        {
            string total = "";
            List<string> codigos = new List<string>();
            foreach (string codigo in Codigo_Servicios)
            {
                codigos.Add(codigo);
            }
            return total;
        }
        
    }
}

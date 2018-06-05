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

        public List<Orden> Ordenes { get; set; }
        public Agente()
        {
            this.ID = new int();
            this.Nombre = "";
            this.Codigo_Servicios = new ArrayList();
            this.Ordenes = new List<Orden>();
        }
        public Agente(int ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Codigo_Servicios = new ArrayList();
            this.Ordenes = new List<Orden>();
        }
        public Agente(int ID, string Nombre, ArrayList codigos)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Codigo_Servicios = codigos;
            this.Ordenes = new List<Orden>();
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

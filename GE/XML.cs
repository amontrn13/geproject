using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GE
{
    class XML
    {
        XDocument doc;
        public ArrayList DatosAgentes;  /*Arreglos de agentes (ID, nombre, servicios)*/

        public XML()
        {
            DatosAgentes = new ArrayList();
        }

        /*Cargar Archivo*/
        public void AgregarXML(string path)
        {
            doc = XDocument.Load(path);
        }

        public void CreateXml(string path)
        {
            AgregarXML(path);
            doc.Save(Environment.CurrentDirectory + "\\data_agents.xml");
        }

        public void LeerXML()
        {
            foreach (XElement element in doc.Descendants("agente"))
            {
                ArrayList datosAgentep = new ArrayList
                {
                    element.Element("id").Value,
                    element.Element("nombre").Value
                };
                foreach (XElement codigo in element.Descendants("codigo"))
                {
                    datosAgentep.Add(codigo.Value);
                }
                DatosAgentes.Add(datosAgentep);
                foreach (string da in datosAgentep)
                {
                    Console.WriteLine(da);
                }
            }
        }






        public ArrayList ObtenerAgentes()
        {
            ArrayList agentes = new ArrayList();
            foreach (ArrayList datosAgentep in DatosAgentes) {

                Agente agente;
                int ID = Int32.Parse(datosAgentep[0].ToString());
                string nombre = datosAgentep[1].ToString();

                agente = new Agente(ID, nombre);

                for (int i = 2; i < datosAgentep.Count; i++) {
                    agente.AgregarCodigo(datosAgentep[i].ToString());
                }
                agentes.Add(agente);

            }

            foreach (Agente agent in agentes)
            {
                Console.WriteLine(agent.ID);
                Console.WriteLine(agent.Nombre);
                foreach (string codigo in agent.Codigo_Servicios) {

                    Console.WriteLine(codigo);
                }
            }
            return agentes;

        }
    }
}
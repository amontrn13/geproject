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
        public ArrayList DatosAgentes;
        private static XML xml = null;
        public XML()
        {
            DatosAgentes = new ArrayList();
        }
        public static XML GetInstance()
        {
            if (xml == null)
            {
                xml = new XML();
            }
            return xml;
        }

        public void CreateXml(string path)
        {
            AgregarXML(path);
            doc.Save(Environment.CurrentDirectory + "\\agentes.xml");
        }
 
        public void AgregarXML(string path)
        {
            DatosAgentes = new ArrayList();
            doc = XDocument.Load(path);
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
            }
        }

        public ArrayList ObtenerAgentes()
        {
            ArrayList agentes = new ArrayList();
            foreach (ArrayList datosAgentep in DatosAgentes)
            {
                Agente agente;
                int ID = Int32.Parse(datosAgentep[0].ToString());
                string nombre = datosAgentep[1].ToString();
                agente = new Agente(ID, nombre);
                for (int i = 2; i < datosAgentep.Count; i++)
                {
                    agente.AgregarCodigo(datosAgentep[i].ToString());
                }
                agentes.Add(agente);
            }
            return agentes;

        }
    }
}
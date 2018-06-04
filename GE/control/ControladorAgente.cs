using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GE
{
    class ControladorAgente
    {
        public ArrayList agentes;
        public List<Agente> agentesObjetos;
        private XML xmlArchivo;
        private static ControladorAgente controller = null;
        XDocument doc;
        public ArrayList DatosAgentes;

        private ControladorAgente()
        {
            xmlArchivo = XML.GetInstance();
            AgregarXML();
            agentesObjetos = new List<Agente>();
        }

        public static ControladorAgente GetInstance()
        {
            if (controller == null)
            {
                controller = new ControladorAgente();
            }
            return controller;
        }

        public void ConvertirXMLObjetos()
        {
            int id = 0;
            string nombre;
            ArrayList codigos = new ArrayList();
            foreach (Agente a in agentes)
            {
                id = a.ID;
                nombre  = a.Nombre;
                codigos = a.Codigo_Servicios;
                Agente agente = new Agente(id, nombre, codigos);
                agentesObjetos.Add(agente);
            }
        }

        private void AgregarXML()
        {
            try
            {
                xmlArchivo.AgregarXML(Environment.CurrentDirectory + "\\agentes.xml");
                xmlArchivo.LeerXML();
                agentes = xmlArchivo.ObtenerAgentes();
            }
            catch (Exception)
            {

            }
        }

        public void CrearXml(string path)
        {
            xmlArchivo.CreateXml(path);
            AgregarXML();
        }

    }
}

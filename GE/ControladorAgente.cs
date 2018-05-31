using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE
{
    class ControladorAgente
    {
        public ArrayList agentes;
        private XML xmlArchivo;
        private static ControladorAgente controller = null;

        private ControladorAgente()
        {
            xmlArchivo = new XML();
            AgregarXML();
        }

        public static ControladorAgente GetInstance()
        {
            if (controller == null)
            {
                controller = new ControladorAgente();
            }
            return controller;
        }

        private void AgregarXML()
        {
            try
            {
                xmlArchivo.AgregarXML(Environment.CurrentDirectory + "\\data_agents.xml");
                xmlArchivo.LeerXML();
                agentes = xmlArchivo.ObtenerAgentes();
            }
            catch (Exception)
            { }


        }



        public void CrearXml(string path)
        {
            xmlArchivo.CreateXml(path);
            AgregarXML();
        }

    }
}

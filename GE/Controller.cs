using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_GUI
{
    class Controller
    {
        public ArrayList agentes;
        private XML xmlArchivo;
        private static Controller controller = null;

        private Controller()
        {
            xmlArchivo = new XML();
            AgregarXML();
        }

        public static Controller GetInstance()
        {
            if (controller == null)
            {
                controller = new Controller();
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

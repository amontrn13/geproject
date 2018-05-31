using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE
{
    class ControladorOrden
    {
        public ArrayList ordenes;
        private XML xmlArchivo;
        private static ControladorOrden controller = null;

        private ControladorOrden()
        {
            xmlArchivo = new XML();
            AgregarXML();
        }

        public static ControladorOrden GetInstance()
        {
            if (controller == null)
            {
                controller = new ControladorOrden();
            }
            return controller;
        }

        private void AgregarXML()
        {
            try
            {
                xmlArchivo.AgregarXML(Environment.CurrentDirectory + "\\data_agents.xml");
                xmlArchivo.LeerXML();
                ordenes = xmlArchivo.ObtenerAgentes();
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

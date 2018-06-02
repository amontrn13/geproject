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
        private XMLOrden xmlArchivOrden;
        private static ControladorOrden controller = null;

        private ControladorOrden()
        {
            xmlArchivOrden = new XMLOrden();
            AgregarXMLOrden();
        }

        public static ControladorOrden GetInstance()
        {
            if (controller == null)
            {
                controller = new ControladorOrden();
            }
            return controller;
        }

        private void AgregarXMLOrden()
        {
            try
            {
                xmlArchivOrden.AgregarXmlOrden(Environment.CurrentDirectory + "\\ordenes.xml");
                xmlArchivOrden.LeerXMLOrdenes();
                ordenes = xmlArchivOrden.ObtenerOrden();
            }
            catch (Exception)
            { }
        }

        public void CrearXmlOrden(string path)
        {
            xmlArchivOrden.CrearXmlOrdenes(path);
            AgregarXMLOrden();
        }

    }
}

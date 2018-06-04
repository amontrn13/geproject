using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GE
{
    class XMLOrden
    {
        XDocument docOrdenes;
        private static XMLOrden xml = null;
        public ArrayList DatosOrdenes;

        public XMLOrden()
        {
            DatosOrdenes = new ArrayList();
        }

        public static XMLOrden GetInstance()
        {
            if (xml == null)
            {
                xml = new XMLOrden();
            }
            return xml;
        }

        public void CrearXmlOrdenes(string path)
        {
            AgregarXmlOrden(path);
            docOrdenes.Save(Environment.CurrentDirectory + "\\ordenes.xml");
        }

        public void AgregarXmlOrden(string path)
        {
            docOrdenes = XDocument.Load(path);
        }


        public void LeerXMLOrdenes()
        {
            foreach (XElement element in docOrdenes.Descendants("orden"))
            {
                ArrayList datosOrdenp = new ArrayList
                {
                    element.Element("id").Value,
                    element.Element("cliente").Value,
                    element.Element("codigo").Value
                };
                DatosOrdenes.Add(datosOrdenp);
            }
        }

        public ArrayList ObtenerOrden()
        {
            ArrayList ordenes = new ArrayList();
            foreach (ArrayList datosOrdenp in DatosOrdenes)
            {   Orden orden;
                int ID = Int32.Parse(datosOrdenp[0].ToString());
                string cliente = datosOrdenp[1].ToString();
                string Codigo_Servicios = datosOrdenp[2].ToString();

                orden = new Orden(ID, cliente, Codigo_Servicios);
                ordenes.Add(orden);
            }
            return ordenes;

        }

    }
}
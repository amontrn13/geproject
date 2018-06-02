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
        public ArrayList DatosOrdenes;

        public XMLOrden()
        {
            DatosOrdenes = new ArrayList();
        }

        public void CrearXmlOrdenes(string path)
        {
            AgregarXmlOrden(path);
            docOrdenes.Save(Environment.CurrentDirectory + "\\datos\\ordenes.xml");
        }

        public void AgregarXmlOrden(string path)
        {
            docOrdenes = XDocument.Load(path);
        }


        public void LeerXMLOrdenes()
        {
            foreach (XElement element in docOrdenes.Descendants("ordenes"))
            {
                ArrayList datosOrdenp = new ArrayList
                {
                    element.Element("id").Value,
                    element.Element("nombre").Value,
                    element.Element("servicio").Value
                };
                DatosOrdenes.Add(datosOrdenp);

            }
        }

        public ArrayList ObtenerOrden()
        {
            ArrayList ordenes = new ArrayList();
            foreach (ArrayList datosOrdenp in DatosOrdenes)
            {

                Orden orden;
                int ID = Int32.Parse(datosOrdenp[0].ToString());
                string cliente = datosOrdenp[1].ToString();
                string codigo = datosOrdenp[2].ToString();

                orden = new Orden(ID, cliente, codigo);
                ordenes.Add(orden);
            }
            foreach (Orden orden in ordenes)
            {
                Console.WriteLine(orden.ID);
                Console.WriteLine(orden.Cliente);
                Console.WriteLine(orden.Codigo);
            }
            /* End Debug part*/
            return ordenes;

        }

    }
}
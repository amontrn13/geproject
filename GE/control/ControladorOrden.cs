using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GE
{
    class ControladorOrden
    {
        public ArrayList ordenes;
        public List<Orden> ordernesObjetos;
        private XMLOrden xmlArchivOrden;
        private static ControladorOrden controladorOrden = null;

        private ControladorOrden()
        {
            xmlArchivOrden = XMLOrden.GetInstance();
            AgregarXMLOrden();
            ordernesObjetos = new List<Orden>();
        }

        public void ConvertirXMLObjetos()
        {
            int id = 0;
            string cliente;
            string codigo;
            foreach (Orden o in ordenes)
            {
                id = o.ID;
                cliente = o.Cliente;
                codigo = o.Codigo_Servicios;
                Orden orden = new Orden(id, cliente, codigo);
                ordernesObjetos.Add(orden);
            }
        }

        public static ControladorOrden GetInstance()
        {
            if (controladorOrden == null)
            {controladorOrden = new ControladorOrden();}
            return controladorOrden;
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

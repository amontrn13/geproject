using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE
{

    class ControladorServicio
    {
        private XMLServicio XMLArchivoServicio;
        public ArrayList servicios;
        private static ControladorServicio controller = null;

        private ControladorServicio()
        {
            XMLArchivoServicio = new XMLServicio();
        }

    }

}

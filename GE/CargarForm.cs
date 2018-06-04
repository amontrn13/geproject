using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE
{
    public partial class Abrir_Archivo : Form
    {
        ControladorAgente controller = ControladorAgente.GetInstance();
        ControladorOrden Controlador = ControladorOrden.GetInstance();

        OpenFileDialog x = new OpenFileDialog();

        public Abrir_Archivo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            string path, extension;
            path = txtAbrirArchivos.Text;
            extension = Path.GetExtension(path);

            if (extension.Equals(".xml"))
            {
                controller.CrearXml(path);
                Controlador.CrearXmlOrden(path);
            }
            else {

                txtAbrirArchivos.Text = ("Formato incorrecto");
            }
            
            MenuForm form1 = new MenuForm();
            form1.Show();
            Hide();
            
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (x.ShowDialog() == DialogResult.OK)
            {
                txtAbrirArchivos.Text = x.FileName;
            }
        }

        private void Abrir_Archivo_Load(object sender, EventArgs e)
        {

        }
    }
}

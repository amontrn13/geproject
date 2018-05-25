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
        Controller controller = Controller.GetInstance();
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
            }
            Form1 form1 = new Form1();
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
    }
}

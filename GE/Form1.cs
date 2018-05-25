using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GE
{
    public partial class Form1 : Form
    {
        Controller controller = Controller.GetInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Abrir_Archivo CargarForm = new Abrir_Archivo();
            CargarForm.Show();
            Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarAgente_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void btnCargaOrdenes_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnMostrarOrden_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnRepartirOrden_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}


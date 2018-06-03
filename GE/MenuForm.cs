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
    public partial class MenuForm : Form
    {
        ControladorAgente controller = ControladorAgente.GetInstance();
        public MenuForm()
        {
            InitializeComponent();
            MostrarAgente();

        }

        private void MostrarAgente()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Codigo de servicios");

            foreach (Agente a in controller.agentes)
            {
                var resultado = string.Join(",", a.Codigo_Servicios.ToArray()
                    .Select(w => w.ToString())
                    .ToArray());
                dt.Rows.Add(new object[] { a.ID, a.Nombre,resultado});
            }
            dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


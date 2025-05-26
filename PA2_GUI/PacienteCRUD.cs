using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA2_BL;

namespace PA2_GUI
{
    public partial class PacienteCRUD : Form
    {

        PacienteBL objPacienteBL = new PacienteBL();
        DataView dtv;

        public PacienteCRUD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PacienteCRUD_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objPacienteBL.ListarPaciente());
            dataGridView1.DataSource = dtv;
            LblRegistros.Text = dataGridView1.Rows.Count.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

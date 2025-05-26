using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA2_BE;

namespace PA2_GUI
{
    public partial class PacienteCRUD : Form
    {

        PacientesBE objPacienteBE = new PacientesBE();
        DataView dtv;
        public PacienteCRUD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTaskManagement
{
    public partial class MisTareas : Form
    {
        public MisTareas()
        {
            InitializeComponent();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void MisTareas_Load(object sender, EventArgs e)
        {
            cmbDate.Items.Add("Esta semana");
            cmbDate.Items.Add("Proximas semanas");
            cmbDate.Items.Add("Semanas anteriores");
            cmbDate.Items.Add("Sin fecha de entrega");
            cmbDate.Items.Add("Todas las tareas");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

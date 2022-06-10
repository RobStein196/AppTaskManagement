using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppTask_M
{
    public partial class CrearTarea : Form
    {
        public CrearTarea()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-71KERVI\SERVIDOR;Initial Catalog=APPTASK;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {

            string estado = comboBoxEstado.Text.ToString();
            string titulo = txtTitulo.Text.ToString();
            string fechaIn = dateTimePicker2.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string finali = dateTimePicker3.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string import = cmbImport.Text.ToString();
            string etiqueta = txtetiqueta.Text.ToString();
            string descrip = txtboxDescrip.Text.ToString();

            conexion.Open();

            
            try
            {
                SqlCommand insert = new SqlCommand("insert into TAREAS (TITULO, IMPORTANCIA,ETIQUETA, DESCRIPCION, ESTADO, FECHAIN, FECHAFIN)" + "values(@TITULO, @IMPORTANCIA, @ETIQUETA, @DESCRIPCION, @ESTADO, @FECHAIN, @FECHAFIN)", conexion);

                insert.Parameters.AddWithValue("TITULO", titulo);
                insert.Parameters.AddWithValue("IMPORTANCIA", import);
                insert.Parameters.AddWithValue("ETIQUETA", etiqueta);
                insert.Parameters.AddWithValue("DESCRIPCION", descrip);
                insert.Parameters.AddWithValue("ESTADO", estado);
                insert.Parameters.AddWithValue("FECHAIN", fechaIn);
                insert.Parameters.AddWithValue("FECHAFIN", finali);


                insert.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex}");
            }

            MessageBox.Show("Tarea Creada");
            conexion.Close();
        }

        public void llenar_grid(DataGridView grid)
        {
            SqlCommand da = new SqlCommand("Select *from TAREAS", conexion);
            SqlDataAdapter dt = new SqlDataAdapter(da);
            DataTable dx = new DataTable();

            dt.Fill(dx);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
            txtetiqueta.Text = "";
            cmbImport.Text = null;
            txtboxDescrip.Text = "";
            
        }

        private void txtEtiq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbImport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfechaIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CrearTarea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aPPTASKDataSet.TAREAS' Puede moverla o quitarla según sea necesario.
            this.tAREASTableAdapter.Fill(this.aPPTASKDataSet.TAREAS);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("Select *from TAREAS WHERE ID_TAREAS=@ID_TAREAS", conexion);
            conexion.Open();
            consulta.Parameters.AddWithValue("id_Cliente", txtTitulo.Text);


            SqlDataReader leer = consulta.ExecuteReader();

            while (leer.Read())
            {
                txtTitulo.Text = leer[0].ToString();
                

            }
            MessageBox.Show("Consulta Completada");
            conexion.Close();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

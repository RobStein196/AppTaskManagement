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
    public partial class MisTareas : Form
    {
        public MisTareas()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-71KERVI\SERVIDOR;Initial Catalog=APPTASK;Integrated Security=True");
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                conexion.Open();

                
                //if (APPTASK.State == ConnectionState.Closed)
                //cn.Open();

                using (DataTable dt = new DataTable("TAREAS"))
                {
                    using (SqlCommand cmd = new SqlCommand("select FECHAFIN from TAREAS where FECHAFIN between @FECHAFIN and @FECHAIN", conexion))
                    {
                        cmd.Parameters.AddWithValue("@FECHAFIN", datePick.Value);
                        cmd.Parameters.AddWithValue("@FECHAIN", DateTime.Now);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();



                using (DataTable dt = new DataTable("TAREAS"))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from TAREAS where FECHAFIN between @FECHAFIN and @FECHAIN", conexion))
                    {
                        //Convert datepick.value to yyyy/mm/dd

                        cmd.Parameters.AddWithValue("@FECHAFIN", datePick.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@FECHAIN", DateTime.Now);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MisTareas_Load(object sender, EventArgs e)
        {
            this.tAREASTableAdapter.Fill(this.aPPTASKDataSet.TAREAS);
        }
    }
}

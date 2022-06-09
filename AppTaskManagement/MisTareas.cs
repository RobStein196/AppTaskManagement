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
using System.Configuration;

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
            try
            {
                SqlConnection APPTASK = new SqlConnection("Data Source=DESKTOP-54P6O5D\\VENTAS;Initial Catalog=APPTASK;Integrated Security=True");
               
                    APPTASK.Open();
                    //if (APPTASK.State == ConnectionState.Closed)
                    //cn.Open();

                    using (DataTable dt = new DataTable("TAREAS"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select FECHAFIN from TAREAS where FECHAFIN between @FECHAFIN and @FECHAIN", APPTASK))
                        {
                            cmd.Parameters.AddWithValue("@FECHAFIN", datePick.Value);
                            cmd.Parameters.AddWithValue("@FECHAIN", DateTime.Now);
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                        }
                    }
                    APPTASK.Close();
                
            }catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MisTareas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPPTASKDataSet.TAREAS' table. You can move, or remove it, as needed.
            this.tAREASTableAdapter.Fill(this.aPPTASKDataSet.TAREAS);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection APPTASK = new SqlConnection("Data Source=DESKTOP-54P6O5D\\VENTAS;Initial Catalog=APPTASK;Integrated Security=True");

                APPTASK.Open();
                
                using (DataTable dt = new DataTable("TAREAS"))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from TAREAS where FECHAFIN between @FECHAFIN and @FECHAIN", APPTASK))
                    {
                        //Convert datepick.value to yyyy/mm/dd

                        cmd.Parameters.AddWithValue("@FECHAFIN", datePick.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@FECHAIN", DateTime.Now);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        
                    }
                }
                APPTASK.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

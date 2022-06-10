using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalBD
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=CR0W;DATABASE=APPTASK;integrated security=true"); //Aqui cambiarian sus datos nada más!
            cn.Open();
            return cn;
        }
    }
}

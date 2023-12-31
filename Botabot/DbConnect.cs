using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Botabot
{
    internal class DbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string con;


        public string connection()
        {
            con = @"Data Source=DESKTOP-DI42I1S;Initial Catalog=Botabot;Integrated Security=True";
            return con; 
        }
    }
}

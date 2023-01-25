using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employemanage
{
    class functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DateTable dt;
        private SqlDateAdapter sda;
        private string ConStr();
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eslam\OneDrive\Documents\Empdb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DateTable GetDate(string Query)
        {
            dt = new DateTable();
            sda = new SqlDateAdapter(Query, ConStr);
            sda.Fill(dt);
            return dt;
        }
        public int SetDate(String Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed) 
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}

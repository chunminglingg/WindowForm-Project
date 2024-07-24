using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Practice.Model;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Practice.Controllers
{
    internal class Controllers : ConnectionString
    {
        public DataTable data_table(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(sql, conn);
                    adpt.Fill(table);
                } catch (Exception ex)
                {
                    MessageBox.Show("error", ex.Message);
                }
                
                return table;
            }
        }
    }
}

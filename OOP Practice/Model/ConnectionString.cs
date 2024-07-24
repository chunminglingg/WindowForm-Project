using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    internal class ConnectionString
    {
        private static string USERNAME = "sa";
        private static string PASSWORD = "123";
        private static string SERVER_NAME = "MINGG\\MINGSERVER";
        private static string DB_NAME = "sokleng_db";

        // ConnectionString 
        public string connectionString = $"Server={SERVER_NAME};Database={DB_NAME};User Id={USERNAME};Password={PASSWORD}";

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace trabalho_2
{
    public static class DBComun
    {
        private const string CS = "server=127.0.0.1;port=3306;database=trab2_portari;uid=root;pwd=123456789;SslMode=none;";
        public static MySqlConnection Conectar()
        {
            return new MySqlConnection(CS);
        }
    }
}

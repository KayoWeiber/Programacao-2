using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula08_banco
{
    
        
        public static class DBComun
        {
        private const string CS = "server=127.0.0.1;port=3306;database=prog2;uid=root;pwd=123456789;SslMode=none;";
        public static MySqlConnection Conectar()
            {
                return new MySqlConnection(CS);
            }
        }
    
}

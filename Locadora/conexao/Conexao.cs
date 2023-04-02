using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    public class Conexao
    {
        MySqlConnection conexao = new MySqlConnection();
        public Conexao() {
            
             conexao.ConnectionString = "datasource=localhost;username=root;password=@Quenede1393;database=locadora;port=3307";
        }

        public MySqlConnection conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed) { 
                conexao.Open();
            }
            
            return conexao;
        }

        public void Closed ()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

    }
}

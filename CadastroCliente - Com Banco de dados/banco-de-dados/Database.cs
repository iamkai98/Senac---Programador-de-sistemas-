using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CadastroCliente.Banco_de_dados
{
    internal class Database // Classe Database
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;"; // String de conexão com o banco de dados MySQL
        public static MySqlConnection GetConnection() // Método para obter uma nova conexão com o banco de dados
        {
            return new MySqlConnection(ConnectionString); // Cria uma nova conexão com o banco de dados
        }
    }
}

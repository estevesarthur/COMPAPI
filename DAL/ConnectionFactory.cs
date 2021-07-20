using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CompAPI.DAL
{
    public class ConnectionFactory
    {
        public static string nomeConexao = "ConexaoSomee";
        public static IDbConnection GetStringConexao(IConfiguration config)
        {
            return new SqlConnection(config.GetConnectionString(nomeConexao));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PBL_1.DAO
{
    public class ConexaoBD
    {
        /// <summary>
        /// Método Estático que retorna um conexao aberta com o BD
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static SqlConnection GetConexao()
        {
            //casa
            string strCon = "Data Source=LAPTOP-OMPG54KE; Database=AulaBD; integrated security=true";
            //lab
            //string strCon = "Data Source=LOCALHOST; Database=AulaDB; user=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}

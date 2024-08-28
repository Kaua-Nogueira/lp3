using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Util
{
    internal class ConexaoBD
    {
        private MySqlConnection con;
        public ConexaoBD()
        {
            //Conexao com o Banco de Dados
            string strconexao = "";
            //String de Conexao com o Banco de Dados
            strconexao = "server=localhost;userid=root;database=hotelhub_system";
            //Criação do Canal de Comunicação
            con = new MySqlConnection(strconexao);
        }

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }
}

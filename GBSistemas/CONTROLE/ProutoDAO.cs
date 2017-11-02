using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBSistemas.MODELO;
using GBSistemas.DAO;
using MySql.Data.MySqlClient;

namespace GBSistemas.CONTROLE
{
    class ProutoDAO
    {

        public void CadastrarProduto(ProdutoDTO dto) {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = "insert into produto () values ()";

            try
            {

            }
            catch (Exception erro)
            {
                
                throw;
            }           
        }
        
    }
}

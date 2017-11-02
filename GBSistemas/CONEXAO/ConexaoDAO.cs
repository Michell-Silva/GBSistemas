using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GBSistemas.DAL
{
    class ConexaoDAO
    {

        public MySqlConnection conexaoSql()
        {
            return new MySqlConnection("server = localhost; user = root; password= root; database = GBSistema");
        }
    }
}

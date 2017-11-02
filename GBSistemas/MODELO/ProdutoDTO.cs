using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBSistemas.MODELO
{
    class ProdutoDTO
    {
        private int idProd;
        public int IdProd
        {
            get { return idProd; }
            set { idProd = value; }
        }


        private int codigoCard;
        public int CodigoCard
        {
            get { return codigoCard; }
            set { codigoCard = value; }
        }


        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int qtd;

        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        private double precouni;

        public double Precouni
        {
            get { return precouni; }
            set { precouni = value; }
        }
      

        private double precovenda;
        public double Precovenda
        {
            get { return precovenda; }
            set { precovenda = value; }
        }
       
    }
}

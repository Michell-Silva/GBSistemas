using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBSistemas.MODELO
{
    class VendasDTO
    {
        private int idVendas;

        public int IdVendas
        {
            get { return idVendas; }
            set { idVendas = value; }
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private int idformaPag;

        public int IdformaPag
        {
            get { return idformaPag; }
            set { idformaPag = value; }
        }
        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        private string datavenda;

        public string Datavenda
        {
            get { return datavenda; }
            set { datavenda = value; }
        }
        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private double acrescimo;

        public double Acrescimo
        {
            get { return acrescimo; }
            set { acrescimo = value; }
        }
        private double desconto;

        public double Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }
        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
    }
}

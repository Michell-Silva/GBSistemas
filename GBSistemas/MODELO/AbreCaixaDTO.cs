using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBSistemas.MODELO
{
    class AbreCaixaDTO
    {
        private int idAbreCaixa;
        private string horaAbre;
        private string dataAbre;        
        private double valorInicial;
        private string usuario;
        private string horaFecha;
        private string dataFecha;
        private double valorFecha;

        public int AbreCaixa
        {
            get
            {
                return idAbreCaixa;
            }

            set
            {
                idAbreCaixa = value;
            }
        }

        public string HoraAbre
        {
            get
            {
                return horaAbre;
            }

            set
            {
                horaAbre = value;
            }
        }

        public string DataAbre
        {
            get
            {
                return dataAbre;
            }

            set
            {
                dataAbre = value;
            }
        }

        public double ValorInicial
        {
            get
            {
                return valorInicial;
            }

            set
            {
                valorInicial = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string HoraFecha
        {
            get
            {
                return horaFecha;
            }

            set
            {
                horaFecha = value;
            }
        }

        public string DataFecha
        {
            get
            {
                return dataFecha;
            }

            set
            {
                dataFecha = value;
            }
        }

        public double ValorFecha
        {
            get
            {
                return valorFecha;
            }

            set
            {
                valorFecha = value;
            }
        }
    }
}

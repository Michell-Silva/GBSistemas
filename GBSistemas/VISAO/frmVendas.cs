using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBSistemas.VISAO;
using GBSistemas.DAO;
using GBSistemas.MODELO;

namespace GBSistemas
{
    public partial class frmVendas : Form
    {
        double precoVenda;
        public frmVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFormaPag frmFormaPag = new frmFormaPag();
            frmFormaPag.ShowDialog();
            
        }

        private void txtCodProd_Leave(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            ProdutoDAO dao = new ProdutoDAO();
            dto = dao.BuscarProduto(int.Parse(txtCodProd.Text));

            txtDescr.Text = dto.Descricao;

            precoVenda = dto.Precovenda;     
        }

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuant_Leave(object sender, EventArgs e)
        {
            int quant = Convert.ToInt32(txtQuant.Text);

            double subtotal = precoVenda * quant;
            txtSubTotal.Text = (double.Parse(txtSubTotal.Text) + subtotal).ToString();

            string itensLista = txtDescr.Text + "      "  + txtQuant.Text +   "     X    " + precoVenda +    "     =     "   + subtotal ;

            lstVendas.Items.Add(itensLista);

            txtTotaldeItens.Text = (lstVendas.Items.Count - 1).ToString();
        }

        private void txtTotaldeItens_TextChanged(object sender, EventArgs e)
        {

        }              
        
        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                 MessageBox.Show("teste");
            }   
        
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {

        }

              
    }
}

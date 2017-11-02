using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using GBSistemas.MODELO;


namespace GBSistemas
{
    public partial class frmPrincipal : Form
    {
        private string login;
        private int id;
        

        public frmPrincipal(string login)
        {
            InitializeComponent();
            lblGbSistema.Text = "GB Sistemas";
            lblData.Text = DateTime.Now.ToShortDateString();

            lblUsuario.Text = login;

        }

        public frmPrincipal(string login, int id)
        {
            this.login = login;
            this.id = id;
        }

        private void cadastroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuarioF = new frmUsuario();
            usuarioF.ShowDialog();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos produtoF = new frmProdutos();
            produtoF.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start (@"calc.exe");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProdutos produtoF = new frmProdutos();
            produtoF.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBilheteria bilheteriaF = new frmBilheteria();
            bilheteriaF.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }
       
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void barra_status_Click(object sender, EventArgs e)
        {
            if (barra_status.Checked)
            {
                Barra_de_Status.Visible = true;
            }
            else
            {
                Barra_de_Status.Visible = false;
            }
        }        

        private void cadastroFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor frmFornecedor = new frmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void cadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCliente = new frmClientes();
            frmCliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Sistema", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAlteraProduto_Click(object sender, EventArgs e)
        {
            frmProdutos frmprod = new frmProdutos();
            frmprod.ShowDialog();
        }

        private void btnAbreCaixa_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();
            frmVendas.ShowDialog();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"notepad.exe");
        }
    }
}

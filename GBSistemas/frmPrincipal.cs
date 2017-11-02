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


namespace GBSistemas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblGbSistema.Text = "GB Sistemas";
            lblData.Text = DateTime.Now.ToShortDateString();
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
            Process.Start ("calc.exe");

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

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
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

       
    }
}

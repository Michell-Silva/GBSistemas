using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBSistemas.VISAO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrarnovo_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario();
            frmusuario.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmprincipal = new frmPrincipal();
            frmprincipal.Show();
        }
    }
}

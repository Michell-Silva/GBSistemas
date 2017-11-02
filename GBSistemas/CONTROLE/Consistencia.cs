using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBSistemas.MODELO;
using GBSistemas.DAO;


namespace GBSistemas.DAO
{
    class Consistencia
    {
        
        public static void limparCampos(Form formlimpar)
        {

            foreach (Control controle in formlimpar.Controls)
            {
                if (controle is GroupBox && controle.Name == "grpdados")
                {
                    foreach (Control item in controle.Controls)
                    {
                        if (controle is TextBox)
                        {
                            controle.Text = string.Empty;
                        }
                    }

                }
                if (controle is ComboBox)
                {
                    controle.Text = string.Empty;
                }
            }

        }
        public static void limparCampos2(Control frmlimpar2)
        {
            foreach (Control controle in frmlimpar2.Controls)
            {
                if (controle is TextBox)
                {
                    controle.Text = string.Empty;
                }
            }

        }


        //#region Abrir Formulario
        //public static void AbrirForm(Form formequeseraaberto, Form formprincipal)
        //{
        //    foreach (Form formfilho in formprincipal.MdiChildren)
        //    {
        //        if (formfilho.GetType() == formequeseraaberto.GetType())
        //        {
        //            formfilho.Focus();
        //            return;
        //        }
        //    }
        //    formequeseraaberto.MdiParent = formprincipal;
        //    formequeseraaberto.Show();
        //}

        //#endregion     
    }
}

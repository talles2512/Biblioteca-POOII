using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNIP.POOII.BibliotecaPOOII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        void AbrirNovoForm<T>(string TAG) where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == typeof(T))
                {
                    f.Activate();
                    return;
                }
            }

            Form form = new T();
            form.MdiParent = this;
            form.Tag = TAG;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void RibbonOrbMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RbCadastrarAutores_Click(object sender, EventArgs e)
        {
            AbrirNovoForm<frmCadastroAutores>("AUTORES");
        }

        private void RbCadastrarLivros_Click(object sender, EventArgs e)
        {
            AbrirNovoForm<frmCadastroLivros>("LIVROS");
        }

        private void RbCadastrarMulta_Click(object sender, EventArgs e)
        {
            //AbrirNovoForm<frmCadastroMultas>("MULTAS");
        }

        private void RbConsultarAutores_Click(object sender, EventArgs e)
        {
            AbrirNovoForm<frmConsultaAutores>("AUTORES");
        }

        private void RbConsultarLivros_Click(object sender, EventArgs e)
        {
            AbrirNovoForm<frmConsultarLivros>("LIVROS");
        }

        private void BtnADAutores_Click(object sender, EventArgs e)
        {
            AbrirNovoForm<frmAlterarDeletarAutores>("AUTORES");
        }
    }
}

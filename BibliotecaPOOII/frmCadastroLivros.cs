using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIP.POOII.BS_BlibliotecaPOOII;

namespace UNIP.POOII.BibliotecaPOOII
{
    public partial class frmCadastroLivros : Form
    {
        //SITE PARA ENTENDER COMO VALIDAR O ISBN
        //https://pt.wikipedia.org/wiki/International_Standard_Book_Number

        Livros livro = new Livros();

        public frmCadastroLivros()
        {
            InitializeComponent();
        }

        bool validaFormulario()
        {
            bool ret = false;

            if (txtTitulo.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Nome não está preechido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ret;
            }

            ret = true;

            return ret;
        }

        private void ProximoCodigo()
        {
            txtCodigoLivro.Text = livro.ProximoCodigo().ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCadastroLivros_Load(object sender, EventArgs e)
        {
            ProximoCodigo();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (validaFormulario())
            {
                livro.Titulo = txtTitulo.Text;
                livro.CodLivro = Convert.ToInt32(txtCodigoLivro.Text);
                livro.ISBN = txtISBN.Text;
                livro.Quantidade = Convert.ToInt32(dpQuantidade.Text);
                livro.Valor = Convert.ToDouble(txtvalor.Text);
                livro.DataEntrada = dtdataentrada.Value;

                if (rdoEmprestimo.Checked == true)
                {
                    livro.Status = "E".ToString();
                }
                else
                {
                    livro.Status = "C".ToString();
                }

                if (livro.Salvar())
                {
                    MessageBox.Show("Sucesso ao Salvar Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao Salvar Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnConsultaLivros_Click(object sender, EventArgs e)
        {
            frmConsultarLivros form = new frmConsultarLivros();
            form.Show();
        }
    }
}

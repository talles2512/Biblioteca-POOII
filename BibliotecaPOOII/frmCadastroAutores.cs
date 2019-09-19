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
    public partial class frmCadastroAutores : Form
    {
        Autores autor = new Autores();

        public frmCadastroAutores()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (validaFormulario())
            {
                autor.Nome = txtNomeAutor.Text;
                autor.Codigo = Convert.ToInt32(txtCodigo.Text);
                autor.Data = dtData.Value;

                if (autor.Salvar())
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


        private void ProximoCodigo()
        {
            txtCodigo.Text = autor.ProximoCodigo().ToString();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroAutores_Load(object sender, EventArgs e)
        {
            ProximoCodigo();
        }


        bool validaFormulario()
        {
            bool ret = false;

            if (txtNomeAutor.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Nome não está preechido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ret;
            }

            ret = true;

            return ret;
        }

        private void btnConsultaAutores_Click(object sender, EventArgs e)
        {
            frmConsultaAutores frmAutores = new frmConsultaAutores();
            frmAutores.Show();
        }
    }
}

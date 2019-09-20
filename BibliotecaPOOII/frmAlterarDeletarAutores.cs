using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIP.POOII.BS_BlibliotecaPOOII;

namespace UNIP.POOII.BibliotecaPOOII
{
    public partial class frmAlterarDeletarAutores : Form
    {
        Autores autor = new Autores();

        public frmAlterarDeletarAutores()
        {
            InitializeComponent();
        }

        private void Btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool validaFormulario()
        {
            bool ret = false;

            if (txtcodautor.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Código do Autor não está preechido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ret;
            }

            ret = true;

            return ret;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (validaFormulario())
            {
                autor.Codigo = Convert.ToInt32(txtcodautor.Text);
                SqlDataReader dr = null;
                dr = autor.ConsultarDR();
 
                if(dr.Read())
                {
                    txtNomeAutor.Text = (string)dr["NomeAutor"];
                    dtData.Value = (DateTime)dr["DataEntrada"];
                }
                dr.Close();

                txtNomeAutor.Enabled = true;
                dtData.Enabled = true;
                btnaltera.Enabled = true;
                btndeleta.Enabled = true;
                txtcodautor.Enabled = false;
            }
        }

        private void Btnaltera_Click(object sender, EventArgs e)
        {
            if(validaFormulario())
            {
                if (txtNomeAutor.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Nome do Autor não está preechido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    autor.Nome = txtNomeAutor.Text;
                    autor.Data = dtData.Value;

                    if (autor.Atualizar())
                    {
                        MessageBox.Show("Sucesso ao Alterar Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Alterar Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }  
        }

        private void Btndeleta_Click(object sender, EventArgs e)
        {
            if (autor.Apagar())
            {
                MessageBox.Show("Sucesso ao Apagar Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                autor.Codigo = Convert.ToInt32(txtcodautor.Text);
                MessageBox.Show("Falha ao Apagar Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

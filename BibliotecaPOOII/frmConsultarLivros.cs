using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIP.POOII.BS_BlibliotecaPOOII;

namespace UNIP.POOII.BibliotecaPOOII
{
    public partial class frmConsultarLivros : Form
    {
        public frmConsultarLivros()
        {
            InitializeComponent();
        }

        Livros livros = new Livros();

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LerTodosDados()
        {
            dgTodosLivros.DataSource = livros.LerTodosDados().Tables[0];
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if(txtcodlivro.Text.Trim() == "")
            {
                MessageBox.Show("Ops, digite Código do Autor para prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgTodosLivros.DataSource = livros.Consultar().Tables[0];
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LerTodosDados();
        }
    }
}

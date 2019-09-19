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
    public partial class frmConsultaAutores : Form
    {
        Autores autores = new Autores();

        public frmConsultaAutores()
        {
            InitializeComponent();
        }

        private void LerTodosDados()
        {
            dgTodosAutores.DataSource = autores.LerTodosDados().Tables[0];
        }

        private void frmConsultaAutores_Load(object sender, EventArgs e)
        {  
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LerTodosDados();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (txtcodautor.Text.Trim() == "")
            {
                MessageBox.Show("Ops, digite Código do Autor para prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgTodosAutores.DataSource = autores.Consultar().Tables[0];
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIP.POOII.DB_Kernel;
using UNIP.POOII.Util;
using System.Data;
using System.Data.SqlClient;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    public class dbTabelas
    {
        private string stringConexao { get; set; }

        dbKernel db = new dbKernel();

        public dbTabelas()
        {
            LerStringConexao();
        }

        private void LerStringConexao()
        {
            stringConexao = Configuracoes.LeDadosStringCoexao("BibliotecaPOOII");
        }

        protected bool Salvar(string str)
        {
            bool ret = false;
            ret = db.Salvar(str, stringConexao);

            return ret;
        }

        protected bool Atualizar(string str) //Igual SALVAR, Melhor criar apenas um "ExecutaIntrucoes" ?
        {
            bool ret = false;
            ret = db.Atualizar(str, stringConexao);

            return ret;
        }

        protected bool Apagar(string str) //Igual SALVAR, Melhor criar apenas um "ExecutaIntrucoes" ?
        {
            bool ret = false;
            ret = db.Apagar(str, stringConexao);

            return ret;
        }


        protected int ProximoCodigo(string str)
        {
            int ret = int.MinValue;
            ret = db.ConsultarMaximo(str, stringConexao);

            return ret;
        }

        protected int ConsultarNumeroInteiro(string str)
        {
            int ret = int.MinValue;
            ret = db.ConsultarNumeroInteiro(str, stringConexao);

            return ret;
        }

        public DataSet LerTodosDados(string str)
        {
            DataSet ds = new DataSet();
            ds = db.LerTodosDados(str, stringConexao);

            return ds;
        }

        public SqlDataReader ConsultarDR(string str)
        {
            SqlDataReader dr = null;
            dr = db.ConsultarDR(str, stringConexao);

            return dr;
        }
    }
}

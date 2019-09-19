using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIP.POOII.DB_Kernel;
using UNIP.POOII.Util;
using System.Data;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    public class dbTabelas
    {
        private string stringConexao { get; set; }

        public  dbTabelas()
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
            dbKernel db = new dbKernel();

            ret = db.Salvar(str, stringConexao);

            return ret;
        }

        protected bool Atualizar(string str) //Igual SALVAR, Melhor criar apenas um "ExecutaIntrucoes" ?
        {
            bool ret = false;
            dbKernel db = new dbKernel();

            ret = db.Atualizar(str, stringConexao);

            return ret;
        }

        protected bool Apagar(string str) //Igual SALVAR, Melhor criar apenas um "ExecutaIntrucoes" ?
        {
            bool ret = false;
            dbKernel db = new dbKernel();

            ret = db.Apagar(str, stringConexao);

            return ret;
        }


        protected int ProximoCodigo(string str)
        {
            int ret = int.MinValue;
            dbKernel db = new dbKernel();

            ret = db.ConsultarMaximo(str, stringConexao);

            return ret;
        }

        protected int ConsultarNumeroInteiro(string str)
        {
            int ret = int.MinValue;
            dbKernel db = new dbKernel();

            ret = db.ConsultarNumeroInteiro(str, stringConexao);

            return ret;
        }

        public DataSet LerTodosDados(string str)
        {
            DataSet ds = new DataSet();

            dbKernel db = new dbKernel();

            ds = db.LerTodosDados(str, stringConexao);

            return ds;
        }
    }
}

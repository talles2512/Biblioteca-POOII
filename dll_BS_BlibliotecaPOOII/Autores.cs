using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIP.POOII.DB_BlibliotecaPOOII;
using System.Data;
using System.Data.SqlClient;

namespace UNIP.POOII.BS_BlibliotecaPOOII
{
    public class Autores : bsNegocio, IBSBanco
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        tbAutores tb = new tbAutores();

        private void SetDados()
        {
            tb.Codigo = Codigo;
            tb.Data = Data;
            tb.Nome = Nome;
        }


        public bool Salvar()
        {
            bool ret = false;
            SetDados();
            ret = tb.Salvar();

            return ret;
        }

        public bool Atualizar()
        {
            bool ret = false;
            SetDados();
            ret = tb.Atualizar();

            return ret;
        }

        public bool Apagar()
        {
            bool ret = false;
            SetDados();
            ret = tb.Apagar();

            return ret;
        }
        public DataSet Consultar() //Troquei BOOL por DataSet para retornar dados no DataGrid
        {
            DataSet ds = new DataSet();
            SetDados();
            ds = tb.Consultar();

            return ds;
        }

        public int ProximoCodigo()
        {
            int ret = int.MinValue;

            ret = tb.ProximoCodigo();

            return ret;
        }

        public DataSet LerTodosDados()
        {
            DataSet ds = new DataSet();

            ds = tb.LerTodosDados();

            return ds;
        }

        public SqlDataReader ConsultarDR()
        {
            SqlDataReader dr = null;
            SetDados();
            dr = tb.ConsultarDR();
            return dr;
        }
    }
}

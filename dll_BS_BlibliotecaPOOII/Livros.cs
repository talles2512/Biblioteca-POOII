using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UNIP.POOII.DB_BlibliotecaPOOII;

namespace UNIP.POOII.BS_BlibliotecaPOOII
{
    public class Livros:bsNegocio, IBSBanco
    {
       public int CodLivro{get;set;}
       public string Titulo {get;set;}
       public string ISBN { get; set; }
       public DateTime DataEntrada { get; set; }
       public string Status { get; set; }
       public int Quantidade { get; set; }
       public double Valor { get; set; }

       tbLivros tb = new tbLivros();

        public void SetDados()
        {
            tb.CodLivro = CodLivro;
            tb.Titulo = Titulo;
            tb.ISBN = ISBN;
            tb.DataEntrada = DataEntrada;
            tb.Status = Status;
            tb.Quantidade = Quantidade;
            tb.Valor = Valor;
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
            ret = tb.Salvar();

            return ret;
        }

        public bool Apagar()
        {
            bool ret = false;
            SetDados();
            ret = tb.Salvar();

            return ret;
        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    public class tbLivros : dbTabelas, IDBBanco
    {
        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Status { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public bool Salvar()
        {
            bool ret = false;
            int count = int.MinValue;
            string query = "";

            query = "SELECT COUNT(*) FROM tbLivros WHERE CodLivro=" + CodLivro.ToString();

            count = base.ConsultarNumeroInteiro(query);

            if (0 >= count)
            {
                query = "INSERT INTO [dbo].[tbLivros]([CodLivro],[Titulo],[ISBN],[DataEntrada],[Status],[Quantidade],[Valor])" +
                    "VALUES (" + CodLivro.ToString() +
                    ", '" + Titulo +
                    "', '" + ISBN +
                    "', '" + DataEntrada.ToShortDateString() +
                    "', '" + Status.ToString() +
                    "', " + Quantidade +
                    ", " + Valor + ")";
            }
            else
            {
                query = " UPDATE[dbo].[tbLivros]" +
                        "SET[CodLivro] = " + CodLivro.ToString() +
                        ",[Titulo] = '" + Titulo +
                        "',[ISBN] = '" + ISBN +
                        "',[DataEntrada] = '" + DataEntrada.ToShortDateString() +
                        "',[Status] = '" + Status.ToString() +
                        "',[Quantidade] = " + Quantidade +
                        ",[Valor] = " + Valor +
                        "WHERE [CodLivro] = " + CodLivro.ToString();
            }

            ret = base.Salvar(query);
            return ret;
        }

        public bool Atualizar()
        {
            bool ret = false;

            string query = " UPDATE[dbo].[tbLivros]" +
                        "SET[CodLivro] = " + CodLivro.ToString() +
                        ",[Titulo] = '" + Titulo +
                        "',[ISBN] = '" + ISBN +
                        "',[DataEntrada] = '" + DataEntrada.ToShortDateString() +
                        "',[Status] = '" + Status.ToString() +
                        "',[Quantidade] = " + Quantidade +
                        ",[Valor] = " + Valor +
                        "WHERE [CodLivro] = " + CodLivro.ToString();

            ret = base.Atualizar(query);

            return ret;
        }

        public bool Apagar()
        {
            bool ret = false;

            string query = "DELETE FROM [dbo].[tbLivros]" +
                         "WHERE [CodLivro] = " + CodLivro.ToString();

            ret = base.Apagar(query);

            return ret;
        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();

            string query = "";

            query = "SELECT CodAutor, NomeAutor, DataEntrada FROM tbAutores" +
                "WHERE [CodLivro] = " + CodLivro.ToString();

            ds = base.LerTodosDados(query);

            return ds;
        }

        public int ProximoCodigo()
        {
            int ret = int.MinValue;

            string query = "";

            query = "SELECT Max(CodLivro) FROM tbLivros";

            ret = base.ProximoCodigo(query);

            return ret;
        }

        public DataSet LerTodosDados()
        {
            DataSet ds = new DataSet();

            string query = "";

            query = "SELECT CodLivro, Titulo, ISBN, DataEntrada, Status, Quantidade, Valor FROM tbLivros";

            ds = base.LerTodosDados(query);

            return ds;
        }
    }
}

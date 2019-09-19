using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace UNIP.POOII.DB_Kernel
{
    public class dbKernel
    {

        public bool Salvar(string str, string stringConexao)
        {
            bool ret = false;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            string Query = "";

            try
            {
                Query = str;
                conexao = new SqlConnection(stringConexao);
                comando = new SqlCommand(Query, conexao);

                conexao.Open();

                comando.ExecuteNonQuery();

                ret = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }

            return ret;
        }

        public bool Atualizar(string str, string stringConexao)  //Igual SALVAR, Melhor criar apenas um "ExecutaIntrucoes" ?
        {
            bool ret = false;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            string Query = "";

            try
            {
                Query = str;
                conexao = new SqlConnection(stringConexao);
                comando = new SqlCommand(Query, conexao);

                conexao.Open();

                comando.ExecuteNonQuery();

                ret = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }

            return ret;
        }

        public bool Apagar(string str, string stringConexao)  //Igual SALVAR, Melhor criar apenas um "ExecutaIntrucoes" ?
        {
            bool ret = false;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            string Query = "";

            try
            {
                Query = str;
                conexao = new SqlConnection(stringConexao);
                comando = new SqlCommand(Query, conexao);

                conexao.Open();

                comando.ExecuteNonQuery();

                ret = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }

            return ret;
        }

        public int ConsultarMaximo(string str, string stringConexao)
        {
            int ret = int.MinValue;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            string Query = "";

            try
            {
                Query = str;
                conexao = new SqlConnection(stringConexao);
                comando = new SqlCommand(Query, conexao);
                conexao.Open();

                object ValorAnterior = comando.ExecuteScalar();

                if (ValorAnterior != DBNull.Value && ValorAnterior != null)
                {
                    ret = Convert.ToInt32(ValorAnterior) + 1;
                }
                else
                {
                    ret = 1;
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }

            return ret;
        }

        public int ConsultarNumeroInteiro(string str, string stringConexao)
        {
            int ret = int.MinValue;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            string Query = "";

            try
            {
                Query = str;
                conexao = new SqlConnection(stringConexao);
                comando = new SqlCommand(Query, conexao);
                conexao.Open();

                object ValorAnterior = comando.ExecuteScalar();

                if (ValorAnterior != DBNull.Value && ValorAnterior != null)
                {
                    ret = Convert.ToInt32(ValorAnterior);
                }
                else
                {
                    ret = 1;
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }

            return ret;
        }

        public DataSet LerTodosDados(string str, string stringConexao)
        {
            DataSet ds = new DataSet();

            SqlConnection conexao = null;
            SqlDataAdapter da = null;

            try
            {
                conexao = new SqlConnection(stringConexao);
                da = new SqlDataAdapter(str, conexao);

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }

            return ds;
        }
    }
}

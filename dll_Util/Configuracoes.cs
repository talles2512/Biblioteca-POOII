using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UNIP.POOII.Util
{
    public static class Configuracoes
    {
        public static string LeDadosStringCoexao(string chave)
        {
            string RetornaStringConexao = string.Empty;

            try
            {
               RetornaStringConexao = ConfigurationManager.ConnectionStrings[chave].ConnectionString;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                RetornaStringConexao = string.Empty;
            }

            return RetornaStringConexao;
        }
    }
}

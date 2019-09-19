using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UNIP.POOII.DB_BlibliotecaPOOII
{
    interface IDBBanco
    {
        bool Salvar();
        bool Atualizar(); 
        bool Apagar();
        DataSet Consultar(); //Troquei BOOL por DataSet para retornar dados no DataGrid
    }
}

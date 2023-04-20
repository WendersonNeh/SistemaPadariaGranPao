using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaPadariaGranPao
{
    class ClassLogin
    {
        public ClassLogin()
        {
            login = null;
            senha = null;
        }

        public string login { get; set; }
        public string senha { get; set; }

        public DataTable ConsultaLogin()
        {
            string query = $"SELECT login, senha FROM funcionario WHERE STATUS = 1 AND login = '{login}' AND senha = '{senha}'";

            ClassConexao ObjClassConexao = new ClassConexao();

            return ObjClassConexao.RetornaDataTable(query);
        }
    }
 }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SistemaPadariaGranPao
{
    class ClassCategoria
    {
        // construtor da classe - inicializar os objetos da classe
        public ClassCategoria()
        {
            id_categoria = 0;
            nome = null;
            status = 0;
            data_cadastro = DateTime.Now;
            observacao = null;
        }

        // propriedades ler, gravar e calcular
  
        public int id_categoria { get; set; }
        public string nome { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }
        public string observacao { get; set; }

        //query cadastrar

        public int CadastrarCategoria()
        {
            string query = " insert into categoria values(0, '" + nome + "', 1, now(),'" + observacao + "' )";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.ExecutaQuery(query);
        }

        //query buscar infos no BD
        public DataTable BuscarCategoria()
        {
            string query = "SELECT id_categoria, nome FROM categoria WHERE status = 1 ORDER BY nome";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }
    }
}

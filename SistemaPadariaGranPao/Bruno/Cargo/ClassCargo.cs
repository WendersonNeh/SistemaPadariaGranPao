using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaPadariaGranPao
{
    class ClassCargo
    {
        //CONSTRUTOR DA CLASSE - INICIALIZAR OS OBJETOS DA CLASSE
        //O CONSTRUTOR PRECISA TER O MESMO NOME DA CLASSE
        public ClassCargo()
        {
            id_cargo = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //PROPRIEDADES - LER, GRAVAR E CALCULAR 
        //ATALHO PARA CRIAR AS PROPRIEDADES: PROP TAB TAB
        public int id_cargo
        {
            get; set;
        }
        public string nome
        {
            get; set;
        }
        public int status
        {
            get; set;
        }
        public DateTime data_cadastro
        {
            get; set;
        }
        public string observacao
        {
            get; set;
        }

        public int CadastrarCargo()
        {
            string query = $"INSERT INTO cargo VALUES (0, '{nome}', 1, now(), '{observacao}')";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public DataTable BuscarCargo()
        {
            string query = "SELECT id_cargo, nome FROM cargo WHERE status = 1 ORDER BY nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
    }
}
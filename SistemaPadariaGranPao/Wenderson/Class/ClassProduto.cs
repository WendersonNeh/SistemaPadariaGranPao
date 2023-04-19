using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SistemaPadariaGranPao
{
    class ClassProduto
    {
        public ClassProduto()
        {
            id_produto = 0;
            id_fornecedor = 0;
            id_marca = 0;
            id_categoria = 0;
            nome = null;
            estoque = 0;
            data_cadastro = DateTime.Now;
            //validade = DateTime.Now;
            valor_custo = 0;
            valor_venda = 0;
            margem_lucro = 0;
            //desconto = 0;
            status = 0;
            observacao = null;
        }

        public int id_produto { get; set; }
        public  int id_fornecedor { get; set; }
        public  int id_marca { get; set; }
        public int id_categoria { get; set; }
        public string nome { get; set; }
        public int estoque { get; set; }
        public DateTime data_cadastro { get; set; }
        //public DateTime validade { get; set; }
        public decimal valor_custo { get; set; }
        public decimal valor_venda { get; set; }
        public int margem_lucro { get; set; }
        //public decimal desconto  { get; set; }
        public int status { get; set; }     
        public string observacao { get; set; }
        public int CadastrarProduto()
        {

            string query = " insert into produto values(0, " + id_fornecedor + ", " + id_marca + ", " + id_categoria + ",'" + nome + "', " + estoque + ", now(), '" + valor_custo.ToString().Replace("," , ".") + "', '" + valor_venda.ToString().Replace(",", ".") + "', " + margem_lucro + ", 1,'" + observacao + "' )";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.ExecutaQuery(query);
        }


        //?????
        public DataTable BuscarProduto()  
        {
            string query = "SELECT id_produto, nome FROM produto WHERE status = 1 ORDER BY nome";
            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }


        // MÉTODOS DE PESQUISA DE FORNECEDOR
        //POR NOME inicial e final, valor venda, fornecedor, marca, categoria, status;
        //CAMPOS EXIBIDOS NA CONSULTA: CÓDIGO, Nome, Marca, Fornecedor, estoque status;

        //CONSULTA DE FUNCIONÁRIO POR NOME(INICIAL)
        public DataTable ConsultaProdutoNomeInicial(string nomei)
        {
            string query = " SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor= fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE produto.nome LIKE '" + nomei + "%' AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //nome contem
        public DataTable ConsultaProdutoNomeContem(string nomec)
        {
            string query = "SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor= fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE produto.nome LIKE '%" + nomec + "%' AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //Valor venda (preço)

        public DataTable ConsultaProdutoValorvenda(decimal preco)
        {
            string query = "SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor=fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE produto.valor_venda = " + preco.ToString().Replace(",", ".") + " AND produto.status = 1 ORDER BY produto.nome ";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //fonecedor

        public DataTable ConsultaProdutoFornecedor(int fornecedor)
        {
            string query = "SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor=fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE fornecedor.id_fornecedor = " + fornecedor + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //marca

        public DataTable ConsultaProdutoMarca(int marca)
        {
            string query = "SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor=fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE marca.id_marca = " + marca + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }


        //CATEGORIA
        public DataTable ConsultaProdutoCategoria(int categoria)
        {
            string query = "SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor=fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE categoria.id_categoria = " + categoria + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }

        //status
        public DataTable ConsultaProdutoStatus(int status)
        {
            string query = "SELECT produto.id_produto 'Cod', produto.nome 'Produto', produto.valor_venda 'Preço', produto.estoque 'Estoque', fornecedor.nome_fantasia 'Fornecedor', marca.nome 'Marca', categoria.nome 'Categoria', produto.status 'Status' FROM produto join fornecedor ON produto.id_fornecedor= fornecedor.id_fornecedor JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria on produto.id_categoria = categoria.id_categoria WHERE produto.status = " + status + " ORDER BY produto.nome";

            ClassConexao objConexao = new ClassConexao();
            return objConexao.RetornaDataTable(query);
        }


        //buscar produto e editar na grid 

        public bool ConsultaProduto(int id)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM produto WHERE id_produto = " + id + " ";

            ClassConexao objConexao = new ClassConexao();

            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = objConexao.RetornaDataTable(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_produto = Convert.ToInt32(dt.Rows[0]["id_produto"]);
                id_fornecedor = Convert.ToInt32(dt.Rows[0]["id_fornecedor"]);
                id_marca = Convert.ToInt32(dt.Rows[0]["id_marca"]);
                id_categoria = Convert.ToInt32(dt.Rows[0]["id_categoria"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                estoque = Convert.ToInt32(dt.Rows[0]["estoque"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                valor_custo = Convert.ToDecimal(dt.Rows[0]["valor_custo"]);
                valor_venda = Convert.ToDecimal(dt.Rows[0]["valor_venda"]);
                margem_lucro = Convert.ToInt32(dt.Rows[0]["margem_lucro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
               
                return true;

            }
            else //SE A CONSULTA NÃO DER CERTO
            {
                return false;
            }
        }

        //Atualizar cadastro
        public bool AtualizarProduto()
        {
            string query = "UPDATE produto set id_fornecedor = "+ id_fornecedor + ", id_marca = " + id_marca + ", id_categoria = " + id_categoria + ", nome = '" + nome + "', estoque = " + estoque + ", valor_custo ='" + valor_custo.ToString().Replace(",", ".") + "', valor_venda = '" + valor_venda.ToString().Replace(",", ".") + "', margem_lucro = " + margem_lucro + ", status = " + status + ", observacao = '" + observacao + "' WHERE id_produto = " + id_produto + " ";

            ClassConexao objConexao = new ClassConexao();

            int resp = objConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Excluir
        public bool ExcluirProduto()
        {
            string query = "DELETE FROM produto WHERE id_produto = " + id_produto + "; ";

            ClassConexao objConexao = new ClassConexao();
            int resp = objConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

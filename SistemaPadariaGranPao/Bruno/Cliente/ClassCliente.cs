using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaPadariaGranPao
{
    class ClassCliente
    {
        public ClassCliente()
        {
            id_cliente = 0;
            nome = null;
            nome_fantasia = null;
            razao_social = null;
            tipo = null;
            email = null;
            sexo = null;
            estado_civil = null;
            data_nascimento = DateTime.Now;
            cpf = null;
            cnpj = null;
            rg = null;
            telefone_celular = null;
            telefone_residencial = null;
            telefone_recado = null;
            cep = null;
            endereco = null;
            numero = 0;
            complemento = null;
            cidade = null;
            bairro = null;
            estado = null;
            status = 0;
            data_cadastro = DateTime.Now;
            observacao = null;
        }

        public int id_cliente
        {
            get; set;
        }
        public string nome
        {
            get; set;
        }
        public string nome_fantasia
        {
            get; set;
        }
        public string razao_social
        {
            get; set;
        }
        public string tipo
        {
            get; set;
        }
        public string email
        {
            get; set;
        }
        public string sexo
        {
            get; set;
        }
        public string estado_civil
        {
            get; set;
        }
        public DateTime data_nascimento
        {
            get; set;
        }
        public string cpf
        {
            get; set;
        }
        public string cnpj
        {
            get; set;
        }
        public string rg
        {
            get; set;
        }
        public string telefone_celular
        {
            get; set;
        }
        public string telefone_residencial
        {
            get; set;
        }
        public string telefone_recado
        {
            get; set;
        }
        public string cep
        {
            get; set;
        }
        public string endereco
        {
            get; set;
        }
        public int numero
        {
            get; set;
        }
        public string complemento
        {
            get; set;
        }
        public string cidade
        {
            get; set;
        }
        public string bairro
        {
            get; set;
        }
        public string estado
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

        public int CadastrarClienteFisico()
        {
            string query = $"INSERT INTO cliente(id_cliente, nome, nome_fantasia, razao_social, tipo, email, sexo, estado_civil, data_nascimento, cpf, cnpj, rg, telefone_celular, telefone_residencial, telefone_recado, cep, endereco, numero, complemento, cidade, bairro, estado, status, data_cadastro, observacao) VALUES(0, '{nome}', null, null, '{tipo}', '{email}', '{sexo}', '{estado_civil}', '{data_nascimento.ToString("yyyy-MM-dd")}', '{cpf}', null, '{rg}', '{telefone_celular}', '{telefone_residencial}', '{telefone_recado}', '{cep}', '{endereco}', {numero}, '{complemento}', '{cidade}', '{bairro}', '{estado}', 1, now(), '{observacao}')";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public int CadastrarClienteJuridico()
        {
            string query = $"INSERT INTO cliente(id_cliente, nome, nome_fantasia, razao_social, tipo, email, sexo, estado_civil, data_nascimento, cpf, cnpj, rg, telefone_celular, telefone_residencial, telefone_recado, cep, endereco, numero, complemento, cidade, bairro, estado, status, data_cadastro, observacao) VALUES(0, null, '{nome_fantasia}', '{razao_social}', '{tipo}', '{email}', null, null, '{data_nascimento.ToString("yyyy-MM-dd")}', null, '{cnpj}', null, '{telefone_celular}', '{telefone_residencial}', '{telefone_recado}', '{cep}', '{endereco}', {numero}, '{complemento}', '{cidade}', '{bairro}', '{estado}', 1, now(), '{observacao}')";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public DataTable ConsultaClienteNome(string nome)
        {
            string query = $"SELECT id_cliente 'Codigo', nome 'Nome', data_nascimento 'Data Nascimento', cpf 'CPF', cep 'CEP', estado 'Estado' FROM cliente WHERE nome LIKE '%{nome}%' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteCPF(string cpf)
        {
            string query = $"SELECT id_cliente 'Codigo', nome 'Nome', data_nascimento 'Data Nascimento', cpf 'CPF', cep 'CEP', estado 'Estado' FROM cliente WHERE cpf = '{cpf}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteCEP(string cep)
        {
            string query = $"SELECT id_cliente 'Codigo', nome 'Nome', data_nascimento 'Data Nascimento', cpf 'CPF', cep 'CEP', estado 'Estado' FROM cliente WHERE cep = '{cep}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
        public DataTable ConsultaClienteEstado(string estado)
        {
            string query = $"SELECT id_cliente 'Codigo', nome 'Nome', data_nascimento 'Data Nascimento', cpf 'CPF', cep 'CEP', estado 'Estado' FROM cliente WHERE estado = '{estado}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
        public DataTable ConsultaClienteStatus(int status)
        {
            string query = $"SELECT id_cliente 'Codigo', nome 'Nome', nome_fantasia 'Nome Fantasia', razao_social 'Razao Social', data_cadastro 'Data Cadastro', cpf 'CPF', cnpj 'CNPJ', cep 'CEP', estado 'Estado' FROM cliente WHERE status = {status};";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteTipoFisico(string tipof)
        {
            string query = $"SELECT id_cliente 'Codigo', nome 'Nome', data_nascimento 'Data Nascimento', cpf 'CPF', cep 'CEP', estado 'Estado' FROM cliente WHERE tipo = '{tipof}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteTipoJuridico(string tipoj)
        {
            string query = $"SELECT id_cliente 'Codigo', nome_fantasia 'Nome Fanstasia', razao_social 'Razão Social', cnpj 'CNPJ', cep 'CEP', estado 'Estado' FROM cliente WHERE tipo = '{tipoj}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteCNJP(string cnpj)
        {
            string query = $"SELECT id_cliente 'Codigo', nome_fantasia 'Nome Fanstasia', razao_social 'Razão Social', cnpj 'CNPJ', cep 'CEP', estado 'Estado' FROM cliente WHERE cnpj = '{cnpj}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteNomeFantasia(string nome_fantasia)
        {
            string query = $"SELECT id_cliente 'Codigo', nome_fantasia 'Nome Fanstasia', razao_social 'Razão Social', cnjp 'CNPJ', cep 'CEP', estado 'Estado' FROM cliente WHERE nome_fantasia = '{nome_fantasia}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaClienteRazaoSocial(string razao_social)
        {
            string query = $"SELECT id_cliente 'Codigo', nome_fantasia 'Nome Fanstasia', razao_social 'Razão Social', cnjp 'CNPJ', cep 'CEP', estado 'Estado' FROM cliente WHERE razao_social = '{razao_social}' AND status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public void RetornaCliente(int cod)
        {
            string query = $"SELECT * FROM cliente WHERE id_cliente = {cod}";

            ClassConexao cConexao = new ClassConexao();

            DataTable dt = cConexao.RetornaDataTable(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_cliente = Convert.ToInt32(dt.Rows[0]["id_cliente"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                telefone_residencial = Convert.ToString(dt.Rows[0]["telefone_residencial"]);
                telefone_recado = Convert.ToString(dt.Rows[0]["telefone_recado"]);
                telefone_celular = Convert.ToString(dt.Rows[0]["telefone_celular"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                cnpj = Convert.ToString(dt.Rows[0]["cnpj"]);
                razao_social = Convert.ToString(dt.Rows[0]["razao_social"]);
                nome_fantasia = Convert.ToString(dt.Rows[0]["nome_fantasia"]);
                tipo = Convert.ToString(dt.Rows[0]["tipo"]);
            }
        }
        public int AtualizaClienteFisico()
        {
            string query = $"UPDATE cliente SET nome = '{nome}', nome_fantasia = null, razao_social = null, email = '{email}', sexo = '{sexo}', estado_civil = '{estado_civil}', data_nascimento = '{data_nascimento.ToString("yyyy-MM-dd")}', cpf = '{cpf}', cnpj = null, rg = '{rg}', telefone_celular = '{telefone_celular}', telefone_residencial = '{telefone_residencial}', telefone_recado = '{telefone_recado}', cep = '{cep}', endereco = '{endereco}', numero = {numero}, complemento = '{complemento}', cidade = '{cidade}', bairro = '{bairro}', estado = '{estado}', status = {status}, data_cadastro = '{data_cadastro.ToString("yyyy-MM-dd")}', observacao = '{observacao}' WHERE id_cliente = {id_cliente}";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public int AtualizaClienteJuridico()
        {
            string query = $"UPDATE cliente SET nome = null, nome_fantasia = '{nome_fantasia}', razao_social = '{razao_social}', email = '{email}', sexo = null, estado_civil = null, data_nascimento = null, cpf = null, cnpj = '{cnpj}', rg = null, telefone_celular = '{telefone_celular}', telefone_residencial = '{telefone_residencial}', telefone_recado = '{telefone_recado}', cep = '{cep}', endereco = '{endereco}', numero = {numero}, complemento = '{complemento}', cidade = '{cidade}', bairro = '{bairro}', estado = '{estado}', status = {status}, data_cadastro = '{data_cadastro.ToString("yyyy-MM-dd")}', observacao = '{observacao}' WHERE id_cliente = {id_cliente}";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public DataTable CarregaCidadeRel()
        {
            string query = "SELECT DISTINCT cidade FROM cliente WHERE status = 1 ORDER BY cidade";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }


    }
}

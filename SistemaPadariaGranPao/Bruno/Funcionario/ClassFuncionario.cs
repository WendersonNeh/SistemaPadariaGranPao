using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SistemaPadariaGranPao
{
    class ClassFuncionario
    {
        public ClassFuncionario()
        {
            id_funcionario = 0;
            id_departamento = 0;
            id_cargo = 0;
            nome = null;
            email = null;
            sexo = null;
            estado_civil = null;
            data_nascimento = DateTime.Now;
            cpf = null;
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
            salario = 0;
            login = null;
            senha = null;
            tipo_acesso = null;
            status = 0;
            data_cadastro = DateTime.Now;
            observacao = null;
        }

        public int id_funcionario { get; set; }
        public int id_departamento { get; set; }
        public int id_cargo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public DateTime data_nascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_residencial { get; set; }
        public string telefone_recado { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string estado { get; set;}
        public decimal salario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string tipo_acesso {get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }
        public string observacao { get; set; }

        public int CadastrarFuncionarios()
        {
            string query = $"INSERT INTO funcionario(id_funcionario, id_departamento, id_cargo, nome, email, sexo, estado_civil, data_nascimento, cpf, rg, telefone_celular, telefone_residencial, telefone_recado, cep, endereco, numero, complemento, cidade, bairro, estado, salario, login, senha, tipo_acesso, status, data_cadastro, observacao) VALUES(0, {id_departamento}, {id_cargo}, '{nome}', '{email}', '{sexo}', '{estado_civil}', '{data_nascimento.ToString("yyyy-MM-dd")}', '{cpf}', '{rg}', '{telefone_celular}', '{telefone_residencial}', '{telefone_recado}', '{cep}', '{endereco}', {numero}, '{complemento}', '{cidade}', '{bairro}', '{estado}', {salario.ToString().Replace("," , ".")}, '{login}', '{senha}', '{tipo_acesso}', 1, now(), '{observacao}')";  

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.ExecutaQuery(query);
        }

        public DataTable ConsultaFuncionarioNome(string nome)
        {
            string query = $"SELECT funcionario.id_funcionario 'Codigo', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.telefone_celular 'Telefone Principal', cargo.nome 'Cargo', departamento.nome 'Departamento' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo JOIN departamento ON departamento.id_departamento = funcionario.id_departamento WHERE funcionario.nome LIKE '%{nome}%' AND funcionario.status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaFuncionarioCPF(string cpf)
        {
            string query = $"SELECT funcionario.id_funcionario 'Codigo', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.telefone_celular 'Telefone Principal', cargo.nome 'Cargo', departamento.nome 'Departamento' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo JOIN departamento ON departamento.id_departamento = funcionario.id_departamento WHERE funcionario.cpf = '{cpf}' AND funcionario.status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaFuncionarioStatus(int status)
        {
            string query = $"SELECT funcionario.id_funcionario 'Codigo', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.telefone_celular 'Telefone Principal', cargo.nome 'Cargo', departamento.nome 'Departamento' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo JOIN departamento ON departamento.id_departamento = funcionario.id_departamento WHERE funcionario.status = {status}";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
        public DataTable ConsultaFuncionarioCargo(int id_cargo)
        {
            string query = $"SELECT funcionario.id_funcionario 'Codigo', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.telefone_celular 'Telefone Principal', cargo.nome 'Cargo', departamento.nome 'Departamento' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo JOIN departamento ON departamento.id_departamento = funcionario.id_departamento WHERE funcionario.id_cargo = {id_cargo} AND funcionario.status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
        public DataTable ConsultaFuncionarioDepartamento(int id_departamento)
        {
            string query = $"SELECT funcionario.id_funcionario 'Codigo', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.telefone_celular 'Telefone Principal', cargo.nome 'Cargo', departamento.nome 'Departamento' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo JOIN departamento ON departamento.id_departamento = funcionario.id_departamento WHERE funcionario.id_departamento = {id_departamento} AND funcionario.status = 1";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public void RetornaFuncionario(int cod)
        {
            string query = $"SELECT * FROM funcionario WHERE id_funcionario = {cod}";

            ClassConexao cConexao = new ClassConexao();

            DataTable dt = cConexao.RetornaDataTable(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_funcionario = Convert.ToInt32(dt.Rows[0]["id_funcionario"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                salario = Convert.ToDecimal(dt.Rows[0]["salario"]);
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
                login = Convert.ToString(dt.Rows[0]["login"]);
                tipo_acesso = Convert.ToString(dt.Rows[0]["tipo_acesso"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                id_cargo = Convert.ToInt32(dt.Rows[0]["id_cargo"]);
                id_departamento = Convert.ToInt32(dt.Rows[0]["id_departamento"]);
            }
        }

        public int AtualizaFuncionario()
        {
            string query = $"UPDATE funcionario SET id_departamento = {id_departamento}, id_cargo = {id_cargo}, nome = '{nome}', email = '{email}', sexo = '{sexo}', estado_civil = '{estado_civil}', data_nascimento = '{data_nascimento.ToString("yyyy-MM-dd")}', cpf = '{cpf}', rg = '{rg}', telefone_celular = '{telefone_celular}', telefone_residencial = '{telefone_residencial}', telefone_recado = '{telefone_recado}', cep = '{cep}', endereco = '{endereco}', numero = {numero}, complemento = '{complemento}', cidade = '{cidade}', bairro = '{bairro}', estado = '{estado}', salario = {salario.ToString().Replace(",", ".")}, login = '{login}', senha = '{senha}', tipo_acesso = '{tipo_acesso}', status = {status}, data_cadastro = '{data_cadastro.ToString("yyyy-MM-dd")}', observacao = '{observacao}' WHERE funcionario.id_funcionario = {id_funcionario}";

            ClassConexao ObjClassConexao = new ClassConexao();
            int resp = ObjClassConexao.ExecutaQuery(query);
            if(resp == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeletaFuncionario()
        {
            string query = $"DELETE FROM funcionario WHERE funcionario.id_funcionario = {id_funcionario}";

            ClassConexao ObjClassConexao = new ClassConexao();
            int resp = ObjClassConexao.ExecutaQuery(query);

            if(resp == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
         }

        public DataTable RelFuncionarioDiaMes(int dia, int mes)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE DAY(funcionario.data_nascimento) = {dia} AND MONTH(funcionario.data_nascimento) = {mes} ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioMes(int mes)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE MONTH(funcionario.data_nascimento) = {mes} ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioIdade(int idadei, int idadef)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE TIMESTAMPDIFF(YEAR, funcionario.data_nascimento, NOW()) BETWEEN {idadei} AND {idadef} AND funcionario.status = 1 ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioCidade(string cidade)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE funcionario.cidade = '{cidade}' AND funcionario.status = 1 ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioDataAdmissao(DateTime datai, DateTime dataf)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE CAST(funcionario.data_cadastro as date) BETWEEN '{datai.ToString("yyyy-MM-dd")}' AND '{dataf.ToString("yyyy-MM-dd")}' ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioSexo(string sexo)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE funcionario.sexo = '{sexo}' AND funcionario.status = 1 ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioStatus(int status)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE funcionario.status = {status} ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioCargo(int cargo)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE funcionario.id_cargo = {cargo} AND funcionario.status = 1 ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioDepartamento(int departamento)
        {
            string query = $"SELECT funcionario.nome, funcionario.cpf, funcionario.data_nascimento, funcionario.cidade, funcionario.data_cadastro, departamento.nome 'id_departamento', cargo.nome 'id_cargo' FROM funcionario JOIN departamento ON departamento.id_departamento = funcionario.id_departamento JOIN cargo ON cargo.id_cargo = funcionario.id_cargo WHERE funcionario.id_departamento = {departamento} AND funcionario.status = 1 ORDER BY funcionario.nome";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }

        public DataTable CarregaCidadeRel()
        {
            string query = "SELECT DISTINCT cidade FROM funcionario WHERE status = 1 ORDER BY cidade";

            ClassConexao ObjClassConexao = new ClassConexao();
            return ObjClassConexao.RetornaDataTable(query);
        }
    }
}
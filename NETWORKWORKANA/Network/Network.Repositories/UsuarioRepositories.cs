using Network.Dommain;
using Network.Infra.Contex;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Repositories
{
    public class UsuarioRepositories
    {
        private readonly Infra.Contex.DbDefaultContext context;
        private readonly Infra.Contex.ConnectionString connectionString;
        public UsuarioRepositories()
        {
            this.context = new Infra.Contex.DbDefaultContext();
            this.connectionString = new ConnectionString();
        }
        public IEnumerable<networkusuario> ListarPorFiltro(networkusuario dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return null;
        }
        public networkusuario ListarPorEmail(string email)
        {
            return this.context.networkusuarios.ToList().FirstOrDefault(x => x.Email.Equals(email));
        }
        public networkusuario ListarPorId(int id)
        {
            return this.context.networkusuarios.Find(id);
        }
        public IEnumerable<networkusuario> ListarTodos()
        {
            return this.context.networkusuarios;
        }
        public void Excluir(int id)
        {
            var filtro = this.context.networkusuarios.Find(id);
            this.context.Entry(filtro).State = System.Data.Entity.EntityState.Deleted;
            this.context.SaveChanges();
        }
        public void Atualizar(networkusuario dto)
        {

            this.context.Entry(dto).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();

        }
        public void Salvar(networkusuario dto)
        {
            this.context.networkusuarios.Add(dto);

            this.context.SaveChanges();

        }
        public networkusuario Login(string cpf, string senha)
        {
            return this.context.networkusuarios.ToList().FirstOrDefault(x => x.Senha.Equals(senha) && x.Cpf.Equals(cpf));
        }
        public bool Existe(string cpf)
        {
            return this.context.networkusuarios.ToList().Exists(x => x.Cpf == cpf);
        }
        public void Dispose()
        {
            this.context.Database.Connection.Dispose();
            this.context.Database.Connection.Close();
        }

        public DataTable Relatorio()
        {
            /* Criar conexão com banco de dados */
            var _connection = new SqlConnection(ConnectionString.GetConnectionString);

            /* Abrir conexão */
            _connection.Open();

            /* Criar comando que vai enviar informações para o banco */
            SqlCommand _command = _connection.CreateCommand();

            /* Adicionar as informações dentro do comando que vai enviar para o banco */
            _command.CommandType = CommandType.StoredProcedure;

            /* Recebe o nome da procedure que esta sendo executada */
            _command.CommandText = "usp_ListarUsuarios";

            /* Defini o tempo que a conexão ficará aberta (Em Segundos [7200] = 2 horas) */
            _command.CommandTimeout = 7200;

            /* Criar um adptador */
            var sqlDataAdapter = new SqlDataAdapter(_command);

            /* Criar datatable vasia aonde vou adicionar os valores que serão retornados do banco */
            var datatable = new DataTable();

            /* Mandar comando ir ate o banco buscar os daods e o o adptador preencher a datatable */
            sqlDataAdapter.Fill(datatable);

            return datatable;
        }
    }
}

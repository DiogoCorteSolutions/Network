using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Repositories
{
    public class ClienteRepositorio
    {
        private readonly Network.Infra.Contex.DbDefaultContext context;
        public ClienteRepositorio()
        {
            this.context = new Infra.Contex.DbDefaultContext();
        }
        public IEnumerable<networkusuario> ListarPorFiltro(networkusuario dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return null;
        }
        public Networkcliente ListarPorId(int id)
        {
            return this.context.Networkclientes.Find(id);
        }
        public Networkcliente ListarPorCpf(int cpf)
        {
            return this.context.Networkclientes.Find(cpf);
        }
        public IEnumerable<Networkcliente> ListarTodos()
        {
            return this.context.Networkclientes;
        }
        public void Excluir(int id)
        {
            var filtro = this.context.Networkclientes.Find(id);
            this.context.Entry(filtro).State = System.Data.Entity.EntityState.Deleted;
            this.context.SaveChanges();
        }
        public void Atualizar(Networkcliente dto)
        {

            this.context.Entry(dto).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();

        }
        public void Salvar(Networkcliente dto)
        {
            this.context.Networkclientes.Add(dto);

            this.context.SaveChanges();

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
    }
}

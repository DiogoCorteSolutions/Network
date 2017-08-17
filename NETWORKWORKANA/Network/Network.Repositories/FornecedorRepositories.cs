using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Repositories
{
    public class FornecedorRepositories
    {
        private readonly Network.Infra.Contex.DbDefaultContext context;
        public FornecedorRepositories()
        {
            this.context = new Infra.Contex.DbDefaultContext();
        }
        public IEnumerable<networkfornecedore> ListarPorFiltro(networkfornecedore dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return null;
        }
        public networkfornecedore ListarPorId(int id)
        {
            return this.context.networkfornecedores.Find(id);
        }
        public IEnumerable<networkfornecedore> ListarTodos()
        {
            return this.context.networkfornecedores;
        }
        public void Excluir(int id)
        {
            var filtro = this.context.networkfornecedores.Find(id);
            this.context.Entry(filtro).State = System.Data.Entity.EntityState.Deleted;
            this.context.SaveChanges();
        }
        public void Atualizar(networkfornecedore dto)
        {

            this.context.Entry(dto).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();

        }
        public void Salvar(networkfornecedore dto)
        {
            this.context.networkfornecedores.Add(dto);

            this.context.SaveChanges();

        }
    }
}

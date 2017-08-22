using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Repositories
{
    public class ProdutoRepositories
    {
        private readonly Network.Infra.Contex.DbDefaultContext context;
        public ProdutoRepositories()
        {
            this.context = new Infra.Contex.DbDefaultContext();
        }
        public IEnumerable<networkproduto> ListarPorFiltro(networkproduto dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return null;
        }
        public networkproduto ListarPorId(int id)
        {
            return this.context.networkprodutos.Find(id);
        }
        public IEnumerable<networkproduto> ListarTodos()
        {
            return this.context.networkprodutos;
        }
        public void Excluir(int id)
        {
            var filtro = this.context.networkprodutos.Find(id);
            this.context.Entry(filtro).State = System.Data.Entity.EntityState.Deleted;
            this.context.SaveChanges();
        }
        public void Atualizar(networkproduto dto)
        {

            this.context.Entry(dto).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();

        }
        public void Salvar(networkproduto dto)
        {
            this.context.networkprodutos.Add(dto);

            this.context.SaveChanges();

        }
    }
}

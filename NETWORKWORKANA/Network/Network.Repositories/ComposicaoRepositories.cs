using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Repositories
{
    public class ComposicaoRepositories
    {
        private readonly Network.Infra.Contex.DbDefaultContext context;

        public ComposicaoRepositories()
        {
            this.context = new Infra.Contex.DbDefaultContext();
        }

        public IEnumerable<networkcomposicao> ListarPorFiltro(networkcomposicao dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return null;
        }
        public networkcomposicao ListarPorId(int id)
        {
            return this.context.networkcomposicaos.Find(id);
        }
        public IEnumerable<networkcomposicao> ListarTodos()
        {
            return this.context.networkcomposicaos;
        }
        public void Excluir(int id)
        {
            var filtro = this.context.networkcomposicaos.Find(id);
            this.context.Entry(filtro).State = System.Data.Entity.EntityState.Deleted;
            this.context.SaveChanges();
        }
        public void Atualizar(networkcomposicao dto)
        {

            this.context.Entry(dto).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();

        }
        public void Salvar(networkcomposicao dto)
        {
            this.context.networkcomposicaos.Add(dto);

            this.context.SaveChanges();

        }


    }
}

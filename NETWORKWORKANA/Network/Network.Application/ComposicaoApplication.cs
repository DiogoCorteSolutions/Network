using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Application
{
    public class ComposicaoApplication
    {
        private readonly Network.Repositories.ComposicaoRepositories repositorio;


        public ComposicaoApplication()
        {
            this.repositorio = new Repositories.ComposicaoRepositories();
        }
        public IEnumerable<networkcomposicao> ListarPorFiltro(networkcomposicao dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return this.repositorio.ListarPorFiltro(dto);
        }
        public networkcomposicao ListarPorId(int id)
        {
            return this.repositorio.ListarPorId(id);
        }
        public IEnumerable<networkcomposicao> ListarTodos()
        {
            return this.repositorio.ListarTodos();
        }
        public void Excluir(int id)
        {
            this.repositorio.Excluir(id);
        }
        public void Atualizar(networkcomposicao dto)
        {
            this.repositorio.Atualizar(dto);
        }
        public void Salvar(networkcomposicao dto)
        {
            this.repositorio.Salvar(dto);

        }
    }
}

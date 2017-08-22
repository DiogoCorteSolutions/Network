using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Application
{
    public class ProdutoApplication
    {
        private readonly Network.Repositories.ProdutoRepositories repositorio;
        public ProdutoApplication()
        {
            this.repositorio = new Repositories.ProdutoRepositories();
        }
        public IEnumerable<networkproduto> ListarPorFiltro(networkproduto dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return this.repositorio.ListarPorFiltro(dto);
        }
        public networkproduto ListarPorId(int id)
        {
            return this.repositorio.ListarPorId(id);
        }
        public IEnumerable<networkproduto> ListarTodos()
        {
            return this.repositorio.ListarTodos();
        }
        public void Excluir(int id)
        {
            this.repositorio.Excluir(id);
        }
        public void Atualizar(networkproduto dto)
        {
            this.repositorio.Atualizar(dto);
        }
        public void Salvar(networkproduto dto)
        {
            this.repositorio.Salvar(dto);

        }

    }
}

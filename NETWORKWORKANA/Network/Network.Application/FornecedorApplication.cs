using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Application
{
    public class FornecedorApplication
    {
        private readonly Network.Repositories.FornecedorRepositories repositorio;

        public FornecedorApplication()
        {
            this.repositorio = new Repositories.FornecedorRepositories();
        }

        public IEnumerable<networkfornecedore> ListarPorFiltro(networkfornecedore dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return this.repositorio.ListarPorFiltro(dto);
        }
        public networkfornecedore ListarPorId(int id)
        {
            return this.repositorio.ListarPorId(id);
        }
        public IEnumerable<networkfornecedore> ListarTodos()
        {
            return this.repositorio.ListarTodos();
        }
        public void Excluir(int id)
        {
            this.repositorio.Excluir(id);
        }
        public void Atualizar(networkfornecedore dto)
        {
            this.repositorio.Atualizar(dto);
        }
        public void Salvar(networkfornecedore dto)
        {
            this.repositorio.Salvar(dto);

        }
        public IEnumerable<networktipo> ListarTodosTiposFornecedores()
        {
            return this.repositorio.ListarTodosTiposFornecedor();
        }
        public void ExcluirTipoFornecedor(int id)
        {
            this.repositorio.ExcluirTipoFornecedor(id);
        }
        public void AtualizarFornecedor(networktipo dto)
        {
            this.repositorio.AtualizarTipoFornecedor(dto);

        }
        public void SalvarTipoFornecedor(networktipo dto)
        {
            this.repositorio.SalvarTipoFornecedor(dto);
        }
    }
}

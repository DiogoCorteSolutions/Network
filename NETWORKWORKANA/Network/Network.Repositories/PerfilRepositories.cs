using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Repositories
{
    public class PerfilRepositories
    {
        private readonly Network.Infra.Contex.DbDefaultContext context;
        public PerfilRepositories()
        {
            this.context = new Infra.Contex.DbDefaultContext();
        }
        public IEnumerable<networkperfil> ListarPorFiltro(networkperfil dto)
        {
            //return this._context.Pessoa.Where(x => x.Chave.Contains(dto.Chave) && x.Id == dto.Id);
            return null;
        }
        public networkperfil ListarPorId(int id)
        {
            return this.context.networkperfils.Find(id);
        }
        public networkperfil ListarPorCpf(int cpf)
        {
            return this.context.networkperfils.Find(cpf);
        }
        public IEnumerable<networkperfil> ListarTodos()
        {
            return this.context.networkperfils;
        }
    }
}

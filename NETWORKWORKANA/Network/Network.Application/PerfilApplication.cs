using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Application
{
   public class PerfilApplication
    {
       private readonly Network.Repositories.PerfilRepositories repositorio;

       public PerfilApplication()
       {
           this.repositorio = new Repositories.PerfilRepositories();
       }
        public IEnumerable<networkperfil> ListarPorFiltro(networkperfil dto)
        {
            return this.repositorio.ListarPorFiltro(dto);
        }
        public networkperfil ListarPorId(int id)
        {
            return this.repositorio.ListarPorId(id);
        }
        public networkperfil ListarPorCpf(int cpf)
        {
            return this.repositorio.ListarPorCpf(cpf);
        }
        public IEnumerable<networkperfil> ListarTodos()
        {
            return this.repositorio.ListarTodos();
        }
    }
}

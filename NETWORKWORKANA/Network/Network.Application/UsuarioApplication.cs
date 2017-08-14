using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Application
{
    public class UsuarioApplication : IDisposable
    {
        private readonly Network.Repositories.UsuarioRepositories repositorio;

        public UsuarioApplication()
        {
            this.repositorio = new Repositories.UsuarioRepositories();


        }
        public IEnumerable<networkusuario> ListarTodos()
        {
            return this.repositorio.ListarTodos();

        }
        public networkusuario ListarPorEmail(string email)
        {
            return this.repositorio.ListarPorEmail(email);
        }
        public networkusuario ListarPorId(int id)
        {
            return this.repositorio.ListarPorId(id);
        }
        public IEnumerable<networkusuario> ListarPorFilto(networkusuario dto)
        {
            return this.repositorio.ListarPorFiltro(dto);
        }
        public void Salvar(networkusuario dto)
        {
            this.repositorio.Salvar(dto);

        }
        public void Excluir(int id)
        {
            this.repositorio.Excluir(id);
        }
        public void Atualizar(networkusuario dto)
        {
            this.repositorio.Atualizar(dto);
        }

        public bool Existe(string cpf)
        {
            return this.repositorio.Existe(cpf);
        }
        public networkusuario Login(string senha, string cpf)
        {
            return this.repositorio.Login(senha, cpf);
        }

        public DataTable Relatorio()
        {
            return this.repositorio.Relatorio();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

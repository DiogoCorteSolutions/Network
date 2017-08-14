using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Application
{
    public class ClienteApplication
    {
        private readonly Network.Repositories.ClienteRepositorio clienteRepository;

        public ClienteApplication()
        {
            this.clienteRepository = new Repositories.ClienteRepositorio();

        }
        public Networkcliente ListarPorId(int id)
        {
            return this.clienteRepository.ListarPorId(id);
        }
        public Networkcliente ListarPorCpf(int cpf)
        {
            return this.clienteRepository.ListarPorCpf(cpf);
        }
        public IEnumerable<Networkcliente> ListarTodos()
        {
            return this.clienteRepository.ListarTodos();
        }
        public void Excluir(int id)
        {
            this.clienteRepository.Excluir(id);
        }
        public void Atualizar(Networkcliente dto)
        {
            this.clienteRepository.Atualizar(dto);
        }
        public void Salvar(Networkcliente dto)
        {
            this.clienteRepository.Salvar(dto);

        }
        public bool Existe(string cpf)
        {
            return this.clienteRepository.Existe(cpf);
        }
    }
}

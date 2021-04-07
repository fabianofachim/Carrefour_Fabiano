using Carrefour_Projeto.Application.DTOs;
using Carrefour_Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Carrefour_Projeto.Application.Interfaces
{
    public interface IClienteService
    {

        Task<Cliente> InsereCliente(ClienteRequest cliente);
        Task<Cliente> RetornarCliente(int IdCliente);

        void AlterarCliente(Cliente obj);

        Task DeletaCliente(int IdCliente);
        Task<List<Cliente>> RetornarClientes(string CodEmpresa, string Nome, string Cpf, string idCidade, string UF);
    }
}

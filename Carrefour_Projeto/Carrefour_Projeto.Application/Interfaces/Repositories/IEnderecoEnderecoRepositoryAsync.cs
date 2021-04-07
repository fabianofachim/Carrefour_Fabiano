using Carrefour_Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Carrefour_Projeto.Application.Interfaces.Repositories
{
    public interface IEnderecoRepositoryAsync : IGenericRepositoryAsync<Endereco>
    {
        //Task<Cliente> ObterCidade(string IdCidade);
        Task<Endereco> RetornarEndereco(int Id);
        
    }
}

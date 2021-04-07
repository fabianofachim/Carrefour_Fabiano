using Carrefour_Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Carrefour_Projeto.Application.Interfaces.Repositories
{
    public interface ICidadeRepositoryAsync : IGenericRepositoryAsync<Cidade>
    {
        Task<Cliente> ObterCidade(string IdCidade);
    }
}

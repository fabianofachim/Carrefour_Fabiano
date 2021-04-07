using Carrefour_Projeto.Application.DTOs;
using Carrefour_Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Carrefour_Projeto.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task DeletaEndereco(IList<ClienteEndereco> obj);
    }
}

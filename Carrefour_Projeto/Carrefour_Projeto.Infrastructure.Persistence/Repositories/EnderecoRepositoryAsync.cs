using Carrefour_Projeto.Application.Interfaces.Repositories;
using Carrefour_Projeto.Domain.Entities;
using Carrefour_Projeto.Infrastructure.Persistence.Contexts;
using Carrefour_Projeto.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Carrefour_Projeto.Application.Interfaces;
using System.Linq;

namespace Carrefour_Projeto.Infrastructure.Persistence.Repositories
{
    public class EnderecoRepositoryAsync : GenericRepositoryAsync<Endereco>, IEnderecoRepositoryAsync
    {
        private readonly DbSet<Endereco> _Endereco;

        public EnderecoRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _Endereco = dbContext.Set<Endereco>();
        }

        public async Task<Endereco> RetornarEndereco(int Id)
        {
            return  _Endereco.Where(x => x.IdEndereco == Id).FirstOrDefault();
        }

    }
}

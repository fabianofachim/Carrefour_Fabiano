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


namespace Carrefour_Projeto.Infrastructure.Persistence.Repositories
{
    public class CidadeRepositoryAsync : GenericRepositoryAsync<Cidade>, ICidadeRepositoryAsync
    {
        private readonly DbSet<Cidade> _cidade;

        public CidadeRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _cidade = dbContext.Set<Cidade>();
        }

        public Task<Cliente> ObterCidade(string IdCidade)
        {
            throw new NotImplementedException();
        }
    }
}

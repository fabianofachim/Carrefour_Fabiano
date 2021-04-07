using Carrefour_Projeto.Application.DTOs.Email;
using Carrefour_Projeto.Application.Exceptions;
using Carrefour_Projeto.Application.Interfaces;
using Carrefour_Projeto.Application.DTOs;
using Carrefour_Projeto.Domain.Settings;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;
using Carrefour_Projeto.Application.Interfaces.Repositories;
using Carrefour_Projeto.Domain.Entities;
using System.Collections.Generic;
using Carrefour_Projeto.Infrastructure.Persistence.Contexts;
using System;
using Carrefour_Projeto.Infrastructure.Persistence.Repositories;

namespace Carrefour_Projeto.Infrastructure.Shared.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly ApplicationDbContext _dbContext;


        IEnderecoRepositoryAsync _enderecoRepository;

        public ILogger<ClienteService> _logger { get; }

        public EnderecoService(IEnderecoRepositoryAsync enderecoRepository, ILogger<ClienteService> logger,
                                    ApplicationDbContext dbContext)
        {

            _enderecoRepository = enderecoRepository;
            _logger = logger;
            _dbContext = dbContext;
        }


        public async Task DeletaEndereco(IList<ClienteEndereco> obj)
        {
            try
            {
                foreach (var item in obj)
                {
                    Endereco end = new Endereco();

                    
                    end = await _enderecoRepository.RetornarEndereco(item.IdEndereco);

                    _enderecoRepository.DeleteAsync(end);
                }                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw new ApiException(ex.Message);
            }
        }
    }

}

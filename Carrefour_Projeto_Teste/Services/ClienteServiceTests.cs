using NUnit.Framework;
using Carrefour_Projeto.Infrastructure.Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Carrefour_Projeto.Application.Interfaces;

namespace Carrefour_Projeto.Infrastructure.Shared.Services.Tests
{
    [TestFixture()]
    public class ClienteServiceTests
    {
        private readonly IClienteService _clienteService;
        public ClienteServiceTests(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [Test()]
        public async System.Threading.Tasks.Task RetornarClienteTestAsync()
        {

            var cli = await _clienteService.RetornarCliente(4);

            Assert.AreEqual(cli.IdCliente, 4);
        }

        [Test()]
        public async System.Threading.Tasks.Task RetornarClientesTestAsync()
        {
            var cli = await _clienteService.RetornarClientes("1",null, null, null, null);

            foreach (var item in cli)
            {
                Assert.IsNotNull(item.IdCliente);
                Assert.IsNotNull(item.Nome);
            }
        }

        //CodEmpresa invalido
        [Test()]
        public async System.Threading.Tasks.Task RetornarClientesCodEmpresaInvalidoTestAsync()
        {
            var cli = await _clienteService.RetornarClientes("10", null, null, null, null);

            Assert.IsNull(cli);

        }
    }
}
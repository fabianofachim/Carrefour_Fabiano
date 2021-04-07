using Carrefour_Projeto.Application.Interfaces;
using Carrefour_Projeto.Infrastructure.Shared.Services;
using NUnit.Framework;

namespace Carrefour_Projeto_Testes
{
    public class Tests
    {

        private readonly IClienteService _clienteService;

        public Tests()
        {
            _clienteService = new ClienteService();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var cli =  _clienteService.RetornarCliente(4);

            Assert.AreEqual(4, cli.Result.IdCliente);
        }
    }
}
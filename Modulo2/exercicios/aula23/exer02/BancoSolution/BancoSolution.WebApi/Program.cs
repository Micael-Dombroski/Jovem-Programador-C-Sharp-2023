using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BancoSolution.Domain.Entidade;
using BancoSolution.Infra.Data.Repository;

namespace BancoSolution.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*ClienteRepository _clienteRepo = new ClienteRepository();
            Cliente cliente = _clienteRepo.ConsultarPorCpf("111.111.111-11");
            ContaRepository contas = new ContaRepository();
            foreach (var item in contas.ConsultarTodos())
            {
                Console.WriteLine(_clienteRepo.ConsultarPorCpf("111.111.111-11").Equals((Cliente)item.Correntista));
            }   */
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

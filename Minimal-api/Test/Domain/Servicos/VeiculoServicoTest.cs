// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection;
// using System.Threading.Tasks;
// using Microsoft.Extensions.Configuration;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Minimal_api.Dominio.Entidades;
// using Minimal_api.Dominio.Servicos;
// using Minimal_api.Infraestrutura.Db;

// namespace Test.Domain.Servicos
// {
//     [TestClass]
//     public class VeiculoServicoTest
//     {
//         private DbContexto CriarContextoDeTeste()
//         {
//             var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
//             var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

//             var builder = new ConfigurationBuilder()
//                 .SetBasePath(path ?? Directory.GetCurrentDirectory())
//                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//                 .AddEnvironmentVariables();

//             var configuration = builder.Build();

//             return new DbContexto(configuration);
//         }

//         [TestMethod]
//         public void TestandoApagarVeiculo()
//         {
//             // Arrange
//             var context = CriarContextoDeTeste();

//             var veiculo = new Veiculo();
//             veiculo.Id = 1;
//             veiculo.Nome = "veiculo Teste";
//             veiculo.Marca = "Marca Teste";
//             veiculo.Ano = 2020;
//         }
//     }
// }
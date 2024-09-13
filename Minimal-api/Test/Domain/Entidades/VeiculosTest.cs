using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculosTest
    {
        [TestMethod]
        public void TestarGetSetPropriedadesVeiculo()
        {
            // Arrange 
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "Civic";
            veiculo.Marca = "Honda";
            veiculo.Ano = 2024;

            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Civic", veiculo.Nome);
            Assert.AreEqual("Honda", veiculo.Marca);
            Assert.AreEqual(2024, veiculo.Ano);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minimal_api.Dominio.Entidades;
using Minimal_api.Dominio.Interfaces;

namespace Test.Mocks
{
    public class VeiculoServicoMock : iVeiculoServico
    {
        private static List<Veiculo> veiculos = new List<Veiculo>()
        {
            new Veiculo {
                Id = 1,
                Nome = "Teste",
                Marca = "Marca Teste",
                Ano = 2020
            }
        };

        public void Apagar(Veiculo veiculo)
        {
            veiculos.Remove(veiculo);
        }

        public void Atualizar(Veiculo veiculo)
        {
            // Encontrar o veículo existente pelo Id
            var veiculoExistente = veiculos.FirstOrDefault(v => v.Id == veiculo.Id);
            if (veiculoExistente != null)
            {
                // Atualizar as propriedades do veículo existente
                veiculoExistente.Nome = veiculo.Nome;
                veiculoExistente.Marca = veiculo.Marca;
                veiculoExistente.Ano = veiculo.Ano;
            }
            else
            {
                // Se o veículo não for encontrado, você pode lançar uma exceção ou adicionar o veículo à lista
                throw new Exception("Veículo não encontrado");
            }
        }

        public Veiculo BuscaPorId(int id)
        {
            return veiculos.FirstOrDefault(v => v.Id == id);
        }

        public void Incluir(Veiculo veiculo)
        {
            veiculo.Id = veiculos.Count() + 1;
            veiculos.Add(veiculo);
        }

        public List<Veiculo> Todos(int? pagina = 1, string nome = null, string marca = null)
        {
            return veiculos;
        }
    }
}
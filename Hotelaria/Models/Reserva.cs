using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Reserva
    {

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int quantidadeHospedes = hospedes.Count;
            int capacidadeSuite = Suite.Capacidade;

            if (quantidadeHospedes <= capacidadeSuite)
            {
                Hospedes = hospedes;
            }
            else
            {
                // throw new ArgumentException("Capacidade excedida");
                Console.WriteLine("Capacidade excedida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal precoTotal;
            decimal desconto;

            if (DiasReservados <= 9)
            {
                precoTotal = DiasReservados * Suite.ValorDiaria;
            }
            else
            {
                decimal precoOriginal = Suite.ValorDiaria * DiasReservados;
                desconto = precoOriginal * (10m / 100m);
                precoTotal = precoOriginal - desconto;
            }
            return precoTotal;
        }
    }
}
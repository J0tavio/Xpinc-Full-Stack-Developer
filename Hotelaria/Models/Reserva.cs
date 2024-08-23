using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Reserva
    {
        private List<Pessoa> hospedes = new List<Pessoa>();
        private Suite suite;
        private int diasReservados;

        public Reserva()
        {

        }

        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> pessoa)
        {

        }

        public void CadastrarSuite(Suite suite)
        {

        }

        public int ObterQuantidadeHospedes()
        {
            return 0;
        }
        public decimal CalcularValorDiaria()
        {
            return 0;
        }
    }
}
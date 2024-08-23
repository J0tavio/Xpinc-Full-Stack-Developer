using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Suite
    {
        private string tipoSuite;
        private int capacidade;
        private decimal valorDiaria;

        public Suite()
        {

        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public Pessoa()
        {
            
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
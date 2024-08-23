using System.Text;
using Hotelaria.Models;
Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Hóspede 1");
Pessoa p2 = new Pessoa("Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("Premium", 3, 30);

Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Número de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
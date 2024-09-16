using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minimal_api.Dominio.DTOs;
using Minimal_api.Dominio.Entidades;
using Minimal_api.Dominio.Interfaces;

namespace Test.Mocks
{
    public class AdministradorServicoMock : iAdministradorServico
    {
        private static List<Administrador> administradores = new List<Administrador>()
        {
            new Administrador {
                Id = 1,
                Email = "adm@test.com",
                Senha = "123456",
                Perfil = "Adm"
            },
             new Administrador {
                Id = 1,
                Email = "editor@test.com",
                Senha = "123456",
                Perfil = "Editor"
            }
        };

        public Administrador BuscaPorId(int id)
        {
            return administradores.Find(a => a.Id == id);
        }

        public Administrador Incluir(Administrador administrador)
        {
            administrador.Id = administradores.Count() + 1;
            administradores.Add(administrador);

            return administrador;
        }

        public Administrador Login(LoginDTO loginDTO)
        {
            return administradores.Find(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
        }

        public List<Administrador> Todos(int? pagina)
        {
            return administradores;
        }
    }
}
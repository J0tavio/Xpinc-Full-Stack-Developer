using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minimal_api.Dominio.DTOs;
using Minimal_api.Dominio.Entidades;
using Minimal_api.Dominio.Interfaces;
using Minimal_api.Infraestrutura.Db;

namespace Minimal_api.Dominio.Servicos
{
    public class AdministradorServico : iAdministradorServico
    {
        private readonly DbContexto _contexto;

        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores
                .Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha)
                .FirstOrDefault();

            return adm;
        }
    }
}
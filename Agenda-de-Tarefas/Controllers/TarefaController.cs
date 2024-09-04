using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda_de_Tarefas.Contexts;
using Agenda_de_Tarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_de_Tarefas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            var status = tarefa.Status;

            if (tarefa.Data == DateTime.MinValue)
            {
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            }
            // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
            _context.Add(tarefa);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
            // return Ok(tarefa);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            // TODO: Buscar o Id no banco utilizando o EF
            var tarefaBanco = _context.TarefasDbSet.Find(id);
            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
            // caso contrário retornar OK com a tarefa encontrada
            if (tarefaBanco == null)
            {
                return NotFound();
            }
            return Ok(tarefaBanco);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            // TODO: Buscar todas as tarefas no banco utilizando o EF
            var tarefa = _context.TarefasDbSet.ToList();
            return Ok(tarefa);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = _context.TarefasDbSet.Where(x => x.Titulo.Contains(titulo));

            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.TarefasDbSet.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = _context.TarefasDbSet.Where(x => x.Status == status);
            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.TarefasDbSet.Find(id);

            if (tarefaBanco == null)
            {
                return NotFound();
            }

            if (tarefa.Data == DateTime.MinValue)
            {
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            }
            // TODO: Atualizar as informações da variável tarefaBanco com a tarefa recebida via parâmetro
            // TODO: Atualizar a variável tarefaBanco no EF e salvar as mudanças (save changes)
            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefaBanco.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.TarefasDbSet.Update(tarefaBanco);
            _context.SaveChanges();

            return Ok(tarefaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.TarefasDbSet.Find(id);

            if (tarefaBanco == null)
            {
                return NotFound();
            }

            // TODO: Remover a tarefa encontrada através do EF e salvar as mudanças (save changes)
            _context.TarefasDbSet.Remove(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("Deletartudo")]
        public IActionResult DeletarTudo()
        {
            var tarefaBanco = _context.TarefasDbSet.ToList();

            _context.TarefasDbSet.RemoveRange(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
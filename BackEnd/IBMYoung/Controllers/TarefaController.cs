using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBMYoung.Infrastructure;
using IBMYoung.Infrastructure.ViewModel;
using IBMYoung.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBMYoung.Controllers
{
    [Produces("application/json")]
    [Route("api/Tarefa")]
    public class TarefaController : Controller
    {
        ProjectContext _Db;
        public TarefaController(ProjectContext Db)
        {
            _Db = Db;

        }

        [HttpPost]
        public Tarefa Post([FromBody] TarefaCadastroViewModel model)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.titulo = model.titulo;
            tarefa.conteudo = model.conteudo;
            tarefa.entregavel = model.entregavel;
            tarefa.nivel = model.nivel;
            tarefa.dataCriacao = DateTime.Now;
            tarefa.active = true;

            _Db.Tarefas.Add(tarefa);
            _Db.SaveChanges();

            return tarefa;
        }

        [HttpGet]
        public List<Tarefa> Get()
        {
            return _Db.tarefa.ToList();
        }

    }
}
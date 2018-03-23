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
    [Route("api/Aprendiz")]
    public class AprendizController : Controller
    {
        ProjectContext _Db;
        public AprendizController(ProjectContext Db)
        {
            _Db = Db;
        }

        [HttpPost]
        public Aprendiz Post([FromBody] AprendizCadastroViewModel model/*arquivo??*/)
        {

            Aprendiz aprendiz = new Aprendiz();
            aprendiz.nome = model.nome;
            aprendiz.sobrenome = model.sobrenome;
            aprendiz.instituicao = model.instituicao;
            aprendiz.dataEntrada = model.dataEntrada;


            _Db.Aprendizes.Add(aprendiz);
            _Db.SaveChanges();

            return aprendiz;
        }

        [HttpGet]
        public List<Aprendiz> Get()
        {
            return _Db.Aprendizes.ToList();
        }

    }
}
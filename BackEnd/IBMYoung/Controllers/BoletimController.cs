using IBMYoung.Infrastructure;
using IBMYoung.Infrastructure.ViewModel;
using IBMYoung.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Controllers
{
    public class BoletimController
    {
        ProjectContext _Db;
        public BoletimController(ProjectContext Db)
        {
            _Db = Db;
        }

        [HttpPost]
        public Boletim Post([FromBody] BoletimCadastroViewModel model)
        {
            Boletim boletim = new Boletim();
            boletim.nota = model.nota;
            boletim.frequencia = model.frequencia;
            boletim.mesReferencia = model.mesReferencia;
            boletim.anoReferencia = model.anoReferencia;

            _Db.Boletins.Add(boletim);
            _Db.SaveChanges();

            return boletim;
        }

        [HttpGet]
        public List<Boletim> Get()
        {
            return _Db.boletim.ToList();
        }

    }
}

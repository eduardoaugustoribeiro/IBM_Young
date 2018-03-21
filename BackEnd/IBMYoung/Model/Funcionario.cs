using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string nome { get; set; }
        //public Departamento departamentoId { get; set; }
        //public UnidadeIbm unidadeId { get; set; }
        public Usuario usuarioId { get; set; }
    }
}

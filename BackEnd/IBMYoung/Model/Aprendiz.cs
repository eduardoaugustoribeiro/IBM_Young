using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Aprendiz
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        //public UnidadeIbm unidade { get; set; }
        //public Departamento departamento { get; set; }
        public int nivel { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }
        public Instituicao instituicao { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual ICollection<Boletim> boletins { get; set; }
    }
}

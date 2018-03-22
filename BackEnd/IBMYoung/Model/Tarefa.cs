using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataExclusao { get; set; }
        public bool entregavel { get; set; }
        public int nivel { get; set; }
        public string conteudo { get; set; }
        public bool active { get; set; }
        public ICollection<Questao> questoes { get; set; }
        public Usuario usuario { get; set; }
        public bool multEscolha { get; set; }

    }
}

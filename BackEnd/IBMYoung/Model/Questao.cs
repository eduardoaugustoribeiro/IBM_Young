using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Questao
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public string conteudo { get; set; }
        public virtual List<Alternativa> alternativaId { get; set; }
        public Tarefa tarefaId { get; set; }
    }
}

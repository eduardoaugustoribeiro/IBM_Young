using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Alternativa
    {
        public int ID { get; set; }
        public string alternativaCorreta { get; set; }
        public Questao questaoId { get; set; }
    }
}

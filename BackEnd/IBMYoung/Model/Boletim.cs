using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Boletim
    {
        public int ID { get; set; }
        public float nota { get; set; }
        public float frequencia { get; set; }
        public DateTime dataCadastro { get; set; }
        public string mesReferencia { get; set; }
        public string observacao { get; set; }
        public int anoReferencia { get; set; }

    }
}

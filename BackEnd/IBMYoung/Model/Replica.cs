using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Replica
    {
        public int ID { get; set; }
        public string texto { get; set; }
        public DateTime dataCriacao { get; set; }
        public Topico topicoId { get; set; }
    }
}

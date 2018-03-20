using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Topico
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public string texto { get; set; }
        public DateTime dataCriacao { get; set; }
        public ICollection<Replica> replicas { get; set; }
    }
}

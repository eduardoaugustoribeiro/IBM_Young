using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Instituicao
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public ICollection<Aprendiz> Aprendizes { get; set; }

    }
}

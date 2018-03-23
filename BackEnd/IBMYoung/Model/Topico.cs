using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Topico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string titulo { get; set; }

        public string texto { get; set; }

        public DateTime dataCriacao { get; set; }

        public virtual ICollection<Replica> replicas { get; set; }
    }
}

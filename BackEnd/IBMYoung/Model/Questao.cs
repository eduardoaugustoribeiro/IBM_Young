using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Questao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string titulo { get; set; }
        public string conteudo { get; set; }
        
        [ForeignKey("tarefaid")]
        public virtual Tarefa tarefa { get; set; }
        public int tarefaid { get; set; }

        public virtual List<Alternativa> alternativaId { get; set; }
    }
}

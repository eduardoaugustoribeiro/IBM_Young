using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string titulo { get; set; }

        public DateTime dataCriacao { get; set; }

        public DateTime dataExclusao { get; set; }

        public bool entregavel { get; set; }

        public int nivel { get; set; }

        public string conteudo { get; set; }

        public bool active { get; set; }
                
        [ForeignKey("usuarioid")]
        public virtual Usuario usuario { get; set; }
        public int usuarioid { get; set; }

        public bool multEscolha { get; set; }

        public virtual ICollection<Questao> questoes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string nome { get; set; }
        //public Departamento departamentoId { get; set; }
        //public UnidadeIbm unidadeId { get; set; }

        [ForeignKey("usuarioid")]
        public virtual Usuario usuario { get; set; }
        public int usuarioid { get; set; }
    }
}

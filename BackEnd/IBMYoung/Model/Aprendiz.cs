using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Aprendiz
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string nome { get; set; }

        public string sobrenome { get; set; }
        //public UnidadeIbm unidade { get; set; }
        //public Departamento departamento { get; set; }
        public int nivel { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }

        [ForeignKey("instituicaoid")]
        public virtual Instituicao instituicao { get; set; }
        public int instituicaoid { get; set; }

        [ForeignKey("usuarioid")]
        public virtual Usuario usuario { get; set; }
        public int usuarioid { get; set; }

        public virtual ICollection<Boletim> boletins { get; set; }

        public virtual ICollection<Tarefa> tarefas { get; set; }
    }
}

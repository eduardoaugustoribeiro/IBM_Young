using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{
    public class Alternativa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int MyProperty { get; set; }
        public string textoAlternativa { get; set; }
        public bool correta { get; set; }

        [ForeignKey("questaoid")]
        public virtual Questao questao { get; set; }
        public int questaoid { get; set; }
    }
}

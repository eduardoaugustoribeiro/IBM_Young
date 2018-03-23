using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Model
{

    public class Usuario
    {
        public int Id { get; set; }
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string username { get; set; }
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string password { get; set; }
        public bool active { get; set; }
        public ICollection<Tarefa> tarefas { get; set; }
        //tipo: aprendiz,instituição, gestor ou rh
        public string tipo { get; set; }

    }
}

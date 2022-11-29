using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Web2EscuelaMVC.Validations;

namespace Web2EscuelaMVC.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Key] 
        public int EscuelaId { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        [Column(TypeName ="int")]
        [CheckValidationNumero]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Estado { get; set; }


    }
}
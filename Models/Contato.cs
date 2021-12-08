using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DataContato { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string NomePessoa { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailPessoa { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O assunto deve possuir no máximo 100 caracteres")]
        public string Assunto { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "A mensagem deve possuir no máximo 500 caracteres")]
        public string Mensagem { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        [StringLength(500)]
        public string Retorno { get; set; }
    }
}

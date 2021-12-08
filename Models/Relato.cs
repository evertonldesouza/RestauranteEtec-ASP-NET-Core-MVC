using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Relato")]
    public class Relato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "O texto deve possuir no máximo 500 caracteres")]
        public string Texto { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string NomePessoa { get; set; }

        [Required]
        [StringLength(30)]
        public string TipoPessoa { get; set; }

        [Required]
        [StringLength(200)]
        public string FotoPessoa { get; set; }

        [Required]
        public bool ExibirHome { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O titulo deve possuir no máximo 100 caracteres")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "O texto deve possuir no máximo 1000 caracteres")]
        public string Texto { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }

        [Required]
        [StringLength(200)]
        public string Foto { get; set; }
    }
}

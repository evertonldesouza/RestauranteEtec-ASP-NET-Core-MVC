using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(200)]
        public string Foto { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "O texto deve possuir no máximo 200 caracteres")]
        public string Texto { get; set; }

        [Required]
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }

        public bool ExibirHome { get; set; }

        public byte OrdemExibicao { get; set; }
    }
}

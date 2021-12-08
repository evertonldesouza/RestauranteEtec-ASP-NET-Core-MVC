using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string NomePessoa { get; set; }

        [Required]
        [StringLength(100)]
        public string EmailPessoa { get; set; }

        [Required]
        [StringLength(20)]
        public string FonePessoa { get; set; }

        [Required]
        public DateTime DataReserva { get; set; }

        [Required]
        public byte Convidados { get; set; }

        public DateTime DataCadastro { get; set; }

        public int Status { get; set; }
    }
}

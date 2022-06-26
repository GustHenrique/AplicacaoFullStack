using System.ComponentModel.DataAnnotations;

namespace AplicacaoFullStack.Models
{
    public class Cliente
    {
        [Key]

        public Guid id { get; set; }

        [Required]
        [MaxLength(45)]

        public string nome { get; set; }

        [Required]
        [MaxLength(45)]

        public string telefone { get; set; }

        [Required]
        [MaxLength(45)]
        public string email { get; set; }

        public void GenerateNewId()
        {
            id = Guid.NewGuid();
        }

    }
}

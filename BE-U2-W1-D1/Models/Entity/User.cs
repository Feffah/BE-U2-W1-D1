using System.ComponentModel.DataAnnotations;

namespace BE_U2_W1_D1.Models.Entity
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string? Nome { get; set; }

        public string? Cognome { get; set; }

        public string? Email { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BE_U2_W1_D1.Models.Entity
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string? Copertina { get; set; }
        public string? Titolo { get; set; }
        public string? Autore { get; set; }
        [Precision(18, 2)]
        public decimal Prezzo { get; set; }

    }
}

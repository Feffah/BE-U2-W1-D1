namespace BE_U2_W1_D1.Models.Entity
{
    public class Prestito
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }

        public DateTime? DataDiRiconsegna { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}

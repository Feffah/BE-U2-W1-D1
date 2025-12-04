using BE_U2_W1_D1.Models.Entity;
namespace BE_U2_W1_D1.Models.Services
{
    public class PrestitoService
    {
        private readonly ApplicationDbContext _context;
        public PrestitoService(ApplicationDbContext context) { 
        
        _context = context;

        }

        public void AddPrestito (Guid LibroId, Guid UserId)
        {

        var Prestito = new Prestito
            {
                ProductId = LibroId,
                UserId = UserId,
            DataDiRiconsegna = DateTime.Now.AddDays(30),
            };
            _context.Prestiti.Add(Prestito);
            _context.SaveChanges();

        }

    }
}

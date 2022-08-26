using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Repositories
{
    public class ProducerRepository : EntityBaseRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(AppDbContext context) : base(context) { }
     
    }
}

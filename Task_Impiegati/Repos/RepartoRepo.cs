using Task_Impiegati.Models;

namespace Task_Impiegati.Repos
{
    public class RepartoRepo : IRepo<Reparto>
    {
        private readonly TaskImpiegatiContext _context;

        public RepartoRepo(TaskImpiegatiContext ctx)
        {
            _context = ctx;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reparto> GetAll()
        {
            return _context.Repartos.ToList();
        }

        public Reparto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Reparto t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Reparto t)
        {
            throw new NotImplementedException();
        }
    }
}

using Task_Impiegati.Models;

namespace Task_Impiegati.Repos
{
    public class ImpiegatiRepo : IRepo<Impiegati>
    {
        private readonly TaskImpiegatiContext _context;

        public ImpiegatiRepo(TaskImpiegatiContext ctx)
        {
            _context = ctx;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Impiegati> GetAll()
        {
            return _context.Impiegatis.ToList();
        }

        public Impiegati? GetById(int id)
        {
            throw new NotImplementedException();
        }

        

        public bool Insert(Impiegati t)
        {
            try
            {
                _context.Impiegatis.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Update(Impiegati t)
        {
            throw new NotImplementedException();
        }
    }
}

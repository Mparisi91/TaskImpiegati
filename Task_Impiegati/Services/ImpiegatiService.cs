using Task_Impiegati.Models;
using Task_Impiegati.Repos;

namespace Task_Impiegati.Services
{
    public class ImpiegatiService
    {
        private readonly ImpiegatiRepo _repository;

        public ImpiegatiService(ImpiegatiRepo repo)
        {
            _repository = repo;
        }
        public bool InserisciImpiegato(Impiegati imp)
        {
            return _repository.Insert(imp);
        }
        public List<Impiegati> ElencoImpiegati()
        {
            return _repository.GetAll();
        }
    }
}

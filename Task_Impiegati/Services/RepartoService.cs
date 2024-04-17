using Task_Impiegati.Models;
using Task_Impiegati.Repos;

namespace Task_Impiegati.Services
{
    public class RepartoService
    {
        private readonly RepartoRepo _repository;

        public RepartoService(RepartoRepo repo)
        {
            _repository = repo;
        }

        public List<Reparto> RepartoLista()
        {
            return _repservice 
        }
        public List<Reparto> ElencoTuttiReparti()
        {
            return _repository.GetAll();
        }
    }
}

using Proyecto_BackEnd.Model;
using Proyecto_BackEnd.Repository;

namespace Proyecto_BackEnd.Service
{
    public class CallService
    {
        private readonly CallRepository _repository;

        public CallService(CallRepository repository)
        {
            _repository = repository;
        }

        public void Insert(CallModel c)
        {
            _repository.Insert(c);
        }

        public List<CallModel> GetAll()
        {
            return _repository.GetAll();
        }
    }
}

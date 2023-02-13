using Proyecto_BackEnd.Context;
using Proyecto_BackEnd.Model;

namespace Proyecto_BackEnd.Repository
{
    public class CallRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public CallRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

        public void Insert(CallModel c)
        {
            _dbContext.Calls.Add(c);
            _dbContext.SaveChanges();
        }

        public List<CallModel> GetAll()
        {
            return _dbContext.Calls.ToList();
        }
    }
}

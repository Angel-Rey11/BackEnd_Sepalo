using Proyecto_BackEnd.Context;
using Proyecto_BackEnd.Model;

namespace Proyecto_BackEnd.Repository
{
    public class CajeroRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public CajeroRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

        public void Insert(CajeroModel c)
        {
            _dbContext.Cashiers.Add(c);
            _dbContext.SaveChanges();
        }

        public List<CajeroModel> GetAll()
        {
            return _dbContext.Cashiers.ToList();
        }
    }
}

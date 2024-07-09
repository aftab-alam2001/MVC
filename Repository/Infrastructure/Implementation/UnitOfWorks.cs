using Repository.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Implementation
{
    public class UnitOfWorks : IUnitOfWorks
    {
        public ICategoryRepository Category {  get; private set; }
        private UnitofWorkDbContext _dbContext;
        public UnitOfWorks(UnitofWorkDbContext dbContext) 
        {
            _dbContext = dbContext;
            Category = new CategoryRepository(dbContext);
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}

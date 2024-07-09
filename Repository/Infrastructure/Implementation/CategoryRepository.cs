using Entities.Models;
using Repository.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Implementation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private UnitofWorkDbContext _dbContext;
        public CategoryRepository(UnitofWorkDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext; 
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

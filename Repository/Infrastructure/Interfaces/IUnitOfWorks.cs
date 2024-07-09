using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Interfaces
{
    public interface IUnitOfWorks
    {
        ICategoryRepository Category { get; }
        void SaveChanges();
    }
}

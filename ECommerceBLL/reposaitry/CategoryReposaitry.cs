using EcomerceDAL.Context;
using EcomerceDAL.Entity;
using ECommerceBLL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBLL.reposaitry
{
    public class CategoryReposaitry:GenericReposaitry<Category>,ICategoryReposaitry
    {
        public CategoryReposaitry(AppDbContext dbContext):base(dbContext)
        

        
        {

        }
    }
}

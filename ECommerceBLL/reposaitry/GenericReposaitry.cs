using EcomerceDAL.Context;
using ECommerceBLL.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBLL.reposaitry
{
    public class GenericReposaitry<T> : IGenericReposaitry<T> where T : class
    {
        private readonly AppDbContext dbcontext;

        public GenericReposaitry(AppDbContext dbcontext) {
            this.dbcontext = dbcontext;
        }
        public async Task<int> create(T entity)
        {
            dbcontext.Set<T>().Add(entity);
                return await dbcontext.SaveChangesAsync(); //return int 0 or 1
        }

        public async Task<int> Delete(T entity)
        {
            dbcontext.Set<T>().Remove(entity);
            return await dbcontext.SaveChangesAsync();
            
        }

        public async Task<T> Get(int id)
        =>await dbcontext.Set<T>().FindAsync(id);




        public async Task<IEnumerable<T>> GetAll()

         => await dbcontext.Set<T>().ToListAsync();
        

        public async Task<int> update(T entity)
        {
            dbcontext.Set<T>().Update(entity);
            return await dbcontext.SaveChangesAsync();
        }
    }
}

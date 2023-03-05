using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBLL.interfaces
{
    public interface IGenericReposaitry<T> where T :class
    {
       Task< IEnumerable<T>> GetAll();

        Task<T> Get(int id);
        Task<int> create(T entity);
        Task<int> Delete(T entity);
        Task<int> update(T entity);   

    }
}

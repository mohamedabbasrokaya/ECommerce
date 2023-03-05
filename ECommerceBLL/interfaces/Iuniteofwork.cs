using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBLL.interfaces
{
    public interface Iuniteofwork
    {
        public IProductreposaitry productreposaitry { get; set; }
        public ICategoryReposaitry categoryReposaitry { get; set; }
    }
}

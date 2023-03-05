using ECommerceBLL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBLL.reposaitry
{
    public class UniteOfWork : Iuniteofwork
    {
        //Dynamic properity signature
        public IProductreposaitry productreposaitry { get ; set ; }
        public ICategoryReposaitry categoryReposaitry { get ; set ; }

        public UniteOfWork(IProductreposaitry _productreposaitry,ICategoryReposaitry _categoryReposaitry) { 
        productreposaitry= _productreposaitry;
            categoryReposaitry= _categoryReposaitry;
        }
   
    }

}

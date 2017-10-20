using SkiWorld.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkiWorld.Data.Repositories
{
    public interface IUnitOfWorkk : IDisposable
    {
        
        
        void Commit();
       
    }

}

using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkiWorld.Data.Repositories
{
    class MatchRepository : RepositoryBase<match>, IMatchRepository
    {
        public MatchRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }

    public interface IMatchRepository : IRepositoryBase<match> { }
    
}

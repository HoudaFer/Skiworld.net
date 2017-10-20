using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiWorld.Data.Repositories
{
    public class CompetitionRepository : RepositoryBase<competition>, ICompetitionRepository
    {
        public CompetitionRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
        
    }
    public interface ICompetitionRepository : IRepositoryBase<competition>
    {

    }
}

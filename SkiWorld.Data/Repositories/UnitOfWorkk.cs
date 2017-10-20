using SkiWorld.Data;
using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiWorld.Data.Repositories
{
    public class UnitOfWorkk : IUnitOfWorkk
    {
       
         private skiworldContext dataContext;

        protected skiworldContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWorkk(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }


        //competition
        private ICompetitionRepository competitionRepository;
        public ICompetitionRepository CompetitionRepository
        {
            get { return competitionRepository = new CompetitionRepository(dbFactory); ; }
        }


        //match
        private IMatchRepository matchRepository;
        public IMatchRepository MatchRepository
        {
            get { return matchRepository = new MatchRepository(dbFactory); }

        }

        public void Dispose()
        {
            DataContext.Dispose();
        }

    }
}

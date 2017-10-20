using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkiWorld.Data.Repository.RestoRepository;

namespace SkiWorld.Data.Repository
{
    public class RestoRepository : RepositoryBase<restaurant>, IRestoRepository
    {
        public RestoRepository(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }

        public interface IRestoRepository : IRepositoryBase<restaurant>
        {

        }

    }
}

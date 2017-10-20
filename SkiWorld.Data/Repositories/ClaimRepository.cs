using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkiWorld.Data.Repository.ClaimRepository;

namespace SkiWorld.Data.Repository
{
    public class ClaimRepository : RepositoryBase<claim>, IClaimRepository
    {
        public ClaimRepository(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }

        public interface IClaimRepository : IRepositoryBase<claim>
        {

        }

    }
}

using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkiWorld.Data.Repository.WorkerRepository;

namespace SkiWorld.Data.Repository
{
        public class WorkerRepository : RepositoryBase<Worker>, IWorkerRepository
    {
            public WorkerRepository(IDatabaseFactory dbFactory) : base(dbFactory)
            {
            }

            public interface IWorkerRepository : IRepositoryBase<Worker>
            {

            }

        }
    }

using SkiWorld.Data.Infrastructure;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkiWorld.Data.Repository.MenuRepository;

namespace SkiWorld.Data.Repository
{
    public class MenuRepository : RepositoryBase<menu>, IMenuRepository
    {
        public MenuRepository(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }

        public interface IMenuRepository : IRepositoryBase<menu>
        {

        }

    }

}
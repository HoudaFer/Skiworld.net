using SkiWorld.Data;
using SkiWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiWorld.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private skiworldContext dataContext;
        public skiworldContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new skiworldContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}

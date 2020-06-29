using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.DataAccessLayer
{
    public class RepositoryBase
    {
        protected static DataContext db;
        private static object _lock = new object();

        public RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (db == null)
            {
                lock (_lock)
                {
                    if (db == null)
                    {
                        db = new DataContext();
                    }
                }
            }
        }
    }
}

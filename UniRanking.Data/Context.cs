using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UniRanking.Data
{
    public class Context: DbContext
    {
        public DbSet<RatingData> Ratings { get; set; }
        public DbSet<UniversitysInfo> Univesities { get; set; }
        public DbSet<Country> Countries { get; set; }

        public Context() : base("localsql")
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simbirsoft
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Word> Words { get; set; }

        public ApplicationContext()
            : base("DbConnection")
        {
            Words.RemoveRange(Words);
            SaveChanges();
        }
    }
}

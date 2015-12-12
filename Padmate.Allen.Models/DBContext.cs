using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.Models
{
    public class DBContext:DbContext
    {
        public DbSet<Singer> Singer { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Song> Song { get; set; }

    }
}

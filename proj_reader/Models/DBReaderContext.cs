using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Models
{
    public partial class DBReaderContext : DbContext
    {
        public DBReaderContext() : base("name=DBEntityReader")
        {

        }
        public DbSet<Note> tbNotes { get; set; }
        public DbSet<Kind> tbKinds { get; set; }

        public DbSet<Link> tbLinks { get; set; }
    }
}

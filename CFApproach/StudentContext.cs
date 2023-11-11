using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFApproach
{
    internal class StudentContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Student>().ToTable("Student");
        }
        public DbSet<Student> Students { get; set; }
    }
}

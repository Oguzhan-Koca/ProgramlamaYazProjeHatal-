using Microsoft.EntityFrameworkCore;
using ProgramlamaYazProje_Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaYazProje_DataAccsess.Data
{
    public class DatabaseContext:DbContext { 
 
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options) 
        { }
        public DbSet<Animal> hayvanCesits { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

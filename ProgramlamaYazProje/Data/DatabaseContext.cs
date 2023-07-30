﻿using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaYazProje
{
    public class DatabaseContext:DbContext { 
 
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options) 
        { }
        
        public DbSet<User> Users { get; set; }
    }
}

using CME.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CME.EntityFramework
{
   public class ResolutionDBContext: DbContext

    {
        public ResolutionDBContext(DbContextOptions options)
    : base(options)
        {
        }

        public DbSet<ResolutionTypes> ResolutionTypes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_aplikacja_webowa.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzz_aplikacja_webowa.Data
{
    public class LiczbaContext : DbContext
    {
        public LiczbaContext(DbContextOptions options) : base(options) { }
        public DbSet<Class> Class { get; set; }
    }
}

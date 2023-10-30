using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Diaconu_Andreea_Lab2.Models;

namespace Diaconu_Andreea_Lab2.Data
{
    public class Diaconu_Andreea_Lab2Context : DbContext
    {
        public Diaconu_Andreea_Lab2Context (DbContextOptions<Diaconu_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Diaconu_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Diaconu_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sastras_Alina_Lab2.Models;

namespace Sastras_Alina_Lab2.Data
{
    public class Sastras_Alina_Lab2Context : DbContext
    {
        public Sastras_Alina_Lab2Context (DbContextOptions<Sastras_Alina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sastras_Alina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sastras_Alina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Sastras_Alina_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Sastras_Alina_Lab2.Models.Category> Category { get; set; } = default!;
    }
}

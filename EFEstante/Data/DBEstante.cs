using EFEstante.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEstante.Data
{
    public class DBEstante : DbContext
    {
        public DbSet<Autor> Autors { get; set; } = null!;

        public DbSet<Livro> Livros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-PQ0V2OD3\SQLEXPRESS;Initial Catalog=DBEstante;Integrated Security=True;
            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}

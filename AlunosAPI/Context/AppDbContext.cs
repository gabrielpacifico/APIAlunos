using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Gabriel Pacífico",
                    Email = "gabrielpacifico.dev@gmail.com",
                    Idade = 19
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "João Pedro",
                    Email = "joaopedro30@gmail.com",
                    Idade = 24
                }
               );
        }
    }
}

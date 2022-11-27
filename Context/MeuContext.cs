using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTeste.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTeste.Context
{
    public class MeuContext : DbContext
    {
        public MeuContext(DbContextOptions<MeuContext> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }

}
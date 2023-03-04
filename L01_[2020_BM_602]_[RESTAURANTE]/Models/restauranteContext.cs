using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using webApiPractica.Models;

namespace L01__2020_BM_602___RESTAURANTE_.Models
{
    public class restauranteContext : DbContext
    {
        public restauranteContext(DbContextOptions<restauranteContext> options) : base(options)
        {

        }
        public DbSet<restaurante> equipos { get; set; }
    }
}

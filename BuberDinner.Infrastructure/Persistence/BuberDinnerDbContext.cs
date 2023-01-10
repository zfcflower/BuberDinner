using System.Reflection;

using BuberDinner.Domain.MenuAggregate;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BuberDinner.Infrastructure.Persistence;

public class BuberDinnerDbContext  : DbContext
{
    public BuberDinnerDbContext(DbContextOptions<BuberDinnerDbContext> options)
        : base(options)
    {

    }

    public DbSet<Menu> Menus { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BuberDinnerDbContext).Assembly);
        /*modelBuilder.Model.GetEntityTypes()
            .SelectMany(m=>m.GetProperties())
            .Where(t=>t.IsPrimaryKey())
            .ToList()
            .ForEach(x=>x.ValueGenerated = ValueGenerated.Never);*/
        base.OnModelCreating(modelBuilder);
    }
}
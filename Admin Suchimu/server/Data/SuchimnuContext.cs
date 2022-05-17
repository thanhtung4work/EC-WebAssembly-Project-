using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Admin.Models.Suchimnu;

namespace Admin.Data
{
  public partial class SuchimnuContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public SuchimnuContext(DbContextOptions<SuchimnuContext> options):base(options)
    {
    }

    public SuchimnuContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .HasOne(i => i.Category)
              .WithMany(i => i.Games)
              .HasForeignKey(i => i.CategoryId)
              .HasPrincipalKey(i => i.Id);
        builder.Entity<Admin.Models.Suchimnu.Game>()
              .HasOne(i => i.Studio)
              .WithMany(i => i.Games)
              .HasForeignKey(i => i.StudioId)
              .HasPrincipalKey(i => i.Id);


        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.CreateDate)
              .HasColumnType("datetime2");

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.LatestUpdate)
              .HasColumnType("datetime2");

        builder.Entity<Admin.Models.Suchimnu.Stat>()
              .Property(p => p.LastVisit)
              .HasColumnType("datetime2");

        builder.Entity<Admin.Models.Suchimnu.Category>()
              .Property(p => p.Id)
              .HasPrecision(10, 0);

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.Id)
              .HasPrecision(10, 0);

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.Price)
              .HasPrecision(53, 0);

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.OriginalPrice)
              .HasPrecision(53, 0);

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.CategoryId)
              .HasPrecision(10, 0);

        builder.Entity<Admin.Models.Suchimnu.Game>()
              .Property(p => p.StudioId)
              .HasPrecision(10, 0);

        builder.Entity<Admin.Models.Suchimnu.Stat>()
              .Property(p => p.Id)
              .HasPrecision(10, 0);

        builder.Entity<Admin.Models.Suchimnu.Stat>()
              .Property(p => p.Visits)
              .HasPrecision(10, 0);

        builder.Entity<Admin.Models.Suchimnu.Studio>()
              .Property(p => p.Id)
              .HasPrecision(10, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<Admin.Models.Suchimnu.Category> Categories
    {
      get;
      set;
    }

    public DbSet<Admin.Models.Suchimnu.Game> Games
    {
      get;
      set;
    }

    public DbSet<Admin.Models.Suchimnu.Stat> Stats
    {
      get;
      set;
    }

    public DbSet<Admin.Models.Suchimnu.Studio> Studios
    {
      get;
      set;
    }
  }
}

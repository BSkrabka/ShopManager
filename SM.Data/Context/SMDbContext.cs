using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SM.Data.Models.Common;
using SM.Data.Models.Shop;
using System.Linq.Expressions;
using SM.Data.Models;

namespace SM.Data.Context;

public class SMDbContext : DbContext
{
    public SMDbContext(DbContextOptions<SMDbContext> options) : base(options)
    {
    }

    public DbSet<Contrahent> Contrahents { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<VatValue> VatValues { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ApplyQueryFilters(modelBuilder);
    }

    protected void ApplyQueryFilters(ModelBuilder modelBuilder)
    {
        Expression<Func<BaseEntity, bool>> softDeleteFilterExpr = entity => !entity.DeletedAt.HasValue;

        var types = modelBuilder.Model.GetEntityTypes();
        foreach (var mutableType in modelBuilder.Model.GetEntityTypes())
        {
            if (mutableType.ClrType.IsAssignableTo(typeof(BaseEntity)))
            {
                var parameter = Expression.Parameter(mutableType.ClrType);
                var body = ReplacingExpressionVisitor.Replace(softDeleteFilterExpr.Parameters.First(), parameter, softDeleteFilterExpr.Body);
                var lambda = Expression.Lambda(body, parameter);

                mutableType.SetQueryFilter(lambda);
            }
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateSoftDeleteStatus();
        return base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
        UpdateSoftDeleteStatus();
        return base.SaveChanges();
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        UpdateSoftDeleteStatus();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        UpdateSoftDeleteStatus();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    private void UpdateSoftDeleteStatus()
    {
        foreach (var entry in ChangeTracker.Entries())
        {
            if (entry.Entity is BaseEntity)
            {
                var baseEntity = entry.Entity as BaseEntity;

                if (entry.State == EntityState.Added)
                {
                    baseEntity.CreatedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    baseEntity.ModifiedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    baseEntity.DeletedAt = DateTime.Now;
                }
            }
        }
    }
}


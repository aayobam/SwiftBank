using Microsoft.EntityFrameworkCore;
using SwiftBank.Domain.Entities;
using SwiftBank.Domain.Entities.Common;

namespace SwiftBank.Persistence.DatabaseContexts;

public class SwiftBankDbContext:DbContext
{
    public SwiftBankDbContext(DbContextOptions<SwiftBankDbContext> options): base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Loan> Loans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SwiftBankDbContext).Assembly);

        modelBuilder.Entity<User>().HasData(new List<User>()
        {
            new User(){FirstName = "firstname", LastName = "lastname"},
            new User(){FirstName = "firstname", LastName = "lastname"},
            new User(){FirstName = "firstname", LastName = "lastname"},
            new User(){FirstName = "firstname", LastName = "lastname"},
        });
        
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                     .Where(q=>q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.DateModified = DateTime.Now;
            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}

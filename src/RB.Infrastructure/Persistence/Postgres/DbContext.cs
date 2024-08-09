namespace RB.Infrastructure.Persistence.Postgres;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions options) : base(options)
  {
  }
}

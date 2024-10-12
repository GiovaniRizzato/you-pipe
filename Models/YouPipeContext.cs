using Microsoft.EntityFrameworkCore;

namespace YouPipe.Models;

public class YouPipeContext : DbContext
{
    public YouPipeContext(DbContextOptions<YouPipeContext> options)
        : base(options)
    {
    }

    public DbSet<Video> Videos { get; set; } = null!;
}
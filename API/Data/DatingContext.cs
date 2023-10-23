using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DatingContext : DbContext
{
    public DatingContext(DbContextOptions<DatingContext> options) :base(options)
    {
        
    }
    public DbSet<AppUser> Users {get; set;}
}

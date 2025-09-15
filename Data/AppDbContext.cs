using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : AppDbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
using Microsoft.EntityFrameworkCore;
using SecondByksWebsite.Models;

public class SecondBykzDbContext : DbContext

    
{
    public SecondBykzDbContext(DbContextOptions<SecondBykzDbContext> options) : base(options)
    {

    }

    public DbSet<Bike> Bikes { get; set; }

    }


using GAF.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GAF.API.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : 
        base(options)
    {
    } 

    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Report> Reports { get; set; }       
}

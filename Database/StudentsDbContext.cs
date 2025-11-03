using EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.Database;

public class StudentsDbContext:DbContext
{
    public StudentsDbContext():base()
    {
    }

    public DbSet<Students> Students { get; set; }

    public DbSet<Subject> Subjects { get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentsStorage;Integrated Security=True");
    }
}

using Microsoft.EntityFrameworkCore;

namespace EF.Database;

public class StudentsDbContext:DbContext
{
    public StudentsDbContext():base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentsStorage;Integrated Security=True");
    }
}

using Microsoft.EntityFrameworkCore;
using WebApplicationStudy.Models;

namespace WebApplicationStudy.Contexts
{
  public class StudentContext : DbContext
  {
    public StudentContext(DbContextOptions<StudentContext> options) : base(options)
    {

    }
    public DbSet<Student> Students { get; set; }
  }
}
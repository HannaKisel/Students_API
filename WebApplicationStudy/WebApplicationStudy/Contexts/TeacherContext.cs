using Microsoft.EntityFrameworkCore;
using WebApplicationStudy.Models;

namespace WebApplicationStudy.Contexts
{
  public class TeacherContext : DbContext
  {
    public TeacherContext(DbContextOptions<TeacherContext> options) : base(options)
    {

    }
    public DbSet<Teacher> Teachers { get; set; }
  }
}
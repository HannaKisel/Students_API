using System.Data.Entity;

namespace MyStudentsAPI.Models
{
  public class StudentContext : DbContext
  {
    public DbSet<Student> Students { get; set; }
  }
}
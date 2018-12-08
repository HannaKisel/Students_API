using Microsoft.EntityFrameworkCore;

namespace WebApplicationStudy.Data
{
  public class ToDoContext : DbContext
  {
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {

    }      
    public DbSet<ToDo> ToDos { get; set; }//list todos
  }
}
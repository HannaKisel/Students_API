namespace Repositories.Models
{
  public class Student : Person
  {
    public int Id { get; set; }

    public int Teacher_id { get; set; }
  }
}
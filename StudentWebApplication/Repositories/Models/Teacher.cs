using System.Collections.Generic;

namespace Repositories.Models
{
  public class Teacher : Person
  {
    public string JobFaculty { get; set; }

    public /*virtual*/ List<int> StudentsId { get; set; }

    public int Id { get; set; }

    public Teacher()
    {
      StudentsId = new List<int>();
    }
  }
}
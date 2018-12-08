using System.Collections.Generic;
namespace MyStudentsAPI.Models
{
  public class Teacher 
  {
    public string FirstName { get; set; }

    public string SecondName { get; set; }

    public string MiddleName { get; set; }

    public string JobFaculty { get; set; }

    public List<Student> CourseworkStudents { get; set; }
  }
}
namespace StudentsAPI.Models
{
  public class Teacher
  {
    public string JobFaculty { get; set; }
    public List<Student> CourseworkStudents { get; set; }

    public Teacher(string firstName, string secondName, string middleName) : base(firstName, secondName, middleName)
    {

    }
  }
}
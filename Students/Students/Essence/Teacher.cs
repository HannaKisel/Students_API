using System.Collections.Generic;

namespace Students.Essence
{
  class Teacher : Person
  {
    public string JobFaculty { get; set; }
    public List<Student> CourseworkStudents { get; set; }

    public Teacher(string firstName, string secondName, string middleName) : base(firstName, secondName, middleName)
    {

    }

    //public Teacher(string firstName, string secondName, string middleName, string jobFaculty, List<Student> courseworkStudents)
    //  : base(firstName, secondName, middleName)
    //{
    //  JobFaculty = jobFaculty;
    //  CourseworkStudents = courseworkStudents;
    //}
  }
}
namespace Students
{
  /// <summary>
  /// this class is the essence of the student
  /// </summary>
  class Student : Person
  {
    public string Gender { get; set; }
    public string BirthDate { get; set; }
    public bool HasPrivileges { get; set; }
    public string Status { get; set; }
    public string ResidencePlace { get; set; }
    public Faculty Faculty { get; set; }
    public string Specialty { get; set; }
    public int Course { get; set; }
    public string EducationForm { get; set; }
    public Group Group { get; set; }
    public double LastSessionMark { get; set; }
    public int ScholarshipSize { get; set; }
    public Teacher CourseworkTeacher { get; set; }
    public int EntityType { get; set; }
    public string Title { get; set; }
    public string URLToAvatar { get; set; }

    public Student(string firstName, string secondName, string middleName, string gender, string birthDate, bool priveleges,
      string status, string residencePlace, string facultyName, string displayFacultyName, string specialty,
      int course, string educationForm, string groupName, double lastSessionMark, int scholarshipSize,
      string teachersFirstName, string teachersSecondName, string teachersMiddleName, int entityType,
      string title, string urlToAvatar) : base(firstName, secondName, middleName)
    {
      BirthDate = birthDate;
      Course = course;
      Faculty = new Faculty(facultyName, displayFacultyName);
      CourseworkTeacher = new Teacher(teachersFirstName, teachersSecondName, teachersMiddleName);
      EntityType = entityType;
      Gender = gender;
      Group = new Group(groupName);
      HasPrivileges = priveleges;
      LastSessionMark = lastSessionMark;
      ResidencePlace = residencePlace;
      ScholarshipSize = scholarshipSize;
      Specialty = specialty;
      Status = status;
      EducationForm = educationForm;
      Title = title;
      URLToAvatar = urlToAvatar;
    }
  }
}
namespace Students.Entities
{
  abstract class Person
  {
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string MiddleName { get; set; }

    public Person(string firstName, string secondName, string middleName)
    {
      FirstName = firstName;
      SecondName = secondName;
      MiddleName = middleName;
    }
  }
}
namespace StudentWebApplication.Models
{
  public class Faculty// добавить репозиторий к каждой сушности. 
    //
  {
    public string Name { get; set; }

    public string DisplayName { get; set; }

    public int FacultyId { get; set; }

    public Faculty(string name, string displayName, int id)
    {
      Name = name;
      DisplayName = displayName;
      FacultyId = id;
    }
  }
}
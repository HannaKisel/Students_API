namespace Students.Entities
{
  /// <summary>
  /// this class is the essence of the faculty
  /// </summary>
  public class Faculty
  {
    public string Name { get; set; }
    public string DisplayName { get; set; }

    public Faculty(string name, string displayName)
    {
      Name = name;
      DisplayName = displayName;
    }
  }
}
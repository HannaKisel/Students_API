namespace MyStudentsAPI.Models
{
  public class Group
  {
    public string GroupName { get; set; }

    public Group(string name)
    {
      GroupName = name;
    }
  }
}
namespace Students.Entities
{
  /// <summary>
  /// this class is the essence of the group
  /// </summary>
  class Group
  {
    public string GroupName { get; set; }

    public Group(string groupName)
    {
      GroupName = groupName;
    }
  }
}
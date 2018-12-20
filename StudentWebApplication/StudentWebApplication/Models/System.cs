namespace StudentWebApplication.Models
{
  public class System
  {
    public int NumberOfAvailablePlacesInHostel { get; set; }

    public System(int numberOfAvailablePlacesInHostel)
    {
      NumberOfAvailablePlacesInHostel = numberOfAvailablePlacesInHostel;
    }
  }
}
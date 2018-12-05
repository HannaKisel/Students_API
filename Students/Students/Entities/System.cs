namespace Students.Entities
{
  class System
  {
    public int NumberOfAvailablePlacesInHostel { get; set; }

    public System(int numberOfAvailablePlacesInHostel)
    {
      NumberOfAvailablePlacesInHostel = numberOfAvailablePlacesInHostel;
    }
  }
}
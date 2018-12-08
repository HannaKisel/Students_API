namespace MyStudentsAPI.Models
{
  public class Discipline
  {
    /// <summary>
    /// this class is the essence of the discipline
    /// </summary>
    public string DisciplineName { get; set; }

    public string Teacher { get; set; }

    public int[] Coefficients { get; set; }

    public string Faculty { get; set; }

    public string Specialty { get; set; }

    public int Course { get; set; }
  }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Models
{
  /// <summary>
  /// this class is the essence of the discipline
  /// </summary>
  public class Discipline
  {
    public string DisciplineName { get; set; }

    public Teacher Teacher { get; set; }
    
    public int[] Coefficients { get; set; }

    public string Faculty { get; set; }

    public string Specialty { get; set; }

    public int Course { get; set; }

    //public Discipline(string disciplineName, string teacher, int[] coefficients, string faculty, string specialty, int course)
    //{
    //  DisciplineName = disciplineName;
    //  Teacher = teacher;
    //  Coefficients = coefficients;
    //  Faculty = faculty;
    //  Specialty = specialty;
    //  Course = course;
    //}
  }
}

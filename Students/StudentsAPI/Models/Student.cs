﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Models
{
  public class Student
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
  }
}
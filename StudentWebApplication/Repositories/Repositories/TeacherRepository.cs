using System;
using System.Collections.Generic;
using Repositories.Models;

namespace Repositories.Repositories
{
  public class TeacherRepository<T> : IRepository<Teacher>
  {
    public static readonly List<Teacher> _teachers = new List<Teacher>() {
        new Teacher { FirstName = "Valentin", SecondName = "Melnikov", MiddleName = "Mihailovich?", JobFaculty = "RFICT", Id = 1 },
        new Teacher { FirstName = "?", SecondName = "Kizim", MiddleName = "?", JobFaculty = "RFICT", Id = 2 },
      };

    static private int _last_id = 3;

    public int Add(Teacher obj)
    {
      obj.Id = _last_id;
      _teachers.Add(obj);
      _last_id++;
      return obj.Id;
    }

    public void Delete(Predicate<Teacher> match)
    {
      _teachers.RemoveAll(match);
    }

    public Teacher Find(int id)
    {
      return _teachers.Find(s => s.Id == id);
    }

    public IEnumerable<Teacher> GetAll(Predicate<Teacher> match)
    {
      return _teachers.FindAll(match);
    }

    public IEnumerable<Teacher> GetAll()
    {
      return _teachers;
    }

    public void Update(Teacher obj)
    {
      var teacher = Find(obj.Id);
      if (teacher != null)
      {
        if (obj.FirstName != null)
        {
          teacher.FirstName = obj.FirstName;
        }
        if (obj.SecondName != null)
        {
          teacher.SecondName = obj.SecondName;
        }
        if (obj.MiddleName != null)
        {
          teacher.MiddleName = obj.MiddleName;
        }
      }
    }
  }
}
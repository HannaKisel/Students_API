using System;
using System.Collections.Generic;
using Repositories.Models;

namespace Repositories.Repositories
{
  public class StudentRepository<T> : IRepository<Student>
  {
    public static /*readonly*/ List<Student> _students = new List<Student>() {
        new Student { FirstName = "Olga", SecondName = "Nechay", MiddleName = "Sergeevna", Id = 1 },
        new Student { FirstName = "Andrei", SecondName = "Sushko", MiddleName = "Aleksandrovich", Id = 2 },
      };

    static private int _last_id = 3;

    public int Add(Student obj)
    {
      obj.Id = _last_id;
      _students.Add(obj);
      _last_id++;
      return obj.Id;
    }

    public void Delete(Predicate<Student> match)
    {
      _students.RemoveAll(match);
    }

    public Student Find(int id)
    {
      return _students.Find(s => s.Id == id);
    }

    public IEnumerable<Student> GetAll(Predicate<Student> match)
    {
      return _students.FindAll(match);
    }

    public IEnumerable<Student> GetAll()
    {
      return _students;
    }

    public void Update(Student obj)
    {
      var student = Find(obj.Id);
      if (student != null)
      {
        if (obj.FirstName != null)
        {
          student.FirstName = obj.FirstName;
        }
        if (obj.SecondName != null)
        {
          student.SecondName = obj.SecondName;
        }
        if (obj.MiddleName != null)
        {
          student.MiddleName = obj.MiddleName;
        }
      }
    }
  }
}

using MyStudentsAPI.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;

namespace MyStudentsAPI.Controllers
{
  public class ValuesController : ApiController
  {
    StudentContext db = new StudentContext();

    // GET api/values
    
    public IEnumerable<Student> GetStudents()
    {
      return db.Students;
      // return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    public Student GetStudent(int id)
    {
      Student student = db.Students.Find(id);
      return student;
    }

    [HttpPost]
    public void CreateStudent([FromBody]Student student)
    {
      db.Students.Add(student);
      db.SaveChanges();
    }

    [HttpPut]
    public void EditStudent(int id, [FromBody]Student student)
    {

      if (id == student.Id)
      {
        db.Entry(student).State = EntityState.Modified;

        db.SaveChanges();
      }
    }

    // DELETE api/values/5
    public void DeleteStudent(int id)
    {
      Student student = db.Students.Find(id);
      if (student != null)
      {
        db.Students.Remove(student);
        db.SaveChanges();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        db.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
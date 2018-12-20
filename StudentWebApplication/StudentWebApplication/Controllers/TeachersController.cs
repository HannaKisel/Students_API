using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Repositories;
using Repositories.Models;
using Repositories.Repositories;

namespace StudentWebApplication.Controllers
{
  public class TeachersController : ApiController
  {
    private readonly IRepository<Teacher> teachersRepo = new TeacherRepository<Teacher>();

    // GET: api/Teachers
    //[HttpGet]
    public IEnumerable<Teacher> GetTeachers()
    {
      return teachersRepo.GetAll();
    }

    //GET: api/Teachers/5
    [ResponseType(typeof(Teacher))]
    public IHttpActionResult GetById(int id)
    {
      IEnumerable<Teacher> teachers = teachersRepo.GetAll(teacher => teacher.Id == id);
      if (teachers.Count() == 0)
      {
        return NotFound();
      }
      return Ok(teachers);
    }

    //GET: api/teachers?SecondName=Nechay
    [ResponseType(typeof(Teacher))]
    public IHttpActionResult GetBySecondName(string secondName)
    {
      IEnumerable<Teacher> teachers = teachersRepo.GetAll(teacher => teacher.SecondName == secondName);
      if (teachers.Count() == 0)
      {
        return NotFound();
      }
      return Ok(teachers);
    }

    [ResponseType(typeof(void))]
    public IHttpActionResult PutTeacher(int id, Student student)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (teachersRepo.GetAll(t => t.Id == id) == null)
      {
        return NotFound();
      }

      Teacher teacher = teachersRepo.GetAll(t => t.Id == id).First();
      Decanat.AddCourseworkTeacherToStudent(student, teacher);

      return Ok(teacher);
    }

    [ResponseType(typeof(void))]
    public IHttpActionResult PutTeacher(Teacher teacher)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (teachersRepo.GetAll(t => t.Id == teacher.Id) == null)
      {
        return NotFound();
      }

      teachersRepo.Update(teacher);

      return Ok(teachersRepo.GetAll());
    }

    //// GET: api/StudentsTeacher/5
    //[ResponseType(typeof(Student))]
    //public IHttpActionResult GetStudentTeacher(int id)
    //{
    //  Student student = db.Students.Include(x => x.CourseWorkTeacher()).Find(id);
    //  if (student == null)
    //  {
    //    return NotFound();
    //  }

    //  return Ok(student);
    //}




    // POST: api/Students
    [ResponseType(typeof(Teacher))]
    public IHttpActionResult PostTeacher(Teacher teacher)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      teachersRepo.Add(teacher);

      return Ok(teachersRepo.GetAll());
    }
    
    // DELETE: api/Teachers/5
    [ResponseType(typeof(Teacher))]
    public IHttpActionResult DeleteTeacher(int id)
    {
      IEnumerable<Teacher> teachers = teachersRepo.GetAll(teacher => teacher.Id == id);
      if (teachers == null)
      {
        return NotFound();
      }
      Decanat.DeleteTeacherFromStudents(id);
      teachersRepo.Delete(teacher => teacher.Id == id);

      return Ok(teachers);
    }

    //// DELETE: api/Teachers/SecondName
    ////api/teachers?SecondName=Nechay
    //[ResponseType(typeof(Teacher))]
    //public IHttpActionResult DeleteBySecondName(string secondName)
    //{
    //  IEnumerable<Teacher> teachers = teachersRepo.GetAll(teacher => teacher.SecondName == secondName);
    //  if (teachers == null)
    //  {
    //    return NotFound();
    //  }
    //  teachersRepo.Delete(teacher => teacher.SecondName == secondName);
    //  return Ok(teachers);
    //}
    //    private UniversityContext db = new UniversityContext();

    //    // GET: api/Teachers
    //    public IEnumerable<Teacher> GetTeachers()
    //    {
    //      //List<Teacher> teachers = db.Teachers.Include(x => x.Students).ToList();
    //      //return db.Teachers.Include(x => x.Students).ToList();
    //      return db.Teachers;
    //    }

    //    // GET: api/Teachers/5
    //    [ResponseType(typeof(Teacher))]
    //    public IHttpActionResult GetTeacher(int id)
    //    {
    //      //Teacher teacher = db.Teachers.Find(id);
    //      var teacher = db.Teachers.Include(x => x.Students).SingleOrDefault(x => x.TeacherId == id);
    //      if (teacher == null)
    //      {
    //        return NotFound();
    //      }

    //      return Ok(teacher);
    //    }

    //    // PUT: api/Teachers/5
    //    [ResponseType(typeof(void))]
    //    public IHttpActionResult PutTeacher(int id, Teacher teacher)
    //    {
    //      if (!ModelState.IsValid)
    //      {
    //        return BadRequest(ModelState);
    //      }

    //      if (id != teacher.TeacherId)
    //      {
    //        return BadRequest();
    //      }

    //      db.Entry(teacher).State = EntityState.Modified;

    //      try
    //      {
    //        db.SaveChanges();
    //      }
    //      catch (DbUpdateConcurrencyException)
    //      {
    //        if (!TeacherExists(id))
    //        {
    //          return NotFound();
    //        }
    //        else
    //        {
    //          throw;
    //        }
    //      }

    //      return StatusCode(HttpStatusCode.NoContent);
    //    }

    //    // POST: api/Teachers
    //    [ResponseType(typeof(Teacher))]
    //    public IHttpActionResult PostTeacher(Teacher teacher)
    //    {
    //      if (!ModelState.IsValid)
    //      {
    //        return BadRequest(ModelState);
    //      }

    //      db.Teachers.Add(teacher);
    //      db.SaveChanges();

    //      return CreatedAtRoute("DefaultApi", new { id = teacher.TeacherId }, teacher);
    //    }

    //    // DELETE: api/Teachers/5
    //    [ResponseType(typeof(Teacher))]
    //    public IHttpActionResult DeleteTeacher(int id)
    //    {
    //      Teacher teacher = db.Teachers.Find(id);
    //      if (teacher == null)
    //      {
    //        return NotFound();
    //      }

    //      db.Teachers.Remove(teacher);
    //      db.SaveChanges();

    //      return Ok(teacher);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //      if (disposing)
    //      {
    //        db.Dispose();
    //      }
    //      base.Dispose(disposing);
    //    }

    //    private bool TeacherExists(int id)
    //    {
    //      return db.Teachers.Count(e => e.TeacherId == id) > 0;
    //    }
  }
}
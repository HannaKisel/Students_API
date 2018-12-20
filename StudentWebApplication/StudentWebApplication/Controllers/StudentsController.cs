using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Repositories.Repositories;
using Repositories.Models;
using Repositories;

namespace StudentWebApplication.Controllers
{
  public class StudentsController : ApiController
  {
    private readonly IRepository<Student> studentsRepo = new StudentRepository<Student>();

    // GET: api/Students
    //[HttpGet]
    public IEnumerable<Student> GetStudents()
    {
      return studentsRepo.GetAll();
    }

    //GET: api/Students/5
    [ResponseType(typeof(Student))]
    public IHttpActionResult GetById(int id)
    {
      IEnumerable<Student> students = studentsRepo.GetAll(student => student.Id == id);
      if (students.Count() == 0)
      {
        return NotFound();
      }

      return Ok(students);
    }

    //GET: api/students?SecondName=Nechay
    [ResponseType(typeof(Student))]
    public IHttpActionResult GetBySecondName(string secondName)
    {
      IEnumerable<Student> students = studentsRepo.GetAll(student => student.SecondName == secondName);
      if (students.Count() == 0)
      {
        return NotFound();
      }
      return Ok(students);
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

    //PUT: api/Students/5
    [ResponseType(typeof(void))]
    public IHttpActionResult PutStudent(int id, Teacher teacher)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (studentsRepo.GetAll(s => s.Id == id) == null)
      {
        return NotFound();
      }

      Student student = studentsRepo.GetAll(s => s.Id == id).First();
      Decanat.AddCourseworkTeacherToStudent(student, teacher);

      return Ok(student);
    }

    [ResponseType(typeof(void))]
    public IHttpActionResult PutStudent(Student student)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (studentsRepo.GetAll(s => s.Id == student.Id) == null)
      {
        return NotFound();
      }

      studentsRepo.Update(student);
      
      return Ok(studentsRepo.GetAll());
    }


    // POST: api/Students
    [ResponseType(typeof(Student))]
    public IHttpActionResult PostStudent(Student student)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      studentsRepo.Add(student);

      return Ok(studentsRepo.GetAll()); // return CreatedAtRoute("DefaultApi", new { id = student.StudentId }, student);
    }

    // DELETE: api/Students/5
    [ResponseType(typeof(Student))]
    public IHttpActionResult DeleteStudent(int id)
    {
      IEnumerable<Student> students = studentsRepo.GetAll(student => student.Id == id);
      if (students == null)
      {
        return NotFound();
      }
      Decanat.DeleteStudentFromTeacher(id);
      studentsRepo.Delete(student => student.Id == id);

      return Ok(students);
    }

    // DELETE: api/Students/SecondName
    //api/students?SecondName=Nechay
    //[ResponseType(typeof(Student))]
    //public IEnumerable<Student> DeleteStudent(string secondName)
    //{
    //  IEnumerable<Student> currentStudents = studentsRepo.GetAll(student => student.SecondName == secondName);
    //  //if (currentStudents == null)
    //  //{
    //  //  return NotFound();
    //  //}
    //  //if (TeacherRepository<Teacher>._teachers.Select(p => p.StudentsId.Contains(students.First().Id)).First())
    //  //{
    //  //  TeacherRepository<Teacher>._teachers.Where(p => p.StudentsId.Contains(students.First().Id)).First().StudentsId.Remove(students.First().Id);
    //  //}
    //  studentsRepo.Delete(student => student.SecondName == secondName);
    //  //Decanat.DeleteCoursworkTeacherFromStudent(currentStudents.First(), TeacherRepository<Teacher>._teachers.Where(p => p.StudentsId.Contains(currentStudents.First().Id)).First());

    //  return studentsRepo.GetAll();//Ok(studentsRepo.GetAll);
    //}
  }
}
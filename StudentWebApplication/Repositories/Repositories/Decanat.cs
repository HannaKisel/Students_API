using Repositories.Models;
using System.Linq;

namespace Repositories.Repositories
{
  public static class Decanat
  {
    public static void AddCourseworkTeacherToStudent(Student student, Teacher teacher)
    {
      if (!TeacherRepository<Teacher>._teachers.Where(t => t.Id == teacher.Id).First().StudentsId.Contains(student.Id))
      {
        TeacherRepository<Teacher>._teachers.Find(t => t.Id == teacher.Id).StudentsId.Add(student.Id);
        StudentRepository<Student>._students.Find(s => s.Id == student.Id).Teacher_id = teacher.Id;
        if (TeacherRepository<Teacher>._teachers.Where(t => t.Id != teacher.Id).Select(p => p.StudentsId.Contains(student.Id)).First())
        {
          TeacherRepository<Teacher>._teachers.Where(t => t.Id != teacher.Id).Where(p => p.StudentsId.Contains(student.Id)).First().StudentsId.Remove(student.Id);
        }
      }
    }

    public static void DeleteStudentFromTeacher(int studentId)
    {
      if (TeacherRepository<Teacher>._teachers.Any(p => p.StudentsId.Contains(studentId)))
      {
        TeacherRepository<Teacher>._teachers.Find(p => p.StudentsId.Contains(studentId)).StudentsId.Remove(studentId);
      }
    }

    public static void DeleteTeacherFromStudents(int teacherId)
    {
      if (StudentRepository<Student>._students.Any(s => s.Teacher_id == teacherId))
      {
        StudentRepository<Student>._students.Where(s => s.Teacher_id == teacherId).ToList().ForEach(p => p.Teacher_id = 0);
      }
    }
  }
}
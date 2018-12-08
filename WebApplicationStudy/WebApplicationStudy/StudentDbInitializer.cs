//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using WebApplicationStudy.Contexts;
//using WebApplicationStudy.Models;

//namespace WebApplicationStudy
//{
//  public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
//  {
//    protected override void Seed(StudentContext db)
//    {
//      // db.Students.Add(new Student { FirstName = "Вася", SecondName = "Пупкин", MiddleName = "Сергеевич"/*/*, Gender = "", BirthDate = "", HasPrivileges = true, Status = "", ResidencePlace = "", /*Faculty = new Faculty( nameof = "Name", "DisplName"),*/ Specialty = "AI", Course = 1, EducationForm = "Free",/* Group group = new Group("wer")*/LastSessionMark = 6.7, ScholarshipSize = 200,/*CourseworkTeacher*/ EntityType = 1, Title = "", URLToAvatar = "some URL"*/, Id = 007 });
//      db.Students.Add(new Student { FirstName = "Вася", SecondName = "Пупкин", MiddleName = "Сергеевич", Id = 007 });
//      //db.Students.Add(new Student { Name = "Чайка", Author = "А. Чехов", Year = 1896 });

//      base.Seed(db);
//    }
//  }
//}
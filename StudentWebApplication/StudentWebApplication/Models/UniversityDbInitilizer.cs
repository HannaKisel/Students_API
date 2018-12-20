//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using StudentWebApplication.Context;

//namespace StudentWebApplication.Models
//{
//  public class UniversityDbInitilizer : DropCreateDatabaseAlways<UniversityContext>
//  {
//    protected override void Seed(UniversityContext db)
//    {
//      //db.Groups.Add(new Group { GroupName = "Pervaia" });
//      Group group = db.Groups.Add(new Group { GroupName = "Pervaia" });//new Group { GroupName = "Pervaia" };

//      List<Student> students = new List<Student>()
//      {
//        new Student { FirstName = "Olga", SecondName = "Nechay", MiddleName = "Sergeevna", StudentId = 1 },
//        new Student { FirstName = "Andrei", SecondName = "Sushko", MiddleName = "Aleksandrovich", StudentId = 2 },
//      };
      
//      db.Teachers.Add(new Teacher { FirstName = "Alexander", SecondName = "Kurochkin", MiddleName = "Vasilievich", TeacherId = 1, Students = students });
      
//      db.Groups.Add(new Group { GroupName = "Piataia", Students = students });
//      db.SaveChanges();
//      db.Students.Add(new Student { FirstName = "Hanna", SecondName = "Kisel", MiddleName = "Nikolaevna", StudentId = 3, Group = db.Groups.Where(x => x.GroupName == "Pervaia").First(), Teacher = db.Teachers.First() });
      
//      base.Seed(db);
//    }
//  }
//}
using System;
using System.Collections.Generic;

namespace Students
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      JSONWorker jSONWorker = new JSONWorker();
      List<Student> students = jSONWorker.Deserialized();
      Student student = new Student("Vadim", "Pupkin", "Vaits", "M", "23", true, "Student", "Home", "RFaKS", "RF", "AI", 3, "Free", "1+5AI", 8.8, 150, "Bibidy", "Bobidy", "Boo", 2, "Blabla", "UrlToAvatar");
     // List<Student> students = new List<Student>();
      students.Add(student);
      jSONWorker.Serialized(students);



      foreach (Student st in students)
      {
        Console.WriteLine(st.FirstName);
      }
      // jSONWorker.Serialized(students);
      //students = jSONWorker.Deserialized();
      //foreach (Student st in students)
      //{
      //  Console.WriteLine(st.FirstName);
      //}
    
      Console.ReadKey();
    }
  }
}
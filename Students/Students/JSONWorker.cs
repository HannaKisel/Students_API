using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Students
{
  class JSONWorker
  {
    private const string pathToJsonFileWithStudents = @"D:\Учёба\3 курс\c#\Students\Students\firstGroup.json";// change!
    
    /// <summary>
    /// Writes to the collection from JSON file
    /// </summary>
    /// <returns></returns>
    public List<Student> Deserialized()
    {
      List<Student> usersFromFile = new List<Student>();
      usersFromFile = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(pathToJsonFileWithStudents));
      return usersFromFile;
    }

    /// <summary>
    /// Writes to the JSON file
    /// </summary>
    /// <param name="users"></param>
    public void Serialized(List<Student> students)
    {
      //List<User> users = CreateList();
      string serialized = JsonConvert.SerializeObject(students);
      using (StreamWriter file = new StreamWriter(pathToJsonFileWithStudents))
      {
        file.Write(serialized);
      }
    }
  }
}
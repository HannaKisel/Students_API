using System;
using System.IO;
using System.Net.Sockets;

namespace StudentService
{
  class Response
  {
    Byte[] Data;//in bite
    String Status;//200, 404. 405 and 400
    String Mine;//text html

    private Response(string status, string mine, Byte[] data)
    {
      Data = data;
      Status = status;
      Mine = mine;
    }

    public static Response From(Request request)// инициализирует дату реквеста
    {
      if (request == null)
      {
        return NotWork("400.html", "400 Bad Request");
      }
      if (request.Type == "GET")
      {
        String file = Environment.CurrentDirectory + HttpServer.WEB_DIR + request.URL;
        FileInfo fi = new FileInfo(file);
        if (fi.Exists && fi.Extension.Contains("."))
        {
          return MakeFromFile(fi);
        }
        else
        {
          DirectoryInfo di = new DirectoryInfo(fi + "/");
          if (!di.Exists)
          {
            return NotWork("404.html", "404 Page Not Found");
          }
          FileInfo[] files = di.GetFiles();

          foreach (FileInfo ff in files)
          {
            if (ff.Name.Contains("default.html") || ff.Name.Contains("index.html"))
            {
              return MakeFromFile(ff);
            }
          }
        }
      }
      else
      {
        NotWork("405.html", "405 Method Not Allowed");
      }
      return NotWork("404.html", "404 Page Not Found");
    }

    private static Response MakeFromFile(FileInfo fi)
    {
      FileStream fs = fi.OpenRead();
      Byte[] data = new Byte[fs.Length];
      BinaryReader reader = new BinaryReader(fs);
      reader.Read(data, 0, data.Length);
      return new Response("200 OK", "text/html", data);
    }

    private static Response NotWork(String fileName, String status)
    {
      String file = Environment.CurrentDirectory + HttpServer.MSG_DIR + fileName;
      FileInfo fileInfo = new FileInfo(file);// берем нудный файл

      FileStream fs = fileInfo.OpenRead();// открываем поток
      BinaryReader reader = new BinaryReader(fs);
      Byte[] data = new Byte[fs.Length];//считываем локальную дату
      reader.Read(data, 0, data.Length);
      return new Response(status, "text/html", data);
    }

    public void Post(NetworkStream stream)// отправляем ответ
    {
      StreamWriter writer = new StreamWriter(stream);
      Console.WriteLine(String.Format("RESPONSE:\r\nVersion: {0}, Status:{1}\r\nServer:" +
        " {2}\r\nContent-Language: ru\r\nContent-type:{3}\r\nAccept-Ranges:" +
        " bytes\r\nContentLength: {4}\r\nConnection: close\r\n", HttpServer.VERSION, Status, HttpServer.SERVERNAME, Mine, Data.Length));
      writer.WriteLine(String.Format("{0} {1}\r\nServer:" +
        " {2}\r\nContent-Language: ru\r\nContent-type:{3}\r\nAccept-Ranges:" +
        " bytes\r\nContentLength: {4}\r\nConnection: close\r\n", HttpServer.VERSION, Status, HttpServer.SERVERNAME, Mine, Data.Length));
      writer.Flush();// это мы записали Header, Flush- очистили все бафферы

      stream.Write(Data, 0, Data.Length);// записываем саму HTML страницу
    }
  }
}
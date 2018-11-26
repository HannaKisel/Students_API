namespace StudentService
{
  class Program
  {
    static void Main(string[] args)
    {
      HttpServer server = new HttpServer(8080);
      server.Start();
    }
  }
}
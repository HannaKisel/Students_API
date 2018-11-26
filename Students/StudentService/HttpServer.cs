using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace StudentService
{
  class HttpServer
  {
    public const string MSG_DIR = "/root/message";
    public const string WEB_DIR = "/root/web";

    public const string VERSION = "HTTP/1.0";
    public const string SERVERNAME = "myserv/1.1";

    TcpListener listener;
    bool running = false;

    public HttpServer(int port)
    {
      listener = new TcpListener(IPAddress.Any, port);
    }

    public void Start()
    {
      Thread thread = new Thread(new ThreadStart(Run));
      thread.Start();
    }

    private void Run()
    {
      listener.Start();
      running = true;
      Console.WriteLine("sever is running.");

      while (running)
      {
        Console.WriteLine("waiting for connection...");
        TcpClient client = listener.AcceptTcpClient();
        Console.WriteLine("Client connected");
        ClientHandle(client);
        client.Close();
      }
    }


    private void ClientHandle(TcpClient client)
    {
      StreamReader reader = new StreamReader(client.GetStream());
      String message = "";

      while (reader.Peek()!= -1)//if Peel equal to '-1', our message are ended and there is nothing to read
      {
        message += reader.ReadLine() + "\n";
      }

      Console.WriteLine("REQUEST: \r\n {0}", message);
      Request request = Request.GetRequest(message);
      Response response = Response.From(request);
      response.Post(client.GetStream());
    }
  }
}

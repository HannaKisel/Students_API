using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService
{
  class Request
  {
    public String Type { get; set; }//Get, Post or other...
    public String URL { get; set; }
    public String Host { get; set; }


    private Request(String type, String url, String host)
    {
      Type = type;
      URL = url;
      Host = host;
    }

    public static Request GetRequest(String message)
    {
      if (String.IsNullOrEmpty(message))
      {
        return null;
      }

      String[] tokens = message.Split(' ');
      Console.WriteLine("Type: {0}, URL: {1}, Host: {2}", tokens[0], tokens[1], tokens[3]);
      return new Request(tokens[0],tokens[1], tokens[3]);
    }
  }
}

using System;

namespace Uppgift_2_9
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv en Url-addres");
      // https://meet.google.com/qqt-rkqu-nff?authuser=0
      string Url = Console.ReadLine();
      int protocolIndex = Url.IndexOf("//");
      int subDomainIndex = Url.IndexOf(".");
      int domainIndex = Url.IndexOf("c");
      //   int topLevelDomain = Url.IndexOf("/");
      //   int path = Url.IndexOf("/");
      string protocol = Url.Substring(0, protocolIndex + 2);
      string subDomain = Url.Substring(protocolIndex + 2, subDomainIndex - 8);
      string domain = Url.Substring(protocolIndex + 2, domainIndex - 9);

      Console.WriteLine("Protocol : " + protocol);
      Console.WriteLine("Subdomain : " + subDomain);
      Console.WriteLine("Domain : " + domain);


    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mock4Net.Core;

namespace ConsoleApplication1
{
    static class Program
    {
        static void Main(string[] args)
        {
            var port = Int16.Parse(args[0]);
            var server = FluentMockServer.Start(port);
            Console.Out.WriteLine("Server started on port " + port);
            server
                .Given(
                    Requests.WithUrl("/*").WithParam("HiAdam")
                ).RespondWith(
                    Responses
                        .WithStatusCode(200)
                        .WithBody("Hello World!")
                        .AfterDelay(TimeSpan.FromSeconds(5))
                );
            Console.Out.WriteLine("Press any key to stop the server!");
            Console.In.Read();

        }

      

        
    }
}

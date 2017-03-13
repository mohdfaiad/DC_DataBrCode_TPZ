using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Testing WebService DataBRcode");
            List<PostService> LPost = new List<PostService>();
            for (int i = 0; i < 1; i++ )
            {
                LPost.Add(new PostService(i, 1000));
            }
            
            
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);

            Console.WriteLine("Stoping Threading");
            foreach (var elem in LPost)
                elem.StopThread();

            Console.ReadLine();
        }
    }
}

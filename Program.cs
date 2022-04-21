using System;

namespace ConsoleApp1
{
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.Write("Высота ромба(не менее 3х строк): ");
            var h = int.Parse(Console.ReadLine());
            for(var i=0; i<h;i++){
                var spaceBefore = Math.Abs(h / 2 - i);
                var starsCount = (h-2 * spaceBefore);
                Console.WriteLine("{0}{1}", new string(' ',spaceBefore), new string('*', starsCount));
            }
            Console.WriteLine();
        }
    }
}

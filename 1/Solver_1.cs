using System;
using System.IO;
using System.Text;
using System.Linq;

namespace AdventOfCode
{
    public static class Solver_1
    {
        public static void Part1()
        {
            int counter = 0;

            var path = @"C:\Users\Martin\Code\AdventOfCode\1\input.txt";

            var lines = File.ReadAllLines(path, Encoding.UTF8);
            for(var i=0;i<lines.Length;i++) {
                var firstGroup = lines.Skip(i).Take(3).Select(x => int.Parse(x)).Sum();
                var secondGroup = lines.Skip(i+1).Take(3).Select(x => int.Parse(x)).Sum();
                if(firstGroup < secondGroup){
                    counter++;
                }
            }
            Console.WriteLine("Done Part1");
            Console.WriteLine(counter);
        }

        public static void Part2()
        {
            int counter = 0;

            var path = @"C:\Users\Martin\Code\AdventOfCode\1\input.txt";

            int? oldValue = null;
            foreach(var line in File.ReadAllLines(path, Encoding.UTF8)) {
                int currentValue = int.Parse(line);
                if(currentValue > oldValue){
                    counter++;
                }
                oldValue = currentValue;
            }
            Console.WriteLine("Done Part2");
            Console.WriteLine(counter);
        }
    }
}

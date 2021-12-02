using System;
using System.IO;
using System.Text;
using System.Linq;

namespace AdventOfCode
{
    public static class Solver_2
    {
        public static void Part1()
        {
            var path = @"C:\Users\Martin\Code\AdventOfCode\2\input.txt";

            int hoz = 0;
            int depth = 0;

            foreach(var line in File.ReadAllLines(path, Encoding.UTF8)) {
                var split = line.Split(' ');
                switch(split[0])
                {
                    case "forward":
                        hoz = hoz + int.Parse(split[1]);
                    break;
                    case "down":
                        depth = depth + int.Parse(split[1]);
                    break;
                    case "up":
                        depth = depth - int.Parse(split[1]);
                    break;
                }
            }

            Console.WriteLine("Done Part1");
            Console.WriteLine($"Hoz: {hoz}");
            Console.WriteLine($"Depth: {depth}");
            Console.WriteLine($"Result (Hoz * Depth): {hoz*depth}");
        }

        public static void Part2()
        {
            var path = @"C:\Users\Martin\Code\AdventOfCode\2\input.txt";

            int hoz = 0;
            int depth = 0;
            int aim = 0;

            foreach(var line in File.ReadAllLines(path, Encoding.UTF8)) {
                var split = line.Split(' ');
                int parsed = int.Parse(split[1]);
                switch(split[0])
                {
                    case "forward":
                        hoz = hoz + parsed;
                        depth += aim * parsed;
                    break;
                    case "down":
                        aim = aim + parsed;
                    break;
                    case "up":
                        aim = aim - parsed;
                    break;
                }
            }

            Console.WriteLine("Done Part1");
            Console.WriteLine($"Hoz: {hoz}");
            Console.WriteLine($"Depth: {depth}");
            Console.WriteLine($"Result (Hoz * Depth): {hoz*depth}");
        }
    }
}

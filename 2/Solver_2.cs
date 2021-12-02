using System;
using System.IO;
using System.Text;
using System.Linq;

namespace AdventOfCode
{
    public static class Solver_2
    {
        static private string path = @"2\input.txt";
        public static void Part1()
        {
            int pos = 0;
            int depth = 0;

            foreach(var line in File.ReadAllLines(path, Encoding.UTF8)) {
                var split = line.Split(' ');
                switch(split[0])
                {
                    case "forward":
                        pos = pos + int.Parse(split[1]);
                    break;
                    case "down":
                        depth = depth + int.Parse(split[1]);
                    break;
                    case "up":
                        depth = depth - int.Parse(split[1]);
                    break;
                }
            }

            Console.WriteLine($"Pos: {pos}");
            Console.WriteLine($"Depth: {depth}");
            Console.WriteLine($"Result (Pos * Depth): {pos*depth}");
            Console.WriteLine("Done Part1"+System.Environment.NewLine);
        }

        public static void Part2()
        {
            int pos = 0;
            int depth = 0;
            int aim = 0;

            foreach(var line in File.ReadAllLines(path, Encoding.UTF8)) {
                var split = line.Split(' ');
                int parsed = int.Parse(split[1]);
                switch(split[0])
                {
                    case "forward":
                        pos += parsed;
                        depth += aim * parsed;
                    break;
                    case "down":
                        aim += parsed;
                    break;
                    case "up":
                        aim -= parsed;
                    break;
                }
            }

            Console.WriteLine($"Pos: {pos}");
            Console.WriteLine($"Depth: {depth}");
            Console.WriteLine($"Aim: {aim}");
            Console.WriteLine($"Result (Pos * Depth): {pos*depth}");
            Console.WriteLine("Done Part2"+System.Environment.NewLine);
        }
    }
}

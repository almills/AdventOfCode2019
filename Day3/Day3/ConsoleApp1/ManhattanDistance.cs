using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Day3
{
    public static class ManhattanDistance
    {
        public static int Calculate(string wire1, string wire2)
        {
            var wire1Instructions = ParseWire(wire1);
            var wire2Instructions = ParseWire(wire2);

            var points1 = GetPointsVisited(wire1Instructions);
            var points2 = GetPointsVisited(wire2Instructions);

            var pointsThatCross = points1.Intersect(points2); 

            int best = 10000000;

            foreach(Point p in pointsThatCross)
            {
                var distance = Distance(0, p.X, 0, p.Y);
                if(distance < best)
                {
                    best = distance;
                }
            }

            return best;
        }  

        private static IEnumerable<Instruction> ParseWire(string wire)
        {
            var commands = wire.Split(',', StringSplitOptions.RemoveEmptyEntries);

            List<Instruction> instructions = new List<Instruction>();
            foreach(var i in commands)
            {
                instructions.Add(new Instruction()
                {
                    Direction = i[0],
                    Count = int.Parse(i.Substring(1))
                });
            }

            return instructions;
        }

        private static IEnumerable<Point> GetPointsVisited(IEnumerable<Instruction> instructions)
        {
            List<Point> points = new List<Point>();
            Point current = new Point(0, 0);

            foreach(Instruction i in instructions)
            {
                switch (i.Direction)
                {
                    case 'R':
                        for(int v = 0; v < i.Count; v++)
                        {
                            current.X = current.X+1;
                            points.Add(current);
                        }
                        break;
                    case 'D':
                        for (int v = 0; v < i.Count; v++)
                        {
                            current.Y = current.Y-1;
                            points.Add(current);
                        }
                        break;
                    case 'L':
                        for (int v = 0; v < i.Count; v++)
                        {
                            current.X = current.X-1;
                            points.Add(current);
                        }
                        break;
                    case 'U':
                        for (int v = 0; v < i.Count; v++)
                        {
                            current.Y = current.Y+1;
                            points.Add(current);
                        }
                        break;
                }
            }

            return points;
        }
        
        private static int Distance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }
}

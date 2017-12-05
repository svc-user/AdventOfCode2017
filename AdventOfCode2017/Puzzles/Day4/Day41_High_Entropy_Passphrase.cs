using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2017.Puzzles.Day4
{
    public class Day51_A_Maze_Of_Twisty_Trampolines_All_Alike : IPuzzle
    {
        public string Run()
        {
            var input = 
                File.ReadAllLines("Puzzles\\Day4\\input.txt")
                .Select(l => l.Split(" ", StringSplitOptions.RemoveEmptyEntries));

            var count = 0;
            foreach(var passphrase in input)
            {
                if(passphrase.GroupBy(k => k).All(q => q.Count() == 1))
                    count++;
            }

            return count.ToString();
        }
    }
}

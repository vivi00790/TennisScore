using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Judge judge = new Judge();
                string input = Console.ReadLine();

                if (input != null)
                {
                    string[] data = input.Split(' ');
                    judge.Player1Name = data[0];
                    judge.Player1Score = Convert.ToInt32(data[1]);
                    judge.Player2Name = data[2];
                    judge.Player2Score = Convert.ToInt32(data[3]);
                    Console.WriteLine(judge.Score());
                }
            }
        }
    }
}

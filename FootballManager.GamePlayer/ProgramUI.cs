using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.GamePlayer
{
    public class ProgramUI
    {
        Random random = new Random();

        public int NormalPower()
        {
            Thread.Sleep(5);
            int[] yards = {0, 5, 10, 15 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public int IntermediatePower()
        {
            Thread.Sleep(5);
            int[] yards = {0, 5, 10, 15, 20 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public int AdvancedPower()
        {
            Thread.Sleep(5);
            int[] yards = {0, 5, 10, 15, 20, 25 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public void Run()
        {
            string titlescreen = System.IO.File.ReadAllText(@"C:\ElevenFiftyProjects\FootballManager\FootballManager.GamePlayer\Football Manager Start Screen.txt");
            Console.WriteLine(titlescreen);
            Console.ReadKey();
        }

        public void SelectionScreen()
        {

        }

        //use counter to add "yards covered". When reaches 100 total, touchdown!

    }
}

using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cord cord1 = new Cord("№1");
            Cord cord2 = new Cord("№2");

            while (true)
            {
                Player p1_1 = new Player("noob", "Vadim");
                Player p1_2 = new Player("noob", "Oleg");
                Player p2_1 = new Player("Pro", "Max");
                Player p2_2 = new Player("Pro", "Den");

                cord1.Play(p1_1, p1_2);
                cord2.Play(p2_1, p2_2);
                Random rand = new Random();
                if(rand.Next(0,14) == 14)
                {
                    cord1.Play(p1_1, p2_1);
                    cord2.Play(p1_2, p2_2);
                }
            }
        }
    }
}

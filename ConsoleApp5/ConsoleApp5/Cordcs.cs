using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    class Cord
    {
        public string NameCord { get; set; }

        public Cord(string name)
        {
            NameCord = name;
        }
        public void Play(Player p1, Player p2)
        {
            Console.WriteLine($"На корті {NameCord}, відбуваеться гра між: {p1.Name} ^^ {p2.Name}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Відбуваеться гра");
                Thread.Sleep(500);
                if (i==4)
                {
                    Random rand = new Random();
                    switch (rand.Next(0, 1)
)
                    {
                        case 0:
                            {
                                Console.WriteLine($"Win: {p1.Name}");
                                break;
                            }

                        case 1:
                            {
                                Console.WriteLine($"Win: {p2.Name}");
                                break;
           
                            }
                        default:
                            break;
                    }


                }
            }

        }

    }
}

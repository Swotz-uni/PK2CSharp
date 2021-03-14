using System;

namespace Praktikum11
{
    class Program
    {
        static void Main(string[] args)
        {
            CdPlayer cd = new CdPlayer();
            Garage g = new Garage();
            cd.Start();
            cd.Stopp();
            g.Hoch();
            g.Runter();

        }
    }
}

using System;
namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int antalX = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            int antalO = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            int antalOMönster = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int rader = int.Parse(Console.ReadLine());

            string xGrupp = "";
            for (int i = 0; i < antalX; i++)
            {
                xGrupp += "X";
            }

            string oGrupp = "";
            for (int i = 0; i < antalO; i++)
            {
                oGrupp += "O";
            }

            string enRad = xGrupp;
            for (int i = 0; i < antalOMönster; i++)
            {
                enRad += "-" + oGrupp + "-" + xGrupp;
            }

            for (int i = 0; i < rader; i++)
            {
                Console.WriteLine(enRad);
            }
        }
    }
}
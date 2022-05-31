using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgGftStart.src.Entities;

namespace RpgGftStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
            Console.ReadKey();
        }
    }
}

using System;

namespace Ex6_CSharp_Tank
{
    class Program
    {
        public static void Main(string[] args)
        {            
            Console.WriteLine("============================");
            Console.WriteLine(" *** EXERCICI 6 v.TANKS *** ");
            Console.WriteLine("============================");

            var weapon1 = new Tank(new Cannon());
            weapon1.Attack("enemics");

            var weapon2 = new Tank(new Grenade());
            weapon2.Attack("enemics");

            var weapon3 = new Tank(new Bomb());
            weapon3.Attack("enemics");
        }
    }
}

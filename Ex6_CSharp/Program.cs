using System;

namespace Ex6_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine(" *** EXERCICI 6 ***");
            Console.WriteLine("====================");

            var soldier1 = new Soldier(new MachineGun());
            var soldier2 = new Soldier(new Pistol());
            var soldier3 = new Soldier(new Knife());
            soldier1.Attack("enemics");
            soldier2.Attack("soldats");
            soldier3.Attack("oponents");
        }
    }
}

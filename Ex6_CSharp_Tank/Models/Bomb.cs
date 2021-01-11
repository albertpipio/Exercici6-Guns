using System;

namespace Ex6_CSharp_Tank
{
    class Bomb : IWeapon
    {
        public void Shoot (string target)
        {
            Console.WriteLine($"Els {target} han estat destruits.");
        }
    }
}
using System;

namespace Ex6_CSharp_Tank
{
    class Cannon : IWeapon
    {
        public void Shoot (string target)
        {
            Console.WriteLine($"Els {target} han sigut abatuts.");
        }
    }
}

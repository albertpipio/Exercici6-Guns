using System;

namespace Ex6_CSharp_Tank
{
    class Grenade : IWeapon
    {
        public void Shoot (string target)
        {
            Console.WriteLine($"Els {target} han explotat.");
        }
    }
}

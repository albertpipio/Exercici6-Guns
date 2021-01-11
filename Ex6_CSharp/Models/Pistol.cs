using System;

namespace Ex6_CSharp
{
    public class Pistol : IWeapon
    {
        public void Shoot (string target)
        {
            Console.WriteLine($"Els {target} han sigut abatuts.");
        }
    }
}
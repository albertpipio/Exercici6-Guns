using System;

namespace Ex6_CSharp
{
    public class Knife : IWeapon
    {
        public void Shoot (string target)
        {
            Console.WriteLine($"Els {target} han sigut atravessats.");
        }        
    }
}
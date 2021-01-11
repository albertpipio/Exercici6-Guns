namespace Ex6_CSharp
{
    public class Soldier
    {
        readonly IWeapon weapon;
        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack (string target)
        {
            this.weapon.Shoot(target);
        }
    }
}
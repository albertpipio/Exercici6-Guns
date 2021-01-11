namespace Ex6_CSharp_Tank
{
    public class Tank
    {
        readonly IWeapon weapon;
        public Tank (IWeapon weapon)
        {
            this.weapon = weapon;
        }
        public void Attack (string target)
        {
            this.weapon.Shoot(target);
        }
    }
}
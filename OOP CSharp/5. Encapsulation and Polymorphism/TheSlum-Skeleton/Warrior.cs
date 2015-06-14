namespace TheSlum
{
    class Warrior:Interfaces.IAttack
    {
        public int AttackPoints
        {
            get
            {
                return this.AttackPoints;
            }
            set
            {
                this.AttackPoints = value;
            }
        }
    }
}

using Homework_8.Exceptions;

namespace Homework_8
{
    public class Villain : Identity
    {
        private int darkAbility;
        public int DarkAbility
        {
            get { return darkAbility; }
            set
            {
                if (value > 0)
                {
                    darkAbility = value;
                }
                else
                {
                    throw new DarkAbilityException("Darkability should be a positive number");
                }
            }
        }
        public Properties Properties { get; set; }
        public void AttackOnHero(Hero name)
        {
            name.Properties.Health -= DarkAbility;
        }
    }
}

using Homework_8.Exceptions;

namespace Homework_8
{
    public class Hero : Identity
    {
        private int lightAbility;
        public int LightAbility
        {
            get { return lightAbility; } 
            set
            {
                if (value > 0)
                {
                    lightAbility = value;
                }
                else
                {
                    throw new LightAbilityException("lightability should be a positive number");
                }
            }
        }
        public Properties Properties { get; set; }
        public void AttackOnVilan(Villain name)
        {
            name.Properties.Health -= lightAbility;
        }
        public void Heal(Hero name)
        {
            Properties.Health -= lightAbility;
            name.Properties.Health += lightAbility;
        }
    }
}

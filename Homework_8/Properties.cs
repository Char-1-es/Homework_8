using Homework_8.Exceptions;

namespace Homework_8
{
    public class Properties 
    {
        private int money;
        public int Money
        {
            get { return money; } 
            set
            {
                if (value > 0)
                {
                    money = value;
                }
                else
                {
                    throw new MoneyException("Money should be a positive number");
                }
            }
        }

        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 0)
                {
                    health = value;
                }
                else
                {
                    throw new HealthException("Health should be a positive number");
                }
            } 
        }
    }
}

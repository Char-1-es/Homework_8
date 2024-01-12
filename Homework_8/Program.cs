using Homework_8.Exceptions;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ააწყვეთ თამაშის ლოგიკა სადაც გვეყოლება ორი ტიპის პერსონაჟი გმირი(Hero) და ბოროტმოქმედი(Villan).

            Hero Batman = new Hero()
            {
                Name = "Batman",
                LightAbility = 30,
                Properties = new Properties()
                {
                    Money = 5000000,
                    Health = 100,
                }
            };
            Hero Catwoman = new Hero()
            {
                Name = "Catwoman",
                LightAbility = 20,
                Properties = new Properties()
                {
                    Money = 100000,
                    Health = 100,
                }
            };
            Hero Gordon = new Hero()
            {
                Name = "Gordon",
                LightAbility = 10,
                Properties = new Properties()
                {
                    Money = 1000,
                    Health = 100,
                }
            };
            Villain Joker = new Villain()
            {
                Name = "Joker",
                DarkAbility = 25,
                Properties = new Properties()
                {
                    Money = 10000,
                    Health = 100,
                }
            };
            Villain Penguin = new Villain()
            {
                Name = "Penguin",
                DarkAbility = 20,
                Properties = new Properties()
                {
                    Money = 1000000,
                    Health = 100,
                }
            };
            Villain Riddler = new Villain()
            {
                Name = "Riddler",
                DarkAbility = 15,
                Properties = new Properties()
                {
                    Money = 200000,
                    Health = 100,
                }
            };
            
        }
    }
}

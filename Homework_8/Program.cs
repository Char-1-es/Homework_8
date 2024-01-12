using Homework_8.Exceptions;
using System.Transactions;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ააწყვეთ თამაშის ლოგიკა სადაც გვეყოლება ორი ტიპის პერსონაჟი გმირი(Hero) და ბოროტმოქმედი(Villan).
            try
            {
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

                Console.WriteLine("Initial health score of villains:");
                Console.WriteLine($"Joker: {Joker.Properties.Health}, Penguin: {Penguin.Properties.Health}, Riddler: {Riddler.Properties.Health} ");
                Console.WriteLine("");
                Console.WriteLine("Initial health score of heroes:");
                Console.WriteLine($"Batman: {Batman.Properties.Health}, Catwoman: {Catwoman.Properties.Health}, Gordon: {Gordon.Properties.Health} ");

                Console.WriteLine("-----------------------------------------");
                Batman.AttackOnVilan(Joker);
                Catwoman.AttackOnVilan(Penguin);
                Gordon.AttackOnVilan(Riddler);

                Joker.AttackOnHero(Batman);
                Penguin.AttackOnHero(Catwoman);
                Riddler.AttackOnHero(Gordon);

                Console.WriteLine("Health score of villains after the war:");
                Console.WriteLine($"Joker: {Joker.Properties.Health}, Penguin: {Penguin.Properties.Health}, Riddler: {Riddler.Properties.Health} ");
                Console.WriteLine("");
                Console.WriteLine("Health score of heroes after the war:");
                Console.WriteLine($"Batman: {Batman.Properties.Health}, Catwoman: {Catwoman.Properties.Health}, Gordon: {Gordon.Properties.Health} ");
                Console.WriteLine("-----------------------------------------");

                Batman.Heal(Catwoman);
                Catwoman.Heal(Gordon);
                Gordon.Heal(Batman);

                Console.WriteLine("Health score of heroes after the healing:");
                Console.WriteLine($"Batman: {Batman.Properties.Health}, Catwoman: {Catwoman.Properties.Health}, Gordon: {Gordon.Properties.Health} ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

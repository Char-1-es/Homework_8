using Homework_8.Exceptions;

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

                Console.WriteLine("Welcome, to Arkham City!");
                Console.WriteLine("Choose your team:");
                Console.WriteLine($"Heroes : {Batman.Name}, {Catwoman.Name}, {Gordon.Name} (Type H)");
                Console.WriteLine($"Villains : {Joker.Name}, {Penguin.Name}, {Riddler.Name} (Type V)");

                char choice = char.Parse(Console.ReadLine()!);

                if (choice == 'H')
                {
                    Console.WriteLine($"Health levels of your team -- Batman: {Batman.Properties.Health}, Catwoman: {Catwoman.Properties.Health}, Gordon: {Gordon.Properties.Health}");
                }
                else if (choice == 'V')
                {
                    Console.WriteLine($"Health levels of your opponent's team -- Joker: {Joker.Properties.Health}, Penguin: {Penguin.Properties.Health}, Riddler: {Riddler.Properties.Health}");
                }
                Console.WriteLine("Type A to start attack");

                char attack = char.Parse(Console.ReadLine()!);
                while (true)
                {
                    if (attack == 'A')
                    {
                        Batman.AttackOnVilan(Joker);
                        Catwoman.AttackOnVilan(Penguin);
                        Gordon.AttackOnVilan(Riddler);
                        Gordon.AttackOnVilan(Joker);

                        Joker.AttackOnHero(Batman);
                        Penguin.AttackOnHero(Batman);
                        Penguin.AttackOnHero(Catwoman);
                        Riddler.AttackOnHero(Gordon);

                        Console.WriteLine($"Health levels of your team -- Batman: {Batman.Properties.Health}, Catwoman: {Catwoman.Properties.Health}, Gordon: {Gordon.Properties.Health}");
                        Console.WriteLine($"Health levels of your opponent's team -- Batman: {Batman.Properties.Health}, Catwoman: {Catwoman.Properties.Health}, Gordon: {Gordon.Properties.Health}");
                        Console.WriteLine("------------------");
                    }
                }
                
                //if (choice == 'H')
                //    {
                //        Console.WriteLine("Type + to heal or A to attack again");
                //        if (choice == '+')
                //        {
                //            Console.WriteLine("Choose, who do you want to heal: Type b for batman, c for catwoman, g for gordon");
                //            char healer = char.Parse(Console.ReadLine()!);
                //            if (healer == 'b')
                //            {
                //                Catwoman.Heal(Batman);
                //            }
                //            else if (healer == 'c')
                //            {
                //                Batman.Heal(Catwoman);
                //            }
                //            else if (healer == 'g')
                //            {
                //                Batman.Heal(Gordon);
                //            }
                //        }
                //        else if (choice == 'A')
                //        {
                //            Batman.AttackOnVilan(Joker);
                //            Catwoman.AttackOnVilan(Penguin);
                //            Gordon.AttackOnVilan(Riddler);
                //            Gordon.AttackOnVilan(Joker);

                //            Joker.AttackOnHero(Batman);
                //            Penguin.AttackOnHero(Batman);
                //            Penguin.AttackOnHero(Catwoman);
                //            Riddler.AttackOnHero(Gordon);
                //        }
                //    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

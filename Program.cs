namespace GrottAventyr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange ditt namn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Välkommen " + name);
            Console.WriteLine("Du står framför en stor, mörk och mystisk grotta...");

            int health = 30;
            int damage = 5;
            int coins = 5;
            int monsterHealth = 15;
            int monsterDamage = 5;
            int defeatedmonsters = 0;


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Du har två vägar framför dig.");
                Console.WriteLine("1. Gå till vänster");
                Console.WriteLine("2. Gå till höger");
                Console.WriteLine();
                Console.Write("Ditt val: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1 || choice == 2)

                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Du går till vänster...");
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.WriteLine("Du går till höger...");
                                Console.WriteLine();
                                break;
                        }
                        int mysteryNumber = Random.Shared.Next(1, 6);

                        switch (mysteryNumber)
                        {
                            case 1:
                                Console.WriteLine("Du hittar en skattkista");
                                Console.WriteLine("Du fick 10 coins");
                                coins += 10;
                                break;
                            case 2:
                                string monsterName = "";
                                if (defeatedmonsters == 0)
                                {
                                    monsterName = "Grottgoblinen";
                                    monsterHealth = 15;
                                    monsterDamage = 5;
                                    Console.WriteLine("Du möter monstret: " + monsterName + "!");
                                    Console.WriteLine();

                                }
                                else if (defeatedmonsters == 1)
                                {
                                    monsterName = "Grottkrossaren";
                                    monsterHealth = 25;
                                    monsterDamage = 8;
                                    Console.WriteLine("Du möter monstret: " + monsterName + "!");
                                }
                                else if (defeatedmonsters == 2)
                                {
                                    monsterName = "Avgrundens best";
                                    monsterHealth = 40;
                                    monsterDamage = 12;
                                    Console.WriteLine("Du möter monstret: " + monsterName + "!");
                                }
                                Console.WriteLine("Monstrets hälsa: " + monsterHealth);
                                Console.WriteLine("Monstrets skada: " + monsterDamage);
                                Console.WriteLine();
                                while (monsterHealth > 0 && health > 0)
                                {
                                    Console.WriteLine(name + " attakerar monstret");
                                    monsterHealth -= damage;

                                    if (monsterHealth <= 0)
                                    {
                                        defeatedmonsters++;
                                        coins += 10;
                                        Console.WriteLine("Besegrade monster: " + defeatedmonsters);
                                        Console.WriteLine(name + " besegrade monstret: " + monsterName);
                                        Console.WriteLine("Du får 10 coins som belöning!");
                                        Console.WriteLine("Du går vidare...");
                                        if (defeatedmonsters == 3)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Grattis! Du har besegrat alla tre monster.");
                                            Console.WriteLine("Du har klarat Grottäventyret!");
                                            Console.WriteLine();

                                            Console.WriteLine("Slutlig hälsa: " + health);
                                            Console.WriteLine("Antal coins: " + coins);
                                            Console.WriteLine(name + " vapen skada : " + damage);
                                            return;
                                        }

                                        break;
                                    }

                                    Console.WriteLine("Monstrets hälska kvar: " + monsterHealth);
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("Monstret attackerar " + name);
                                    health -= monsterDamage;

                                    if (health <= 0)
                                    {
                                        Console.WriteLine("Monstret besegrade " + name);
                                        Console.WriteLine("Du börjar om spelet!");

                                        health = 30;
                                        damage = 5;
                                        coins = 5;
                                        monsterHealth = 15;
                                        monsterDamage = 5;
                                        defeatedmonsters = 0;
                                        break;
                                    }
                                    Console.WriteLine(name + " hälsa kvar: " + health);
                                    Console.WriteLine("------------------------------");

                                }
                                break;
                            case 3:
                                Console.WriteLine("Du hittar ett vapen");
                                Console.WriteLine("Ditt vapen ökade med 5 skada");
                                damage += 5;
                                break;
                            case 4:
                                Console.WriteLine("Du möter en vakt! Betala 5 coins eller återvänd till början av grottan");
                                if (coins >= 5)
                                {
                                    Console.WriteLine("Du har betalat vakten, du går vidare...");
                                    coins -= 5;
                                }
                                else
                                {
                                    Console.WriteLine("Du har inte råd!");
                                    Console.WriteLine("Du återvänder till början av grottan!");

                                    health = 30;
                                    damage = 5;
                                    coins = 5;
                                    defeatedmonsters = 0;
                                    monsterHealth = 15;
                                    monsterDamage = 5;
                                }
                                break;
                            case 5:
                                Console.WriteLine("Du hittar en mystisk helande källa!");
                                Console.WriteLine("Du ökar med 10 hälsa!");
                                health += 10;
                                 break;
                               

                        }
                        Console.WriteLine();
                        Console.WriteLine($"Hälsa: {health}");
                        Console.WriteLine($"Skada: {damage}");
                        Console.WriteLine($"Coins: {coins}");
                        Console.WriteLine();
                        Console.WriteLine("Tryck Enter för att fortsätta...");
                        Console.ReadLine();
                        Console.Clear();


                    }
                    else
                    {
                        Console.WriteLine("Fel! Du måste skriva ett nummer mellan 1-2");
                    }
                }
                else
                {
                    Console.WriteLine("Du måste skriva en siffra");
                }

            }

        }

    }
}
















using System; // put in using directive
using System.Collections.Generic; // semicolon missing
using System.Threading;

public class ProblematicProblem // was missing 'public class'
{
    public class Program // class was after Program
    {
        static bool cont = false;
        //semicolon missing
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {        // another semicolon       
        Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //bool cont = bool.Parse(Console.ReadLine());
            var userIn = Console.ReadLine().ToLower();
            if (userIn == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
                Environment.Exit(0);
            }
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");

            //bool seeList = bool.Parse(Console.ReadLine());
            bool seeList = false;
            userIn = Console.ReadLine().ToLower();
            if (userIn == "sure")
            {
                seeList = true;
            }
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(1);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                //bool addToList = bool.Parse(Console.ReadLine());
                bool addToList = false;
                userIn = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (userIn == "yes") 
                { 
                    addToList = true; 
                }
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(1);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    break;
                }
                
            }
        
            while (cont)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(1);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(1);
                }
                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber]; // semicolon
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                   
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                }
                Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                        Console.WriteLine();
                //cont = bool.Parse(Console.ReadLine()); 
                userIn = Console.ReadLine();
                if (userIn == "Keep")
                {
                    cont = false;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
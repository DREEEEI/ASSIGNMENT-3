using System;

//   THIS PROGRAM IS CREATED BY:

//   XXXXx   XXXXx   XXXXXX  XXX
//   XX  XX  XX  XX  XX      XXX
//   XX  XX  XXXXx   XXXXX   XXX
//   XX  XX  XX  XX  XX      XXX
//   XXXXx   XX  XX  XXXXXX  XXX


namespace CodeByDrei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char convertAgain;

            do
            {
                Console.WriteLine("Choose a time to convert.");
                Console.WriteLine("\n1. Seconds to Minutes.");
                Console.WriteLine("2. Minutes to Hours.");
                Console.WriteLine("3. Hours to Days.");
                Console.WriteLine("4. Days to Months.");
                Console.Write("\nEnter your choice (1/2/3/4): ");
                char choice = Console.ReadKey().KeyChar;    
                Console.WriteLine("\n");

                switch (choice)
                {
                    case '1':
                      { 
                        Console.Write("Enter seconds: ");
                        double seconds = int.Parse(Console.ReadLine());
                        double minutes = seconds / 60;
                        Console.WriteLine("\n" + seconds + " second/s = " + minutes + " minute/s");
                        break;
                       }
               
                    case '2':
                      { 
                        Console.Write("Enter minutes: ");
                        double minutes = int.Parse(Console.ReadLine());
                        double hours = minutes / 60;
                        Console.WriteLine("\n" + minutes + " minute/s = " + hours + " hour/s");
                        break;
                      }

                    case '3':
                      {
                        Console.Write("Enter hours: ");
                        double hours = int.Parse(Console.ReadLine());
                        double days = hours / 24;
                        Console.WriteLine("\n" + hours + " hour/s = " + days + " day/s");
                        break;
                      }

                    case '4':
                      {
                        Console.Write("Enter days: ");
                        double days = int.Parse(Console.ReadLine());
                        double months = days / 30;
                        Console.WriteLine("\n" + days + " day/s = " + months + " month/s");
                        break;
                      }

                    default:
                        Console.WriteLine("\nEnter a number from the choices only!");
                        break;
                
                }

                Console.WriteLine("\n\nDo you want to convert again?");
                Console.WriteLine("Type 'Y' to continue or any key to exit.");
                convertAgain = (Console.ReadKey().KeyChar);
                Console.WriteLine("\n");

            } while (convertAgain == 'Y' || convertAgain == 'y');

            Console.WriteLine("\nThank you for using this time converter!");
            Console.ReadLine();
        }

    }

}
using System.Security.Claims;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            // tutaj rozwiązanie zadania 1
            int[] liczPomiędzy = new int[b - a + 1];
            for (int i = 0; i < liczPomiędzy.Length; i++)
            {
                if (i %3 == 0)
                {
                    Console.WriteLine(liczPomiędzy[i]);
                }

            }



            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void PrintTriangle(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("$");
                }
                Console.WriteLine(" ");
            }
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

            // tutaj rozwiązanie zadania 3
            if (today.Hour <12)
            {
                Console.WriteLine($"Dzień dobry, dzisjaj {today.DayOfWeek}, czyli {today.Day} dzień tygodnia");
            }
            else
            {
                Console.WriteLine($"Dobry wieczór, dzisiaj {today.DayOfWeek}, czyli {today.Day} dzień tygodnia");
            }

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static double FindMaxAbsoluteValue(double[] numbers)
        {
            Array.Sort(numbers);
            double max = numbers[numbers.Length - 1];
            return max;
        }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            zw:  Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");

            int liczba = int.Parse(Console.ReadLine());
            if (liczba < 1)
            {
                Console.WriteLine("nie ma takiego zadania, wybierz ponownie.");
                goto zw;
            }
            else if (liczba > 4)
            {
                Console.WriteLine("nie ma takiego zadania, wybierz ponownie.");
                goto zw;
            }
            else if (liczba == 1)
            {
                Console.WriteLine(Zadanie_1);
            }
            else if (liczba == 2)
            {
                Console.WriteLine(Zadanie_2);
            }
            else if (liczba == 3) 
            {
                Console.WriteLine(Zadanie_3);
            }
            else if (liczba == 4) 
            {
                Console.WriteLine(Zadanie_4);
            }


            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

        

    }
}
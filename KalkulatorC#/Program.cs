using System;

namespace Kalkulator
{
    class program
    {
        static void Main(string[] args)
        {
            double liczba1 = 0;
            double liczba2 = 0;
            double wynik = 0;
            string operacja;

            Console.WriteLine("Kalkulator");
            Console.WriteLine("----------");

            Console.WriteLine("Podaj pierwszą liczbę : ");
            liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz operacje (+, -, *, /) : ");
            operacja = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę : ");
            liczba2 = Convert.ToDouble(Console.ReadLine());

            if (operacja == "+")
            {
                wynik = liczba1 + liczba2;
                Console.WriteLine("Wynik : " + wynik);
            }
            else if (operacja == "-")
            {
                wynik = liczba1 - liczba2;
                Console.WriteLine("Wynik : " + wynik);
            }
            else if (operacja == "*")
            {
                wynik = liczba1 * liczba2;
                Console.WriteLine("Wynik : " + wynik);
            }
            else if (operacja == "/")
            {
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                    Console.WriteLine("Wynik : " + wynik);
                }
                else
                {
                    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                }
                        
            }
            else
            {
                Console.WriteLine("Błąd: Nieznany operator.");
            }

            Console.ReadKey();


        }
    }

}





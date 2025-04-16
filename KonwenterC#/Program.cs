using System;

namespace PPOKonwenter
{
    class program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Wybierz kierunek konwersacji :");
            Console.WriteLine("C - Celsjusz na Fahrenheit");
            Console.WriteLine("F - Fahrenheit na Celsjusz");
            Console.Write("Twój wybór: ");
            string wybor = Console.ReadLine().ToUpper();

            Console.WriteLine("Podaj wartość temperatury");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (wybor == "C")
            {
                double wynik = temperatura * 1.8 + 32;
                Console.WriteLine($"{temperatura}C = {wynik}F");
            }
            else if (wybor == "F")
            {
                double wynik = (temperatura - 32) / 1.8;
                Console.WriteLine($"{temperatura}F = {wynik}C");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór. Użyj C lub F.");
            }
        }
    }
}

    
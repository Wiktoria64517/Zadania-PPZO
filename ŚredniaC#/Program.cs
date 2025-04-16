using System;

namespace PPOSredniaocen
{ 

  class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczający średnią ocen ucznia");
            Console.WriteLine("Podaj liczbę ocen do wprowadzenia: ");

            int liczbaOcen;
            while (!int.TryParse(Console.ReadLine(), out liczbaOcen) || liczbaOcen <= 0)
            {
                Console.WriteLine("Błąd! Podaj poprawną liczbę ocen (> 0): ");
            }

            double sumaOcen = 0;

            for (int i = 1; i <= liczbaOcen; i++)
            {
                Console.Write($"Podaj ocene nr {i} (od 1 do 6): ");
                double ocena;

                while (!double.TryParse(Console.ReadLine(), out ocena) || ocena < 1 || ocena > 6)
                {
                    Console.WriteLine("Nieprawidłowa ocena. Wprowadź wartość od 1 do 6: ");
                }

                sumaOcen += ocena;
            }

            double srednia = sumaOcen / liczbaOcen;
            Console.WriteLine($"\nŚrednia ocen: {srednia:F2}");

            if (srednia >= 3.0)
            {
                Console.WriteLine("Uczeń zaliczył przedmiot.");
            }
            else
            {
                Console.WriteLine("Uczeń nie zaliczył przedmiotu.");
            }
        }
   }
}
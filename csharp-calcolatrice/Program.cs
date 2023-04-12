namespace csharp_calcolatrice
{
    internal class Program
    {

        public static class CalcoliHelper
        {

            // SOMMA
            public static int Somma(int x, int y)
            {
                return x + y;
            }
            public static double Somma(double x, double y)
            {
                return x + y;
            }


            // DIFFERENZA
            public static int Differenza(int x, int y)
            {
                return x - y;
            }
            public static double Differenza(double x, double y)
            {
                return x - y;
            }


            // MOLTIPLICAZIONE
            public static int Moltiplicazione(int x, int y)
            {
                return x * y;
            }
            public static double Moltiplicazione(double x, double y)
            {
                return x * y;
            }


            // VALORE ASSOLUTO
            public static int ValoreAssoluto(int x)
            {
                return Math.Abs(x);
            }
            public static double ValoreAssoluto(double x)
            {
                return Math.Abs(x);
            }


            // MINIMO
            public static int Minimo(int x, int y)
            {
                if (x < y)
                    return x;

                else
                    return y;
            }
            public static double Minimo(double x, double y)
            {
                if (x < y)
                    return x;

                else
                    return y;
            }


            // MASSIMO
            public static int Massimo(int x, int y)
            {
                if (x > y)
                    return x;

                else
                    return y;
            }
            public static double Massimo(double x, double y)
            {
                if (x > y)
                    return x;

                else
                    return y;
            }


            // POTENZA
            public static double Potenza(double x, double y)
            {
                if (x == 0 && y==0)
                {
                    return 1; //se x=0 e y=0 allora il risultato è 1
                }
                else
                {
                    double risultato = 1;
                    for (double i = 0; i < y; i++) //se né la x né la y rientrano nei casi allora fare una potenza normale
                    {
                        risultato *= x;
                    }
                    return risultato;

                }


                // Polimorfismo: classi con lo stesso nome ma diverso tipo di variabile in entrata

            }


            static void Main(string[] args)
            {
                // SOMMA
                Console.WriteLine("Esempi somma: ");
                int result1 = CalcoliHelper.Somma(5, 3);
                double result2 = CalcoliHelper.Somma(2.5, 1.75);
                Console.WriteLine($"5+3: {result1} ||| 2,5+1,75: {result2}");

                // DIFFERENZA
                Console.WriteLine("Esempi differenza: ");
                int result3 = CalcoliHelper.Differenza(10, 3);
                double result4 = CalcoliHelper.Differenza(5.2, 2.8);
                Console.WriteLine($"10-3: {result3} ||| 5,2-2,8: {result4}");

                // MOLTIPLICAZIONE
                Console.WriteLine("Esempi moltiplicazione: ");
                int result5 = CalcoliHelper.Moltiplicazione(12, 9);
                double result6 = CalcoliHelper.Moltiplicazione(67.5, 3.4);
                Console.WriteLine($"12*9: {result5} ||| 67,5*3,4: {result6}");

                // VALORE ASSOLUTO
                Console.WriteLine("Esempi valore assoluto: ");
                int result7 = CalcoliHelper.ValoreAssoluto(-8);
                double result8 = CalcoliHelper.ValoreAssoluto(-2.6);
                Console.WriteLine($"-8: {result7} ||| -2,6: {result8}");

                // MINIMO
                Console.WriteLine("Esempi minimo: ");
                int result9 = CalcoliHelper.Minimo(34, 21);
                double result10 = CalcoliHelper.Minimo(19.5, 3.66);
                Console.WriteLine($"fra 34 e 21: {result9} ||| fra 19,5 e 3,66: {result10}");

                // MASSIMO
                Console.WriteLine("Esempi massimo: ");
                int result11 = CalcoliHelper.Massimo(88, 2);
                double result12 = CalcoliHelper.Massimo(55.5, 2.98);
                Console.WriteLine($"fra 88 e 2: {result11} ||| fra 55,5 e 2,98: {result12}");

                //POTENZA
                Console.WriteLine("Scegli i due numeri da elevare: ");
                Console.Write("Inserisci base: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Inserisci esponente: ");
                int y = Int32.Parse(Console.ReadLine());
                double result13 = CalcoliHelper.Potenza(x, y);
                Console.WriteLine($"il numero {x} elevato {y} come risultato ha: {result13}");
            }
        }
    }
}
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wyjscie = false;
            while (!wyjscie)
            {
                Console.WriteLine("Wybor: \n 1 zad1 \n 2 zad2 \n 4 zad4 \n");
                var wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "1": zad1(); break;
                    case "2": zad2(); break;
                    case "4": zad4(); break;
                    case "5": zad5(); break;
                    case "wyjdz":wyjscie=true; break;
                    default: Console.WriteLine("zly wybor"); break;
                }
            }



        }
        static void zad1()
        {
            var input = Console.ReadLine();
            int liczba = int.Parse(input);
            if (liczba % 2 == 0)
            {
                Console.WriteLine("parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
        }
        static void zad2()
        {
            var N = Console.ReadLine();
            for (int i = 0; i <= int.Parse(N); i += 2)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void zad4()
        {
            int N = int.Parse(Console.ReadLine());
            N = silnia(N);
            Console.WriteLine("Silnia wynosi: "+ N);

            int silnia(int n)
            {
                if (n < 2)
                {
                    return 1;
                }
                return n * silnia(n - 1);
            }


        }
        static void zad5()
        {

            bool zgadniete = false;
            Random rand = new Random();
            int wylosowana = rand.Next(1, 10);
            int ilosc_prob = 0;
            while (!zgadniete)
            {
                int N = int.Parse(Console.ReadLine());
                if (N == wylosowana)
                {
                    Console.WriteLine("Zgadles");
                    Console.WriteLine("Ilosc prob: " + (ilosc_prob+1));
                    zgadniete = true;
                }
                else
                {
                    Console.WriteLine("Zle");
                    ilosc_prob++;
                }   

            }
       
            
        }

    }

}

namespace CS_Konzole
{
    internal class Program
    {
        static int Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine($"CHYBA! Počet vstupních parametrů: {{{args.Length}}}");
                    return 1;
                case 1:
                    if (true)
                    {
                    }
                    break;
            }
                

            Console.WriteLine("Hello, World!");

            Console.Read();
            return 0;
        }
    }
}
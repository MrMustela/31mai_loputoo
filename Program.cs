using System.Security.Cryptography.X509Certificates;

namespace _31mai_lõputoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //max ja range
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Vali: ");
            Console.WriteLine("1. max ja 2. range ja 3. püramiid ja 4. fail");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.WriteLine("lõpu numbri leidmine");
                    MaxMethod();
                    break;

                case "2":
                    Console.WriteLine("keskmise numbri arvutamine");
                    AverageMethod();
                    break;

                case "3":
                    Console.WriteLine("püramiid");
                    Pyramide();
                    break;

                case "4":
                    IfAndElseFile();
                    break;

                default:
                    Console.WriteLine("Midagi läks valesti... ");
                    break;

            }
        }
        public static void MaxMethod()
        {
            var max = Numbers.number.Max();

            Console.WriteLine("Numbri lõpp on: " + max);
        }
        public static void AverageMethod()
        {
            var averageTest = Numbers.number.Average(x => x);
                
            Console.WriteLine("Tulemus: " + averageTest);
        }
        public static void IfAndElseFile()
        {
            Console.WriteLine("if ja else");
            Console.WriteLine("Kirjuta midagi siia");
            string inputText = Console.ReadLine();
            string theFilePath = @"C:/Users/Opilane/Desktop/WriteToFile.txt";

            if (File.Exists(theFilePath))
            {
               Console.WriteLine("Muutsite teksti");
                File.WriteAllText(theFilePath, inputText);
            }
            else
            {
               Console.WriteLine("Lõid uue faili");
               File.WriteAllText(theFilePath, inputText);
            }
        }

        public static void Pyramide()
        {
            int x = 3;
            int y = 1;
            int number = 1;
            for (int i = 0; i < 3; i++)
            {
                x--;
                y++;
                Console.WriteLine(" ");
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write(" ");
                    if (j == x)
                    {
                        for (int k = 1; k < y; k++)
                        {
                            Console.Write(" " + number);
                            number++;
                        }
                    }
                }
            }
        }
    }
}
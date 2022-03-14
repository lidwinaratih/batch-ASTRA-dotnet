namespace Day1
{
    class consoleIntro
    {
        public static void MultiControl()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            Console.Write("Code id bootcamp");

            //concat
            Console.WriteLine("Code Academy " + " Bootcamp .Net");

            //tab
            Console.WriteLine("Code academy \t Boootcamp");

            //quote
            Console.WriteLine("I love programming \"C\"");

            //verbatin
            Console.WriteLine(@"BOOTCAMP .NET with Code.id Academy
Lokasi Sentul CIty Bogor
Indonesia
");

            //formating number
            Console.WriteLine("Temperature di bogor tanggal {0} suku {1} celcius", DateTime.Today, 20);

        }
    }
}
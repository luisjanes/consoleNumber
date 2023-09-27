using System.Globalization;

namespace consoleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //se quiser uma grande precisão, pode utilizar o decimal, caso contrário pode usar double ou float
            decimal coin = 15810.25m;
            var cultureUS = CultureInfo.CreateSpecificCulture("en-US");
            var cultureBR = CultureInfo.CreateSpecificCulture("pt-BR");
            var culturePT = CultureInfo.CreateSpecificCulture("pt-PT");
            var cultureDN = CultureInfo.CreateSpecificCulture("dn-DN");
            var cultureJP = CultureInfo.CreateSpecificCulture("jp-JP");
            //da pra usar o C, G, N, E04.
            Console.WriteLine(coin.ToString("C", cultureUS));
            Console.WriteLine(coin.ToString("C", cultureBR));
            Console.WriteLine(coin.ToString("C", culturePT));
            Console.WriteLine(coin.ToString("C", cultureDN));
            Console.WriteLine(coin.ToString("C", cultureJP));

            //Math
            Console.WriteLine(Math.Round(coin));
            Console.WriteLine(Math.Ceiling(coin));
            Console.WriteLine(Math.Floor(coin));
        }
    }
}

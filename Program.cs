using HomeWork28.Classes;

namespace HomeWork28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var otusDictionary = new OtusDictionary();
            otusDictionary.Add(1, "qwe");
            otusDictionary.Add(2, "sdasd");
            otusDictionary.Add(4, "sdasd444");
            otusDictionary.Add(36, "36 sdasd444");
            otusDictionary.Add(598, "3qwe");
            otusDictionary.Add(235, "41sdasd");
            otusDictionary.Add(1444, "1444 sdasdsax");

            Console.WriteLine("Перебор массива:");
            for (int i = 0; i < otusDictionary.Capacity; i++)
            {
                var de = otusDictionary.IndexOf(i);
                if (de is not null)
                {
                    Console.WriteLine($"{otusDictionary.IndexOf(i).Key}={otusDictionary.IndexOf(i).Name}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Параметры массива:");

            Console.WriteLine($"Capacity={otusDictionary.Capacity}");
            Console.WriteLine($"Size={otusDictionary.Size}");

            Console.WriteLine("");
            Console.WriteLine("Удачный поиск:");
            Console.WriteLine($"1444={otusDictionary[1444]}");
            Console.WriteLine("");
            Console.WriteLine("Неудачный поиск (12):");
            Console.WriteLine($"12={otusDictionary[12]}");
        }
    }
}

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
            otusDictionary.Add(3, "3qwe");
            otusDictionary.Add(4, "41sdasd");
            otusDictionary.Add(4, "42sdasdsax");

            for (int i = 0; i < otusDictionary.Capacity; i++)
            {
                var de = otusDictionary.IndexOf(i);
                if (de is not null)
                {
                    Console.WriteLine($"{otusDictionary.IndexOf(i).Key}={otusDictionary.IndexOf(i).Name}");
                }
            }
            Console.WriteLine($"Capacity={otusDictionary.Capacity}");
            Console.WriteLine($"Size={otusDictionary.Size}");
            Console.WriteLine($"3={otusDictionary.Get(3)}");
            Console.WriteLine(otusDictionary.Get(12));
        }
    }
}

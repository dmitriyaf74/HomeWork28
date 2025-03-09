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
            otusDictionary.Add(4, "4sdasd");

            for (int i = 0; i < otusDictionary.Size; i++)
            {
                //Console.WriteLine(otusDictionary.Get(otusDictionary.IndexOf(i).Key));
                Console.WriteLine(otusDictionary.IndexOf(i).Key);
                Console.WriteLine(otusDictionary.IndexOf(i).Name);
            }
            //Console.WriteLine(otusDictionary.Get(12));
        }
    }
}

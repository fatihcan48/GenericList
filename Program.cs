namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> sayilar = new MyList<int>();

            sayilar.Add(5);
            sayilar.Add(8);
            sayilar.Add(9);

            foreach (var i in sayilar.Items)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Listenin eleman sayısı : "+sayilar.Lenght);

            Console.ReadKey();
        }
    }
}
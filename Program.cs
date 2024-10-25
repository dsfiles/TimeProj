namespace TimeProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Time t1 = new Time();
            Console.WriteLine(t1);
            Console.WriteLine(t1.hour);
            Console.WriteLine(t1.minute);
            Console.WriteLine(t1.second);

            Time t2 = new Time(11, 23, 55);
            Console.WriteLine(t2.hour);
            Console.WriteLine(t2.minute);
            Console.WriteLine(t2.second);

            Console.WriteLine($"{t2.hour}:{t2.minute}:{t2.second}");
        }
    }
}

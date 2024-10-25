namespace TimeProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            
            Time t2 = new Time(11, 23, 55);
            

            Console.WriteLine($"{t2.hour}:{t2.minute}:{t2.second}");
            Time.WriteTime(t2);
            Time.WriteTime2(t2);
            t1.WriteTime3();
            t2.WriteTime3();
        }
    }
}

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
            Console.WriteLine("let's invoke WriteTime4:");
            
            t1.WriteTime4(t1);
            t1.WriteTime4(t2);
            t2.WriteTime4(t1);
            t2.WriteTime4(t2);
            /*
        public void WriteTime4(Time t)
        {   // a version takes an argument
            Console.WriteLine(t.hour + ":" + t.minute + ":" + t.second);
        }
            */
        }
    }
}

namespace HorasPerfeitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 0, 0);
            while (t1.Days < 1)
            {
                TimeSpan t2 = TimeSpan.FromSeconds(60);
                t1 = t1.Add(t2);
                if((t1.Hours/10 < t1.Hours%10) && (t1.Hours%10 < t1.Minutes/10) && (t1.Minutes/10 < t1.Minutes%10)){
                    if((t1.Hours%10 == (t1.Hours/10 + 1)) && (t1.Minutes/10 == (t1.Hours%10 + 1)) && (t1.Minutes%10 == (t1.Minutes/10 + 1))){
                        Console.WriteLine(t1);
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
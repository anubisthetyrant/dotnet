using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("hh:mm:ss tt"));
            System.Threading.Thread.Sleep(1000); // wait for 1 second
        }
    }
}
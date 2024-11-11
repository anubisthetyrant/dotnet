using System;
using System.Threading;
class ADWIN
{
static void Main()
{
Thread t = new Thread(Worker);
t.Start();
for (int i = 0; i < 10; i++)
{
Console.WriteLine("Marvel is better");
Thread.Sleep(100);
}
t.Join();
Console.WriteLine("Done");
}
static void Worker()
{
for (int i = 0; i < 10; i++)
{
Console.WriteLine("DC is good");
Thread.Sleep(100);
}
}
}
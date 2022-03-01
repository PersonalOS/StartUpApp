
public class ThreadTest
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Thread thread = new Thread(WriteY);
        thread.Start();
        thread.Name = "WriteY";
        Console.WriteLine(Thread.CurrentThread.Name);
        for (int i = 0; i < 1000; i++)
        {
            Console.Write("x");
        }
    }

    static void WriteY()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write("Y");
        }
    }
}

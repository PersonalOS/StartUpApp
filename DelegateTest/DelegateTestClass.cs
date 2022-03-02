namespace DelegateTest
{
    delegate int Transformer(int x);
    public class DelegateTestClass
    {
        public void TestFunc()
        {
            Transformer t = Square;
            Console.WriteLine(t(3));
        }

        static int Square(int x) { return x * x; }
    }
}
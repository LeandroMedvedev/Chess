using Board;

namespace Chess
{
    class Program
    {
#pragma warning disable IDE0060
        static void Main(string[] args)
        {
            Position p = new(3, 4);
            Console.WriteLine("Position: " + p);
            Console.ReadLine();
        }
    }
}

namespace dotNet5783_8405_0000;

partial class Program
{
    public  static  void Main()
    {
        Hello8405();
        Hello0000();
        Console.ReadLine();
    }
    static partial void Hello0000();

 static void Hello8405()
    {
        Console.WriteLine("Hello, whats your name?");

        string? n = Console.ReadLine();

        Console.WriteLine($"Welcome {n}");
    }
}

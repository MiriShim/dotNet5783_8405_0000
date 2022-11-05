partial class Program8405
{
    public  static  void Main()
    {
        Hellow8405();
        Hellow0000();
        Console.ReadLine();
    }
    static partial void Hellow0000();

 static void Hellow8405()
    {
        Console.WriteLine("Hello, whats your name?");

        string? n = Console.ReadLine();

        Console.WriteLine($"Welcome {n}");
    }
}
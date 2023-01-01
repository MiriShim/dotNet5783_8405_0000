// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
Alphon alphon = new();

foreach (var item in alphon )
{
    string s =   "d";
    char c = s[9];
   string newS= s += s+"fff";
   s += s + "d";

    string vv = InputLibrary.Input.ReadString("please type a name", ConsoleColor.Red);
}


public class Alphon : IEnumerable<Contact> ,IEnumerator<Contact>
{
    List<Contact> contacts = new List<Contact>();
    public  List<Dial> Dials = new List<Dial>();

    public bool AddContact (Contact c)
    {
        contacts.Add(c);
        return true;
    }

    #region Implemet the interfaces
    int current;
     public Contact  Current => contacts[current];

    object IEnumerator.Current => contacts[current];

    public bool MoveNext()
    {
        if (current >= contacts.Count)
            return false;
        else
            current++;
        return true;
    }

    public void Reset()
    {
        current = -1;
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
    {
        return this;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
    #endregion
}

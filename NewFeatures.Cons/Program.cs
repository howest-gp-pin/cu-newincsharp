using static System.Console;
using System;

WriteLine("Hello " + (args.Length > 0 ? args[0] : "world!"));
Console.WriteLine(Foo());
Foo foo = new Foo();

return 0;

string Foo() { return $"In Foo method"; }

class Foo
{
    public Foo()
    {
        Console.WriteLine($"In Foo class");
    } 
}

// See https://aka.ms/new-console-template for more information



static void Greeting()
{
    Console.WriteLine("Hello users");
}

Greeting();

static void Greeting1(string name , int age)
{
    Console.WriteLine("Hello "+name +" you are "+ age);
}

Greeting1("Aman",23);



static int Cube(int a)
{
    a = a * a * a;
    return a;
}
Console.WriteLine(Cube(2));



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

struct Employee
{
    public int salary;
    public int age;
}
class Programs
{
    static void main(string[] args)
    {
        Employee e = new Employee();
        e.salary = 30000;
        e.age = 23;
        Employee e1 = e;
        Employee e2= e;
        e.age = 27;
        Console.WriteLine(e1.age);
        Console.WriteLine(e2.age);
        Console.ReadLine();


    }
}

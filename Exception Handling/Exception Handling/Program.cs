// See https://aka.ms/new-console-template for more information

//kuch exceptional error aayaa code me toh usko hmara program keise handle karega usko hi ham kehte hai exception handling
//ham try catch se isko handle kar sakte hai
/*
Console.Write("Enter a Number: ");
int num1=Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another Number: ");
int num2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 / num2); */
//if num1=5 and num2=0 error
//if num1=6 num2=h error
//so to avoid this kind of error use try catch


/*
try  //Right code hone per try chalegea warna catch chalega aur hmra diya Error show karega
{
    Console.Write("Enter a Number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter another Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch
{
    Console.WriteLine("Error");
}
*/

//try 
//{ 
//    Console.Write("Enter a Number: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Enter another Number: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine(num1 / num2);
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Enter a Number: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Enter another Number: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine(num1 / num2);
//}
//catch (DivideByZeroException e) //Ab only issi Type ke Expection ka message shoe karega aur kisi aur ka nhi
//{
//    Console.WriteLine(e.Message);
//}

/*
try
{
    Console.Write("Enter a Number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter another Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch (DivideByZeroException e) //Ab only issi Type ke Expection ka message shoW karega aur kisi aur ka nhi
{
    Console.WriteLine(e.Message);
}
catch (FormatException e)//Ab galt input i.e Alphabet dene per bhi error show karega
{
    Console.WriteLine(e.Message);
}
*/


try
{
    Console.Write("Enter a Number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter another Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch (DivideByZeroException e) //Ab only issi Type ke Expection ka message shoe karega aur kisi aur ka nhi
{
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
finally//It will always will get executed 
{
    Console.WriteLine("Code Executed ");
}


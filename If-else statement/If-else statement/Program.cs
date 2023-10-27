// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool isMale = true;
if(isMale)
{
    Console.WriteLine("You are male");
}
else
{
    Console.WriteLine("You are not male");

}

bool isTall=true;

if(isTall && isMale)
{
    Console.WriteLine("You are tall male");
}
else
{
    Console.WriteLine("You are either not maleor not tall or both ");
}


if (isTall || isMale)
{
    Console.WriteLine("You are tall male or only male or tall ");
}
else
{
    Console.WriteLine("You are either not male or not tall or both ");
}


if (isTall && isMale)
{
    Console.WriteLine("You are tall male");
}
else if (isMale && !isTall)
{
    Console.WriteLine("You are a short male");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not a male but you are tall");
}
else
{
    Console.WriteLine("You are not male and  not tall ");

}




static int GetMax(int num1, int num2)
{
    int result;
    if(num1 > num2)
    {
        result = num1;
    }
    else
    {
       result= num2;
    }
    return result;

}

int max=GetMax(4, 5);
Console.WriteLine(max);




static int GetMax4(int num1, int num2,int num3)
{
    int result;
    if (num1 >= num2 && num1>=num3)
    {
        result = num1;
    }


    else if (num2>=num1 && num2>=num3)
    {
        result = num2;
    }
    else
    {
        result = num3;
    }
    return result;
}

Console.WriteLine(GetMax4(3, 2, 4));
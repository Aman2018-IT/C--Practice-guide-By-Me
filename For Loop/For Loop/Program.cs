// See https://aka.ms/new-console-template for more information


for(int i=0;i<5;i++)
{
    Console.WriteLine(i);
}

int[] Numbers = { 4, 8, 15, 16, 23, 42 };

for(int i=1;i<Numbers.Length;i++)
{
   
    Console.WriteLine($"{Numbers[i]}");
}


//Exponent Function in c#
static int getPow(int n,int pow)
{
    int result = 1;
    for(int i=0;i<pow;i++)
    {
        result = result * n;
    }

    return result;

}

Console.WriteLine(getPow(3, 3));

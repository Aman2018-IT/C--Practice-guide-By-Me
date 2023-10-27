// See https://aka.ms/new-console-template for more information
//While Loop
int index = 1;
while(index<=4)
{
    Console.WriteLine(index);
    index++;
}


//do-while 
int a = 8;
do
{
    Console.WriteLine(a);
    a++;
}while(a<4);


//Guessing game

string secretWord = "giraffe";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outofGuess = false;

while(guess !=secretWord && !outofGuess)
{
    if (guessCount < guessLimit)
    {
        Console.WriteLine("Please guess ");
        guess = Console.ReadLine();
        guessCount += 1;

    }
    else
    {
        outofGuess = true;
    }
    if(outofGuess) { Console.WriteLine("You Lose"); }
    else { Console.WriteLine(); }
    
}

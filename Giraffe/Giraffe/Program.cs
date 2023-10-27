// See https://aka.ms/new-console-template for more information


//variables
string characterName = "John";
int CharacterAge;
CharacterAge = 34;

Console.WriteLine("There once was a man named "+ characterName);
Console.WriteLine("He was "+ CharacterAge + " years of old");

characterName = "Mike ";
Console.WriteLine("He really liked the  name "+characterName);
Console.WriteLine("But didn't like being "+CharacterAge);

string phrase = "Giraffe Academy";
char grade = 'C';
int no = 23;
//decimal dec = 23.2;
double gpa = 4.9;
//float roll= 23.22;
bool isMale= false;


Console.WriteLine("Giraffe \n Accademy ");
Console.WriteLine("Giraffe \" Accademy");

//string concatnation
Console.WriteLine("gIRRAFE" +" aCADEMY");

string myString = "Tecnomic System";
Console.WriteLine(myString.Length);

Console.WriteLine(myString.ToLower());

string phrase1 = "Giraffe World";
Console.WriteLine(phrase1.Contains("World"));
Console.WriteLine(phrase1[0]);
Console.WriteLine(phrase1.IndexOf("World"));
Console.WriteLine(phrase1.IndexOf('r'));
Console.WriteLine(phrase1.Substring(8));
Console.WriteLine(phrase1.Substring(8, 3));//only want 3 character
Console.WriteLine(phrase1.Substring(phrase1.IndexOf("World")));






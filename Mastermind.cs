using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

Console.Clear();
Random rand = new Random();
int one = 0;
int two = 0;
int three = 0;
int four = 0;

//makes the answer a random set of 4 letters
string[] answer2 = new string[] {"a", "b", "c", "d", "e", "f", "g"};
one = rand.Next(0,6);
string a1 = answer2[one];

while (two == one){
two = rand.Next(0,6);}
string a2 = answer2[two];

while (three == one || three == two){
three = rand.Next(0,6);}
string a3 = answer2[three];

while (four == one || four == three || four == two){
four = rand.Next(0,6);}
string a4 = answer2[four];

string answer = a1 + a2 + a3 + a4;

//runs the code
string guess = "";
int guesses = 0;
int correct = 0;
int wrong = 0;
do
{   
    guesses++;
    wrong = 0;
    correct = 0;

    Console.WriteLine($"guess {guesses}");
    Console.WriteLine("Guess four lowercase letters between a and g without any repeated letters");
    guess = Console.ReadLine();

        for (int i = 0; i < answer.Length; i++)
        {
            if (guess[i] == answer[i])
            {
                correct++;
            }
            else
            {
                for (int j = 0; j < answer.Length; j++)
                {
                    if (guess[i] == answer[j] && i != j)
                    {
                        wrong++;
                        break;
                    }
                }
            }
        }


Console.WriteLine(guess);

for (int i = 0; i < answer.Length; i++)
{
if (guess[i] == answer[i])
{
Console.BackgroundColor = ConsoleColor.Green;
Console.Write(guess[i]);
Console.BackgroundColor = ConsoleColor.Black;
}else{
for (int j = 0; j < answer.Length; j++)
{
if (guess[i] == answer[j] && i != j)
{
Console.BackgroundColor = ConsoleColor.Red;
Console.Write(guess[i]);
Console.BackgroundColor = ConsoleColor.Black;} else {
if (guess[i] != answer[0] && guess[i] != answer[1] && guess[i] != answer[2] && guess[i] != answer[3]){
Console.Write(guess[i]);
break;
}}}}}
Console.WriteLine("");


    Console.WriteLine($" {correct} Correct letters and places");
    Console.WriteLine($" {wrong} Correct letters and wrong places");
    Console.WriteLine("(press any key to continue)");
    Console.ReadKey(); //prevents the stuff from being cleared before the player is ready
    Console.Clear();
}

while (guess != answer);

if (guess == answer){
Console.WriteLine($"Congratulations, you won in {guesses} moves!");
}
Console.ReadKey();
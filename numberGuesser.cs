using System.Text;
using System.Threading.Tasks;

namsespace NumberGuesser{
class Program{
static void Main(string[] args){
Random r = new Random();

int winNum = r.Next(0, 100);

bool win = false;

do
{
Console.WriteLine("Guess a number between 0 and 100: ");

string s =Console.ReadLine();

int i = int.Parse(s);

if(i>winNum){
Console.WriteLine("Too high, friend! Guess a lower number...");
}else if(i<winNum){
Console.WriteLine("Too low, friend! Guess a higher number...");
}else if(i == winNum){
Console.WriteLine("You guessed right!");
win = true;
}
Console.WriteLine();
} while(win==false);
Console.WriteLine("Thank you for playing my game!");
Console.WriteLine("Press any key to finish and close the console.");
}
}
}
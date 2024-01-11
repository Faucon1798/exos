// See https://aka.ms/new-console-template for more information
//Modify the Console.WriteLine statement to say "Good morning, world!".
using System.Text;

Console.WriteLine("Good morning, world!");

//Add another Console.WriteLine statement that says "My name ia [your name]"
Console.WriteLine("My name is FOUMBOULOU BOUKANDA BERIC PHINEE");

//Add a line that printsthe result of a simple arithmetic operation, like 5 + 3.
Console.WriteLine("The result of 5 + 3 is " + (5 + 3));

//Modify the program to print out three different lines of text, each on new line.
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");
Console.WriteLine("This is the third line.");

//Introduce a string variable to hold your name and use it in a Console.WriteLine statement
string name = "Beric";
Console.WriteLine("My name is " + name + ".");

//Use string concatenation to combine two strings in a Console.WriteLine statement.
string firstName = "Beric";
string lastName = "Phinee";
Console.WriteLine("My name is " + firstName + " " + lastName + ".");

//Add a line to read user input with Console.ReadLine() and then print it out.
string input = Console.ReadLine();
Console.WriteLine("You entered: " + input);

//Add comments to the program explaining what each line of code does.
// Declare a string variable named "name" and assign it the value "Beric".
string nickname = "Faucon";
// Use the Console.WriteLine() method to print the string "My name is " followed by the value of the "name" variable and the string "." to the console.
Console.WriteLine("My nickname is " + nickname + ".");

//Use Console.WriteLine to print out a number (like your favorite number).
int favoriteNumber = 1798;
Console.WriteLine("My favorite number is " + favoriteNumber + ".");

//Add a line to display the current date using DateTime.Now
Console.WriteLine("The current date is " + DateTime.Now.ToString("MM/dd/yyyy") + ".");
Console.WriteLine("Hello, JR!");

Console.WriteLine("What is your favorite sweet? ");

string favoriteSweet = Console.ReadLine();
Console.WriteLine("I really like " + favoriteSweet + " aswell");

string first = "On top of that, I really enjoy Peanut Butter too ";
string last = "What about you? ";
string message = first + "," + last;
Console.WriteLine(message);

string person = "JR";
Console.WriteLine($"Hey, {person}!");

string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! Nice to meet you too.");

var isActive = true;
Console.WriteLine(isActive);

 // Declare variables using an explicit type
 string place = "Colombia";

 // Declare a variable using var

 var temperature = 26.6;

 // Display the values of your variables

 Console.WriteLine(place);
 Console.WriteLine(temperature);

 // Reassign a variable to a new value

 temperature = 24.6;

 Console.WriteLine($"This is the temperature today {temperature}");

 Console.WriteLine("Hello, \"World\"!");

 Console.WriteLine("c:\\source\repos");

 Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");

var numbers = "1, 2, 3, 4, 5";
var classrooms = "English, Math, Science, History";
var combined = "The numbers are: " + numbers + " " + classrooms;
Console.WriteLine(combined);

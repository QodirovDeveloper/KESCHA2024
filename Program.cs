
System.Console.Write("Enter your name: ");
string name = System.Console.ReadLine ( );
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
string ageAsString = System.Console.ReadLine ( );
System.Console.WriteLine("Coverting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"successfully converted! {age}");

int keschasAge = 3;
int ageDifference = age + keschasAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");
System.Console.WriteLine(ageDifference); 

if(age > keschasAge) 
{
    System.Console.WriteLine("You're older!");
}
else if(age == keschasAge)
{
    System.Console.WriteLine("You are equal");
}
else
{
    System.Console.WriteLine("You're younger!");
}
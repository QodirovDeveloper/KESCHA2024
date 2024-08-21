System.Console.WriteLine("Enter your name: ");
string name = Console.ReadLine(); 
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter you  age: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted! {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");


//ternary operator
string message =
    keschasAge > age
        ? "kescha is older"
        : "kescha is younger";
System.Console.WriteLine(message);

if (age > keschasAge)
{
    System.Console.WriteLine("You are older !");
}
else if(age == keschasAge)
{
    System.Console.WriteLine("You are equal");
}
else
{
    System.Console.WriteLine("You are younger!");
}

System.Console.WriteLine("Let me tell you about my friends.");

string[] friendsName = new string[3];
friendsName[0] = "Kasee";
friendsName[1] = "Vasya";
friendsName[2] = name;
int[] friendsAge = { 1, 2, age};

for(int iteration = 0; iteration < friendsName.Length; iteration++)
{
    System.Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} year old!");
}

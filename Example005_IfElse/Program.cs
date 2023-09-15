Console.Write("Enter username");
string username = Console.ReadLine();

if (username.ToLower() == "jon")
{
    Console.WriteLine("Hura, This is jon!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
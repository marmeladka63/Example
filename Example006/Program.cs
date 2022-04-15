Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();

if (username.ToLower() == "света")
{
    Console.WriteLine("Света пойдем пить чай!");
}
else
{
    Console.Write("Пойдем плавать ");
    Console.WriteLine(username);

}
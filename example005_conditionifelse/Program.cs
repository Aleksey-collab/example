Console.Write("введите имя пльзователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
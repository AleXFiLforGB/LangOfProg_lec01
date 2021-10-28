Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "джон")
{
    Console.Write("Yippee ki-yay, ");
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
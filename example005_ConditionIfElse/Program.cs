// if (условия)
//{
    // набор действий 1
    //}
//{
    //else
//}
//{
    //набор действий 2
//}
Console.Write("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите ваше имя");
string name = Console.ReadLine();
Console.WriteLine($"привет, {name}!");
string dayOfWeek =  DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("ru-RU"));
Console.WriteLine(dayOfWeek);
Console.WriteLine("Хотите продолжить?");
string answer = Console.ReadLine();

if (answer.ToLower() == "да")
{
    Console.WriteLine("Продолжаем");
}
else
{
    Console.WriteLine("Завершаем");
}
using System.Text.RegularExpressions;

/// Номера

/*Regex rx = new Regex(@"[0-9]{1}.[0-9]{3}.[0-9]{3}-[0-9]{2}-[0-9]{2}");
string filePath = @"D:\ПР-5 Сертиф\Scam.txt";
string fileNum = @"D:\ПР-5 Сертиф\Numbers.txt";
string text = File.ReadAllText(filePath, System.Text.Encoding.UTF8);
string output = "";
MatchCollection matches = rx.Matches(text);
if (matches.Count > 0)
{
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
    output += match.Value + "\n";
}
}
File.WriteAllText(fileNum, output);
Console.WriteLine("Номера добавлены");
Console.ReadKey();*/

/// IP-адреса

/*Regex rx = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
string filePath = @"D:\ПР-5 Сертиф\IP-adress.txt";
string fileNum = @"D:\ПР-5 Сертиф\IPs.txt";
string text = File.ReadAllText(filePath, System.Text.Encoding.UTF8);
string output = "";
MatchCollection matches = rx.Matches(text);
if (matches.Count > 0)
{
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
    output += match.Value + "\n";
}
}
File.WriteAllText(fileNum, output);
Console.WriteLine("IP-адреса добавлены");
Console.ReadKey();*/

/// Проверка почты

/*Email:
Console.Write("Введите логин: ");
string? email = Console.ReadLine();
Regex rxe = new Regex(@"(@gmail\.com)|(@mail\.ru)|(@yandex.ru)");
if (email != null)
{
    if (rxe.IsMatch(email))
    {
        Console.WriteLine("Логин введен корректно");

        Console.Write("Введите пароль: ");
        string? pass = Console.ReadLine();
        Regex rxp = new Regex(@"(?=.*[A-Z].*[A-Z])(?=.*[-!@#$%^&*()_+.,].*[-!@#$%^&*()_+.,]).{5,}");

        if (pass != null)
        {
            if (rxp.IsMatch(pass)) Console.WriteLine("Пароль введен корректно");
            else Console.WriteLine("Пароль введен некорректно");
        }
    }
    else
    {
        Console.WriteLine("Логин введен некорректно, попробуйте снова");
        goto Email;
    }
}
Console.ReadKey();*/

/// Замена номеров на xxx

/*Regex rx = new Regex(@"[0-9]{1}.[0-9]{3}.[0-9]{3}-[0-9]{2}-[0-9]{2}");
string fileNum = @"D:\ПР-5 Сертиф\Numbers.txt";
string text = File.ReadAllText(fileNum, System.Text.Encoding.UTF8);
MatchCollection matches = rx.Matches(text);
if (matches.Count > 0)
{
    foreach (Match match in matches)
    {
        string output = match.Value;
        string textr = Regex.Replace(output, @"[0-9]{2}-[0-9]{2}-[0-9]{2}$", "xx-xx-xx");
        Console.WriteLine(textr);
    }
}
Console.ReadKey();*/
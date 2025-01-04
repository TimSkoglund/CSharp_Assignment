using System.ComponentModel.DataAnnotations;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("KONTAKTLISTA");
Console.ResetColor();

Console.WriteLine("\nAnvänd \u001b[32m↑\u001b[0m och \u001b[32m↓\u001b[0m tangenterna,tryck \u001b[32mEnter\u001b[0m för att välja alternativet.");

ConsoleKeyInfo key;
int option = 1;
bool isSelected = false;
(int left, int top) = Console.GetCursorPosition();
string color = "\u001b[32m → ";

Console.CursorVisible = false;   

while (!isSelected)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine($"{(option == 1 ? color: "   ")}Lägg till kontakt\u001b[0m");
    Console.WriteLine($"{(option == 2 ? color: "   ")}Se Kontakter\u001b[0m");

    key = Console.ReadKey(true);
    switch (key.Key)
    {
        case ConsoleKey.DownArrow:
            option = (option == 2 ? 1 : option +1);
            break;
        
        case ConsoleKey.UpArrow:
            option = (option == 1 ? 2 : option - 1);
            break;

        case ConsoleKey.Enter:
            isSelected = true;
            break;

    }

var telefonbok = new telefonbok();
switch (userInput)
   { 
    case "1":
        Console.WriteLine($"Ange förnamn:");
        var förNamn = Console.ReadLine();

        Console.WriteLine($"Ange efternamn:");
        var efterNamn = Console.ReadLine();

        Console.WriteLine($"Ange efternamn:");
        var Email = Console.ReadLine();

        Console.WriteLine($"Ange efternamn:");
        var Telefon = Console.ReadLine();

        Console.WriteLine($"Ange efternamn:");
        var Address = Console.ReadLine();

        Console.WriteLine($"Ange efternamn:");
        var Stad = Console.ReadLine();

        Console.WriteLine($"Ange efternamn:");
        var efterNamn = Console.ReadLine();

        var newContact = new Contact(förNamn, efterNamn, Email, Telefon, Address, Stad);
        PhoneAttribute.AddContact(newContact);
}
}
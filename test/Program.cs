﻿// if (6>3)
// {
// Console.WriteLine("Hello, World!");
// }
System.Console.WriteLine("Användarnamn:");
string namn = Console.ReadLine();
System.Console.WriteLine("Lösenord");
string Lösenord = Console.ReadLine();
if (namn == "kalleanka")
{
    if (Lösenord == "12345")
    {
    System.Console.WriteLine("välkommen");
    }
    else{
        System.Console.WriteLine("Fel användarnamn eller lösenord");
    }
}
else{
    System.Console.WriteLine("Fel användarnamn eller lösenord");
}
Console.ReadLine();
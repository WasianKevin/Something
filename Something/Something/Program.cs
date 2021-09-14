using System;
using System.Threading;


Console.WriteLine("Nero: Good day, young traveler. Welcome to my store. What may your name be?");

string name;

name = Console.ReadLine();

string question = "";
while (question != "yes")
{
    Console.WriteLine($"Nero: {name}, did I get that right? (Yes or No)");

    question = Console.ReadLine();

    if (question == "no") {

       Console.WriteLine("Nero: No? Then what may your name be?");
        
       name = Console.ReadLine();

   }
}



if (question == "yes") {

  Console.WriteLine($"Nero: {name}.. What a lovely name! What can I get for you today?");

}

string Item;

Item = Console.ReadLine();



Console.WriteLine($"Nero: I believe I have {Item} laying around here somewhere. Give me a moment.");


Thread.Sleep(1200);

Console.WriteLine("...");

Thread.Sleep(1200);

Console.WriteLine(".....");

Thread.Sleep(1200);

Console.WriteLine(".......");

Thread.Sleep(1500);

Console.WriteLine("Ah, found it. Alright, that will be $10, but since I'm in a good mood today, you can have it for only $5.");

Thread.Sleep(1200);

Console.WriteLine("[Press Enter to pay the cashier]");

Console.ReadLine();

Console.WriteLine("       *Proceeds to have hardcore sex with the cashier*");

Thread.Sleep(1500);

Console.WriteLine("");
Console.WriteLine($"Nero: Thank you for buying! have a great day!");
Console.ReadLine();

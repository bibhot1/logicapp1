﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if(age > 18)
{
    Console.WriteLine("Go party in the club");
}
else if (age >= 13)

{
    Console.WriteLine("Are you with your parents press y for yes and n for no");
    string isWithParentsString = Console.ReadLine();
    if(isWithParentsString == "y")
    {
        Console.WriteLine("Party with parents");


    }
    else
    {
        Console.WriteLine("No party for you today");
    }
}
else
{
    Console.WriteLine("sTAY AT HOME.");
}

// See https://aka.ms/new-console-template for more information
int ClasherHP = 100;
// Hur mycket HP du har från start
int EvilHP = 100;
// Hur mycket HP fienden har från start


Console.WriteLine("Hello, fellow clasher!");
System.Console.WriteLine("What is thy nameth fellow clasher?");
//Console skriver en text (i denna fall en fråga om vad du heter)

string ClasherName = Console.ReadLine();
while (ClasherName == "")
{
    System.Console.WriteLine("\nWow, vilket fint namn att du heter        !");
    System.Console.WriteLine("Skriv ett namn nu din lilla sussy baka\n");
    
    ClasherName = Console.ReadLine();
}
 
//Ditt namn är vad du skriver, detta används igenom hela spelet
string EvilName = "Mini Pekka";
//Fiendens namn i variabeln Evilname, i detta fall Mini Pekka 

Random generator = new Random();
//Random generator som gör en ny random

while (ClasherHP > 0 && EvilHP > 0)
//Loopa koden nedan om ditt HP eller fiendens HP är mer än 0 
{
    fight();
    System.Console.WriteLine($"{EvilName} har {EvilHP} {ClasherName} har {ClasherHP}\n");

    int ClasherDamage = generator.Next(20);
    EvilHP -= ClasherDamage;
    System.Console.WriteLine($"{ClasherName} gör {ClasherDamage} skada på {EvilName}");
    System.Console.WriteLine($"{EvilName} har {EvilHP} {ClasherName} har {ClasherHP}\n");

    int EvilDamage = generator.Next(20);
    ClasherHP -= ClasherDamage;
    System.Console.WriteLine($"{EvilName} gör {EvilDamage} skada på {ClasherName}");
    System.Console.WriteLine($"{EvilName} har {EvilHP} {ClasherName} har {ClasherHP}\n");
    
    System.Console.WriteLine("Tryck på valfri knapp för att gå vidare");
    Console.ReadKey();
    
}

System.Console.WriteLine("\n round finished");

if (ClasherHP == 0 && EvilHP == 0) 
{
     System.Console.WriteLine("DRAW");
    }
    else if (ClasherHP == 0) {
        System.Console.WriteLine($"{EvilName} vann (skill issue)");
    }
        else
        {
            System.Console.WriteLine($"{ClasherName} vann!");
        }

System.Console.WriteLine("Tryck på en knapp för att bli klar");
Console.ReadKey();

void fight()
{
    System.Console.WriteLine(@"""
    ______   ____   ______   __  __   ______   
   / ____/  /  _/  / ____/  / / / /  /_  __/   
  / /_      / /   / / __   / /_/ /    / /      
 / __/    _/ /   / /_/ /  / __  /    / /       
/_/      /___/   \____/  /_/ /_/    /_/        
                                               """);
}
//pröva att göra logicen i while loopen till en metod
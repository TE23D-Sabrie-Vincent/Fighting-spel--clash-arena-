// See https://aka.ms/new-console-template for more information
int ClasherHP = 100;
// Hur mycket HP du har från start
int EvilHP = 100;
// Hur mycket HP fienden har från start


Console.WriteLine("Hello, fellow clasher!");
System.Console.WriteLine("What is thy nameth fellow clasher?");
//Console skriver en text (i denna fall en fråga om vad du heter)

string ClasherName = Console.ReadLine();
//Ditt namn är vad du skriver, detta används igenom hela spelet
string EvilName = "Mini Pekka";
//Fiendens namn i variabeln Evilname, i detta fall Mini Pekka 

Random generator = new Random();

while (ClasherHP > 0 && EvilHP > 0)
{
    System.Console.WriteLine("\n 𝒻𝒾𝑔𝒽𝓉");
    System.Console.WriteLine($"{EvilName} har {EvilHP} {ClasherName} har {ClasherHP}\n");

    int ClasherDamage = generator.Next(20);
    EvilHP -= ClasherDamage;
    EvilHP = Math.Max(0, ClasherHP);
    System.Console.WriteLine($"{ClasherName} gör {ClasherDamage} skada på {EvilName}");

    
}

System.Console.WriteLine("");








Console.ReadLine();
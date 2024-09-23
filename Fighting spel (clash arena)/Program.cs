// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

int ClasherHP = 100;
// Hur mycket HP du har från start
int EvilHP = 100;
// Hur mycket HP fienden har från start


Console.WriteLine("Hello, fellow clasher!");
System.Console.WriteLine("What is thy nameth fellow clasher?");
//Console skriver en text (i denna fall en fråga om vad du heter)

string ClasherName = Console.ReadLine();
if (ClasherName == "")
{
    System.Console.WriteLine("Wow, vilket fint namn att du heter        !");
}
    while (ClasherName == "")
    {
    System.Console.WriteLine("Skriv ett namn nu din lilla sussy baka");
    ClasherName = Console.ReadLine();
    }
while  (ClasherName.Length >= 7)
{
    System.Console.WriteLine("aja baja, du har förlångt namn");
    ClasherName = Console.ReadLine();
}

 
//Ditt namn är vad du skriver, detta används igenom hela spelet
string EvilName = "Mini Pekka";
//Fiendens namn i variabeln Evilname, i detta fall Mini Pekka 

Random generator = new Random();
//Random generator som gör en ny random

fight();
while (ClasherHP > 0 && EvilHP > 0)
//Loopa koden nedan om ditt HP eller fiendens HP är mer än 0 
{ 
    System.Console.WriteLine($"{EvilName} har {EvilHP} hp {ClasherName} har {ClasherHP} hp \n");

    int ClasherDamage = generator.Next(20);
    EvilHP -= ClasherDamage;
    System.Console.WriteLine($"{ClasherName} gör {ClasherDamage} skada på {EvilName}");
    System.Console.WriteLine($"{EvilName} har {EvilHP} hp {ClasherName} har {ClasherHP} hp \n");

    int EvilDamage = generator.Next(20);
    ClasherHP -= ClasherDamage;
    System.Console.WriteLine($"{EvilName} gör {EvilDamage} skada på {ClasherName}");
    System.Console.WriteLine($"{EvilName} har {EvilHP} hp {ClasherName} har {ClasherHP} hp \n");

    System.Console.WriteLine("Tryck på valfri knapp för att gå vidare");
    Console.ReadKey();
    
}

finished();

if (ClasherHP == 0 && EvilHP == 0) 
{
     draw();
    }
    else if (ClasherHP == 0) {
        System.Console.WriteLine($"{EvilName} vann (skill issue)");
        winner();
    }
        else
        {
            System.Console.WriteLine($"{ClasherName} vann!");
            winner();


        }

System.Console.WriteLine("Tryck på en knapp för exit");
Console.ReadKey();

void fight()
{
    System.Console.WriteLine(@"
    ______   ____   ______   __  __   ______   
   / ____/  /  _/  / ____/  / / / /  /_  __/   
  / /_      / /   / / __   / /_/ /    / /      
 / __/    _/ /   / /_/ /  / __  /    / /       
/_/      /___/   \____/  /_/ /_/    /_/        
                                               ");
}
//pröva att göra logicen i while loopen till en metod

void finished() 
{
  System.Console.WriteLine(@" 
 _______          ______         __    __        __    __        _______                      ______         __     __        ________        _______        
/       \        /      \       /  |  /  |      /  \  /  |      /       \                    /      \       /  |   /  |      /        |      /       \       
$$$$$$$  |      /$$$$$$  |      $$ |  $$ |      $$  \ $$ |      $$$$$$$  |                  /$$$$$$  |      $$ |   $$ |      $$$$$$$$/       $$$$$$$  |      
$$ |__$$ |      $$ |  $$ |      $$ |  $$ |      $$$  \$$ |      $$ |  $$ |                  $$ |  $$ |      $$ |   $$ |      $$ |__          $$ |__$$ |      
$$    $$<       $$ |  $$ |      $$ |  $$ |      $$$$  $$ |      $$ |  $$ |                  $$ |  $$ |      $$  \ /$$/       $$    |         $$    $$<       
$$$$$$$  |      $$ |  $$ |      $$ |  $$ |      $$ $$ $$ |      $$ |  $$ |                  $$ |  $$ |       $$  /$$/        $$$$$/          $$$$$$$  |      
$$ |  $$ |      $$ \__$$ |      $$ \__$$ |      $$ |$$$$ |      $$ |__$$ |                  $$ \__$$ |        $$ $$/         $$ |_____       $$ |  $$ |      
$$ |  $$ |      $$    $$/       $$    $$/       $$ | $$$ |      $$    $$/                   $$    $$/          $$$/          $$       |      $$ |  $$ |      
$$/   $$/        $$$$$$/         $$$$$$/        $$/   $$/       $$$$$$$/                     $$$$$$/            $/           $$$$$$$$/       $$/   $$/       
                                                                                                                                                             
                                                                                                                                                             
                                                                                                                                                             ");      
}

void draw()
{
    System.Console.WriteLine(@" 
_______     .______              ___         ____    __    ____    
|       \    |   _  \            /   \        \   \  /  \  /   /    
|  .--.  |   |  |_)  |          /  ^  \        \   \/    \/   /     
|  |  |  |   |      /          /  /_\  \        \            /      
|  '--'  |   |  |\  \----.    /  _____  \        \    /\    /       
|_______/    | _| `._____|   /__/     \__\        \__/  \__/        
                            ¯\_(T_T)_/¯                                               ");
}
// fin Ascii text om båda personerna har 0 hp

// void Newround()
// {
//     System.Console.WriteLine(@" 
//  _   _                                           _ 
// | \ | | _____      __  _ __ ___  _   _ _ __   __| |
// |  \| |/ _ \ \ /\ / / | '__/ _ \| | | | '_ \ / _` |
// | |\  |  __/\ V  V /  | | | (_) | |_| | | | | (_| |
// |_| \_|\___| \_/\_/   |_|  \___/ \__,_|_| |_|\__,_|");
// }
// //Ny runda för att det ska vara best of 3 (PS: Detta används inte än)
void winner(){
    System.Console.WriteLine(@"  
  _   _ _____ _____   _   _ _____ _____   _   _ _____ _____   _   _    ___        __
 | | | | ____| ____| | | | | ____| ____| | | | | ____| ____| | | | |  / \ \      / /
 | |_| |  _| |  _|   | |_| |  _| |  _|   | |_| |  _| |  _|   | |_| | / _ \ \ /\ / / 
 |  _  | |___| |___  |  _  | |___| |___  |  _  | |___| |___  |  _  |/ ___ \ V  V /  
 |_| |_|_____|_____| |_| |_|_____|_____| |_| |_|_____|_____| |_| |_/_/   \_\_/\_/   
                                                                                    
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⠶⣶⠾⠿⢿⣇⢸⣿⣶⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣾⣿⣶⣿⡀⠸⠀⠀⢸⣿⢿⡇⠀⠈⠉⢻⣿⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶
⡿⠿⠿⠻⠿⠛⠛⠿⠿⠛⠛⠛⠛⠻⠛⢻⣿⡿⠋⢹⣿⣿⡇⠀⠀⠀⠈⢿⣿⡇⠀⠀⠀⣿⡿⠿⠿⠿⢿⠿⠿⠿⠿⠿⠿⠿⠿⠿⢿⠿
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣯⠀⠀⠀⠿⠟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣦⠀⠀⠀⠀⢀⣀⣠⡤⠤⠤⠤⣄⣰⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣧⢀⡴⠚⠉⠁⠀⠀⠀⠀⠀⣠⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣦⣤⣀⣀⣤⣤⣤⣶⡿⠟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣭⣭⣿⣿⣿⣿⣿⠿⢷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⡀⠀⣀⣀⣴⣿⣿⣴⣿⣿⣿⡍⠁⠀⠀⠀⣴⣶⣤⣿⣿⣷⣦⣄⡀⠀⢀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣠⣴⣾⡿⠿⠿⠿⠿⠿⠿⣿⣿⣿⣿⣿⣿⠿⠁⢀⣀⣀⡀⠻⢿⣿⣿⣿⣿⣿⠿⠿⠿⠿⠿⠿⠿⢿⣿⣶⣤⡀⠀⠀⠀⠀
⠀⠀⠀⣠⣾⡿⠋⠁⠀⠀⠀⠀⠀⠀⠀⢈⣿⡟⣋⡀⠀⠀⢰⡇⠀⠀⢸⠀⠀⠈⠉⠛⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣿⣆⠀⠀⠀
⠀⠀⢰⣿⡟⠀⠀⠀⠀⠀⠀⢀⣀⣀⣤⣾⠋⣼⣿⣿⣆⠀⢸⡇⠀⠀⢸⠀⢀⣶⣿⣷⡘⣿⡀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠹⣿⣆⠀⠀
⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⡇⠀⠀⠓⠺⢟⣀⣸⠃⠀⠀⢸⣀⣺⠿⠤⠈⠁⠘⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⢻⣿⠀⠀
⠀⠀⣿⡏⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣷⣶⣶⣿⡋⠁⠀⠀⠀⠀⠈⠉⠙⢿⣶⣶⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⣻⣿⡿⠿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⠟⠃⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⣴⣿⣿⣧⡀⠀⠀⢸⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⢸⡇⠀⠀⢀⡴⠻⣿⣷⡀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣷⣦⣼⣀⠀⠀⠀⠀⠀⣸⠀⠀⠀⠀⠀⢸⣀⣤⠶⠋⠀⠀⣿⣿⣿⡄⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⢿⠟⠛⠛⠒⠻⠒⠒⠛⠛⠋⠉⠉⠀⠀⠀⠀⢸⣿⣿⣿⣿⡄⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⠻⣿⣿⣿⣿⣿⣟⡛⠛⠁⠀⠀⠘⣠⣴⣾⣿⡗⢸⣿⣶⣤⣤⣄⠀⠀⠀⠀⣀⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⠀⠘⢿⣿⣿⣿⣟⠳⢦⣄⣀⡀⠋⠉⠙⠛⠻⢧⣿⠟⠉⠁⠀⠀⣙⣠⡴⠞⣻⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⣹⣿⣿⣿⣦⡀⠀⣹⠙⠓⠒⠒⠒⠲⢶⡷⠖⠒⠒⠚⠋⢹⠁⢀⣴⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⣇⠀⠀⠀⠀⠀⢠⣿⠻⣿⣿⣿⣿⣦⣁⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⢈⣶⣿⣿⣿⣿⠟⠛⣿⡀⠀⠀⠀⠀⠀⢸⣿⠀⠀
⠀⠀⣿⣿⡀⠀⠀⠀⢀⣿⣇⠀⠈⠻⣿⣿⣿⣿⣿⣶⣦⣤⣤⣤⣬⣤⣤⣤⣤⣶⣾⣿⣿⣿⡿⠟⠁⠀⠀⣿⣇⠀⠀⠀⠀⠀⣾⣿⠀⠀
⠀⠀⢿⣿⣷⡀⠀⠀⣼⡟⠙⠻⢦⣤⣀⠙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠟⠉⢀⣀⣴⠶⠟⠉⢿⡆⠀⠀⢀⣼⣿⣿⠀⠀
⠀⠀⠘⢿⣿⣿⣦⣴⡿⠀⠀⠀⠀⠈⠙⠛⠶⣦⣄⣈⠛⠿⣿⣿⣿⣿⣿⣿⠿⢋⣁⣤⠶⠾⠛⠉⠀⠀⠀⠀⠸⣿⣀⣴⣾⣿⣿⠃⠀⠀
⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠉⠛⠛⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠟⠛⠉⠀⠀⠀⠀⠀⠀  ");
}
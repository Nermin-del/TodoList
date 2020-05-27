using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    public class Menus
    {
        public void mainMenu() 
        {/*Jag klippte ut console writeline texten från program.cs filen. Skapade en ny fil som jag döpte till menu.cs och där började jag med att skriva in public void. 
            Vilket betyder att void är en metod. Och public gör så att metoden går att använda i filer utanför denna classen. Classen innebär då filerna som är separerade.
            Eftersom att det är i en annan fil så måste det vara öppen i en public class. Det stod först class menus men ändrade det till public också.*/
            Console.WriteLine();
            Console.WriteLine("[1] Lägg till en todo");
            Console.WriteLine("[2] Skriv ut innehållet");
            Console.WriteLine("[3] Markera som färdig");
            Console.WriteLine("[4] Visa arkiverade uppgifter");
            Console.WriteLine("[5] Avsluta");
            Console.WriteLine();
            Console.WriteLine("Välj ett nummer");
        }

    }
}

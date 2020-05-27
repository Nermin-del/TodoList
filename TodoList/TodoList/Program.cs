using System;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*todo: 1. Fixa alternativ. 1an ska ha funktionen att lägga till todo.  2an ska generera alternativet siffror som håller antal varor. 
             * 3an ska ha alternativet att kunna markera todo som färdig. 4an ska kunna ta bort oösnkade saker på listan. 5an kommer ha funktionen att avsluta program.
             en funktion som ger ett fel om man skriver in fel input ska även läggas in. Behöver en lista. Göra begränsningar.*/

            List<SelectAtTodo> todolist = new List<SelectAtTodo>(); //Todolista
            List<SelectAtTodo> archivelist = new List<SelectAtTodo>(); // Arkivering

            string input = "";
            bool runProgram = true;


            /*Började med att skriva in int input och sedan bool runprogram för att sedan skriva in consolen med writeline för att få in texten i consolen som jag skrev.
             * Skrev sedan in console.readline. Vilket innebär att kommandot gör så att programmet stannar förens den har integrerat med en knap.
             då runprogram redan var inskriver räckte det med att jag skrev in while runprogram så kopplades inputen samman med kommandon som jag sedan skrev in genom
             console.writeline och därefter skrev jag in numrering och vad varje kommando har för uppgift.*/

            Console.WriteLine("välkommen till din Todo-app");
            Console.WriteLine("klicka på valfri knapp");
            Console.ReadLine();
            while(runProgram) 
            {/*Här anropar jag main menu metod.*/

                if (input != "0")
                {
                    var menu = new Menus();
                    menu.mainMenu();

                    input = Console.ReadLine();

                }

                

                switch (input)
                {
                    case "1":// case 1 där jag skapade första sektionen utav kommandon.
                        Console.Clear();
                        Console.WriteLine("Lägg till todo");
                        string todo = Console.ReadLine();

                        var newTodo = new SelectAtTodo(todo);
                        todolist.Add(newTodo);
                        Console.Clear();
                        break;

                    case "2":// case 2 innebär sparade todos.
                        Console.Clear();
                        Console.WriteLine("Detta är din todolista");
                        Console.WriteLine();
                        todoforloop();// anropar todoforloop.

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":// case 3 ska visa markerade uppgifter.
                        Console.Clear();
                        Console.WriteLine("Vilka todos vill du markera? ");
                        todoforloop();

                        Console.WriteLine();
                        Console.WriteLine("ange index");
                        int index = Convert.ToInt32(Console.ReadLine());

                        archivelist.Add(todolist[index]);// arkivlistan
                        Console.WriteLine("Archived task" + index + " .");
                        todolist.RemoveAt(index);
                        Console.Clear();
                        break;
                                                        
                    case "4":
                        Console.Clear();
                        Console.WriteLine();
                        archiveforloop();

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("programmet avslutas");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Du måste välja mellan 1-5");// Detta händer om man skriver in fel input.
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            /*switch statement innebär nu att jag ska lägga till olika cases för att få funktionerna att ge en respons till consolen*/
           
            void todoforloop()
            {

                for (int i = 0; i < todolist.Count; i++)
                {
                    var mytodo = todolist[i];
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Index " + i);
                    Console.WriteLine("---------------------");
                    mytodo.toString();
                }

            }

            void archiveforloop()
            {
                for (int i = 0; i < archivelist.Count; i++)
                {
                    var archive = archivelist[i];
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("index " +i);
                    Console.WriteLine("---------------------");
                    archive.toString();
                }
            }
        }
    }
}

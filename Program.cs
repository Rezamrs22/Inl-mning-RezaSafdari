using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client.Extensibility;
using Bibliotek.Models;
using Bibliotek.CRUD;

class Program
{
    static void Main(string[] args)
    {
        int menuSel;
        do
        {
            //Console.Clear();
            menuSel = MenuSelection();
            MenuExecution(menuSel);

        } while (menuSel != 5);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("\nThank you for your time");
        Console.ForegroundColor = ConsoleColor.White;
        
    }

    private static void MenuExecution(int menuSel)
    {
        switch (menuSel)
        {
            case 1:
                CreateBookOrAuthor.Run();
                break;
            case 2:
                DeleteBookeOrAuthors.Run();
                break;
            case 3:
                ReadBooksOrAuthors.Run();
                break;
            case 4:
                UpdateBooksOrAuthors.Run();
                break;
            case 5:
                System.Console.WriteLine("Exiting program...");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Invalid selections. Try again.");
                Console.BackgroundColor = ConsoleColor.White;
                break;

        }
    }

    private static int MenuSelection()
    {
        while (true)
        {
            try
            {
                
                System.Console.WriteLine("Welcome to REZA SAFDARI's library");
                System.Console.WriteLine("1. Create a new author od book");
                System.Console.WriteLine("2. Remove author or books");
                System.Console.WriteLine("3. List Books With Authors");
                System.Console.WriteLine("4. Add a loan for a book");
                System.Console.WriteLine("5. Quit");
                   
                   
                int menuSel = int.Parse(Console.ReadLine());
                if (menuSel >= 1 && menuSel <= 5)
                {
                    return menuSel;
                }
                    
                    
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Invalid selection");
                Console.ForegroundColor = ConsoleColor.White;
                    
                
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            
        }

    }

    
}

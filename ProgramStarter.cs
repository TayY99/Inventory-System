// Program Starter

using System;
using System.Collections.Generic;

class Program
{
    static List<Item> inventory = new List<Item>(); // creates the list in memory

    static void Main()
    {
        bool running = true; // keeps the program running until told otherwise

        while (running)
        {
            Console.WriteLine("\nInventory System"); // menu for the inventory
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine(); //user input for item

            if (choice == "1")
            {
                AddItem();
            }
            else if (choice == "2")
            {
                RemoveItem();
            }
            else if (choice == "3")
            {
                ViewInventory();
            }
            else if (choice == "4")
            {
                running = false; // this stops the program
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter item name: ");
        string name = Console.ReadLine();

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        inventory.Add(new Item(name, quantity)); // creates new item and adds it to the list

        Console.WriteLine($"{name} added to inventory.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter item name to remove: ");
        string name = Console.ReadLine();

        Item itemToRemove = inventory.Find(item => item.Name.ToLower() == name.ToLower());

        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine($"{name} removed from inventory.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    static void ViewInventory()
    {
        Console.WriteLine("\nCurrent Inventory:");

        if (inventory.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        foreach (Item item in inventory)
        {
            Console.WriteLine($"{item.Name} - Quantity: {item.Quantity}"); // goes through each item in inventory
        }
    }
}

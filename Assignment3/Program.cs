// See https://aka.ms/new-console-template for more information

using foodsystem;

foodtrack ft = new foodtrack();

do {
    
string order = "";
string quote = "";

Console.WriteLine("How can I help you today?: (list/Add/Delete/Exit)");
quote = Console.ReadLine();
order = quote.ToLower();




    if (order == "list")
    {
        Console.WriteLine("Here is the list of Current Food Items: ");
        Console.WriteLine(" ");
        Console.WriteLine($"{ft.FoodList()}");
    }

    if (order == "add")
    {
        string item = "";
        string expireddate = "";
        int qty = 0;
        string category = "";

        Console.WriteLine("What kind of food would like to add? ");
        item = Console.ReadLine();
        
        Console.WriteLine("When is the expired date? ");
        expireddate = Console.ReadLine();
        
        Console.WriteLine($"How many of {item} would you like add?");
        while (!int.TryParse(Console.ReadLine(), out qty) || qty <= 0)
        {
            Console.WriteLine("Please enter a positive number:");
        }
        
        Console.WriteLine($"What is the category of {item}?");
        category = Console.ReadLine();
        
        
        bool ok = ft.AddFood(item, expireddate, qty, category);
        Console.WriteLine(ok ? $"{item} added successfully" : "Quantity must be positive.");
        
    }

    if (order == "delete")
    {
        
        Console.WriteLine("Tell me the item name that you want to delete: ");
        string item = Console.ReadLine();
        Console.WriteLine($"What category of {item}?");
        string category = Console.ReadLine();
        Console.WriteLine(ft.RemoveFood(item, category) ? "Deleted.": "Not found.");


    }

    if (order == "exit")
    {
        Console.WriteLine("Thank you for using this app! ");
        break;
    }
    
    if (order != "list" && order != "add" && order != "delete" && order != "exit")
    {
        Console.WriteLine("Invalid command. Please type: list / add / delete / exit");
    }

    
}while(true);





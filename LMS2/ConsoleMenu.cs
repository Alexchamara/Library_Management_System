class ConsoleMenu
{
    public static int mainMenu()
    {
        int option = 0;
        try
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("{0, -50}", "  Library Management System"));
            for (int i = 0; i < 50; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            Console.WriteLine("\t1. Librarian Login");
            Console.WriteLine("\t2. Brows Books");
            Console.WriteLine("\t3. Return Book");
            Console.WriteLine("\t4. Borrow Book");
            Console.WriteLine("\t5. Exit");

            Console.WriteLine();
            Console.Write("Select an option: ");
            option = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Pllease select an option between 1 - 4!");
            Console.WriteLine();
        }
        return option;
    }

    public static List<string> librarianLogin()
    {
        string userId = "";
        string password = "";

        Console.WriteLine("Librarian Login...");
        Console.WriteLine();
        while (true)
        {
            Console.Write("\tUser Id: ");
            userId = Console.ReadLine();
            Console.Write("\tPassword: ");
            password = Console.ReadLine();

            if (userId == "" || password == "")
            {
                Console.WriteLine("Please enter valid credentials!");
                continue;
            }
            else
            {
                return new List<string>() { userId, password };
            }
        }
    }

    public static int librarianMenu(string name)
    {
        int option = 0;
        while (true)
        {
            try
            {
                Console.WriteLine($"Welcome Back {name} :)");
                Console.WriteLine();
                Console.WriteLine("\t1. Add new book");
                Console.WriteLine("\t2. Remove a book");
                Console.WriteLine("\t3. Add new member");
                Console.WriteLine("\t4. Remove a member");
                Console.WriteLine("\t5. Back to main menu");
                Console.WriteLine();
                Console.Write("Select an option: ");
                option = int.Parse(Console.ReadLine());

                if (option == 1 || option == 2 || option == 3 || option == 4 || option == 5) { return option; }
                else { continue; }
            }
            catch
            {
                Console.WriteLine("Invalid Choice! Please try again :(");
                continue;
            }
        }
    }

    public static List<String> addNewBook()
    {
        string title;
        string author;
        string ISBN;

        Console.WriteLine("Add new book...");
        Console.WriteLine();
        Console.Write("\tTitle: ");
        title = Console.ReadLine();
        Console.Write("\tAuthor: ");
        author = Console.ReadLine();
        Console.Write("\tISBN Number: ");
        ISBN = Console.ReadLine();

        return new List<string>() { title, author, ISBN };
    }

    public static List<String> removeBook()
    {
        string title;
        string ISBN;

        Console.WriteLine("Remove book...");
        Console.WriteLine();
        Console.Write("\tTitle: ");
        title = Console.ReadLine();
        Console.Write("\tISBN number: ");
        ISBN = Console.ReadLine();

        return new List<string>() { title, ISBN };
    }

    public static List<String> addNewMember()
    {
        string name;
        string membershipId;

        Console.WriteLine("Add new member...");
        Console.WriteLine();
        Console.Write("\tName: ");
        name = Console.ReadLine();
        Console.Write("\tMembership Id: ");
        membershipId = Console.ReadLine();

        return new List<string>() { name, membershipId };
    }

    public static List<String> removeMember()
    {
        string name;
        string membershipId;

        Console.WriteLine("Remove member...");
        Console.WriteLine();
        Console.Write("\tName: ");
        name = Console.ReadLine();
        Console.Write("\tMembership Id: ");
        membershipId = Console.ReadLine();

        return new List<string>() { name, membershipId };
    }

    public static int browsBooks()
    {
        int choice = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Brows Books...");
                Console.WriteLine("\t1. Show all books");
                Console.WriteLine("\t2. Show available books");
                Console.WriteLine("\t3. Show borrowed books");
                Console.WriteLine("\t4. Main menu");
                Console.Write("Select an option: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Please enter a option between 1 - 4");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Invalid option! Please try again");
                continue;
            }

        }

    }
}
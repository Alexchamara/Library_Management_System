class Program
{
    static void Main(string[] args)
    {
        runConsoleApplication();
    }

    static void runConsoleApplication()
    {
        Library library = new Library();
        Librarian librarian1 = new Librarian();
        int mainOption = 0;
        while (mainOption != 5)
        {
            mainOption = mainMenu();
            if (mainOption == 1)
            {
                librarianLogin(librarian1, library);
            }
            else if (mainOption == 2)
            {
                browsBookMenu(library, librarian1);
            }
            else if (mainOption == 3)
            {
                Console.Clear();
                style("Returning a book...");
                librarian1.returnBook(library);

            }
            else if (mainOption == 4)
            {
                Console.Clear();
                style("Borrowing a book...");
                librarian1.borrowBook(library);
            }
            else if (mainOption == 5)
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                continueMassage("Invalid option! Please try again :(");
                continue;
            }
        }
    }

    static void style(String title)
    {
        Console.Clear();
        for (int i = 0; i < 50; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine(String.Format("{0, -50}", $"  {title}"));
        for (int i = 0; i < 50; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void continueMassage(string title = "Invalid option!", string message = "Press any key to continue...")
    {
        Console.WriteLine(title);
        Console.Write(message);
        Console.ReadKey();
        Console.Clear();
    }

    static void menuList(string option1, string option2, string option3, string option4, string option5)
    {
        Console.WriteLine($"\t1. {option1}");
        Console.WriteLine($"\t2. {option2}");
        Console.WriteLine($"\t3. {option3}");
        Console.WriteLine($"\t4. {option4}");
        Console.WriteLine($"\t5. {option5}");
    }

    static void menuList(string option1, string option2, string option3, string option4)
    {
        Console.WriteLine($"\t1. {option1}");
        Console.WriteLine($"\t2. {option2}");
        Console.WriteLine($"\t3. {option3}");
        Console.WriteLine($"\t4. {option4}");
    }

    static int mainMenu()
    {
        try
        {
            style("Library Management System");

            Console.WriteLine("\t1. Librarian Login");
            Console.WriteLine("\t2. Brows Books");
            Console.WriteLine("\t3. Return Book");
            Console.WriteLine("\t4. Borrow Book");
            Console.WriteLine("\t5. Exit");

            Console.WriteLine();
            Console.Write("Select an option: ");
            return int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }

    }

    static void librarianLogin(Librarian librarian, Library library)
    {
        string userId;
        string password;
        Console.Clear();
        style("Librarian Login...");
        Console.Write("\tUser id: ");
        userId = Console.ReadLine();
        Console.Write("\tPassword: ");
        password = Console.ReadLine();

        if (librarian.authonticated(userId, password))
        {
            Console.Clear();
            librarianMenu(librarian, library);
        }
        else
        {
            Console.WriteLine();
            continueMassage("Wrong user id or password");
        }
    }

    static void librarianMenu(Librarian librarian, Library library)
    {
        int option = 0;

        while (option != 5)
        {
            try
            {
                string bookTitle;
                string author;
                string ISBN;

                string memberName;
                string membershipId;
                Console.Clear();
                style($"Welcom back {librarian.Name}");

                Console.WriteLine("\t1. Add new book");
                Console.WriteLine("\t2. Remove book");
                Console.WriteLine("\t3. Add new member");
                Console.WriteLine("\t4. Remove member");
                Console.WriteLine("\t5. Log out");
                Console.WriteLine();
                Console.Write("Enter an option: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();

                    style("Add new book...");
                    Console.WriteLine("Enter book details...");
                    Console.WriteLine();
                    Console.Write("\tTitle: ");
                    bookTitle = Console.ReadLine();
                    Console.Write("\tAuthor: ");
                    author = Console.ReadLine();
                    Console.Write("\tISBN Number: ");
                    ISBN = Console.ReadLine();
                    if (bookTitle != "" && author != "" && ISBN != "")
                    {
                        library.addNewBook(bookTitle, author, ISBN);
                        Console.WriteLine();
                        continueMassage($"{bookTitle} added succesfully!", "Press any key to continue...");
                    }
                    else
                    {
                        Console.WriteLine();
                        continueMassage("Invalid Book Details!", "Please try again");
                    }
                }
                else if (option == 2)
                {
                    Console.Clear();
                    style("Remove book...");
                    Console.WriteLine("Enter book details...");
                    Console.WriteLine();
                    Console.Write("\tTitle: ");
                    bookTitle = Console.ReadLine();
                    Console.Write("\tISBN Number: ");
                    ISBN = Console.ReadLine();
                    if (bookTitle != "" && ISBN != "")
                    {
                        Console.WriteLine();
                        library.removeBook(bookTitle, ISBN);
                    }
                    else
                    {
                        Console.WriteLine();
                        continueMassage("Invalid Book Details!", "Please try again");
                    }

                }
                else if (option == 3)
                {
                    Console.Clear();
                    style("Add new member...");
                    Console.WriteLine("Enter new member details...");
                    Console.WriteLine();
                    Console.Write("\tFull Name: ");
                    memberName = Console.ReadLine();
                    Console.Write("\tMembership ID: ");
                    membershipId = Console.ReadLine();
                    if (memberName != "" && membershipId != "")
                    {
                        librarian.addMember(memberName, membershipId);
                        Console.WriteLine();
                        continueMassage($"{memberName} added succesfully!", "Press any key to continue...");
                    }
                    else
                    {
                        Console.WriteLine();
                        continueMassage("Invalid Details!", "Please try again");
                    }

                }
                else if (option == 4)
                {
                    Console.Clear();
                    style("Remove member...");
                    Console.WriteLine("Enter member details...");
                    Console.WriteLine();
                    Console.Write("\tFull Name: ");
                    memberName = Console.ReadLine();
                    Console.Write("\tMembership ID: ");
                    membershipId = Console.ReadLine();
                    if (memberName != null && membershipId != null)
                    {
                        librarian.removeMember(memberName, membershipId);
                    }

                }
                else if (option == 5)
                {
                    Console.WriteLine();
                    continueMassage("Loging out...", "Press any key to logout...");
                }
                else
                {
                    continueMassage();
                }
            }
            catch (Exception e)
            {
                continueMassage(e.Message);
            }
        }
    }

    static void browsBookMenu(Library library, Librarian librarian)
    {
        int option = 0;

        while (option != 6)
        {
            try
            {
                string bookTitle;
                string ISBN;

                string memberName;
                string membershipId;
                Console.Clear();
                style("Brows Books...");

                Console.WriteLine("\t1. Show all books");
                Console.WriteLine("\t2. Show available books");
                Console.WriteLine("\t3. Show borrowd books");
                Console.WriteLine("\t4. Search Book by title");
                Console.WriteLine("\t5. Search Book by ISBN");
                Console.WriteLine("\t6. Main menu");
                Console.WriteLine();
                Console.Write("Enter an option: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    style("Show all books...");
                    library.displayAllBooks();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    style("Show available books...");
                    library.displayAvailableBooks();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    style("Borrowed books...");
                    library.displayBorrowedBooks(librarian);
                }
                else if (option == 4)
                {
                    Console.Clear();
                    style("Search book by title...");
                    Console.WriteLine();
                    Console.Write("\tBook title: ");
                    bookTitle = Console.ReadLine();
                    if (bookTitle != null)
                    {
                        library.searchBook(bookTitle);
                    }
                    else
                    {
                        continueMassage("Please enter book title!");
                    }

                }
                else if (option == 5)
                {
                    Console.Clear();
                    style("Search book by ISBN...");
                    Console.WriteLine();
                    Console.Write("\tBook ISBN number: ");
                    ISBN = Console.ReadLine();
                    if (ISBN != null)
                    {
                        library.searchBookISBN(ISBN);
                    }
                    else
                    {
                        continueMassage("Please enter ISBN number!");
                    }
                }
                else if (option == 6)
                {
                    Console.WriteLine();
                    continueMassage("Going back to main menu...");
                }
                else
                {
                    continueMassage();
                }
            }
            catch (Exception e)
            {
                continueMassage(e.Message);
            }
        }
    }
}
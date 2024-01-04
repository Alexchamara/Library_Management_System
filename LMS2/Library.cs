class Library
{
    List<Book> books = new List<Book>();

    public List<Book> Books
    {
        get { return books; }
    }

    public void addNewBook(String title, String author, String ISBNNummber, bool availability = true)
    {
        this.books.Add(new Book(title, author, ISBNNummber, availability));
    }

    public void removeBook(String title, String ISBNNumber)
    {
        Book targetBook = this.books.Find(book => book.Title == title && book.isbnNumber == ISBNNumber);
        if (targetBook != null)
        {
            this.books.Remove(targetBook);
            Console.Write($"{title} removed succesfully! \nPress any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.Write(":( Book not found \nPress any key to continue...");
            Console.ReadKey();
        }
    }

    public void displayAvailableBooks()
    {
        Console.WriteLine("All the available books\n");
        int count = 0;
        foreach (Book book in this.books)
        {
            if (book.Availablility)
            {
                count++;
                Console.WriteLine($"Title : {book.Title}");
                Console.WriteLine($"Author : {book.Author}");
                Console.WriteLine($"ISBN Number : {book.isbnNumber}");
                Console.WriteLine($"Availability : {book.Availablility}");
                Console.WriteLine();
            }
        }
        if (count == 0) { Console.WriteLine("No available book found"); }
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }

    public void displayBorrowedBooks(Librarian librarian)
    {
        string name;
        string membershipId;
        Console.WriteLine("Enter your details...\n");
        Console.Write("\tName: ");
        name = Console.ReadLine();
        Console.Write("\tMembership id: ");
        membershipId = Console.ReadLine();
        //List<Book> borrowedBooks = new List<Book>();
        Member targetMember = librarian.Members.FirstOrDefault(member => member.Name == name && member.MembershipId == membershipId);

        if (targetMember != null)
        {
            Console.WriteLine($"\nAll the borrowed books by {targetMember.Name}\n");
            if (targetMember.BorrowedBooks != null)
            {
                foreach (Book book in targetMember.BorrowedBooks)
                {

                    Console.WriteLine($"\tTitle : {book.Title}");
                    Console.WriteLine($"\tAuthor : {book.Author}");
                    Console.WriteLine($"\tISBN Number : {book.isbnNumber}");
                    Console.WriteLine($"\tAvailability : {book.Availablility}");
                    Console.WriteLine();
                }
                Console.Write("\n\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.Write("You have not borrowed any book \nPress any key to continue...");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine();
            Console.Write(":( Member not found \nPress any key to continue...");
            Console.ReadKey();
        }
    }

    public void displayAllBooks()
    {
        Console.WriteLine("All books\n");
        if (books.Count != 0)
        {
            foreach (Book book in this.books)
            {
                Console.WriteLine($"Title : {book.Title}");
                Console.WriteLine($"Author : {book.Author}");
                Console.WriteLine($"ISBN Number : {book.isbnNumber}");
                Console.WriteLine($"Availability : {book.Availablility}");
                Console.WriteLine();
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.Write("No books found!\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    public void searchBook(String bookTitle)
    {
        Book targetBook;
        targetBook = books.Find(book => book.Title == bookTitle);
        if (targetBook != null)
        {
            Console.WriteLine("\nSearch Result...\n");
            Console.WriteLine($"\tTitle : {targetBook.Title}");
            Console.WriteLine($"\tAuthor : {targetBook.Author}");
            Console.WriteLine($"\tISBN Number : {targetBook.isbnNumber}");
            Console.WriteLine($"\tAvailability : {targetBook.Availablility}");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nBook not found!");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

    }

    public void searchBookISBN(String bookISBN)
    {
        Book targetBook;
        targetBook = books.Find(book => book.isbnNumber == bookISBN);
        if (targetBook != null)
        {
            Console.WriteLine("\nSearch Result...\n");
            Console.WriteLine($"\tTitle : {targetBook.Title}");
            Console.WriteLine($"\tAuthor : {targetBook.Author}");
            Console.WriteLine($"\tISBN Number : {targetBook.isbnNumber}");
            Console.WriteLine($"\tAvailability : {targetBook.Availablility}");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nBook not found!");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

    }
}
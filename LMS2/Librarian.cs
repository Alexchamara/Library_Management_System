class Librarian
{
    String name;
    String userId;
    String password;
    List<Member> members = new List<Member>();

    public Librarian(String name = "librarian 1", String userId = "admin", String password = "0725")
    {
        this.name = name;
        this.userId = userId;
        this.password = password;
    }

    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public String UserId
    {
        get { return userId; }
        set { userId = value; }
    }

    public String Password
    {
        get { return password; }
        set { password = value; }
    }

    public List<Member> Members
    {
        get { return members; }
    }


    public void addMember(string name, string membershipId)
    {
        this.members.Add(new Member(name, membershipId));
    }

    public void removeMember(string name, string membershipId)
    {
        Member targetMember;
        targetMember = members.Find(member => member.Name == name);
        if (targetMember != null && targetMember.Name == name && targetMember.MembershipId == membershipId)
        {
            members.Remove(targetMember);
            Console.WriteLine();
            Console.Write($"{name} removed succesfully \nPress any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine();
            Console.Write(":( Member not found \nPress any key to continue...");
            Console.ReadKey();
        }
    }

    public void displayMembers()
    {
        foreach (Member member in members)
        {
            Console.WriteLine($"Name: {member.Name}");
            Console.WriteLine($"Membership Id: {member.MembershipId}");
            Console.WriteLine("Borrowed Books...");
            foreach (Book borrowedBook in member.BorrowedBooks)
            {
                Console.WriteLine($"\tTitle: {borrowedBook.Title}");
                Console.WriteLine($"\tISBN Number: {borrowedBook.isbnNumber}");
                Console.WriteLine();
            }
        }
    }

    public bool authonticated(String userId, String password)
    {
        if (this.UserId == userId && this.Password == password) { return true; }
        else { return false; }
    }

    public void borrowBook(Library library)
    {
        string name;
        string membershipId;
        string bookTitle;
        string ISBN;
        Console.WriteLine("Enter your details...\n");
        Console.Write("\tName: ");
        name = Console.ReadLine();
        Console.Write("\tMembership id: ");
        membershipId = Console.ReadLine();

        Member targetMember = this.members.FirstOrDefault(member => member.Name == name && member.MembershipId == membershipId);

        if (targetMember != null)
        {
            Console.WriteLine("\nEnter Book details...\n");
            Console.Write("\tTitle: ");
            bookTitle = Console.ReadLine();
            Console.Write("\tISBN number: ");
            ISBN = Console.ReadLine();
            Book targetBook = library.Books.FirstOrDefault(book => book.Title == bookTitle && book.isbnNumber == ISBN);
            if (targetBook != null)
            {
                targetMember.borrowBook(targetBook);
            }
            else
            {
                Console.WriteLine();
                Console.Write(":( Book not found \nPress any key to continue...");
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

    public void returnBook(Library library)
    {
        string name;
        string membershipId;
        string bookTitle;
        string ISBN;
        Console.WriteLine("Enter your details...\n");
        Console.Write("\tName: ");
        name = Console.ReadLine();
        Console.Write("\tMembership id: ");
        membershipId = Console.ReadLine();

        Member targetMember = this.members.FirstOrDefault(member => member.Name == name && member.MembershipId == membershipId);

        if (targetMember != null)
        {
            Console.WriteLine("\nEnter Book details...\n");
            Console.Write("\tTitle: ");
            bookTitle = Console.ReadLine();
            Console.Write("\tISBN number: ");
            ISBN = Console.ReadLine();
            Book targetBook = library.Books.FirstOrDefault(book => book.Title == bookTitle && book.isbnNumber == ISBN);
            if (targetBook != null)
            {
                targetMember.returnBook(targetBook);
            }
            else
            {
                Console.WriteLine();
                Console.Write(":( Book not found \nPress any key to continue...");
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
}
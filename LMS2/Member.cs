class Member
{
    String name;
    String membershipId;
    List<Book> borrowedBooks = new List<Book>();

    public Member(string name, string membershipId)
    {
        this.name = name;
        this.membershipId = membershipId;
    }

    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public String MembershipId
    {
        get { return membershipId; }
        set { membershipId = value; }
    }

    public List<Book> BorrowedBooks
    {
        get { return borrowedBooks; }
        set { borrowedBooks = value; }
    }

    public void borrowBook(Book borrowingBook)
    {
        if (borrowingBook.Availablility)
        {
            this.borrowedBooks.Add(borrowingBook);
            borrowingBook.Availablility = false;
            borrowingBook.BorrowedBy = this;
            Console.Write($"\n{borrowingBook.Title} borrowed succesfully\nPress any key to continue...\n");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nThis book is not available :(\nPress any key to continue...\n");
            Console.ReadKey();
        }
    }
    public void returnBook(Book retuningBook)
    {
        if (this.borrowedBooks.Contains(retuningBook))
        {
            this.borrowedBooks.Remove(retuningBook);
            retuningBook.Availablility = true;
            retuningBook.BorrowedBy = null;
            Console.Write($"{retuningBook.Title} returned succesfully!\nPress any key to continue...\n");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nYou have not borrowed this book\nPress any key to continue...\n");
            Console.ReadKey();
        }
    }
}
class Book
{
    String title;
    String author;
    String ISBNNumber;
    bool availablility;
    Member borrowedBy = null;

    public Book(String title, String author, String ISBNNumber, bool availability)
    {
        this.title = title;
        this.author = author;
        this.ISBNNumber = ISBNNumber;
        this.availablility = availability;
    }

    public String Title
    {
        get { return this.title; }
        set { this.title = value; }
    }
    public String Author
    {
        get { return this.author; }
        set { this.author = value; }
    }
    public String isbnNumber
    {
        get { return this.ISBNNumber; }
        set { this.ISBNNumber = value; }
    }
    public bool Availablility
    {
        get { return this.availablility; }
        set { this.availablility = value; }
    }

    public Member BorrowedBy
    {
        get { return this.borrowedBy; }
        set { this.borrowedBy = value; }
    }
}
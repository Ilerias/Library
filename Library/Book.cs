namespace Library;

public abstract class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishYear { get; set; }
    public int Price { get; set; }
}
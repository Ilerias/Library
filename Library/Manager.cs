using System.Text.Json;

namespace Library;

public class Manager : IManager
{
    public List<Book> Books { get; set; }

    public int BookCount { get { return Books.Count; } }

    public Manager()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void Load(string physicalBookPath, string eBookPath)
    {
        var physicalText = File.ReadAllText(physicalBookPath);
        var eBookText = File.ReadAllText(eBookPath);
        
        Books.AddRange(JsonSerializer.Deserialize<List<PhysicalBook>>(physicalText));
        Books.AddRange(JsonSerializer.Deserialize<List<EBook>>(eBookText));

        if (Books.Count == 0)
        {
            throw new Exception("Üres könyv lista!");
        }
        
        Console.WriteLine("Könyvek sikeresen betöltve.");
    }

    public void EBookSearch()
    {
        var eBooks = Books.OfType<EBook>().ToList();

        foreach (var eBook in eBooks)
        {
            Console.WriteLine(eBook.ToString());
        }
    }

    public void PhysicalBookIsFit()
    {
        Console.Write("Kérem a csomag méretét: ");
        var size = int.Parse(Console.ReadLine() ?? string.Empty);
        var possiblePhysicalBooks = new List<PhysicalBook>();
        var books = Books.OfType<PhysicalBook>().ToList();

        foreach (var book in books)
        {
            if (book.Weight <= size)
            {
                possiblePhysicalBooks.Add(book);
            }
        }
        
        if (!possiblePhysicalBooks.Any())
        {
            throw new Exception("Nincs lehetséges könyv.");
        }
        
        foreach (var physicalBook in possiblePhysicalBooks)
        {
            Console.WriteLine(physicalBook.ToString() + " méret: " + physicalBook.Weight + ". Befér a csomagba");
        }
    }

    public int EBookRate()
    {
        var eBooks = Books.OfType<EBook>().ToList();
        int eBookCount = eBooks.Count();
        int booksCount = Books.Count();

        return (int)((double)eBookCount / booksCount * 100);

    }
}
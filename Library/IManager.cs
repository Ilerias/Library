namespace Library;

public interface IManager
{
    int BookCount { get; }

    void AddBook(Book book);

    void Load(string physicalBookPath, string eBookPath);

    int EBookRate();

    void EBookSearch();

    void PhysicalBookIsFit();
}
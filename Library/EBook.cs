namespace Library;

public enum FileType
{
    PDF,
    EPUB,
    MOBI
}

public class EBook : Book
{ 
    public FileType FileType { get; set; }
    public double FileSize { get; set; }

    public EBook() {}
    public override bool IsFitPackage(int size)
    {
        return false;
    }
}
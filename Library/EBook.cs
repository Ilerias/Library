namespace Library;

public enum FileType
{
    PDF,
    EPUB,
    MOBI
}

public class EBook
{ 
    public FileType FileType { get; set; }
    public double FileSize { get; set; }
}
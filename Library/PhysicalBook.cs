namespace Library;

public class PhysicalBook : Book
{
    public int PageCount { get; set; }
    public int Weight { get; set; }

    public PhysicalBook() {}
    public override bool IsFitPackage(int size)
    {
        return size >= Weight;
    }
}

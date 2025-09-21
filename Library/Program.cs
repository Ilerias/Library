using System.Text.Json;

namespace Library;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();

        #region Beolvas
        try
        {
            manager.Load("pysical_books.json", "ebooks.json");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Nem megfelelő json formátum: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Nem megfelelő formátum: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba történt: {ex.Message}");
        }
        #endregion
        
        #region EBookKeresés
        try
        {
            manager.EBookSearch();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        #endregion

        #region FizikaiKönyvCsomag

        try
        {
            manager.PhysicalBookIsFit();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        #endregion

        #region Arány

        try
        {
            var eBookRate = manager.EBookRate();
            Console.WriteLine($"Az eBookok arány: {eBookRate}%");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        #endregion
    }
}
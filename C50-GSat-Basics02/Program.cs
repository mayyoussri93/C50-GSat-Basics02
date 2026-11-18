namespace C50_GSat_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
             Book book = new Book();
             book.Title = "Egypt History";
             book.Pages = 120;
             object obj = book;
             Console.WriteLine(obj);
            #endregion
        }
    }
}

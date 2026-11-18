namespace C50_GSat_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
            //Book book = new Book();
            //book.Title = "Egypt History";
            //book.Pages = 120;
            //object obj = book;
            //Console.WriteLine(obj);
            #endregion
            #region
            //Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region
            //Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            int pages = "464";
            // is compile-time error the correct answer
            int pages = 464;
            #endregion

        }
    }
}

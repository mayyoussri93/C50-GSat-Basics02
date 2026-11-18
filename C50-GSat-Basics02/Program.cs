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
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region
            ////Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //// is compile-time error the correct answer
            //int pages = 464;
            #endregion
            #region
            ////Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            ////zero", and then prints "Done" in a finally block
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}   
            #endregion
            #region
            //Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
            //  int pages = 300;
            //double pagesDouble = pages;
            //Console.WriteLine(pagesDouble);
            #endregion
            #region
            //Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int priceInt = (int)price;
            //Console.WriteLine(priceInt);
            //Console.ReadKey();
            #endregion
            #region
            ////Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int intPageText = Convert.ToInt32(pagesText);
            //Console.WriteLine(intPageText);
            //Console.ReadKey();
            #endregion
            #region
            //Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            // use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
             string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);
            string badText = "abc";
            int badNumber;
            if(int.TryParse(badText, out badNumber))
            {
                Console.WriteLine(badNumber);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion
        


        }
    }
}

using System;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.PenId = 1;
            pen.PenType = "Ball";
            pen.PenColor = "Blue";

            pen.setPenWidth(24);          
            penInfo();

            //To print Pen Information
            void penInfo()
            {
                Console.WriteLine($"Pen Id is {pen.PenId}, \n" +
                    $"Pen Type is {pen.PenType}, \n" +
                    $"Pen Color is {pen.PenColor}, \n" +
                    $"Pen Width is {pen.getPenWidth()},\n"+
                    $"Pen Height is {pen.getPenHeight()}");
            }

            //Parameteraized Constructor
            Book book = new Book(1,"Vedas",120.5m,2);
            //This will call bookInfo method to print details
            bookInfo(book);

            //Default Constructor
            Book book1 = new Book();
            book1.BookId = 2;
            book1.setBookName("Spritual");
            book1.setBookPrice(10000.5m);
            book1.setNumberOfBooks(3000);

            //Created Class Object to call bookInfo2 non-static method
            Program program = new Program();    
            program.bookInfo2(book1);

            //We can't create Private Constructor Object
            //Therefore we keep only static values if constructor is private
            //PrivateConstructor privateConstructor = new PrivateConstructor();

            //We can call properties using CLass Name 
            PrivateConstructor.Name = "Hi There!";
            Console.WriteLine($"PrivateConstructor Name is {PrivateConstructor.Name}");

            // We can't call printInfo method from PrivateCOnstructor as unable to create class object
            //PrivateConstructor.printInfo(); -- It dosn't work

            //It will print By Default value
            Console.WriteLine($"PrivateConstructor Id is {PrivateConstructor.Id}");
        }

        // Method must be static if you don't want to create class object to call it 
        public static void bookInfo(Book book)
        {
            //Used String Verbatim Method to print Book1 details
            Console.WriteLine(@"Book Id is {0}, Book Name is {1}, Book Price is {2}, Number of Books are {3}",
                                book.BookId, book.getBookName(), book.getBookPrice(), book.getNumberOfBooks());


        }

        //If method is not static then we need to create Class Object to call it
        public void bookInfo2(Book book1)
        {
            //User String Interpolation to print Book2 details
            Console.WriteLine($"Book Id is {book1.BookId}, \n" +
                $"Book Name is {book1.getBookName()}, \n" +
                $"Book Price is {book1.getBookPrice()}, \n" +
                $"Total Number Of Books Available are {book1.getNumberOfBooks()}");
        }

    }
}

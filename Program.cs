using System;

namespace OOPSConcept
{
    public class Program
    {
        static void Main(string[] args)
        {    
            ClassFunctions classFunctions = new ClassFunctions();

            Pen pen = new Pen();
            pen.PenId = 1;
            pen.PenType = "Ball";
            pen.PenColor = "Blue";

            pen.setPenWidth(24);
            classFunctions.penInfo(pen);                       

            //Parameteraized Constructor
            Book book = new Book(1,"Vedas",120.5m,2);
            //This will call bookInfo method to print details
            classFunctions.bookInfo(book);

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
            Console.WriteLine($"PrivateConstructor Name is {PrivateConstructor.Name}\n");

            // We can't call printInfo method from PrivateCOnstructor as unable to create class object
            //PrivateConstructor.printInfo(); -- It dosn't work

            //It will print By Default value
            Console.WriteLine($"PrivateConstructor Id is {PrivateConstructor.Id}\n");

            //Inheritance - Single Level
            Student student1 = new Student(1,"Nabin Soni",100,99);
            student1.BookId = 2;
            student1.setBookName("Maths");
            student1.setBookPrice(700m);
            student1.setNumberOfBooks(500);

            classFunctions.studentDetails(student1);

            Subject subject1 = new Subject(2,"Abhinav Anand",101,34);
            subject1.SubjectId = 111;
            subject1.SubjectName = "Science";
            subject1.SubjectScore = 100;
            subject1.setBookName("Gravity");
            subject1.setBookPrice(1023m);
            subject1.setNumberOfBooks(1);

            classFunctions.subjectDetails(subject1);

        }

        //If method is not static then we need to create Class Object to call it
        public void bookInfo2(Book book1)
        {
            //User String Interpolation to print Book2 details
            Console.WriteLine($"Book Id is {book1.BookId}, \n" +
                $"Book Name is {book1.getBookName()}, \n" +
                $"Book Price is {book1.getBookPrice()}, \n" +
                $"Total Number Of Books Available are {book1.getNumberOfBooks()}\n");
        }

    }
}

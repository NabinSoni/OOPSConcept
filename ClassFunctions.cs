using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    public class ClassFunctions
    {
        //To print Pen Information
        public void penInfo(Pen pen)
        {
            Console.WriteLine($"Pen Id is {pen.PenId}, \n" +
                $"Pen Type is {pen.PenType}, \n" +
                $"Pen Color is {pen.PenColor}, \n" +
                $"Pen Width is {pen.getPenWidth()},\n" +
                $"Pen Height is {pen.getPenHeight()}\n");
        }

        // Method must be static if you don't want to create class object to call it 
        public void bookInfo(Book book)
        {
            //Used String Verbatim Method to print Book1 details
            Console.WriteLine(@"Book Id is {0}, Book Name is {1}, Book Price is {2}, Number of Books are {3}",
                                book.BookId, book.getBookName(), book.getBookPrice(), book.getNumberOfBooks());
            Console.WriteLine();
        }        

        // Here Student Object can access all Book Object Values 
        public void studentDetails(Student student1)
        {
            Console.WriteLine("Student Details are :\n" +
               $"1) Student Name: {student1.StudentName}\n" +
               $"2) Roll Number : {student1.StudentRollNo}\n" +
               $"3) Marks Obtained: {student1.StudentMarks}\n" +
               $"4) Book Name: {student1.getBookName()}\n" +
               $"5) Book Price: {student1.getBookPrice()}\n" +
               $"6) Number of Books Available: {student1.getNumberOfBooks()}\n");
        }

        //Here by creating object of Subject CLass, we can access both Student and Book class properties by Multi-Level Inheritance
        public void subjectDetails(Subject subject1)
        {
            Console.WriteLine("Subject Details are:\n" +
                $"Student Name: {subject1.StudentName}\n" +
                $"Student Roll Number: {subject1.StudentRollNo}\n" +
                $"Subject Name: {subject1.SubjectName}\n" +
                $"Subject Score: {subject1.SubjectScore}\n" +
                $"Book Name: {subject1.getBookName()}\n" +
                $"Book Price: {subject1.getBookPrice()}\n" +
                $"Available Books: {subject1.getNumberOfBooks()}\n");
        }
    }
}

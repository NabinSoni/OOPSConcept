using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{

    // Inheritance - Single Level
    internal class Student : Book
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentRollNo { get; set; }
        public float StudentMarks { get; set; }
       
        public Student(int StudentId, string StudentName, int StudentRollNo, float StudentMarks)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentRollNo = StudentRollNo;
            this.StudentMarks = StudentMarks;
        }
    }
}

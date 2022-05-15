using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    internal class Subject : Student
    {
        public Subject(int StudentId, string StudentName, int StudentRollNo, float StudentMarks) : base(StudentId, StudentName, StudentRollNo, StudentMarks)
        {
        }

        //public Subject(int SubjectId,string StudentName, float SubjectScore)
        //{
        //    this.SubjectId = SubjectId;
        //    this.SubjectName = StudentName;
        //    this.SubjectScore = SubjectScore;
        //}

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public float SubjectScore { get; set; }        
    }
}

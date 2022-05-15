using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    public class Pen
    {
        public int PenId { get; set; }
        public string PenType { get; set; }
        public string PenColor { get; set; }     
        private int PenWidth { get; set; }
        private int PenHeight { get; set; }

        //To set width value we need set method as its property is private and not accessible directly
        public void setPenWidth(int PenWidth)
        {
            this.PenWidth = PenWidth;
        }

        //To retrive width value we need getter method 
        public int getPenWidth()
        {
            return this.PenWidth;
        }

        //set method is called from here to make it constant
        public int getPenHeight()
        {
            setPenHeight(32);
            return this.PenHeight;

        }
        //set method is private so we restrict user to set any data here.
        private void setPenHeight(int PenHeight)
        {
            this.PenHeight = PenHeight;            
        }


    }
}

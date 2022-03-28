using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        private int sideA;

        public Square()
        {

        }
        public Square(int sideA)
        {
            this.sideA = sideA;
        }
        public int Circumference()
        {
            return (sideA * 4);
        }
        public int Area()
        {
            return (SideA * SideA);
        }

        public int SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

    }
}

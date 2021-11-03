using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class ListOfPoints
    {
        private Points _head;
        public Points Head
        {
            get
            {
                return _head;
            }
            set
            {
                _head = value;
            }
        }

        public int Count { get; set; } 

         

        Point nul = new Point();

        public ListOfPoints()
        { 
            Head = new Points(nul);
            Head.Next = Head;
            Head.Prev = Head;
            Count = -1;
        }
         
        public void AddPoint(Point P)
        {
            if (Head != null)
            { 
                Points q = new Points(P, Head.Next, Head);
                Head.Next.Prev = q;
                Head.Next = q;
                Count++;
            }
        }


        public Point GetPoint(int i)
        {
            Points p = Head.Next ;
            while (i > 0)//&& p.Next  != Head
            {
                i--;
                p = p.Next;
            }
            return p.PP;
        }

        public Point ExcludePoint()
        {

            Point Last = new Point();
            if (Head != null && Head.Next != null)
            { 
                Last = Head.Prev.PP;
                Head.Prev.Prev = Head.Prev;
                Head.Prev.Next = Head; 
            }
            return Last; 
        } 
    }
}

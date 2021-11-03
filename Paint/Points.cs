using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Paint
{
    class Points
    { 
        private  Point _p; 
         
        private Points _next;
        private Points _prev;

        public Points Next
        {
            get
            {
                return _next;
            }

            set
            {
                _next = value;
            }
        }

        public Points Prev
        {
            get
            {
                return _prev;
            }

            set
            {
                _prev = value;
            }
        }
        public Point PP
        {
            get
            {
                return _p;
            }

            set
            {
                _p = value;
            }
        }
        

        public Points( Point PP, Points Next, Points Prev)
        {
            this.PP = PP;
            this.Next = Next;
            this.Prev = Prev;
        }
        public Points( Point PP )
        {
            this.PP = PP;
            this.Next = null;
            this.Prev = null;
        }
    }
}

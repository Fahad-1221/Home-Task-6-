using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sn_2
{
    class Canvas
    {
        private int ID;
        private Shape[] shapes;
        private int count;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public Canvas(int id)
        {
            this.id = id;
            shapes = new Shape[100];
            this.count = 0;

        }

        // for copying 
        public Canvas(Canvas c1)
        {
            id = c1.ID;
            shapes = c1.shapes;
            this.count = c1.count;

            for (int i = 0; i < count; i++)
            {
                this.shapes[i] = c1.shapes[i];
            }
        }

        public void addshape(Shape s1)
        {
            shapes[count] = s1;
            count++;
        }

        public void disp()
        {
            Console.WriteLine("All shapes ");
            for (int i = 0; i < count; i++)
            {
                shapes[i].disp();
            }
        }

        ~Canvas()
        {

        }

    }
}

   

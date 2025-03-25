using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sn_2
{
    class Shape
    {
        private int id;
        private string type;
        private string color;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Shape(int id, string type, string color)
        {
            this.id = id;
            this.type = type;
            this.color = color;
        }

        // for copying 

        public Shape(Shape s1)
        {
            this.Type = s1.Type;
            this.color = s1.Color;
            this.id = s1.ID;
        }

        public void disp()
        {
            Console.WriteLine($"ID = {id}");
            Console.WriteLine($"type = {type}");
            Console.WriteLine($"color = {color}");
            Console.WriteLine("\n");

        }

        ~Shape()
        {
            Console.WriteLine("killed !!");
        }

    }
}
   

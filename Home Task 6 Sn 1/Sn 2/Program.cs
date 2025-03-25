using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sn_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape(1, "Square", "Purple");
            Shape s2 = new Shape(2, "Rectangle", "Black");
            Shape orignal = new Shape(3, "Parallelogram", "Orange");

            // shallow
            Shape shallow = orignal;

            // deep 
            Shape deep = new Shape(orignal);

            // Before changes 
            Console.WriteLine("Shapes before changes !!");
            orignal.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");



            Console.WriteLine("shallow Copy !");
            shallow.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            Console.WriteLine("deep Copy !");
            deep.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //making changes 
            orignal.ID = 1221;
            orignal.Color = "White";
            orignal.Type = "Paralelogram";

            // after changes 
            Console.WriteLine("Shapes after changes !!");
            orignal.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            Console.WriteLine("Shallow !!");
            shallow.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            Console.WriteLine("Deep !!");
            deep.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            // for canvas 
            Canvas c1 = new Canvas(1);
            Canvas orignalcanvas = new Canvas(2);

            // add
            orignalcanvas.addshape(s1);
            orignalcanvas.addshape(s2);

            Canvas shallowcan = orignalcanvas;
            Canvas deepcan = new Canvas(orignalcanvas);

            //display before changes 
            Console.WriteLine("orignal cannvas !!");
            orignalcanvas.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //shallow
            Console.WriteLine("Shallow Canvas !!");
            shallowcan.disp();
            Console.WriteLine("______________________________");

            //deep
            Console.WriteLine("Deep Canvas !!");
            deepcan.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //making chages
            orignalcanvas.id = 1221;
            orignalcanvas.addshape(orignal);

            //after chages 
            Console.WriteLine("Orignal Canvas after changes !!");
            orignalcanvas.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //shallow
            Console.WriteLine("Shallow Canvas after changes !!");
            shallowcan.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //deep
            Console.WriteLine("Deep Canvas after changes !!");
            deepcan.disp();
            Console.WriteLine("______________________________");
            Console.WriteLine("");

        }
    }
    }


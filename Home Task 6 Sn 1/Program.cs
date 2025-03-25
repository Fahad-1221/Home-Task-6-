using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_6_Sn_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product P1 = new Product();
            Product P2 = new Product(1220,"GPU");
            Product P3 = new Product(1221,"Keyboard",760.4m);
            Product P4 = new Product(1222, "Laptop", 89.23m, 67);

            Store S1 = new Store("The Computer Store","Islamabad");
            S1.addproduct(P1);
            S1.addproduct(P2);
            S1.addproduct(P3);
            S1.addproduct(P4);

            S1.disp();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_Task_6_Sn_1
{
    class Product
    {
        public int ID;
        public string Name;
        public decimal Price;
        public int Quantity;

        //2nd Approach
        public void FindQuantity(int Quan)
        {
            if (Quan >= 0 && Quan <= 100)
            {
                this.Quantity = Quan;
            }
            else
            {
                Console.WriteLine("Out of range (1-100) !!");
                this.Quantity = 0;
            }
        }
        public Product(int id = 0, string name = " ", decimal price = 0, int Quan = 0)
        {
            ID = id;
            Name = name;
            Price = price;
            FindQuantity(Quan);
        }


        // 4th Approch
        //public Product(int id = 0, string name = " ", decimal price = 0, int Quan = 0)
        //{
        //    ID = id;
        //    Name = name;
        //    Price = price;
        //    if (Quan >= 0 && Quan <= 100)
        //    {
        //        Quantity = Quan;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Out of range (1-100) !!");
        //        Quantity = 0;
        //    }
        //}

        // 3rd Approch
        public Product(int id, string name, decimal price) : this(id, name, price, 0)
        {

        }
        public Product(int id, int Quan) : this(id, " ", 0, Quan)
        {

        }
        public Product(int id, string name) : this(id, name, 0, 0)
        {
        }
        public void disp()
        {
            Console.WriteLine($"ID = {ID} \n Name = {Name} \n Price = {Price} \n Quantity = {Quantity}");
        }

        ~Product()
        {
            Console.WriteLine($"Product having id  {ID} is killed !! ");
        }
    }
}
    

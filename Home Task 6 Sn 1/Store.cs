using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_6_Sn_1
{
        internal class Store
        {
            public string Name;
            public string Location;
            private Product[] products;
            private int Count;
            public Store(string name, string loc)
            {
                Name = name;
                Location = loc;
                products = new Product[100];
                Count = 0;
            }

            public void addproduct(Product p1)
            {
                if (Count < products.Length)
                {
                    products[Count] = p1;
                    Count++;

                }
                else
                {
                    Console.WriteLine("Limmit is reached !!");
                }
            }

            public void disp()
            {
                Console.WriteLine("INVENTORY");
                for (int i = 0; i < Count; i++)
                {
                    products[i].disp();

                }



            }
            ~Store()
            {

            }
        }
    }



using System;
namespace _31._03._2022
{
    public class Praduct
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;

        public Praduct()
        {
            
        }
        public Praduct(int no,string name,int price )
        {
            if (No != 0 || Name != "" || Name != " " || Price != 0)
            {
                No = no;
                Name = name;
                Price = price;
            }
            else
            {
                Console.WriteLine("Product obyekti yaradila bilmez");

            }
        }
    }
}

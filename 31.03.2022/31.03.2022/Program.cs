using System;

namespace _31._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book(1,"Annabelle", 10, "Horror");
            Book book2 = new Book(2,"The Fault in Our Stars", 5, "Romance");
            book1.Counter();
            book2.Counter();


        }
    }
}

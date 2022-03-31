using System;
namespace _31._03._2022
{
    public class Book : Praduct
    {
        public string Genre;

        public Book()
        {

        }
        public Book(int no, string name, int price, string genre) : base(no, name, price)
        {
            Genre = genre;
        }


        public void Counter()
        {
            Count = int.Parse(Console.ReadLine());
            Book[] book = new Book[Count];

            for (int i = 0; i < book.Length; i++)
            {
                No = int.Parse(Console.ReadLine());
                Name = Console.ReadLine();
                Price = int.Parse(Console.ReadLine());
                Genre = Console.ReadLine();

                Book[] books = new Book[Count];
                Array.Resize(ref books, i);
            }
            Console.WriteLine("1.Kitablari qiymete gore filtrele");
            Console.WriteLine("2.Butun kitablari goster");
            Console.WriteLine("0.Programi bagla");

            int input;
            input = int.Parse(Console.ReadLine());
            if (input != 1 || input != 2 || input != 0)
            {
                Console.WriteLine("Yeniden secim edin");
            }
            if (input == 1)
            {
                int minPrice;
                int maxPrice;
                minPrice = int.Parse(Console.ReadLine());
                maxPrice = int.Parse(Console.ReadLine());
                Array.Sort(book);
                Book[] sorting = new Book[book.Length];
                sorting = book;
                Console.WriteLine(sorting);
            }
            else if (input == 2)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var blog = new Blog()
            {
               // URL="tyuu"
            };
            _context.Blogs.Add(blog);
            _context.SaveChanges();

            Console.WriteLine("vaild");
            Console.WriteLine();
        }
    }
}

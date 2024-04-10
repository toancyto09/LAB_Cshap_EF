using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_EF_HuynhVanToan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var db = new LAB_EFEntities())
            {
                var students = db.Student
                .Where(s => s.Age >= 18 && s.Age <= 20 && s.Department == "CNTT")
                .ToList();

                foreach(var s in students)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Department: {s.Department}");
                }
            }
            Console.ReadKey();
        }
    }
}

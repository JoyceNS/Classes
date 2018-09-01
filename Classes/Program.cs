using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            // var person = Person.Parse("John");
            //person.Introduce("Joyce");
            //var customer = new Customer(1, "John");
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);
            //var number = int.Parse("abc");

            //try
            //{
            //    var num = int.Parse("abc");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Conversion Failed.");
            //}

            //int number;
            //var result =  int.TryParse("abc", out number);
            //if (result)
            //    Console.WriteLine(number);
            //else
            //{
            //    Console.WriteLine("Conversion failed");
            //}
            //var customer = new Customer(1);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            //Console.WriteLine(customer.Orders.Count);

            //var person = new Person();
            //person.SetBirthdate(new DateTime(1994, 12, 26));
            //Console.WriteLine(person.GetBirthdate());

            //var person = new Person(new DateTime(1994, 1, 1));
            //Console.WriteLine(person.Age);
            var cookie = new HttpCookie();
            cookie["name"] = "Joyce";
            Console.WriteLine(cookie["name"]);
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 34, 45, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine(" Point is at {0}, {1}", point.X, point.Y);

                point.Move(new Point(100, 200));
                Console.WriteLine(" Point is at {0}, {1}", point.X, point.Y);

                point.Move(null);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }//end UsePoints
    }
}

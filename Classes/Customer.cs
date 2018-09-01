using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        //public Customer()//necessary to initialize the list
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)//can remove
            //: this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)//can remove
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {

        }
    }
}

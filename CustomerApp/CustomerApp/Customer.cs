using System;
using System.Collections.Specialized;

namespace CustomerApp
{
    public class Customer:IComparable<Customer>,IEquatable<Customer>
    {
        public Customer(string name,int id,string adress)
        {
            Name = name;
            ID = id;
            Adress = adress;
        }

        public string Name { get; set; }
        public int ID { get;  set; }
        public string Adress { get;  set; }


        public int CompareTo(Customer c)
        {
            return string.Compare(Name, c.Name, StringComparison.Ordinal);
        }

        public bool Equals(Customer c)
        {
            return Name.Equals(c.Name) && ID == c.ID;
        }

        public override string ToString()
        {
            return $"Name: {Name},ID: {ID},Adress: {Adress}";
        }
    }
}
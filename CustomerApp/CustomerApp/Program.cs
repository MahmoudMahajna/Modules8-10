using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var customerArray = new[]
            {
                new Customer("mahmoud", 123, "haifa"),
                new Customer("john", 11, "tel-aviv"),
                new Customer("sami", 15, "haifa"),
                new Customer("adam", 22, "hadera"),
                new Customer("mohammad", 132, "um-al-fahem"),
                new Customer("maHmoud", 123, "haifa"),
                new Customer("maHMoud", 44, "haifa"),
                new Customer("adam", 22, "hadera")
            };         
            SortAndDisplayByName(customerArray);   
            Console.WriteLine("***************");
            SortAndDisplayById(customerArray);
            Console.WriteLine("***********Module 8 Starts**********");
            var customers = new[]
            {
                new Customer("mahmoud", 123, "haifa"), new Customer("jon", 11, "um-al-fahem"),
                new Customer("Ahmad", 147, "afula"),new Customer("Kamal",22,"tel-aviv"),new Customer("Xamal",22,"tel-aviv")
            };

           var filter1=new CustomerFilter(IsStartWithAK);
           var filteredCustomers= GetCustomers(customers, filter1);
            Console.WriteLine("Start with A-K");
           Display(filteredCustomers);

            var filter2=new CustomerFilter(delegate(Customer customer)
            {
                return customer.Name[0] >= 'L' && customer.Name[0] <= 'Z';
            });

            filteredCustomers = GetCustomers(customers, filter2);
            Console.WriteLine("Start with L-Z");
            Display(filteredCustomers);

            var filter3=new CustomerFilter(customer=>customer.ID<100);
            filteredCustomers = GetCustomers(customers, filter3);
            Console.WriteLine("ID < 100");
            Display(filteredCustomers);
        }

        private static void Display(ICollection<Customer> filteredCustomers)
        {
            foreach (var customer in filteredCustomers)
            {
                Console.WriteLine(customer.ToString());
            }           
        }

        static bool IsStartWithAK(Customer customer)
        {           
            return customer.Name[0]>='A' && customer.Name[0]<='K';
        }
        private static void SortAndDisplayByName(Customer[] customerArray )
        {
            Array.Sort(customerArray);
            Console.WriteLine("Sorting by Name");
            foreach (var customer in customerArray)
            {
                Console.WriteLine(customer);
            }
        }
        private static void SortAndDisplayById(Customer[] customerArray)
        {
            Console.WriteLine("Sorting by ID");
            Array.Sort(customerArray, new AnotherCustomerComparer());
            foreach (var customer in customerArray)
            {
                Console.WriteLine(customer);
            }
        }
        public delegate bool CustomerFilter(Customer customer);

        public static ICollection<Customer> GetCustomers(ICollection<Customer> customers, CustomerFilter f)
        {
            return customers.Where(customer => f(customer)).ToList();
        }
    }
}

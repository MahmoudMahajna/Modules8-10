using System.Collections.Generic;

namespace CustomerApp
{
    public class AnotherCustomerComparer:IComparer<Customer>
    {
        public int Compare(Customer c1, Customer c2)
        {
            return c1.ID - c2.ID;
        }
    }
}
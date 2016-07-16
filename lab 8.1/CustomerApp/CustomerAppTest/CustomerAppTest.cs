using CustomerApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerAppTest
{
    public class CustomerAppTest
    {
        [TestClass]
        public class CustomerTest
        {
            [TestMethod]
            public void Customer_compareTo_greaterThan()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");
                c1.Name = "sami";
                Assert.IsTrue(c1.CompareTo(c2) > 0);
            }
            [TestMethod]
            public void Customer_compareTo_lessThan()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");

                Assert.IsTrue(c1.CompareTo(c2) < 0);
                c1.Name = "Mahmoud";
                Assert.IsTrue(c1.CompareTo(c2) < 0);
            }
            [TestMethod]
            public void Customer_compareTo_equal()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");

                c1.Name = "mahmoud";
                Assert.IsTrue(c1.CompareTo(c2) == 0);
            }
            [TestMethod]
            public void Customer_equals_false()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");

                Assert.IsFalse(c1.Equals(c2));
            }
            [TestMethod]
            public void Customer_equals_true()
            {
                var c1 = new Customer("mahmoud", 123, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");
                Assert.IsTrue(c1.Equals(c2));
            }
            [TestMethod]
            public void Customer_equals_sameNameDifferentIds()
            {
                var c1 = new Customer("mahmoud", 11, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");
                Assert.IsFalse(c1.Equals(c2));
            }
            [TestMethod]
            public void Customer_equals_sameIdsDifferentNames()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 11, "um-al-fahem");
                Assert.IsFalse(c1.Equals(c2));
            }
            [TestMethod]
            public void AnotherCustomerComparer_comparer_equals()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 11, "um-al-fahem");

                var acc = new AnotherCustomerComparer();
                Assert.IsTrue(acc.Compare(c1, c2) == 0);
            }
            [TestMethod]
            public void AnotherCustomerComparer_compare_lessThan()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 123, "um-al-fahem");

                var acc = new AnotherCustomerComparer();
                Assert.IsTrue(acc.Compare(c1, c2) < 0);
            }
            [TestMethod]
            public void AnotherCustomerComparer_compare_greaterThan()
            {
                var c1 = new Customer("adam", 11, "haifa");
                var c2 = new Customer("mahmoud", 1, "um-al-fahem");

                var acc = new AnotherCustomerComparer();
                Assert.IsTrue(acc.Compare(c1, c2) > 0);
            }
        }
    }
}
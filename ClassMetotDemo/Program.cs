using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12345;
            customer1.FirstName = "Emin";
            customer1.LastName = "Demirhan";
            customer1.CardNumber = 987654321;
            customer1.CardSecurityCode = 123;
            customer1.CardPassword = 1111;

            Customer customer2 = new Customer();
            customer2.Id = 00001;
            customer2.FirstName = "John";
            customer2.LastName = "Smith";
            customer2.CardNumber = 111222333;
            customer2.CardSecurityCode = 951;
            customer2.CardPassword = 2222;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.DeleteCustomer(customer1);
            customerManager.DeleteCustomer(customer2);

            customerManager.ListCustomer(customer1);
            customerManager.ListCustomer(customer2);

            customerManager.CustomerDetails("Emin", "Demirhan", 12345, 987654321, 123, 1111);
            customerManager.CustomerDetails("John", "Smith", 0001, 111222333, 951, 2222);
        }
    }
}

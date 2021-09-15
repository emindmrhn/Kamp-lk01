using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Kullanıcı başarıyla eklendi" + " " + customer.FirstName + " " + customer.LastName + " " + "Kullanıcı Id=" + " " + customer.Id);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla silindi" + " " + customer.FirstName + " " + customer.LastName + " " + "Kullanıcı Id=" + " " + customer.Id);
        }
        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("Müşteriler listelendi" + " " + customer.FirstName + " " + customer.LastName + " " + "Kullanıcı Id=" + " " + customer.Id);

        }
        public void CustomerDetails(string customerFirstName, string customerLastName, int Id, int cardNumber, int cardSecurityCode, int cardPassword)
        {
            Console.WriteLine(customerFirstName+" "+ "adlı kullanıcının hesap detayları:"+" ");

        }
    }
}

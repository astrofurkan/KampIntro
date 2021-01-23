using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gerçek Müşteri
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Furkan";
            customer1.CustomerLastName = "Akbaba";
            customer1.TcNo = "1238472323";

            // Tüzel Müşteri
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama IO";
            customer2.VergiNo = "1234567890";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);






        }
    }
}

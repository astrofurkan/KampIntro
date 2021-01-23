using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CustomerFinanceCreditManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planlaması Hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

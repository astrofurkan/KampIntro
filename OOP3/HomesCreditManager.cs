using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HomesCreditManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planlaması Hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

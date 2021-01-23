using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CraftCreditManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

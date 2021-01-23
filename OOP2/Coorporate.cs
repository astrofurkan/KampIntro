using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Coorporate:Customer            //Tüzel  Müşteri 
        // Corrporate:Customer olayı miras, inheritance demek.
    {
        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}

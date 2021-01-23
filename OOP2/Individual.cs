using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Individual:Customer //Gerçek Müşteri
                              // Individual:Customer olayı miras, inheritance demek.
    {

        public string TcNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
    }
}

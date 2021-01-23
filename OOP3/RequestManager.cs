using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequestManager
    {
        // Method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            //Başvuran Bilgilerini Değerlendirme
            //
            creditManager.Calc();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditBriefing(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calc();
            }
        }
    }
}

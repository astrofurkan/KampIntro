using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager customerFinanceCreditManager = new CustomerFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homesCreditManager = new HomesCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SMSLoggerService(), new FileLoggerService() };

            RequestManager requestManager = new RequestManager();
            requestManager.Apply(new VehicleCreditManager(), loggers);


            List<ICreditManager> credits = new List<ICreditManager>() {homesCreditManager, vehicleCreditManager };

            //requestManager.CreditBriefing(credits);


        }
    }
}

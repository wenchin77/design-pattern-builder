using System;
using System.Collections.Generic;

namespace builder
{
    class Program
    {
        static void PrintTripDetail(Trip trip)
        {
            var tripDetail = trip.GetDetail();
            foreach (var item in tripDetail)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Trip 1. SUP 象鼻岩行程");
            Trip trip = new SupTripBuilder()
                        .SetSalesContext()
                        .SetDestination("深澳象鼻岩")
                        .SetPrice(2000)
                        .SetDifficulty(2)
                        .SetDurationHours(4)
                        .SetMaxParticipants(15)
                        .SetDescription()
                        .Build();
            PrintTripDetail(trip);

            Console.WriteLine("Trip 2. SUP 龜山島行程");
            Trip trip1 = new SupTripBuilder()
                        .SetSalesContext()
                        .SetDestination("龜山島牛奶湖")
                        .SetPrice(5000)
                        .SetDifficulty(4)
                        .SetDurationHours(6)
                        .SetMaxParticipants(10)
                        .SetDescription()
                        .Build();
            PrintTripDetail(trip1);

            Console.WriteLine("Trip 3. 獨木舟 小琉球行程");
            Trip trip2 = new KayakTripBuilder()
                        .SetSalesContext()
                        .SetDestination("小琉球")
                        .SetPrice(3500)
                        .SetDifficulty(2)
                        .SetDurationHours(5)
                        .SetMaxParticipants(20)
                        .SetDescription()
                        .Build();
            PrintTripDetail(trip2);
            
            Console.WriteLine("Trip 4. 獨木舟 東澳行程");
            Trip trip3 = new KayakTripBuilder()
                        .SetSalesContext()
                        .SetDestination("東澳海蝕洞")
                        .SetPrice(1500)
                        .SetDifficulty(3)
                        .SetDurationHours(4)
                        .Build();
            PrintTripDetail(trip3);

            Console.WriteLine("Trip 5. 獨木舟 龍洞行程");
            Trip trip4 = new KayakTripBuilder()
                        .SetSalesContext()
                        .SetDestination("龍洞")
                        .SetPrice(1500)
                        .Build();
            PrintTripDetail(trip4);
        }
    }
}

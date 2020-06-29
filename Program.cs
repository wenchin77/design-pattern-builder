using System;
using System.Collections.Generic;

namespace builder
{
    class Program
    {
        static void PrintTripDetail(IEnumerable<object> tripDetail)
        {
            foreach (var item in tripDetail)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---");
        }
        static void Main(string[] args)
        {
            var tripDirector = new TripDirector();
            Console.WriteLine("SUP 象鼻岩行程:");
            var trip = tripDirector.CreateTrip(new SupTripBuilder(), "深澳象鼻岩");
            var tripDetail = trip.GetDetail();
            PrintTripDetail(tripDetail);

            Console.WriteLine("SUP 龜山島行程:");
            var trip1 = tripDirector.CreateTrip(new SupTripBuilder(), "龜山島牛奶湖");
            var tripDetail1 = trip1.GetDetail();
            PrintTripDetail(tripDetail1);

            Console.WriteLine("獨木舟 東澳行程:");
            var trip2 = tripDirector.CreateTrip(new SupTripBuilder(), "東澳海蝕洞");
            var tripDetail2 = trip2.GetDetail();
            PrintTripDetail(tripDetail2);
        }
    }
}

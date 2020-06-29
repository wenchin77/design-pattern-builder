using System.Collections.Generic;

namespace builder
{
    public interface ITripBuilder
    {
        void Reset();
        void SetDestination(string destination);
        void SetPrice();
        void SetDifficulty();
        void SetDurationHours();
        void SetMaxParticipants();
        void SetDescription();
        void SetSalesContext();
        Trip GetTrip();
    }
}
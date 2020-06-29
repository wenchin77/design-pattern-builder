using System.Collections.Generic;

namespace builder
{
    public interface ITripBuilder
    {
        ITripBuilder SetDestination(string destination);
        ITripBuilder SetPrice(int price);
        ITripBuilder SetDifficulty(int difficulty);
        ITripBuilder SetDurationHours(int hours);
        ITripBuilder SetMaxParticipants(int maxParticipants);
        ITripBuilder SetDescription();
        ITripBuilder SetSalesContext();
        Trip Build();
    }
}
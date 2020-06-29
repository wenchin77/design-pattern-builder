namespace builder
{
    public class TripDirector
    {
        public Trip CreateTrip(ITripBuilder tripBuilder, string destination)
        {
            tripBuilder.SetSalesContext();
            tripBuilder.SetDestination(destination);
            tripBuilder.SetPrice();
            tripBuilder.SetDifficulty();
            tripBuilder.SetDurationHours();
            tripBuilder.SetMaxParticipants();
            tripBuilder.SetDescription();
            return tripBuilder.GetTrip();
        }
    }
}
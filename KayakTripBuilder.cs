namespace builder
{
    public class KayakTripBuilder : ITripBuilder
    {
        private Trip _trip;
        private string _description = "獨木舟是一種用單根樹幹挖成的划艇，需要藉助槳驅動。獨木舟的優點在於由一根樹幹製成，製作簡單，不易有漏水，散架的風險。它可以說是人類最古老的水域交通工具之一。";
        private string _salesContext = "獨木舟振興券優惠套餐 開跑囉";
        public KayakTripBuilder()
        {
            _trip = new Trip();
        }
        public ITripBuilder SetDestination(string destination)
        {
            _trip.SetDestination(destination);
            return this;
        }
        public ITripBuilder SetPrice(int price)
        {
            _trip.SetPrice(price);
            return this;
        }
        public ITripBuilder SetDifficulty(int difficulty)
        {
            _trip.SetDifficulty(difficulty);
            return this;
        }
        public ITripBuilder SetDurationHours(int hours)
        {
            _trip.SetDurationHours(hours);
            return this;
        }
        public ITripBuilder SetMaxParticipants(int maxParticipants)
        {
            _trip.SetMaxParticipants(maxParticipants);
            return this;
        }
        public ITripBuilder SetDescription()
        {
            _trip.SetDescription(_description);
            return this;
        }
        public ITripBuilder SetSalesContext()
        {
            _trip.SetSalesContext(_salesContext);
            return this;
        }
        public Trip Build()
        {
            return _trip;
        }
    }
}
namespace builder
{
    public class SupTripBuilder : ITripBuilder
    {
        private Trip _trip;
        private string _description = "立式槳板運動（英語：Stand Up Paddle, SUP)，也俗稱「槳板」， 是起源於夏威夷的一種運動，由衝浪與傳統的手划槳板（Paddleboard）結合而成。活動器材係由槳板（類似大型衝浪板）加上一支高於身高的單槳所組成。運用於衝浪時又稱立式單槳衝浪（簡稱立槳衝浪），也可在湖泊及河流等水域，從事探索、激流及救生等多方面的活動。";
        private string _salesContext = "7/1-8/31 SUP 行程 85 折";
        public SupTripBuilder()
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
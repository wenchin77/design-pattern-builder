namespace builder
{
    public class SupTripBuilder : ITripBuilder
    {
        private Trip _trip;
        private int _price = 3000;
        private int _difficulty = 3;
        private int _durationHours = 5;
        private int _maxParticipants = 10;
        private string _description = "立式槳板運動（英語：Stand Up Paddle, SUP)，也俗稱「槳板」， 是起源於夏威夷的一種運動，由衝浪與傳統的手划槳板（Paddleboard）結合而成。活動器材係由槳板（類似大型衝浪板）加上一支高於身高的單槳所組成。運用於衝浪時又稱立式單槳衝浪（簡稱立槳衝浪），也可在湖泊及河流等水域，從事探索、激流及救生等多方面的活動。";
        private string _note = "7/1-8/31 SUP 行程 85 折";
        public SupTripBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _trip = new Trip();
        }
        public void SetDestination(string destination)
        {
            _trip.AddDetail($"地點: {destination}");
        }
        public void SetPrice()
        {
            _trip.AddDetail($"每人價格: NTD {_price}");
        }
        public void SetDifficulty()
        {
            _trip.AddDetail($"困難度: {_difficulty}/5");
        }
        public void SetDurationHours()
        {
            _trip.AddDetail($"時間: {_durationHours}");
        }
        public void SetMaxParticipants()
        {
            _trip.AddDetail($"每團人數限制: {_maxParticipants} 人");
        }
        public void SetDescription()
        {
            _trip.AddDetail($"SUP 活動敘述: {_description}");
        }
        public void SetSalesContext()
        {
            _trip.AddDetail($"【{_note}】");
        }
        public Trip GetTrip()
        {
            return _trip;
        }
    }
}
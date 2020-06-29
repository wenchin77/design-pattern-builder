namespace builder
{
    public class KayakTripBuilder : ITripBuilder
    {
        private Trip _trip;
        private int _price = 1500;
        private int _difficulty = 2;
        private int _durationHours = 4;
        private int _maxParticipants = 20;
        private string _description = "獨木舟是一種用單根樹幹挖成的划艇，需要藉助槳驅動。獨木舟的優點在於由一根樹幹製成，製作簡單，不易有漏水，散架的風險。它可以說是人類最古老的水域交通工具之一。";
        private string _note = "獨木舟振興券優惠套餐 開跑囉";
        public KayakTripBuilder()
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
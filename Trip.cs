using System.Collections.Generic;

namespace builder
{
    public class Trip
    {
        private string _destination;
        private int _price;
        private int _difficulty;
        private int _hours;
        private int _maxParticipants;
        private string _description;
        private string _salesContext;
        private IList<string> _tripDetail = new List<string>();
        public IEnumerable<string> GetDetail()
        {
            foreach (var item in _tripDetail)
            {
                yield return item;
            }
        }
        // Getters to be added
        public void SetDestination(string destination)
        {
            _destination = destination;
            _tripDetail.Add($"地點: {destination}");
        }
        public void SetPrice(int price)
        {
            _price = price;
            _tripDetail.Add($"每人價格: NTD {price}");
        }
        public void SetDifficulty(int difficulty)
        {
            _difficulty = difficulty;
            _tripDetail.Add($"困難度: {difficulty}/5");
        }
        public void SetDurationHours(int hours)
        {
            _hours = hours;
            _tripDetail.Add($"時間: {hours} 小時");
        }
        public void SetMaxParticipants(int maxParticipants)
        {
            _maxParticipants = maxParticipants;
            _tripDetail.Add($"每團人數限制: {maxParticipants} 人");
        }
        public void SetDescription(string description)
        {
            _description = description;
            _tripDetail.Add($"SUP 活動敘述: {_description}");
        }
        public void SetSalesContext(string salesContext)
        {
            _salesContext = salesContext;
            _tripDetail.Add($"【{_salesContext}】");
        }
    }
}
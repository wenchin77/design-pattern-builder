using System.Collections.Generic;

namespace builder
{
    public class Trip
    {
        private IList<string> _tripDetail = new List<string>();
        public void AddDetail(string detail)
        {
            _tripDetail.Add(detail);
        }
        public IEnumerable<string> GetDetail()
        {
            foreach (var item in _tripDetail)
            {
                yield return item;
            }
        }
    }
}
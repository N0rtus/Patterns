using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class StationList : IEnumerable<RadioStation>
    {
        private List<RadioStation> _stations = new List<RadioStation>();

        public void Add(RadioStation station)
        {
            _stations.Add(station);
        }

        public void Remove(RadioStation station)
        {
            _stations.Add(station);
        }
        
        public IEnumerator<RadioStation> GetEnumerator()
        {
            return _stations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
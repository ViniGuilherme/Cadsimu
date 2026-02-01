using System.Collections.Generic;

namespace CadSimuLike.Core
{
    public class NumberingService
    {
        private readonly Dictionary<string, int> _counters = new();

        public string Next(string prefix)
        {
            if (!_counters.ContainsKey(prefix))
                _counters[prefix] = 1;
            else
                _counters[prefix]++;

            return $"{prefix}{_counters[prefix]}";       
        }
    }
}
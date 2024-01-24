using System.Collections.Generic;

namespace UnitTestProjectLeetCode
{
    public sealed record Pair(int timestamp, string val)
    {
        public int timestamp = timestamp;
        public string val = val;
    }

    public class TimeMap
    {
        private Dictionary<string, List<Pair>> dict;

        public TimeMap()
        {
            dict = new Dictionary<string, List<Pair>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(new Pair(timestamp, value));
            }
            else
            {
                List<Pair> arr = new List<Pair> { new(timestamp, value) };
                dict.Add(key, arr);
            }
        }

        public string Get(string key, int timestamp)
        {
            string cand = "";

            if (dict.ContainsKey(key))
            {
                List<Pair> arr = dict[key];
                int low = 0, high = arr.Count - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    int timeVal = arr[mid].timestamp;
                    if (timeVal == timestamp)
                    {
                        return arr[mid].val;
                    }
                    else if (timeVal < timestamp)
                    {
                        cand = arr[low].val;
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return cand;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab_13
{
    class TestCollections
    {
        // List<TKey>.
        List<State> ListState { get; set; }

        // List<string>.
        List<string> ListString { get; set; }

        // Dictionary<TKey, TValue>.
        Dictionary<State, Monarchy> DictionaryState { get; set; }

        // Dictionary<string, TValue>.
        Dictionary<string, Monarchy> DictionaryString { get; set; }

        // Constructor with parameters that define capacities.
        public TestCollections(int a, int b, int c, int d)
        {
            ListState = new List<State>(a);
            ListString = new List<string>(b);
            DictionaryState = new Dictionary<State, Monarchy>(c);
            DictionaryString = new Dictionary<string, Monarchy>(d);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Subb_Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCollections testCollections = new TestCollections(10);
        }

        public static void GetTime(TestCollections testCollections)
        {
            // Array of state objects that are stored in collections.
            State[] stateArr = testCollections.ListState.ToArray();

            // Array of monarchy objects that are stored in collections.
            Monarchy[] monArr = testCollections.DictionaryState.Values.ToArray();

            // The monarchy object that doesn't exist in the collections.
            Monarchy alienMon = new Monarchy("Jamaica", "Elizabeth II", 43847430, 56, "America", "House of Windsor");


            // The first state object.
            State firstState = new State(stateArr[0].Name, stateArr[0].LeaderName, stateArr[0].Population, stateArr[0].Age, stateArr[0].Continent);

            // The middle state object.
            State middleState = new State(stateArr[stateArr.Length / 2].Name, stateArr[stateArr.Length / 2].LeaderName,
                stateArr[stateArr.Length / 2].Population, stateArr[stateArr.Length / 2].Age, stateArr[stateArr.Length / 2].Continent);

            // The last state object.
            State lastState = new State(stateArr[stateArr.Length - 1].Name, stateArr[stateArr.Length - 1].LeaderName,
                stateArr[stateArr.Length - 1].Population, stateArr[stateArr.Length - 1].Age, stateArr[stateArr.Length - 1].Continent);

            // The state object that doesn't exist in the collections.
            State alienState = alienMon.BaseState;



            // The first monarchy object.
            Monarchy firstMon = new Monarchy(monArr[0].Name, monArr[0].LeaderName, monArr[0].Population, monArr[0].Age, 
                monArr[0].Continent, monArr[0].CurrentRullingClanName);

            // The middle monarchy object.
            Monarchy middleMon = new Monarchy(monArr[monArr.Length / 2].Name, monArr[monArr.Length / 2].LeaderName, monArr[monArr.Length / 2].Population, 
                monArr[monArr.Length / 2].Age, monArr[monArr.Length / 2].Continent, monArr[monArr.Length / 2].CurrentRullingClanName);

            // The last monarchy object.
            Monarchy lastMon = new Monarchy(monArr[monArr.Length - 1].Name, monArr[monArr.Length - 1].LeaderName, monArr[monArr.Length - 1].Population,
                monArr[monArr.Length - 1].Age, monArr[monArr.Length - 1].Continent, monArr[monArr.Length - 1].CurrentRullingClanName);



            // Stores all the search times of the 1st object.
            long[] firstSearch = { StateGetMillis(testCollections, firstState)[0], StateGetMillis(testCollections, firstState)[1],
                StateGetMillis(testCollections, firstState)[2], StateGetMillis(testCollections, firstState)[3], MonarchyGetMillis(testCollections, firstMon) };

            // Stores all the search times of the middle object.
            long[] middleSearch = { StateGetMillis(testCollections, middleState)[0], StateGetMillis(testCollections, middleState)[1],
                StateGetMillis(testCollections, middleState)[2], StateGetMillis(testCollections, middleState)[3], MonarchyGetMillis(testCollections, middleMon) };

            // Stores all the search times of the last object.
            long[] lastSearch = { StateGetMillis(testCollections, lastState)[0], StateGetMillis(testCollections, lastState)[1],
                StateGetMillis(testCollections, lastState)[2], StateGetMillis(testCollections, lastState)[3], MonarchyGetMillis(testCollections, lastMon) };

            // Stores all the search times of the alien object.
            long[] alienSearch = { StateGetMillis(testCollections, alienState)[0], StateGetMillis(testCollections, alienState)[1],
                StateGetMillis(testCollections, alienState)[2], StateGetMillis(testCollections, alienState)[3], MonarchyGetMillis(testCollections, alienMon) };
        }

        // Method to search a state object.
        public static long[] StateGetMillis(TestCollections testCollections, State searchThis)
        {
            // Store time.
            long millisListState, millisListString, millisDicState, millisDicString;

            // A StopWatch object to count milliseconds.
            Stopwatch sw = new Stopwatch();

            // Counting the search time in List<TKey>.
            sw.Start();
            testCollections.ListState.Contains(searchThis);
            sw.Stop();
            millisListState = sw.ElapsedMilliseconds;

            // Counting the search time in List<string>.
            sw.Restart();
            testCollections.ListString.Contains(searchThis.ToString());
            sw.Stop();
            millisListString = sw.ElapsedMilliseconds;

            // Counting the search time in Dinctionary<TKey, TValue>.
            sw.Restart();
            testCollections.DictionaryState.ContainsKey(searchThis);
            sw.Stop();
            millisDicState = sw.ElapsedMilliseconds;

            // Counting the search time in Dinctionary<string, TValue>.
            sw.Restart();
            testCollections.DictionaryString.ContainsKey(searchThis.ToString());
            sw.Stop();
            millisDicString = sw.ElapsedMilliseconds;

            long[] millis = { millisListState, millisListString, millisDicState, millisDicString };

            return millis;
        }

        // Method to search a monarchy object in Dictionary<TKey, TValue>.
        public static long MonarchyGetMillis(TestCollections testCollections, Monarchy searchThis)
        {
            // A StopWatch object to count milliseconds.
            Stopwatch sw = new Stopwatch();

            // Counting the search time.
            sw.Start();
            testCollections.DictionaryState.ContainsValue(searchThis);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}

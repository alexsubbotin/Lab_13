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

            // The first state object.
            State firstState = new State(stateArr[0].Name, stateArr[0].LeaderName, stateArr[0].Population, stateArr[0].Age, stateArr[0].Continent);

            // The middle state object.
            State middleState = new State(stateArr[stateArr.Length / 2].Name, stateArr[stateArr.Length / 2].LeaderName,
                stateArr[stateArr.Length / 2].Population, stateArr[stateArr.Length / 2].Age, stateArr[stateArr.Length / 2].Continent);

            // The last state object.
            State lastState = new State(stateArr[stateArr.Length - 1].Name, stateArr[stateArr.Length - 1].LeaderName,
                stateArr[stateArr.Length - 1].Population, stateArr[stateArr.Length - 1].Age, stateArr[stateArr.Length - 1].Continent);

            // The state object that doesn't exist in the collections.
            State alienState = new State("The Czech Republic", "Milos Zeman", 10610947, 25, "Europe");

            // The first monarchy object.
            Monarchy firstMon = new Monarchy(monArr[0].Name, monArr[0].LeaderName, monArr[0].Population, monArr[0].Age, 
                monArr[0].Continent, monArr[0].CurrentRullingClanName);

            // The middle monarchy object.
            Monarchy middleMon = new Monarchy(monArr[monArr.Length / 2].Name, monArr[monArr.Length / 2].LeaderName, monArr[monArr.Length / 2].Population, 
                monArr[monArr.Length / 2].Age, monArr[monArr.Length / 2].Continent, monArr[monArr.Length / 2].CurrentRullingClanName);

            // The last monarchy object.
            Monarchy lastMon = new Monarchy(monArr[monArr.Length - 1].Name, monArr[monArr.Length - 1].LeaderName, monArr[monArr.Length - 1].Population,
                monArr[monArr.Length - 1].Age, monArr[monArr.Length - 1].Continent, monArr[monArr.Length - 1].CurrentRullingClanName);

            // The monarchy object that doesn't exist in the collections.
            Monarchy alienMonarchy = new Monarchy("Jamaica", "Elizabeth II", 43847430, 56, "America", "House of Windsor");
        }
    }
}

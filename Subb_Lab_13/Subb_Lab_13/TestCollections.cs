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
        public List<State> ListState { get; set; }

        // List<string>.
        public List<string> ListString { get; set; }

        // Dictionary<TKey, TValue>.
        public Dictionary<State, Monarchy> DictionaryState { get; set; }

        // Dictionary<string, TValue>.
        public Dictionary<string, Monarchy> DictionaryString { get; set; }

        // Constructor with a parameter.
        public TestCollections(int capacity)
        {
            ListState = new List<State>(capacity);
            ListString = new List<string>(capacity);
            DictionaryState = new Dictionary<State, Monarchy>(capacity);
            DictionaryString = new Dictionary<string, Monarchy>(capacity);

            for(int i = 0; i < capacity; i++)
            {
                // Random monarchy object.
                Monarchy bufMon = Generate(i);

                // State object with the same fields.
                State bufState = bufMon.BaseState;

                // Adding the state object to the List<TKey>.
                ListState.Add(bufState);

                // Adding the state and the monarchy object to the Dictionary<TKey, TValue>.
                DictionaryState.Add(bufState, bufMon);

                // Adding the state's string to the List<string>.
                ListString.Add(bufState.ToString());

                // Adding the state's string and the monarchy object to the Dictionary<string, TValue>.
                DictionaryString.Add(bufState.ToString(), bufMon);
            }
        }

        // Function to generate a random object.
        public static Random rnd = new Random();
        public static Monarchy Generate(int a)
        {
            Monarchy monarchy = new Monarchy();

            // Creating the element.
            for (int i = 0; i < rnd.Next(4, 20); i++)
            {
                monarchy.Name += (char)rnd.Next(65, 91);
                monarchy.LeaderName += (char)rnd.Next(97, 123);
                monarchy.Age += rnd.Next(0, 150);
                monarchy.Population += rnd.Next(0, 1000);
                monarchy.Continent += (char)rnd.Next(97, 123);
                monarchy.CurrentRullingClanName += (char)rnd.Next(65, 91);
            }

            return monarchy;
        }
    }
}

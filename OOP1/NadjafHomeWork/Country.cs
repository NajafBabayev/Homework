using System;
namespace NadjafHomeWork
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public string SeaName;


        public Country(string name, string capital, int population)
        {
            Name = name;
            Capital = capital;
            Population = population;
        }

        public void Info() {
            bool result = false;
            if (SeaName != null) {
                result = true;
            }

            string words = result ? SeaName : "There is no see";

            Console.WriteLine($"{Capital} is the capital of {Name}. Population: {Population}. Sea Name: {words}");
        }

        
    }
}

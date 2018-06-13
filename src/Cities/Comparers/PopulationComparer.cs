using System;
using System.Collections.Generic;


namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Population.CompareTo(y.Population);
        }

    }
}

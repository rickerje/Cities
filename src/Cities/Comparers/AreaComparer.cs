﻿using System;
using System.Collections.Generic;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Area.CompareTo(y.Area);
        }

    }
}

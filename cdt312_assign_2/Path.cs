﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdt312_assign_2
{
    class Path
    {
        public string fromCity;
        public string toCity;
        public int pathCost;
        public Path() { }
        public Path(string newFromCity, string newToCity, int newPathCost)
        {
            fromCity = newFromCity;
            toCity = newToCity;
            pathCost = newPathCost;
        }
    }
}
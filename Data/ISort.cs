﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Services
{
    internal interface ISort<T> where T : IComparable<T> 
    {
        public void Sort(List<T> array, int left, int right);
    }
}
﻿using System;
using No2.Solution;

namespace No2
{
    public class ForeCastReport
    {
        public void WeatherChanged(object sender, WeatherArgs info)
            => Console.WriteLine("ForeCast");
    }
}

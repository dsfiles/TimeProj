﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProj
{
    internal class Time
    {
        public int hour, minute;
        public double second;

        public Time() {
            this.hour = 0;
            this.minute = 0;
            this.second = 0.0;
        }
        public Time(int hour, int min, double sec) {
            hour = hour;
            minute = min;
            second = sec;
        }
    }
}
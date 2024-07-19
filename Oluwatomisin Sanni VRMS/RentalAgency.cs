using System;
using System.Collections.Generic;

namespace VRMS
{
    public class RentalAgency
    {
        private List<Vehicle> Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        public RentalAgency()
        {
            Fleet = new List<Vehicle>();
            TotalRevenue = 0;
        }
    }


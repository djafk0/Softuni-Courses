﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelIncreaseConsuption = 1.6;

        private const double PercentRefueled = 0.95;

        public Truck(double fuelQuantity, double fuelConsuptionPerKm, double tankCapacity)
           : base(fuelQuantity, fuelConsuptionPerKm, tankCapacity)
        {
        }

        public override double FuelConsuptionPerKm
            => base.FuelConsuptionPerKm + FuelIncreaseConsuption;

        public override void Refuel(double fuelAmount)
        {
            double fuelToRefill = fuelAmount * PercentRefueled;

            if (fuelToRefill > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }

            base.Refuel(fuelToRefill);
        }
    }
}

﻿using CarRental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces
{
    public interface IVehicle
    {
        public int VehicleId { get; set; }
        public string RegNumber { get; init; }
        public Manufacturer Make { get; init; }
        public VehicleTypes Type { get; init; }
        public VehicleStatus Status { get; set; }
        public int Odometer { get; set; }
        public double CostPerKm { get; set; }
        public double CostPerDay { get; set; }
        public void SetCostSettings(double perKm, double perDay);

    }
}

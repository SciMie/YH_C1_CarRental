﻿using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes
{
    public class Car : Vehicle
    {
        //public Car(int id, string regNumber, VehicleTypes type, int odometer, double costPerKm, double costPerDay, Manufacturer make = Manufacturer.Unknown, VehicleStatus status = VehicleStatus.Available)
        //{
        //    VehicleId = id;
        //    RegNumber = regNumber;
        //    Make = make;
        //    Type = type;
        //    Status = status;
        //    Odometer = odometer;
        //    SetCostSettings(costPerKm, costPerDay);
        //}
        public Car(int id, string regNumber, VehicleTypes type, int odometer, double costPerKm, double costPerDay, Manufacturer make = Manufacturer.Unknown, VehicleStatus status = VehicleStatus.Available) : base(id, regNumber, odometer)
        {
            //VehicleId = id;
            //RegNumber = regNumber;
            Make = make;
            Type = type;
            Status = status;
            //Odometer = odometer;
            SetCostSettings(costPerKm, costPerDay);
        }
        //public int VehicleId { get; set; }
        //public string RegNumber { get; init; }
        //public Manufacturer Make { get; init; }
        //public VehicleTypes Type { get; init; }
        //public VehicleStatus Status { get; set; }
        //public int Odometer { get; set; }
        //public double CostPerKm { get; set; }
        //public double CostPerDay { get; set; }
        //public void SetCostSettings(double perKm, double perDay)
        //{
        //    CostPerKm = perKm;
        //    CostPerDay = perDay;
        //}       
    }
}
